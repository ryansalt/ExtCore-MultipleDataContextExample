using Data.Abstractions.Extensions;
using ExtCore.Data.EntityFramework;
using ExtCore.Infrastructure;
using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Reflection;

namespace WebApplication.ExtensionB.Actions
{
	/// <summary>
	/// Implements the <see cref="IConfigureServicesAction">IConfigureServicesAction</see> interface and
	/// registers found implementation of the <see cref="IStorage">IStorage</see> interface inside the DI.
	/// </summary>
	public class AddStorageAction : IConfigureServicesAction
	{
		/// <summary>
		/// Priority of the action. The actions will be executed in the order specified by the priority (from smallest to largest).
		/// </summary>
		public int Priority => 1000;

		/// <summary>
		/// Registers found implementation of the <see cref="IStorage">IStorage</see> interface inside the DI.
		/// </summary>
		/// <param name="serviceCollection">
		/// Will be provided by the ExtCore and might be used to register any service inside the DI.
		/// </param>
		/// <param name="serviceProvider">
		/// Will be provided by the ExtCore and might be used to get any service that is registered inside the DI at this moment.
		/// </param>
		public void Execute(IServiceCollection services, IServiceProvider serviceProvider)
		{
			services.AddScoped(typeof(ExtCore.Data.Abstractions.IStorageContext<SecondStorageContext>), typeof(ExtCore.Data.EntityFramework.Sqlite.StorageContext<SecondStorageContext>));
			services.AddScoped(typeof(ExtCore.Data.Abstractions.IStorage<SecondStorageContext>), typeof(Storage<SecondStorageContext>));
		}
	}
}
