using Registros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Registros.DAL
{
    public class UsuarioDB :DbContext

    {
        public UsuarioDB():base("ConStr")
        {

        }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
