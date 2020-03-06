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


        public static IEnumerable<ApiResource> Apis(){
            // create api resource list
            var apiResources = new List<ApiResource>();

            // Add the groket api resources 
            var groketApi = new ApiResource("groketApi", "Groket Api");
            groketApi.Description = "Api resource to handle all application activity";
            apiResources.Add(groketApi);

            return apiResources;
        }
        
        // clients application who want to access the api resources
        public static IEnumerable<Client> Clients(){
            //Create clients list like webui, console applications and so on
            var clients = new List<Client>();

            // Add the MVC admin client
            var adminWebUi = new Client();
            adminWebUi.ClientId = "Groket Admin App";
            adminWebUi.ClientSecrets.Add(new Secret("secret".Sha256()));
            adminWebUi.ClientName = "AdminUi";
            adminWebUi.AllowedGrantTypes = GrantTypes.Code;
            adminWebUi.RequireConsent = false;
            adminWebUi.AllowOfflineAccess = true;
            adminWebUi.AlwaysSendClientClaims = true;
            adminWebUi.AlwaysIncludeUserClaimsInIdToken = true;
            adminWebUi.RequirePkce = true;
            adminWebUi.AllowedScopes = new List<string>
            {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile,
                "groketApi"
            };
            adminWebUi.RedirectUris.Add("http://localhost:51810/signin-oidc");
            adminWebUi.PostLogoutRedirectUris.Add("http://localhost:51810/signout-callback-oidc");
            clients.Add(adminWebUi);

            return clients;

        }
    }
}