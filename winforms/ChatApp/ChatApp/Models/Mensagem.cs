namespace ChatApp.Models
{
    public class Mensagem
    {
        public int Id { get; set; }
        public string Remetente { get; set; }
        public string Texto { get; set; }
        public string Destinatario { get; set; }
        public bool Reservada { get; set; }
    }
}
