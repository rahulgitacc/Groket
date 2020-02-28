// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId()
            };

        /// <summary>
        /// Declaring the API resource
        /// </summary>
        public static IEnumerable<ApiResource> Apis =>
            new List<ApiResource>() {
                new ApiResource("groketApi", "Groket Api")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>() { 
                // Add mobile client
                new Client
                {
                    ClientId = "Groket Mobile App",
                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    // secret for authentication
                    ClientSecrets = {new Secret("AppSecretId".Sha256())},
                    // scopes that client has access to
                    AllowedScopes = { "groketApi" }
                },

                // Add the admin web client
                new Client
                {
                    ClientId = "Groket Admin App",
                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    // secret for authentication
                    ClientSecrets = {new Secret("AppSecretId".Sha256())},
                    // scopes that client has access to
                    AllowedScopes = { "groketApi" }
                }
            };
        
    }
}