// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUSamplerBorderColor")]
    public enum SamplerBorderColor : int
    {
        [NativeName("Name", "WGPUSamplerBorderColor_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUSamplerBorderColor_TransparentBlack")]
        TransparentBlack = 0x1,
        [NativeName("Name", "WGPUSamplerBorderColor_OpaqueBlack")]
        OpaqueBlack = 0x2,
        [NativeName("Name", "WGPUSamplerBorderColor_OpaqueWhite")]
        OpaqueWhite = 0x3,
        [NativeName("Name", "WGPUSamplerBorderColor_Zero")]
        Zero = 0x4,
        [NativeName("Name", "WGPUSamplerBorderColor_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
