// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ExtCore.Data.EntityFramework
{
  /// <summary>
  /// Implements the <see cref="IStorageContext{T}">IStorageContext&lt;T&gt;</see> interface and represents the physical storage
  /// with the Entity Framework Core as the ORM.
  /// </summary>
  public abstract class StorageContextBase<T> : DbContext, IStorageContext<T> where T : class
  {
    /// <summary>
    /// The connection string that is used to connect to the physical storage.
    /// </summary>
    public string ConnectionString { get; private set; }

    /// <summary>
    /// The assembly name where migrations are maintained for this context.
    /// </summary>
    public string MigrationsAssembly { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="StorageContext">StorageContext</see> class.
    /// </summary>
    /// <param name="options">The IOptions&lt;StorageContextOptions&lt;T&gt;&gt; containging the connection string that is used to connect to the physical storage.</param>
    public StorageContextBase(IOptions<StorageContextOptions<T>> options)
    {
      this.ConnectionString = options.Value.ConnectionString;
      this.MigrationsAssembly = options.Value.MigrationsAssembly;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      this.RegisterEntities<T>(modelBuilder);
    }
  }
}