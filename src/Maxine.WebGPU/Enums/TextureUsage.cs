// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU
{
    /// <summary>
    /// How a texture may be used.
    /// </summary>
    /// <remarks>Hand-written for the reason on <see cref="BufferUsage" />.</remarks>
    [Flags]
    [NativeName("Name", "WGPUTextureUsage")]
    public enum TextureUsage : ulong
    {
        [NativeName("Name", "WGPUTextureUsage_None")]
        None = 0x0,

        [NativeName("Name", "WGPUTextureUsage_CopySrc")]
        CopySrc = 0x1,

        [NativeName("Name", "WGPUTextureUsage_CopyDst")]
        CopyDst = 0x2,

        [NativeName("Name", "WGPUTextureUsage_TextureBinding")]
        TextureBinding = 0x4,

        [NativeName("Name", "WGPUTextureUsage_StorageBinding")]
        StorageBinding = 0x8,

        [NativeName("Name", "WGPUTextureUsage_RenderAttachment")]
        RenderAttachment = 0x10,

        [NativeName("Name", "WGPUTextureUsage_TransientAttachment")]
        TransientAttachment = 0x20,
    }
}
