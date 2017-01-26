using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Registros.Entidades
{
    public class Usuario
    {
        [Key]
        public string Usuarios { get; set; }
        public string clave { get; set; }
        public string Nombres { get; set; }
       

        public Usuario()
        {

        }
    }
}
