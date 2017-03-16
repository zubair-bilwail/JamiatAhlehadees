﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Generic_Pattern.Interface
{
    public interface IGenericPattern<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Insert(T entity);
        void Delete(int id);
        T GetById(int id);
        void Update(T entity);
        List<T> GetMultipleTablesDataById(string SQLQuery);
    }
}
