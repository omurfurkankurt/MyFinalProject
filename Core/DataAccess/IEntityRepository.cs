using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

// Core katmanı diger katmanları referans almaz

namespace Core.DataAccess
{
    // generic constraint generic kısıtlar
    // T : class = T bir referans tip olmalı anlamına gelir ,
    // aynı zamanda  IEntity türünde olabilr veya IEntity implemente eden bir nesne olabilir,
    // new' lenebilr olmalı Yani interface olamaz 
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
