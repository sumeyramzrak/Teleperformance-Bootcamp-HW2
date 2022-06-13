namespace SOLIDKavramı.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataServices(this IServiceCollection service)
        {
            service.AddScoped<IMovieService, MovieService>();
        }
    }
}
