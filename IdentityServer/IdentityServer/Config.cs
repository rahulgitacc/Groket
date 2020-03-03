// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };


        public static IEnumerable<ApiResource> Apis =>
            new List<ApiResource>() {
                new ApiResource("groketApi", "Groket API")
            };


        public static IEnumerable<Client> Clients =>
            new List<Client>() { 
                // Added the console client
                new Client
                {
                    ClientId = "client",
                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    // secret for authentication
                    ClientSecrets = {new Secret("secret".Sha256())},
                    // scopes that client has access to
                    AllowedScopes = { "groketApi" }
                },

                // Add the admin web client
                //new Client
                //{
                //    ClientId = "Groket Admin App",
                //    // no interactive user, use the clientid/secret for authentication
                //    AllowedGrantTypes = GrantTypes.ClientCredentials,
                //    // secret for authentication
                //    ClientSecrets = {new Secret("AppSecretId".Sha256())},
                //    // scopes that client has access to
                //    AllowedScopes = { "groketApi" }
                //}

                // interactive ASP.NET Core MVC client
                new Client
                {
                    ClientId = "Groket Admin App",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,
                    RequireConsent = false,
                    RequirePkce = true,

                    // where to redirect to after login
                    RedirectUris = { "http://localhost:51810/signin-oidc" },

                    // where to redirect to after logout
                    PostLogoutRedirectUris = { "http://localhost:51810/signout-callback-oidc" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "groketApi"
                    },
                    AllowOfflineAccess = true
                }
            };
    }
}