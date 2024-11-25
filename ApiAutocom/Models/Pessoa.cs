using APIeSistemTreinamento.Models.Enums;

namespace APIeSistemTreinamento.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Conjuge { get; set; }
        public string Mae { get; set; }
        public string Pai { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string ApelidoNomeFantasia { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public string CpfCnpj { get; set; }
        public string Identidade { get; set; }
        public string EmissorIdentidade { get; set; }
        public string InscricaoProdutorRural { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public bool Ativo { get; set; }


    }
}
