using ChatApp.DTO;
using ChatApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatApp
{
    public class ApiClient
    {
        HttpClient _httpClient;

        public delegate void NovaMensagensDelegate(Mensagem[] mensagens);
        public delegate void AlterarListaUsuariosDelegate(Usuarios[] usuarios);

        public event NovaMensagensDelegate AoReceberMensagens;
        public event AlterarListaUsuariosDelegate AoAlterarNovaListaUsuarios;

        int _id;
        int _sequencialMensagens;
        int _sequencialUsuarios;

        volatile bool _rodando;
        System.Timers.Timer _timer;

        public ApiClient()
        {
            _timer = new System.Timers.Timer();
            _timer.AutoReset = false;
            _timer.Interval = 1000;
            _timer.Elapsed += _timer_Elapsed;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5000");
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                try
                {
                    var mensagens = PegarNovasMensagens();
                    AoReceberMensagens?.Invoke(mensagens);
                }
                catch
                {

                }


                try
                {
                    var usuarios = PegarNovosUsuarios();
                    AoAlterarNovaListaUsuarios?.Invoke(usuarios);
                }
                catch
                {

                }

            }
            finally
            {
                if (_rodando)
                    _timer.Start();
            }
        }

        private Mensagem[] PegarNovasMensagens()
        {
            var result = _httpClient.GetAsync($"/mensagens?destinatario={_id}").Result;
            result.EnsureSuccessStatusCode();

            var conteudo =
                JsonConvert.DeserializeObject<Mensagem[]>(result.Content.ReadAsStringAsync().Result);

            _sequencialMensagens = conteudo.Max(c => c.Id);
            return conteudo;
        }

        public Usuarios[] PegarNovosUsuarios()
        {
            var result = _httpClient.GetAsync($"/usuarios?seqnum={_sequencialUsuarios}").Result;
            result.EnsureSuccessStatusCode();

            var conteudo =
                JsonConvert.DeserializeObject<Usuarios[]>(result.Content.ReadAsStringAsync().Result);

            if (conteudo.Any())
            {
                conteudo = conteudo
                .Where(c => c.Id != _id)
                .ToArray();

                _sequencialUsuarios = conteudo.Max(c => c.Id);
            }

            return conteudo;
        }

        public void EnviarMensagem(int destinatario, string texto)
        {
            var json = JsonConvert.SerializeObject(
                new { remetente = _id, texto = texto, destinatario = destinatario });

            var result = _httpClient.PostAsync("mensagens",
                new StringContent(json, Encoding.UTF8, "application/json")).Result;

            result.EnsureSuccessStatusCode();
        }

        public void EnviarMensagemParaTodos(string texto)
        {
            var json = JsonConvert.SerializeObject(new { remetente = _id, texto = texto });
            var result = _httpClient.PostAsync("mensagens",
                new StringContent(json, Encoding.UTF8, "application/json")).Result;

            result.EnsureSuccessStatusCode();
        }

        public void FazerLogin(string apelido)
        {
            var json = JsonConvert.SerializeObject(new { nome = apelido });
            var resultado = _httpClient
                                .PostAsync("usuarios",
                                new StringContent(json, Encoding.UTF8, "application/json"))
                                .Result;

            //content-type: application/json; charset=utf-8 

            resultado.EnsureSuccessStatusCode();

            var resultadoContent
                = JsonConvert.DeserializeObject<InputLogin>(
                    resultado.Content.ReadAsStringAsync().Result);

            if (!resultadoContent.Sucesso)
            {
                throw new Exception(Convert.ToString(resultadoContent.Erro));
            }

            _id = resultadoContent.Id;
        }

        public void IniciarRecebimento()
        {
            _rodando = true;
            _timer.Start();
        }
    }
}