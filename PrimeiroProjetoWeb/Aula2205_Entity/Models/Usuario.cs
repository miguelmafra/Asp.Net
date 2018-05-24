﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula2205_Entity.Models
{
    public class Usuario
    {

        public int UsuarioID { get; set; }
        [Required, StringLength(30)]
        public string Nome { get; set; }

        public bool Ativo { get; set; }

    }
}