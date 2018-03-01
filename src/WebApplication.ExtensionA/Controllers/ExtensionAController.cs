// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Data.Abstractions.Extensions;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using WebApplication.ExtensionA.Data.Abstractions;
using WebApplication.ExtensionA.ViewModels.ExtenstionA;

namespace WebApplication.ExtensionA.Controllers
{
	public class ExtensionAController : Controller
	{
		private IStorage<FirstStorageContext> storage;

		public ExtensionAController(IStorage<FirstStorageContext> storage)
		{
			this.storage = storage;
		}

		public ActionResult Index()
		{
			return this.View(new IndexViewModelFactory().Create(this.storage.GetRepository<IItemARepository>().All()));
		}

		public ActionResult IndexB()
		{
			return this.View(new IndexBViewModelFactory().Create(this.storage.GetRepository<IItemBRepository>().All()));
		}

	}
}