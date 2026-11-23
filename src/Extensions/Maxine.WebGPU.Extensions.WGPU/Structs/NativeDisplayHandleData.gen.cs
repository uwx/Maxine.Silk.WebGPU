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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_wgpu_L1116_C5")]
    public unsafe partial struct NativeDisplayHandleData
    {
        public NativeDisplayHandleData
        (
            XlibDisplayHandle? xlib = null,
            XcbDisplayHandle? xcb = null,
            WaylandDisplayHandle? wayland = null
        ) : this()
        {
            if (xlib is not null)
            {
                Xlib = xlib.Value;
            }

            if (xcb is not null)
            {
                Xcb = xcb.Value;
            }

            if (wayland is not null)
            {
                Wayland = wayland.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "WGPUXlibDisplayHandle")]
        [NativeName("Type.Name", "WGPUXlibDisplayHandle")]
        [NativeName("Name", "xlib")]
        public XlibDisplayHandle Xlib;

        [FieldOffset(0)]
        [NativeName("Type", "WGPUXcbDisplayHandle")]
        [NativeName("Type.Name", "WGPUXcbDisplayHandle")]
        [NativeName("Name", "xcb")]
        public XcbDisplayHandle Xcb;

        [FieldOffset(0)]
        [NativeName("Type", "WGPUWaylandDisplayHandle")]
        [NativeName("Type.Name", "WGPUWaylandDisplayHandle")]
        [NativeName("Name", "wayland")]
        public WaylandDisplayHandle Wayland;
    }
}
