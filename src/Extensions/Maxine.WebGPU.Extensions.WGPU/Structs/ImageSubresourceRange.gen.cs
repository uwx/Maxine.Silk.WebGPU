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
    [NativeName("Name", "WGPUImageSubresourceRange")]
    public unsafe partial struct ImageSubresourceRange
    {
        public ImageSubresourceRange
        (
            TextureAspect? aspect = null,
            uint? baseMipLevel = null,
            uint? mipLevelCount = null,
            uint? baseArrayLayer = null,
            uint? arrayLayerCount = null
        ) : this()
        {
            if (aspect is not null)
            {
                Aspect = aspect.Value;
            }

            if (baseMipLevel is not null)
            {
                BaseMipLevel = baseMipLevel.Value;
            }

            if (mipLevelCount is not null)
            {
                MipLevelCount = mipLevelCount.Value;
            }

            if (baseArrayLayer is not null)
            {
                BaseArrayLayer = baseArrayLayer.Value;
            }

            if (arrayLayerCount is not null)
            {
                ArrayLayerCount = arrayLayerCount.Value;
            }
        }


        [NativeName("Type", "WGPUTextureAspect")]
        [NativeName("Type.Name", "WGPUTextureAspect")]
        [NativeName("Name", "aspect")]
        public TextureAspect Aspect;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "baseMipLevel")]
        public uint BaseMipLevel;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mipLevelCount")]
        public uint MipLevelCount;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "baseArrayLayer")]
        public uint BaseArrayLayer;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "arrayLayerCount")]
        public uint ArrayLayerCount;
    }
}
