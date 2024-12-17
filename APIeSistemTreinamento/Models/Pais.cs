using System.Formats.Asn1;

namespace APIeSistemTreinamento.Models
{
    public class Pais : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string codigoBanCen { get; set; }
        public bool Ativo { get; set; }

        //      id integer NOT NULL DEFAULT nextval('pais_id_seq'::regclass),
        //nome character varying(50) NOT NULL DEFAULT ''::character varying,
        //codigo_ban_cen character varying(4) NOT NULL DEFAULT ''::character varying,
        //ativo boolean NOT NULL DEFAULT false,
        //CONSTRAINT "PK_public.pais" PRIMARY KEY(id)
    }
}
