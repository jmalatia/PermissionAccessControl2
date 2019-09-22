﻿// Copyright (c) 2019 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

namespace DataKeyParts
{
    public enum AuthCookieVersions { Off, None, PermissionsOnly, PermissionsDataKey, Impersonation, RefreshClaims, Everything }

    public class DemoSetupOptions
    {
        public string DatabaseSetup { get; set; }
        public bool CreateAndSeed { get; set; }
        public AuthCookieVersions AuthVersion { get; set; }
    }


}