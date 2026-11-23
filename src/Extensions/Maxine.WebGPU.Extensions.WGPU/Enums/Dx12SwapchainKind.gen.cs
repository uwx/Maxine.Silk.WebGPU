// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUDx12SwapchainKind")]
    public enum Dx12SwapchainKind : int
    {
        [NativeName("Name", "WGPUDx12SwapchainKind_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUDx12SwapchainKind_DxgiFromHwnd")]
        DxgiFromHwnd = 0x1,
        [NativeName("Name", "WGPUDx12SwapchainKind_DxgiFromVisual")]
        DxgiFromVisual = 0x2,
        [NativeName("Name", "WGPUDx12SwapchainKind_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
