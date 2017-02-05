using Registros.DAL;
using Registros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registros.BLL
{
   public class PeliculasBLL
    {
        public static void Insertar(Peliculas nuevo)
        {
            using (var con = new PeliculasDB())
            {

                try
                {
                    con.Peliculas.Add(nuevo);
                    con.SaveChanges();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error...");
                }


            }

        }

        public static Peliculas Buscar(int id)
        {
            var buscar = new Peliculas();
            using (var con = new PeliculasDB())
            {
                try
                {
                    buscar = con.Peliculas.Find(id);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error...");
                }
            }
            return buscar;
        }

        public static void Eliminar(Peliculas nuevo)
        {
            var pelicula = new PeliculasDB();
            using (var con = new PeliculasDB())
            {
                con.Entry(nuevo).State = EntityState.Deleted;
                con.SaveChanges();
            }
        }
    }
}

