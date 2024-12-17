using System.Formats.Asn1;

namespace APIeSistemTreinamento.Models
{
    public class Cfop : Entity
    {
        public int Id { get; set; }
        public string CodigoCFOP { get; set; }
        public string Descricao { get; set; }
        public string DescricaoResumida { get; set; }
        public bool CreditaPisCofins { get; set; }
        public bool CompoeTotalNota { get; set; }
        public bool Ativo { get; set; }
        public int TipoCFOP { get; set; }
        public bool GeraMovimentoEstoque { get; set; }
        public int TipoBaseCalculoCredito { get; set; }

        //id_plano_conta foi suprimido pois envolveria a implementação da model do plano de contas.
    }
}
