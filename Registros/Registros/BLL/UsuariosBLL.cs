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
  public  class UsuariosBLL
    {
        public static void Insertar(Usuario nuevo)
        {
            using (var con = new UsuarioDB())
            {
                try
                {
                    con.Usuario.Add(nuevo);
                    con.SaveChanges();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error...");
                }

            }

        }

        public static Usuario Buscar(int Id)
        {
            var usuario = new Usuario();
            using (var conn = new UsuarioDB())
            {
                try
                {
                    usuario = conn.Usuario.Find(Id);

                }
                catch (Exception)
                {

                    MessageBox.Show("Error...");
                }


            }

            return usuario;

        }

        public static void Eliminar(Usuario nuevo)
        {
            var usuario = new Usuario();
            using (var conn = new UsuarioDB())
            {
                try
                {
                    conn.Entry(nuevo).State = EntityState.Deleted;
                    conn.SaveChanges();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error...");

                }

            }

        }
    }
}

