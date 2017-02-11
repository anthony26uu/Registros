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
        public static bool Insertar (Categorias N)
        {
            bool retorno = false;
            using (var repositorio = new Repositorio<Categorias>())
            {
                retorno = repositorio.Guardar(N) != null;

            }
            return  retorno;

        }

        public static bool Eliminar(Categorias N)
        {
            var db = new CategoriasDB();
            bool retorno =false;
            using (var repositorio = new Repositorio<Categorias>())
            {
                try
                {
                    repositorio.Eliminar(N);
                           
                    

                }
                catch (Exception)
                {
                  
                }
                return retorno;

            }
        }

        public static Entidades.Categorias Buscar(string id)
        {
            var b = new Entidades.Categorias();

            using (var repositorio = new Repositorio<Categorias>())
            {
                try
                {
                    //repositorio.Buscar(id);

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
