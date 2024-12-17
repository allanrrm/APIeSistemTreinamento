using System.Formats.Asn1;

namespace APIeSistemTreinamento.Models
{
    public class Unidade : Entity
    {
        public int Id { get; set; }
        public string Simbolo { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }


        //      id integer NOT NULL DEFAULT nextval('unidade_id_seq'::regclass),
        //simbolo character varying(10) NOT NULL,
        //nome character varying(50) NOT NULL DEFAULT ''::character varying,
        //ativo boolean NOT NULL DEFAULT false,
        //CONSTRAINT "PK_public.unidade" PRIMARY KEY(id)
    }
}
