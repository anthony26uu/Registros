using Registros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Registros.DAL
{
  public  class CategoriasDB : DbContext
    {
        public CategoriasDB():base("ConStr")
        {

        }
      public  DbSet<Categorias> Categorias { get; set; }
      public DbSet<Usuario> Usuario { get; set; }
      public DbSet<Peliculas> Peliculas { get; set; }
    }
}
