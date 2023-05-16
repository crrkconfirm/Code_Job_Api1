namespace Code_Job_Api1
{
    public static class CorsPolicy
    {
        public static WebApplicationBuilder Cors(this WebApplicationBuilder builder, string corsPolicyName)
        {
            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy(name: corsPolicyName,
                                policy =>
                                {
                                    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                                });
            });
            return builder;
        }
    }
}
