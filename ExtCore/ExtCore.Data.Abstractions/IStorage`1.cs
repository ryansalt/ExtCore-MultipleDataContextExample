﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace ExtCore.Data.Abstractions
{
  /// <summary>
  /// Describes a storage that is implementation of the Unit of Work design pattern with the mechanism
  /// of getting the repositories to work with the underlying storage context and committing the changes
  /// made by all the repositories.
  /// </summary>
  public interface IStorage<T> where T : class
  {
    /// <summary>
    /// Gets the underlying storage context used by this storage.
    /// </summary>
    IStorageContext<T> StorageContext { get; }

    /// <summary>
    /// Gets a repository of the given type.
    /// </summary>
    /// <typeparam name="TR">The type parameter to find implementation of.</typeparam>
    /// <returns></returns>
    TR GetRepository<TR>() where TR: IRepository<T>;

    /// <summary>
    /// Commits the changes made by all the repositories.
    /// </summary>
    void Save();
  }
}