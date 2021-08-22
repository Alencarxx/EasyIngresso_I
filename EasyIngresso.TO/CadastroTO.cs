using System;


namespace EasyIngresso.TO
{
    public class CadastroTO
    {
        public int idCadastro { get; set; }

        public string nome { get; set; }

        public string Endereco { get; set; }

        public string CPf { get; set; }

        public string Complemento { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public string CEP { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCriacao { get; set; }

        public int codSituacao { get; set; }

        public DateTime DataSituacao { get; set; }

        public DateTime DataBloqueio { get; set; }
    }
}
