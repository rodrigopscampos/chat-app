using Newtonsoft.Json;

namespace ChatApp.DTO
{
    public class OutputMensagem
    {
        [JsonProperty("remetente")]
        public string Remetente { get; set; }

        [JsonProperty("destinatario")]
        public string Destinatario { get; set; }

        [JsonProperty("texto")]
        public string Texto { get; set; }

        [JsonProperty("reservada")]
        public bool Reservada { get; set; }
    }
}
