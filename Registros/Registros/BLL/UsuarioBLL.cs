using Registros.DAL;
using Registros.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registros.BLL
{
   public class UsuarioBLL
    {
        public static bool Insertar(Usuario n)
        {
           
            bool buscar = false;
            using (var con = new UsuarioDB())
            {
                try
                {
                    con.Usuario.Add(n);
                    con.SaveChanges();
                                       
                }
                catch (Exception)
                {
                    MessageBox.Show("Error ");
                }
               
            }
              return buscar;
        }


    }
}
