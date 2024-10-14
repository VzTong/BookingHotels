namespace App.Web.WebConfig
{
	public static class AppService
	{
		public static string WebRootPath { get; private set; }
		public static IConfiguration Configuration { get; }

		public static void AddAppService(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
		{
			WebRootPath = env.WebRootPath;
		}

	}
}