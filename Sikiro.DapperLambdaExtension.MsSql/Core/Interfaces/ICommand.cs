﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sikiro.DapperLambdaExtension.MsSql.Core.Interfaces
{
    public interface ICommand<T>
    {
        int Update(T entity);
        int Update(Expression<Func<T, T>> updateExpression);
        int Delete();
        int Insert(T entity);
        void BatchInsert(IEnumerable<T> entities, int timeout = 120);
    }
}