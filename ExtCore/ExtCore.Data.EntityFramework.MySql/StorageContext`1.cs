// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace ExtCore.Data.EntityFramework.MySql
{
  /// <summary>
  /// Implements the <see cref="IStorageContext{T}">IStorageContext&lt;T&gt;</see> interface and represents MySQL database
  /// with the Entity Framework Core as the ORM.
  /// </summary>
  /// <seealso cref="ExtCore.Data.EntityFramework.StorageContextBase{T}" />
  public class StorageContext<T> : StorageContextBase<T> where T : class
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="StorageContext">StorageContext</see> class.
    /// </summary>
    /// <param name="connectionString">The connection string that is used to connect to the MySQL database.</param>
    public StorageContext(IOptions<StorageContextOptions<T>> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);

      if (string.IsNullOrEmpty(this.MigrationsAssembly))
        optionsBuilder.UseMySQL(this.ConnectionString);

      else optionsBuilder.UseMySQL(
        this.ConnectionString,
        options =>
        {
          options.MigrationsAssembly(this.MigrationsAssembly);
        }
      );
    }
  }
}