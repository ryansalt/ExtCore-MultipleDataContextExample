// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using WebApplication.ExtensionB.Data.Entities;
using WebApplication.ExtensionB.ViewModels.Shared;

namespace WebApplication.ExtensionB.ViewModels.ExtenstionB
{
  public class IndexBViewModelFactory
  {
    public IndexBViewModel Create(IEnumerable<ItemB> items)
    {
      return new IndexBViewModel()
      {
        Items = items.Select(i => new ItemBViewModelFactory().Create(i))
      };
    }
  }
}