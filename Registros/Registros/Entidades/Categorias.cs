using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Registros.Entidades
{
  public  class Categorias
    {
        [Key]
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string id { get; set; }

        public Categorias()
        {

        }
    }
}
