// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace ExtCore.Data.EntityFramework
{
  /// <summary>
  /// Implements the <see cref="IStorage{T}">IStorage&lt;T&gt;</see> interface and represents implementation of the
  /// Unit of Work design pattern with the mechanism of getting the repositories to work with the underlying
  /// Entity Framework storage context and committing the changes made by all the repositories.
  /// </summary>
  public class Storage<T> : IStorage<T> where T : class
  {
    /// <summary>
    /// Gets the Entity Framework storage context.
    /// </summary>
    public IStorageContext<T> StorageContext { get; private set; }

    public Storage(IStorageContext<T> storageContext)
    {
      if (!(storageContext is DbContext))
        throw new ArgumentException("The storageContext object must be an instance of the Microsoft.EntityFrameworkCore.DbContext class.");

      this.StorageContext = storageContext;
    }

    /// <summary>
    /// Gets a repository of the given type.
    /// </summary>
    /// <typeparam name="T">The type parameter to find implementation of.</typeparam>
    /// <returns></returns>
    public TRepository GetRepository<TRepository>() where TRepository : IRepository<T>
    {
      TRepository repository = ExtensionManager.GetInstance<TRepository>();

      if (repository != null)
        repository.SetStorageContext(this.StorageContext);

      return repository;
    }

    /// <summary>
    /// Commits the changes made by all the repositories.
    /// </summary>
    public void Save()
    {
      (this.StorageContext as DbContext).SaveChanges();
    }
        
  }
}