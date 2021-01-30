using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Server
{
	public class Startup : object
	{
		public Startup() : base()
		{
		}

		public void ConfigureServices
			(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
		{
			services.AddControllers();
		}

		public void Configure
			(Microsoft.AspNetCore.Builder.IApplicationBuilder app,
			Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
		{
			//if (env.IsDevelopment())
			//{
			//	app.UseDeveloperExceptionPage();
			//}

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
