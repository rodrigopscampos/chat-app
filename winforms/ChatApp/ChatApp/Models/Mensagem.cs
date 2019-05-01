namespace ChatApp.Models
{
    public class Mensagem
    {
        public int Id { get; set; }
        public int Remetente { get; set; }
        public string Texto { get; set; }
        public int? Destinatario { get; set; }
        public bool Publica { get; set; }
    }
}
