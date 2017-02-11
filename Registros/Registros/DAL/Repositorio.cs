using Registros.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Registros.DAL
{
    
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {

        CategoriasDB Contex = null;

        public Repositorio()
        {
            Contex = new CategoriasDB();
        }
        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Contex.Set<TEntity>();

            }
        }
        TEntity IRepository<TEntity>.Guardar(TEntity laEntidad)
        {
            throw new NotImplementedException();
        }

        public TEntity Guardar (TEntity Entidad)
        {
            TEntity resultado = null;
            try
            {
                EntitySet.Add(Entidad);
                Contex.SaveChanges();
                resultado = Entidad;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public bool Modificar(TEntity Entidad)
        {
            bool resultado = false;

            try
            {
                EntitySet.Attach(Entidad);
                Contex.Entry<TEntity>(Entidad).State = EntityState.Modified;

                resultado = Contex.SaveChanges()>0;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

       public TEntity Buscar(Expression<Func<TEntity, bool >> Criterio)
        {
            TEntity resultado = null;
            try
            {
                resultado = EntitySet.FirstOrDefault(Criterio);

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public bool Eliminar (TEntity Entidad)
        {
            bool resultado = false;
            try
            {
                EntitySet.Attach(Entidad);
                EntitySet.Remove(Entidad);
                resultado = Contex.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public List<TEntity> Lista (Expression <Func<TEntity, bool >> Criterio)
        {
            List<TEntity> resultado = null;
            try
            {
                resultado = EntitySet.Where(Criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public void Dispose()
        {
            if (Contex != null)
                Contex.Dispose();

        }

       
    }
}


