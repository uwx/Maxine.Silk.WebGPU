// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeDisplayHandleType")]
    public enum NativeDisplayHandleType : int
    {
        [NativeName("Name", "WGPUNativeDisplayHandleType_None")]
        None = 0x0,
        [NativeName("Name", "WGPUNativeDisplayHandleType_Xlib")]
        Xlib = 0x1,
        [NativeName("Name", "WGPUNativeDisplayHandleType_Xcb")]
        Xcb = 0x2,
        [NativeName("Name", "WGPUNativeDisplayHandleType_Wayland")]
        Wayland = 0x3,
        [NativeName("Name", "WGPUNativeDisplayHandleType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
