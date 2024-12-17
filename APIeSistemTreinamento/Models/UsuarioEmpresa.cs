namespace APIeSistemTreinamento.Models
{
    public class UsuarioEmpresa : Entity
    {
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public Empresa Empresa { get; set; } = null!;
        public bool Ativo { get; set; }
        public int Integrar { get; set; }
        public bool ApenasDav { get; set; }
        public bool ApenasNfe { get; set; }

    }
}
