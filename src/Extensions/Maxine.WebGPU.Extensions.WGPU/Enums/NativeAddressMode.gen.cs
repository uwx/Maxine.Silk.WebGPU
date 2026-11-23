// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    [Flags]
    [NativeName("Name", "WGPUNativeAddressMode")]
    public enum NativeAddressMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "WGPUNativeAddressMode_ClampToBorder")]
        ClampToBorder = 0x4,
        [NativeName("Name", "WGPUNativeAddressMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
