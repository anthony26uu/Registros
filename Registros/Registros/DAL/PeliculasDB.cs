using Registros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Registros.DAL
{
  public  class PeliculasDB: DbContext
    {
        public PeliculasDB(): base("ConStr")
        {

        }
      
        public DbSet<Peliculas> Peliculas { get; set; }
    }
}
