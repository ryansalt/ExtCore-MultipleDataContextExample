// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Data.Abstractions.Extensions;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using WebApplication.ExtensionB.Data.Entities;

namespace WebApplication.ExtensionB.Data.EntityFramework.Sqlite
{
  public class EntityRegistrar : IEntityRegistrar<SecondStorageContext>
  {
    public void RegisterEntities(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<ItemA>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id);
          etb.ToTable("ItemAs");
        }
      );
      modelBuilder.Entity<ItemB>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id);
          etb.ToTable("ItemBs");
        }
      );
    }
  }
}