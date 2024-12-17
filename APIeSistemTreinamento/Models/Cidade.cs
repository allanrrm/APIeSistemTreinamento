using System.Formats.Asn1;

namespace APIeSistemTreinamento.Models
{
    public class Cidade : Entity
    {

        public int Id { get; set; }
        public int IdEstado { get; set; }
        public UF UF { get; set; }
        public string Nome { get; set; }
        public int CodigoIBGE { get; set; }
        public bool Ativo { get; set; }


    }
}
