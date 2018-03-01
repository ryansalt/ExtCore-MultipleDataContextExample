// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace ExtCore.Data.EntityFramework
{
  /// <summary>
  /// Describes a mechanism of registering entities inside the Entity Framework storage context.
  /// </summary>
  public interface IEntityRegistrar<T> : IEntityRegistrar where T : class
  {
    
  }
}