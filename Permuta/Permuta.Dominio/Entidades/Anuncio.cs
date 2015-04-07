using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Permuta.Dominio.Entidades
{
    public class Anuncio
    {
        [Key]
        public int AnuncioID { get; set; }


        public int ClienteID { get; set; }

        [Display(Name = "Titulo:")]
        [Required(ErrorMessage = "Digite o Titulo")]
        public string Titulo { get; set; }

        [Display(Name = "Descrição:")]
        [Required(ErrorMessage = "Digite a descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Categoria:")]
        [Required(ErrorMessage = "Escolha a Categoria")]
        public int CategoriaID { get; set; }

        [Display(Name = "Estado:")]
        [Required(ErrorMessage = "Digite o Estado")]
        public string Estado { get; set; }

        [Display(Name = "Bairro:")]
        [Required(ErrorMessage = "Digite o Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Fotos:")]
        
        public string Foto { get; set; }

        [Display(Name = "Tipos de Oferta:")]
        [Required(ErrorMessage = "Escolha o tipo de oferta")]
        public string Tipo_Oferta { get; set; }
    }
}
