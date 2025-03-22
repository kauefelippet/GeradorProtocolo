using System.ComponentModel;

namespace GeradorProtocolo.Models
{
    public class Protocolo
    {
        public string Requerente { get; set; }
        public string CpfCnpj { get; set; }
        public int? IdProvisorio { get; set; }
        public string Atendente { get; set; }
        public DateOnly Retirada { get; set; }
        public DateTime HorarioRetirada { get; set; }
        public BindingSource BindingSource { get; set; }
        public BindingList<Item> ProtocoloRetirada { get; set; }
        public BindingList<Item> ProtocoloLivro { get; set; }
        public double Total => ProtocoloRetirada.Sum(item => item.Total);

        public Protocolo()
        {
            Requerente = "";
            CpfCnpj = "";
            Atendente = "";
            BindingSource = new BindingSource();
            ProtocoloRetirada = new BindingList<Item>();
            ProtocoloLivro = new BindingList<Item>();
        }
    }
}
