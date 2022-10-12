using Microsoft.AspNetCore.Identity;

namespace WesternInn_UA_JC_NN.Data
{
    public class SeedRoles
    {

        public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration Configuration)
        {
            // Get the RoleManager and the UserManager objects
            var RoleManager =
            serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager =
            serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
        }
    }
}
