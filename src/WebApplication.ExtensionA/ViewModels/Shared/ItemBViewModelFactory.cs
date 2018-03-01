// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using WebApplication.ExtensionA.Data.Entities;

namespace WebApplication.ExtensionA.ViewModels.Shared
{
  public class ItemBViewModelFactory
  {
    public ItemBViewModel Create(ItemB item)
    {
      return new ItemBViewModel()
      {
        Name = item.Name
      };
    }
  }
}