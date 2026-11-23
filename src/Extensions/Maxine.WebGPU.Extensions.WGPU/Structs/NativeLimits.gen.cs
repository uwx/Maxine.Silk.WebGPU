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
    [NativeName("Name", "WGPUNativeLimits")]
    public unsafe partial struct NativeLimits
    {
        public NativeLimits
        (
            ChainedStruct? chain = null,
            uint? maxNonSamplerBindings = null,
            uint? maxBindingArrayElementsPerShaderStage = null,
            uint? maxBindingArraySamplerElementsPerShaderStage = null,
            uint? maxMultiviewViewCount = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (maxNonSamplerBindings is not null)
            {
                MaxNonSamplerBindings = maxNonSamplerBindings.Value;
            }

            if (maxBindingArrayElementsPerShaderStage is not null)
            {
                MaxBindingArrayElementsPerShaderStage = maxBindingArrayElementsPerShaderStage.Value;
            }

            if (maxBindingArraySamplerElementsPerShaderStage is not null)
            {
                MaxBindingArraySamplerElementsPerShaderStage = maxBindingArraySamplerElementsPerShaderStage.Value;
            }

            if (maxMultiviewViewCount is not null)
            {
                MaxMultiviewViewCount = maxMultiviewViewCount.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxNonSamplerBindings")]
        public uint MaxNonSamplerBindings;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBindingArrayElementsPerShaderStage")]
        public uint MaxBindingArrayElementsPerShaderStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBindingArraySamplerElementsPerShaderStage")]
        public uint MaxBindingArraySamplerElementsPerShaderStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMultiviewViewCount")]
        public uint MaxMultiviewViewCount;
    }
}
