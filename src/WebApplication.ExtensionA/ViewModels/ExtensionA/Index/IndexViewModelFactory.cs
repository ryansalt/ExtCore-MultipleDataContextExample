// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using WebApplication.ExtensionA.Data.Entities;
using WebApplication.ExtensionA.ViewModels.Shared;

namespace WebApplication.ExtensionA.ViewModels.ExtenstionA
{
  public class IndexViewModelFactory
  {
    public IndexViewModel Create(IEnumerable<ItemA> items)
    {
      return new IndexViewModel()
      {
        Items = items.Select(i => new ItemViewModelFactory().Create(i))
      };
    }
  }
}