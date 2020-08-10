using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Web_API.Models;
using Web_API.Models.DTO;
using Web_API.Models.DataManager;
using Web_API.Models.Repository;

namespace Web_API
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<QLNHASACHContext>(options => options.UseSqlServer(Configuration.GetConnectionString("QLNHASACH")));
			services.AddScoped<IDataRepository<Users, UsersDTO>, UsersDM>();
			services.AddScoped<IDataRepository<Sach, SachDTO>, SachDM>();
			services.AddScoped<IDataRepository<KhachHang, KhachHangDTO>, KhachHangDM>();
			services.AddScoped<IDataRepository<HoaDon, HoaDonDTO>, HoaDonDM>();
			services.AddScoped<IDataRepository<PhieuThuTien, PhieuThuTienDTO>, PhieuThuTienDM>();
			services.AddScoped<IDataRepository<PhieuNhapSach, PhieuNhapSachDTO>, PhieuNhapSachDM>();
			services.AddScoped<IDataRepository<ThamSo, ThamSoDTO>, ThamSoDM>();

			services.AddControllers()
				.AddNewtonsoftJson(
					options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
				);

			services.AddControllers();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
