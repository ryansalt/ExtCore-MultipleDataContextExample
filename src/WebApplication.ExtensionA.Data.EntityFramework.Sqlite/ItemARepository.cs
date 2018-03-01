// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using Data.Abstractions.Extensions;
using ExtCore.Data.EntityFramework;
using WebApplication.ExtensionA.Data.Abstractions;
using WebApplication.ExtensionA.Data.Entities;

namespace WebApplication.ExtensionA.Data.EntityFramework.Sqlite
{
	public class ItemARepository : RepositoryBase<ItemA, FirstStorageContext>, IItemARepository
	{
		public IEnumerable<ItemA> All()
		{
			return this.dbSet.OrderBy(i => i.Name);
		}

	}
}