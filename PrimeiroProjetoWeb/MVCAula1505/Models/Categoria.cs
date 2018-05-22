using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAula1505.Models
{
    public class Categoria
    {

        public int CategoriaID { get; set; }

        [Display(Name ="Titulo")]
        [Required(ErrorMessage ="Imploro com todo fervor que preencha esse campo obritaório")]
        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}