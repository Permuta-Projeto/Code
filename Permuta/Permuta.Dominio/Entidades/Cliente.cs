using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Permuta.Dominio.Entidades
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "Digite o Nome")]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Digite o CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Digite o Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Digite o Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Digite o Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Digite o Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite o Celular")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Digite a Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
