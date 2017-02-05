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
  public  class CategoriaBLL
    {
        public static void Insertar (Categorias N)
        {
            using (var Con= new CategoriasDB())
                {
                try
                {
                    Con.Categorias.Add(N);
                    Con.SaveChanges();
           
                }catch(Exception )
                {
                    MessageBox.Show("Error...");
                }
            
            }
        }

        public static void Eliminar(Categorias N)
        {
            using (var Con = new CategoriasDB())
            {
                try
                {
                    Con.Entry(N).State = EntityState.Deleted;
                    Con.SaveChanges();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error...");
                }

            }
        }

        public static Entidades.Categorias Buscar(string id)
        {
            var b = new Entidades.Categorias();

            using (var con = new CategoriasDB())
            {
                try
                {
                    b = con.Categorias.Find(id);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error...");
                }
            }
            return b;
        }


    }
}
