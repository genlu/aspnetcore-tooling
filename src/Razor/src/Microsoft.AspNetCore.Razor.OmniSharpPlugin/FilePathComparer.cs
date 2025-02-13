﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.Razor.OmniSharpPlugin
{
    internal static class FilePathComparer
    {
        private static StringComparer s_instance;

        public static StringComparer Instance
        {
            get
            {
                if (s_instance == null && RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    s_instance = StringComparer.Ordinal;
                }
                else if (s_instance == null)
                {
                    s_instance = StringComparer.OrdinalIgnoreCase;
                }

                return s_instance;
            }
        }
    }
}
