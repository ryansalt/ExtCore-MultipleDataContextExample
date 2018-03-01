// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using WebApplication.ExtensionA.ViewModels.Shared;

namespace WebApplication.ExtensionA.ViewModels.ExtenstionA
{
  public class IndexBViewModel
  {
    public IEnumerable<ItemBViewModel> Items { get; set; }
  }
}