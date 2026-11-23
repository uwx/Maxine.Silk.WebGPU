// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeTextureFormat")]
    public enum NativeTextureFormat : int
    {
        [NativeName("Name", "WGPUNativeTextureFormat_NV12")]
        NV12 = 0x30007,
        [NativeName("Name", "WGPUNativeTextureFormat_P010")]
        P010 = 0x30008,
    }
}
