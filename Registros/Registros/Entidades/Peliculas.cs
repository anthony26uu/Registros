using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Registros.Entidades
{
   
    public class Peliculas
    {
        [Key]
        public string Nombres { get; set; }
        public string Estreno { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }

        public Peliculas()
        {

        }
    }
}
