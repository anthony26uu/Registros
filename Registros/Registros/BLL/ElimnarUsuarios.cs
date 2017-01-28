using Registros.DAL;
using Registros.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registros.BLL
{
    public   class ElimnarUsuarios
    {
        public static void Eliminar(UsuarioBLL n)
        {
            var usuario = new Usuario();

            using (var conn = new UsuarioDB())
            {
                try
                {
                    conn.Entry(n).State = System.Data.Entity.EntityState.Deleted;
                    conn.SaveChanges();

                }catch(Exception)
                {
                    MessageBox.Show("Erro");

                }
            }
        }
    }
    
}
