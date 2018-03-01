// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Data.Abstractions.Extensions;
using ExtCore.Data.Abstractions;
using WebApplication.ExtensionA.Data.Entities;

namespace WebApplication.ExtensionA.Data.Abstractions
{
	public interface IItemARepository : IRepository<FirstStorageContext>
	{
		IEnumerable<ItemA> All();
	}
}