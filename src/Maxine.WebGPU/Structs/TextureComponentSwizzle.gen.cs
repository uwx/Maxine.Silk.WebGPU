// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Maxine.WebGPU
{
    [NativeName("Name", "WGPUTextureComponentSwizzle")]
    public unsafe partial struct TextureComponentSwizzle
    {
        public TextureComponentSwizzle
        (
            ComponentSwizzle? r = null,
            ComponentSwizzle? g = null,
            ComponentSwizzle? b = null,
            ComponentSwizzle? a = null
        ) : this()
        {
            if (r is not null)
            {
                R = r.Value;
            }

            if (g is not null)
            {
                G = g.Value;
            }

            if (b is not null)
            {
                B = b.Value;
            }

            if (a is not null)
            {
                A = a.Value;
            }
        }


        [NativeName("Type", "WGPUComponentSwizzle")]
        [NativeName("Type.Name", "WGPUComponentSwizzle")]
        [NativeName("Name", "r")]
        public ComponentSwizzle R;

        [NativeName("Type", "WGPUComponentSwizzle")]
        [NativeName("Type.Name", "WGPUComponentSwizzle")]
        [NativeName("Name", "g")]
        public ComponentSwizzle G;

        [NativeName("Type", "WGPUComponentSwizzle")]
        [NativeName("Type.Name", "WGPUComponentSwizzle")]
        [NativeName("Name", "b")]
        public ComponentSwizzle B;

        [NativeName("Type", "WGPUComponentSwizzle")]
        [NativeName("Type.Name", "WGPUComponentSwizzle")]
        [NativeName("Name", "a")]
        public ComponentSwizzle A;
    }
}
