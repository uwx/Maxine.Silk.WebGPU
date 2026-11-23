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
    [NativeName("Name", "WGPUInstanceExtras")]
    public unsafe partial struct InstanceExtras
    {
        public InstanceExtras
        (
            ChainedStruct? chain = null,
            Maxine.WebGPU.Extensions.WGPU.InstanceBackend? backends = null,
            ulong? flags = null,
            Dx12Compiler? dx12ShaderCompiler = null,
            Gles3MinorVersion? gles3MinorVersion = null,
            GLFenceBehaviour? glFenceBehaviour = null,
            StringView? dxcPath = null,
            DxcMaxShaderModel? dxcMaxShaderModel = null,
            Dx12SwapchainKind? dx12PresentationSystem = null,
            byte* budgetForDeviceCreation = null,
            byte* budgetForDeviceLoss = null,
            NativeDisplayHandle? displayHandle = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (backends is not null)
            {
                Backends = backends.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (dx12ShaderCompiler is not null)
            {
                Dx12ShaderCompiler = dx12ShaderCompiler.Value;
            }

            if (gles3MinorVersion is not null)
            {
                Gles3MinorVersion = gles3MinorVersion.Value;
            }

            if (glFenceBehaviour is not null)
            {
                GlFenceBehaviour = glFenceBehaviour.Value;
            }

            if (dxcPath is not null)
            {
                DxcPath = dxcPath.Value;
            }

            if (dxcMaxShaderModel is not null)
            {
                DxcMaxShaderModel = dxcMaxShaderModel.Value;
            }

            if (dx12PresentationSystem is not null)
            {
                Dx12PresentationSystem = dx12PresentationSystem.Value;
            }

            if (budgetForDeviceCreation is not null)
            {
                BudgetForDeviceCreation = budgetForDeviceCreation;
            }

            if (budgetForDeviceLoss is not null)
            {
                BudgetForDeviceLoss = budgetForDeviceLoss;
            }

            if (displayHandle is not null)
            {
                DisplayHandle = displayHandle.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUInstanceBackend")]
        [NativeName("Type.Name", "WGPUInstanceBackend")]
        [NativeName("Name", "backends")]
        public Maxine.WebGPU.Extensions.WGPU.InstanceBackend Backends;

        [NativeName("Type", "WGPUInstanceFlag")]
        [NativeName("Type.Name", "WGPUInstanceFlag")]
        [NativeName("Name", "flags")]
        public ulong Flags;

        [NativeName("Type", "WGPUDx12Compiler")]
        [NativeName("Type.Name", "WGPUDx12Compiler")]
        [NativeName("Name", "dx12ShaderCompiler")]
        public Dx12Compiler Dx12ShaderCompiler;

        [NativeName("Type", "WGPUGles3MinorVersion")]
        [NativeName("Type.Name", "WGPUGles3MinorVersion")]
        [NativeName("Name", "gles3MinorVersion")]
        public Gles3MinorVersion Gles3MinorVersion;

        [NativeName("Type", "WGPUGLFenceBehaviour")]
        [NativeName("Type.Name", "WGPUGLFenceBehaviour")]
        [NativeName("Name", "glFenceBehaviour")]
        public GLFenceBehaviour GlFenceBehaviour;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "dxcPath")]
        public StringView DxcPath;

        [NativeName("Type", "WGPUDxcMaxShaderModel")]
        [NativeName("Type.Name", "WGPUDxcMaxShaderModel")]
        [NativeName("Name", "dxcMaxShaderModel")]
        public DxcMaxShaderModel DxcMaxShaderModel;

        [NativeName("Type", "WGPUDx12SwapchainKind")]
        [NativeName("Type.Name", "WGPUDx12SwapchainKind")]
        [NativeName("Name", "dx12PresentationSystem")]
        public Dx12SwapchainKind Dx12PresentationSystem;

        [NativeName("Type", "const uint8_t *")]
        [NativeName("Type.Name", "const uint8_t *")]
        [NativeName("Name", "budgetForDeviceCreation")]
        public byte* BudgetForDeviceCreation;

        [NativeName("Type", "const uint8_t *")]
        [NativeName("Type.Name", "const uint8_t *")]
        [NativeName("Name", "budgetForDeviceLoss")]
        public byte* BudgetForDeviceLoss;

        [NativeName("Type", "WGPUNativeDisplayHandle")]
        [NativeName("Type.Name", "WGPUNativeDisplayHandle")]
        [NativeName("Name", "displayHandle")]
        public NativeDisplayHandle DisplayHandle;
    }
}
