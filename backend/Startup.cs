

namespace _315HealthCareProject
{
    public class Startup
    {

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Thêm middleware CORS
            app.UseCors("AllowSpecificOrigin");

            // Các middleware khác
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            // Cấu hình Endpoint
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:6000")
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

            // Các dịch vụ khác
            services.AddControllers();
        }



    }
}