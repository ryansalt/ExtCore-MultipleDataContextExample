// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using Data.Abstractions.Extensions;
using ExtCore.Data.EntityFramework;
using WebApplication.ExtensionB.Data.Abstractions;
using WebApplication.ExtensionB.Data.Entities;

namespace WebApplication.ExtensionB.Data.EntityFramework.Sqlite
{
	public class ItemBRepository : RepositoryBase<ItemB, SecondStorageContext>, IItemBRepository
	{
		public IEnumerable<ItemB> All()
		{
			return this.dbSet.OrderBy(i => i.Name);
		}

	}
}