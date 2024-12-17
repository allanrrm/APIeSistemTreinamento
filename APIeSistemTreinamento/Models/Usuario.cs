namespace APIeSistemTreinamento.Models
{
    public class Usuario : Entity
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public bool Administrador { get; set; }

        public List<Empresa> Empresas { get;} = [];

        public Pessoa Pessoa { get; set; }

    }
}
