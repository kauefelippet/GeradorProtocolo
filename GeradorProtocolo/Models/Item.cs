namespace GeradorProtocolo.Models
{
    public class Item
    {
        public string TipoRegistro { get; set; }
        public string NomeParte { get; set; }
        public string? CpfParte { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public Boolean ProtocoloLivro { get; set; }
        public double Total => Valor * Quantidade;
    }
}
