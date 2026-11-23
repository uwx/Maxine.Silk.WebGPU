// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    /// <summary>
    /// The backends an instance may bring up.
    /// </summary>
    /// <remarks>
    /// Hand-written: wgpu.h declares this as <c>typedef WGPUFlags WGPUInstanceBackend;</c> — a
    /// 64-bit integer with the bit values as <c>static const</c> — rather than a C enum, so the
    /// generator emits a <c>ulong</c> field and the values as constants. The type is 64-bit for the
    /// same reason as <c>BufferUsage</c>: the structs that carry it lay it out as eight bytes.
    /// </remarks>
    [Flags]
    [NativeName("Name", "WGPUInstanceBackend")]
    public enum InstanceBackend : ulong
    {
        [NativeName("Name", "WGPUInstanceBackend_All")]
        All = 0x0,

        [NativeName("Name", "WGPUInstanceBackend_Vulkan")]
        Vulkan = 0x1,

        [NativeName("Name", "WGPUInstanceBackend_GL")]
        GL = 0x2,

        [NativeName("Name", "WGPUInstanceBackend_Metal")]
        Metal = 0x4,

        [NativeName("Name", "WGPUInstanceBackend_DX12")]
        DX12 = 0x8,

        [NativeName("Name", "WGPUInstanceBackend_BrowserWebGPU")]
        BrowserWebGpu = 0x20,

        [NativeName("Name", "WGPUInstanceBackend_Primary")]
        Primary = 0x2D,

        [NativeName("Name", "WGPUInstanceBackend_Secondary")]
        Secondary = 0x2,

        [NativeName("Name", "WGPUInstanceBackend_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
