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

namespace Maxine.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUINTERNAL_HAVE_EMDAWNWEBGPU_HEADER")]
    public unsafe partial struct InternalHaveEmdawnwebgpuHeader
    {
        public InternalHaveEmdawnwebgpuHeader
        (
            Silk.NET.Core.Bool32? unused = null
        ) : this()
        {
            if (unused is not null)
            {
                Unused = unused.Value;
            }
        }


        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "unused")]
        public Silk.NET.Core.Bool32 Unused;
    }
}
