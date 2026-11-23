// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeSurfaceGetCurrentTextureStatus")]
    public enum NativeSurfaceGetCurrentTextureStatus : int
    {
        [NativeName("Name", "WGPUSurfaceGetCurrentTextureStatus_Occluded")]
        SurfaceGetCurrentTextureStatusOccluded = 0x30001,
        [NativeName("Name", "WGPUNativeSurfaceGetCurrentTextureStatus_Force32")]
        NativeSurfaceGetCurrentTextureStatusForce32 = 0x7FFFFFFF,
    }
}
