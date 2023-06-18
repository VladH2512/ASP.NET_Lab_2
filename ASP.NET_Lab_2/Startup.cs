using ASP.NET_Lab_2.Data.Interfaces;
using ASP.NET_Lab_2.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;


namespace ASP.NET_Lab_2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllClothes, MockClothes>();
            services.AddTransient<IClothesCategory, MockCategory>();
            services.AddTransient<IClothesType, MockType>();
            services.AddTransient<IClothesCompany, MockCompany>();
            services.AddTransient<IClothesColor, MockColor>();

            services.AddMvc(mvcOtions =>
            {
                mvcOtions.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //����������� �������
            app.UseDeveloperExceptionPage();

            app.UseStatusCodePages();//����������� ���� �������

            //��� ����������� ����� �����, ����� �� ����������, css-����� �� ����
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute(); //��� ������������� �� ������������
        }
    }
}
