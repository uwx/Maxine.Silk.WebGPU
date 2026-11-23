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

namespace Maxine.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUWaylandDisplayHandle")]
    public unsafe partial struct WaylandDisplayHandle
    {
        public WaylandDisplayHandle
        (
            void* display = null
        ) : this()
        {
            if (display is not null)
            {
                Display = display;
            }
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "display")]
        public void* Display;
    }
}
