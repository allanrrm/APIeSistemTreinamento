namespace APIeSistemTreinamento.Models
{
    public class Usuario
    {
        public Pessoa IdPessoa { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public bool Administrador { get; set; }
    }
}
