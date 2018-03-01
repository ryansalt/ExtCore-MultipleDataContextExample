﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.Abstractions;
using ExtCore.Data.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace ExtCore.Data.EntityFramework
{
	/// <summary>
	/// Implements the <see cref="IRepository{T}">IRepository&lt;T&gt;</see> interface and represents default repository behavior.
	/// </summary>
	/// <typeparam name="TEntity">The entity type this repository operates.</typeparam>
	/// <typeparam name="TContext"></typeparam>
	public abstract class RepositoryBase<TEntity, TContext> : IRepository<TContext>, IEntity 
		where TEntity : class where TContext : class
  {
    protected DbContext storageContext;
    protected DbSet<TEntity> dbSet;

    /// <summary>
    /// Sets the Entity Framework storage context that represents the physical storage to work with.
    /// </summary>
    /// <param name="storageContext">The Entity Framework storage context to set.</param>
    public void SetStorageContext(IStorageContext<TContext> storageContext)
    {
      this.storageContext = storageContext as DbContext;
      this.dbSet = this.storageContext.Set<TEntity>();
    }
  }
}