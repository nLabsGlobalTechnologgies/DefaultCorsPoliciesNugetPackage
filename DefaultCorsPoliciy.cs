using Microsoft.Extensions.DependencyInjection;

namespace CorsPolicies
{
    public static class DefaultCorsPoliciy
    {
        public static IServiceCollection AddDefaultCors(this IServiceCollection services)
        {
            services.AddCors(cfr =>
            {
                cfr.AddDefaultPolicy(policy =>
                {
                    policy
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .SetIsOriginAllowed(policy => true);
                });
            });
            return services;
        }
    }
}
