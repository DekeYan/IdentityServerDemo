using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerDemo
{
    public class Config
    {

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource> {
                new ApiResource("IdentityApi1","My IdentityApi")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
                return new List<Client>
           {
            new Client
            {
                ClientId = "IdentityServerClient",

                // no interactive user, use the clientid/secret for authentication
                AllowedGrantTypes = GrantTypes.ClientCredentials,

                // secret for authentication
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },

                // scopes that client has access to
                AllowedScopes = { "IdentityApi1" }
                }
                };
        }
        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>{
                new TestUser{
                    SubjectId="1",
                    Username="wyt",
                    Password="123456"
                }
            };
        }
    }
}
