using Microsoft.AspNetCore.Http.HttpResults;
using System.Text.RegularExpressions;

namespace APIeSistemTreinamento.Models
{
    public class Empresa : Entity
    {

        public Pessoa Pessoa { get; set; }
        public int? IdContador { get; set; }
        public string Codigo { get; set; }
        public string Nomenclatura { get; set; }
        public string RazaoSocialSintegra { get; set; }
        public double CapitalSocial { get; set; }
        public bool EmitenteNfe { get; set; }
        public bool Ativo { get; set; }
        public string CodigoContabil { get; set; }
        public string CodigoAlternativo { get; set; }
        public double AliqCredSimplesNacional { get; set; }
        public int? IdGrupoEmpresa { get; set; }
        public string EmailPortalContador { get; set; }
        public string SenhaPortalContador { get; set; }


    }
}
