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

namespace Maxine.WebGPU
{
    public unsafe partial class WebGPU : NativeAPI
    {
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_None")]
        public const ulong BufferUsageNone = unchecked((ulong) 0x0);
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_MapRead")]
        public const ulong BufferUsageMapRead = unchecked((ulong) 0x1);
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_MapWrite")]
        public const ulong BufferUsageMapWrite = unchecked((ulong) 0x2);
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_CopySrc")]
        public const ulong BufferUsageCopySrc = unchecked((ulong) 0x4);
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_CopyDst")]
        public const ulong BufferUsageCopyDst = unchecked((ulong) 0x8);
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_Index")]
        public const ulong BufferUsageIndex = unchecked((ulong) 0x10);
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_Vertex")]
        public const ulong BufferUsageVertex = unchecked((ulong) 0x20);
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_Uniform")]
        public const ulong BufferUsageUniform = unchecked((ulong) 0x40);
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_Storage")]
        public const ulong BufferUsageStorage = unchecked((ulong) 0x80);
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_Indirect")]
        public const ulong BufferUsageIndirect = unchecked((ulong) 0x100);
        [NativeName("Type", "const WGPUBufferUsage")]
        [NativeName("Name", "WGPUBufferUsage_QueryResolve")]
        public const ulong BufferUsageQueryResolve = unchecked((ulong) 0x200);
        [NativeName("Type", "const WGPUColorWriteMask")]
        [NativeName("Name", "WGPUColorWriteMask_None")]
        public const ulong ColorWriteMaskNone = unchecked((ulong) 0x0);
        [NativeName("Type", "const WGPUColorWriteMask")]
        [NativeName("Name", "WGPUColorWriteMask_Red")]
        public const ulong ColorWriteMaskRed = unchecked((ulong) 0x1);
        [NativeName("Type", "const WGPUColorWriteMask")]
        [NativeName("Name", "WGPUColorWriteMask_Green")]
        public const ulong ColorWriteMaskGreen = unchecked((ulong) 0x2);
        [NativeName("Type", "const WGPUColorWriteMask")]
        [NativeName("Name", "WGPUColorWriteMask_Blue")]
        public const ulong ColorWriteMaskBlue = unchecked((ulong) 0x4);
        [NativeName("Type", "const WGPUColorWriteMask")]
        [NativeName("Name", "WGPUColorWriteMask_Alpha")]
        public const ulong ColorWriteMaskAlpha = unchecked((ulong) 0x8);
        [NativeName("Type", "const WGPUColorWriteMask")]
        [NativeName("Name", "WGPUColorWriteMask_All")]
        public const ulong ColorWriteMaskAll = unchecked((ulong) 0xF);
        [NativeName("Type", "const WGPUMapMode")]
        [NativeName("Name", "WGPUMapMode_None")]
        public const ulong MapModeNone = unchecked((ulong) 0x0);
        [NativeName("Type", "const WGPUMapMode")]
        [NativeName("Name", "WGPUMapMode_Read")]
        public const ulong MapModeRead = unchecked((ulong) 0x1);
        [NativeName("Type", "const WGPUMapMode")]
        [NativeName("Name", "WGPUMapMode_Write")]
        public const ulong MapModeWrite = unchecked((ulong) 0x2);
        [NativeName("Type", "const WGPUShaderStage")]
        [NativeName("Name", "WGPUShaderStage_None")]
        public const ulong ShaderStageNone = unchecked((ulong) 0x0);
        [NativeName("Type", "const WGPUShaderStage")]
        [NativeName("Name", "WGPUShaderStage_Vertex")]
        public const ulong ShaderStageVertex = unchecked((ulong) 0x1);
        [NativeName("Type", "const WGPUShaderStage")]
        [NativeName("Name", "WGPUShaderStage_Fragment")]
        public const ulong ShaderStageFragment = unchecked((ulong) 0x2);
        [NativeName("Type", "const WGPUShaderStage")]
        [NativeName("Name", "WGPUShaderStage_Compute")]
        public const ulong ShaderStageCompute = unchecked((ulong) 0x4);
        [NativeName("Type", "const WGPUTextureUsage")]
        [NativeName("Name", "WGPUTextureUsage_None")]
        public const ulong TextureUsageNone = unchecked((ulong) 0x0);
        [NativeName("Type", "const WGPUTextureUsage")]
        [NativeName("Name", "WGPUTextureUsage_CopySrc")]
        public const ulong TextureUsageCopySrc = unchecked((ulong) 0x1);
        [NativeName("Type", "const WGPUTextureUsage")]
        [NativeName("Name", "WGPUTextureUsage_CopyDst")]
        public const ulong TextureUsageCopyDst = unchecked((ulong) 0x2);
        [NativeName("Type", "const WGPUTextureUsage")]
        [NativeName("Name", "WGPUTextureUsage_TextureBinding")]
        public const ulong TextureUsageTextureBinding = unchecked((ulong) 0x4);
        [NativeName("Type", "const WGPUTextureUsage")]
        [NativeName("Name", "WGPUTextureUsage_StorageBinding")]
        public const ulong TextureUsageStorageBinding = unchecked((ulong) 0x8);
        [NativeName("Type", "const WGPUTextureUsage")]
        [NativeName("Name", "WGPUTextureUsage_RenderAttachment")]
        public const ulong TextureUsageRenderAttachment = unchecked((ulong) 0x10);
        [NativeName("Type", "const WGPUTextureUsage")]
        [NativeName("Name", "WGPUTextureUsage_TransientAttachment")]
        public const ulong TextureUsageTransientAttachment = unchecked((ulong) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "WGPU_TRUE")]
        public const uint True = unchecked((uint) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "WGPU_FALSE")]
        public const uint False = unchecked((uint) 0x0);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "WGPU_ARRAY_LAYER_COUNT_UNDEFINED")]
        public const uint ArrayLayerCountUndefined = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "WGPU_COPY_STRIDE_UNDEFINED")]
        public const uint CopyStrideUndefined = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "WGPU_DEPTH_SLICE_UNDEFINED")]
        public const uint DepthSliceUndefined = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "WGPU_LIMIT_U32_UNDEFINED")]
        public const uint LimitU32Undefined = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "WGPU_LIMIT_U64_UNDEFINED")]
        public const ulong LimitU64Undefined = unchecked((ulong) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "WGPU_MIP_LEVEL_COUNT_UNDEFINED")]
        public const uint MipLevelCountUndefined = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "WGPU_QUERY_SET_INDEX_UNDEFINED")]
        public const uint QuerySetIndexUndefined = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "WGPU_STRLEN")]
        public const ulong Strlen = unchecked((ulong) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "WGPU_WHOLE_MAP_SIZE")]
        public const ulong WholeMapSize = unchecked((ulong) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "WGPU_WHOLE_SIZE")]
        public const ulong WholeSize = unchecked((ulong) 0xFFFFFFFFFFFFFFFF);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5959, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCreateInstance")]
        public unsafe partial Instance* CreateInstance([Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5959, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCreateInstance")]
        public unsafe partial Instance* CreateInstance([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InstanceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5966, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetInstanceFeatures")]
        public unsafe partial void GetInstanceFeatures(SupportedInstanceFeatures* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5966, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetInstanceFeatures")]
        public partial void GetInstanceFeatures(ref SupportedInstanceFeatures features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5973, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetInstanceLimits")]
        public unsafe partial Status GetInstanceLimits(InstanceLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5973, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetInstanceLimits")]
        public partial Status GetInstanceLimits(ref InstanceLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5977, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuHasInstanceFeature")]
        public partial Silk.NET.Core.Bool32 HasInstanceFeature(InstanceFeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5982, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public partial PfnProc GetProcAddress(StringView procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6005, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetFeatures")]
        public unsafe partial void AdapterGetFeatures(Adapter* adapter, SupportedFeatures* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6005, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetFeatures")]
        public unsafe partial void AdapterGetFeatures(Adapter* adapter, ref SupportedFeatures features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6013, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetInfo")]
        public unsafe partial Status AdapterGetInfo(Adapter* adapter, AdapterInfo* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6013, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetInfo")]
        public unsafe partial Status AdapterGetInfo(Adapter* adapter, ref AdapterInfo info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6018, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial Status AdapterGetLimits(Adapter* adapter, Limits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6018, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial Status AdapterGetLimits(Adapter* adapter, ref Limits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6019, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterHasFeature")]
        public unsafe partial Silk.NET.Core.Bool32 AdapterHasFeature(Adapter* adapter, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6020, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial Future AdapterRequestDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, RequestDeviceCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6020, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial Future AdapterRequestDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceDescriptor descriptor, RequestDeviceCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6021, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterAddRef")]
        public unsafe partial void AdapterAddRef(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6022, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRelease")]
        public unsafe partial void AdapterRelease(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6035, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterInfoFreeMembers")]
        public partial void AdapterInfoFreeMembers(AdapterInfo adapterInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6045, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6046, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupAddRef")]
        public unsafe partial void BindGroupAddRef(BindGroup* bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6047, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupRelease")]
        public unsafe partial void BindGroupRelease(BindGroup* bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6057, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6058, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutAddRef")]
        public unsafe partial void BindGroupLayoutAddRef(BindGroupLayout* bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6059, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutRelease")]
        public unsafe partial void BindGroupLayoutRelease(BindGroupLayout* bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6069, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDestroy")]
        public unsafe partial void BufferDestroy(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6087, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetConstMappedRange")]
        public unsafe partial void* BufferGetConstMappedRange(Buffer* buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6104, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetMappedRange")]
        public unsafe partial void* BufferGetMappedRange(Buffer* buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6105, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetMapState")]
        public unsafe partial BufferMapState BufferGetMapState(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6106, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetSize")]
        public unsafe partial ulong BufferGetSize(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6107, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetUsage")]
        public unsafe partial Maxine.WebGPU.BufferUsage BufferGetUsage(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6119, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial Future BufferMapAsync(Buffer* buffer, Maxine.WebGPU.MapMode mode, nuint offset, nuint size, BufferMapCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6140, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferReadMappedRange")]
        public unsafe partial Status BufferReadMappedRange(Buffer* buffer, nuint offset, void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6140, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferReadMappedRange")]
        public unsafe partial Status BufferReadMappedRange<T0>(Buffer* buffer, nuint offset, ref T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6141, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6142, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferUnmap")]
        public unsafe partial void BufferUnmap(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6163, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferWriteMappedRange")]
        public unsafe partial Status BufferWriteMappedRange(Buffer* buffer, nuint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6163, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferWriteMappedRange")]
        public unsafe partial Status BufferWriteMappedRange<T0>(Buffer* buffer, nuint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6164, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferAddRef")]
        public unsafe partial void BufferAddRef(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6165, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferRelease")]
        public unsafe partial void BufferRelease(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6175, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6176, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferAddRef")]
        public unsafe partial void CommandBufferAddRef(CommandBuffer* commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6177, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferRelease")]
        public unsafe partial void CommandBufferRelease(CommandBuffer* commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6191, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6191, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6196, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6196, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderPassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6197, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6198, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoder* commandEncoder, Buffer* source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6199, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6199, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6199, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6199, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6199, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6199, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6199, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6199, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6200, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6200, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6200, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6200, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6200, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6200, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6200, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6200, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6201, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6201, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6201, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6201, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6201, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6201, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6201, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6201, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6206, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6206, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandBufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6207, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, StringView markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6208, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPopDebugGroup")]
        public unsafe partial void CommandEncoderPopDebugGroup(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6209, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, StringView groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6210, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoder* commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6211, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6212, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(CommandEncoder* commandEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6213, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderAddRef")]
        public unsafe partial void CommandEncoderAddRef(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6214, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderRelease")]
        public unsafe partial void CommandEncoderRelease(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6224, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroups")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroups(ComputePassEncoder* computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6225, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ComputePassEncoder* computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6226, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEnd")]
        public unsafe partial void ComputePassEncoderEnd(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6227, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, StringView markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6228, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPopDebugGroup")]
        public unsafe partial void ComputePassEncoderPopDebugGroup(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6229, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, StringView groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6230, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, nuint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6230, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, nuint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6231, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetImmediates")]
        public unsafe partial void ComputePassEncoderSetImmediates(ComputePassEncoder* computePassEncoder, uint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6231, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetImmediates")]
        public unsafe partial void ComputePassEncoderSetImmediates<T0>(ComputePassEncoder* computePassEncoder, uint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6232, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6233, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ComputePassEncoder* computePassEncoder, ComputePipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6234, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderAddRef")]
        public unsafe partial void ComputePassEncoderAddRef(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6235, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderRelease")]
        public unsafe partial void ComputePassEncoderRelease(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6249, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* ComputePipelineGetBindGroupLayout(ComputePipeline* computePipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6250, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6251, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineAddRef")]
        public unsafe partial void ComputePipelineAddRef(ComputePipeline* computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6252, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineRelease")]
        public unsafe partial void ComputePipelineRelease(ComputePipeline* computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6266, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BindGroupDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6266, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BindGroupDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6271, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BindGroupLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6271, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BindGroupLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6281, Column 38 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6281, Column 38 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6286, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6286, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6291, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6291, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6292, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial Future DeviceCreateComputePipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, CreateComputePipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6292, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial Future DeviceCreateComputePipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineDescriptor descriptor, CreateComputePipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6297, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6297, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PipelineLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6302, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QuerySetDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6302, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly QuerySetDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6307, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderBundleEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6307, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderBundleEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6312, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6312, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderPipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6313, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial Future DeviceCreateRenderPipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, CreateRenderPipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6313, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial Future DeviceCreateRenderPipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderPipelineDescriptor descriptor, CreateRenderPipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6318, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6318, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SamplerDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6323, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6323, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ShaderModuleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6328, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6328, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6329, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDestroy")]
        public unsafe partial void DeviceDestroy(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6337, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetAdapterInfo")]
        public unsafe partial Status DeviceGetAdapterInfo(Device* device, AdapterInfo* adapterInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6337, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetAdapterInfo")]
        public unsafe partial Status DeviceGetAdapterInfo(Device* device, ref AdapterInfo adapterInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6344, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetFeatures")]
        public unsafe partial void DeviceGetFeatures(Device* device, SupportedFeatures* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6344, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetFeatures")]
        public unsafe partial void DeviceGetFeatures(Device* device, ref SupportedFeatures features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6349, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial Status DeviceGetLimits(Device* device, Limits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6349, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial Status DeviceGetLimits(Device* device, ref Limits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6354, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLostFuture")]
        public unsafe partial Future DeviceGetLostFuture(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6359, Column 23 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetQueue")]
        public unsafe partial Queue* DeviceGetQueue(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6360, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceHasFeature")]
        public unsafe partial Silk.NET.Core.Bool32 DeviceHasFeature(Device* device, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6365, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial Future DevicePopErrorScope(Device* device, PopErrorScopeCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6370, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePushErrorScope")]
        public unsafe partial void DevicePushErrorScope(Device* device, ErrorFilter filter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6371, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6372, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceAddRef")]
        public unsafe partial void DeviceAddRef(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6373, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceRelease")]
        public unsafe partial void DeviceRelease(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6383, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6384, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureAddRef")]
        public unsafe partial void ExternalTextureAddRef(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6385, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRelease")]
        public unsafe partial void ExternalTextureRelease(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6405, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6405, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SurfaceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6409, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceGetWGSLLanguageFeatures")]
        public unsafe partial void InstanceGetWGSLLanguageFeatures(Instance* instance, SupportedWGSLLanguageFeatures* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6409, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceGetWGSLLanguageFeatures")]
        public unsafe partial void InstanceGetWGSLLanguageFeatures(Instance* instance, ref SupportedWGSLLanguageFeatures features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6410, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceHasWGSLLanguageFeature")]
        public unsafe partial Silk.NET.Core.Bool32 InstanceHasWGSLLanguageFeature(Instance* instance, WGSLLanguageFeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceProcessEvents")]
        public unsafe partial void InstanceProcessEvents(Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6417, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial Future InstanceRequestAdapter(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, RequestAdapterCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6417, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial Future InstanceRequestAdapter(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RequestAdapterOptions options, RequestAdapterCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6423, Column 28 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceWaitAny")]
        public unsafe partial WaitStatus InstanceWaitAny(Instance* instance, nuint futureCount, FutureWaitInfo* futures, ulong timeoutNS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6423, Column 28 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceWaitAny")]
        public unsafe partial WaitStatus InstanceWaitAny(Instance* instance, nuint futureCount, ref FutureWaitInfo futures, ulong timeoutNS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6424, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceAddRef")]
        public unsafe partial void InstanceAddRef(Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6425, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRelease")]
        public unsafe partial void InstanceRelease(Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6435, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6436, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutAddRef")]
        public unsafe partial void PipelineLayoutAddRef(PipelineLayout* pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6437, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutRelease")]
        public unsafe partial void PipelineLayoutRelease(PipelineLayout* pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDestroy")]
        public unsafe partial void QuerySetDestroy(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6448, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetCount")]
        public unsafe partial uint QuerySetGetCount(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6449, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetType")]
        public unsafe partial QueryType QuerySetGetType(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6450, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6451, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetAddRef")]
        public unsafe partial void QuerySetAddRef(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6452, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetRelease")]
        public unsafe partial void QuerySetRelease(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6462, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial Future QueueOnSubmittedWorkDone(Queue* queue, QueueWorkDoneCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6463, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6464, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(Queue* queue, nuint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6464, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(Queue* queue, nuint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6469, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(Queue* queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6469, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(Queue* queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyTextureInfo destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TexelCopyBufferLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6471, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueAddRef")]
        public unsafe partial void QueueAddRef(Queue* queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6472, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueRelease")]
        public unsafe partial void QueueRelease(Queue* queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6482, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleSetLabel")]
        public unsafe partial void RenderBundleSetLabel(RenderBundle* renderBundle, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6483, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleAddRef")]
        public unsafe partial void RenderBundleAddRef(RenderBundle* renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6484, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleRelease")]
        public unsafe partial void RenderBundleRelease(RenderBundle* renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6494, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDraw")]
        public unsafe partial void RenderBundleEncoderDraw(RenderBundleEncoder* renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6495, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexed")]
        public unsafe partial void RenderBundleEncoderDrawIndexed(RenderBundleEncoder* renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6496, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(RenderBundleEncoder* renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(RenderBundleEncoder* renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6502, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderBundleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6502, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderBundleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6503, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, StringView markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6504, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPopDebugGroup")]
        public unsafe partial void RenderBundleEncoderPopDebugGroup(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6505, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, StringView groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, nuint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, nuint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6507, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetImmediates")]
        public unsafe partial void RenderBundleEncoderSetImmediates(RenderBundleEncoder* renderBundleEncoder, uint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6507, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetImmediates")]
        public unsafe partial void RenderBundleEncoderSetImmediates<T0>(RenderBundleEncoder* renderBundleEncoder, uint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6508, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(RenderBundleEncoder* renderBundleEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6509, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(RenderBundleEncoder* renderBundleEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6511, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(RenderBundleEncoder* renderBundleEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderAddRef")]
        public unsafe partial void RenderBundleEncoderAddRef(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderRelease")]
        public unsafe partial void RenderBundleEncoderRelease(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginOcclusionQuery")]
        public unsafe partial void RenderPassEncoderBeginOcclusionQuery(RenderPassEncoder* renderPassEncoder, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDraw")]
        public unsafe partial void RenderPassEncoderDraw(RenderPassEncoder* renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexed")]
        public unsafe partial void RenderPassEncoderDrawIndexed(RenderPassEncoder* renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(RenderPassEncoder* renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(RenderPassEncoder* renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEnd")]
        public unsafe partial void RenderPassEncoderEnd(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6529, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndOcclusionQuery")]
        public unsafe partial void RenderPassEncoderEndOcclusionQuery(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6530, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(RenderPassEncoder* renderPassEncoder, nuint bundleCount, RenderBundle** bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6530, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(RenderPassEncoder* renderPassEncoder, nuint bundleCount, ref RenderBundle* bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6531, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, StringView markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6532, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPopDebugGroup")]
        public unsafe partial void RenderPassEncoderPopDebugGroup(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6533, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, StringView groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6534, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, nuint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6534, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, nuint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6539, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6539, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Color color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetImmediates")]
        public unsafe partial void RenderPassEncoderSetImmediates(RenderPassEncoder* renderPassEncoder, uint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetImmediates")]
        public unsafe partial void RenderPassEncoderSetImmediates<T0>(RenderPassEncoder* renderPassEncoder, uint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(RenderPassEncoder* renderPassEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6542, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(RenderPassEncoder* renderPassEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetScissorRect")]
        public unsafe partial void RenderPassEncoderSetScissorRect(RenderPassEncoder* renderPassEncoder, uint x, uint y, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6545, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetStencilReference")]
        public unsafe partial void RenderPassEncoderSetStencilReference(RenderPassEncoder* renderPassEncoder, uint reference);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6546, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(RenderPassEncoder* renderPassEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6552, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetViewport")]
        public unsafe partial void RenderPassEncoderSetViewport(RenderPassEncoder* renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6553, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderAddRef")]
        public unsafe partial void RenderPassEncoderAddRef(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6554, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderRelease")]
        public unsafe partial void RenderPassEncoderRelease(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6568, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* RenderPipelineGetBindGroupLayout(RenderPipeline* renderPipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6569, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6570, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineAddRef")]
        public unsafe partial void RenderPipelineAddRef(RenderPipeline* renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6571, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineRelease")]
        public unsafe partial void RenderPipelineRelease(RenderPipeline* renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6581, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6582, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerAddRef")]
        public unsafe partial void SamplerAddRef(Sampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerRelease")]
        public unsafe partial void SamplerRelease(Sampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6593, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial Future ShaderModuleGetCompilationInfo(ShaderModule* shaderModule, CompilationInfoCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6594, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6595, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleAddRef")]
        public unsafe partial void ShaderModuleAddRef(ShaderModule* shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6596, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleRelease")]
        public unsafe partial void ShaderModuleRelease(ShaderModule* shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6609, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSupportedFeaturesFreeMembers")]
        public partial void SupportedFeaturesFreeMembers(SupportedFeatures supportedFeatures);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6622, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSupportedInstanceFeaturesFreeMembers")]
        public partial void SupportedInstanceFeaturesFreeMembers(SupportedInstanceFeatures supportedInstanceFeatures);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6635, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSupportedWGSLLanguageFeaturesFreeMembers")]
        public partial void SupportedWGSLLanguageFeaturesFreeMembers(SupportedWGSLLanguageFeatures supportedWGSLLanguageFeatures);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6654, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceConfigure")]
        public unsafe partial void SurfaceConfigure(Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceConfiguration* config);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6654, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceConfigure")]
        public unsafe partial void SurfaceConfigure(Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SurfaceConfiguration config);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6670, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetCapabilities")]
        public unsafe partial Status SurfaceGetCapabilities(Surface* surface, Adapter* adapter, SurfaceCapabilities* capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6670, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetCapabilities")]
        public unsafe partial Status SurfaceGetCapabilities(Surface* surface, Adapter* adapter, ref SurfaceCapabilities capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6680, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetCurrentTexture")]
        public unsafe partial void SurfaceGetCurrentTexture(Surface* surface, SurfaceTexture* surfaceTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6680, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetCurrentTexture")]
        public unsafe partial void SurfaceGetCurrentTexture(Surface* surface, ref SurfaceTexture surfaceTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6688, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfacePresent")]
        public unsafe partial Status SurfacePresent(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6695, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceSetLabel")]
        public unsafe partial void SurfaceSetLabel(Surface* surface, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6700, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceUnconfigure")]
        public unsafe partial void SurfaceUnconfigure(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6701, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceAddRef")]
        public unsafe partial void SurfaceAddRef(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6702, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceRelease")]
        public unsafe partial void SurfaceRelease(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6715, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceCapabilitiesFreeMembers")]
        public partial void SurfaceCapabilitiesFreeMembers(SurfaceCapabilities surfaceCapabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6729, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureViewDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6729, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureViewDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6730, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDestroy")]
        public unsafe partial void TextureDestroy(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6731, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDepthOrArrayLayers")]
        public unsafe partial uint TextureGetDepthOrArrayLayers(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6732, Column 34 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDimension")]
        public unsafe partial TextureDimension TextureGetDimension(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6733, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetFormat")]
        public unsafe partial TextureFormat TextureGetFormat(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6734, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetHeight")]
        public unsafe partial uint TextureGetHeight(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6735, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetMipLevelCount")]
        public unsafe partial uint TextureGetMipLevelCount(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6736, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetSampleCount")]
        public unsafe partial uint TextureGetSampleCount(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6737, Column 38 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetTextureBindingViewDimension")]
        public unsafe partial TextureViewDimension TextureGetTextureBindingViewDimension(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6738, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetUsage")]
        public unsafe partial Maxine.WebGPU.TextureUsage TextureGetUsage(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6739, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetWidth")]
        public unsafe partial uint TextureGetWidth(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6740, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6741, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureAddRef")]
        public unsafe partial void TextureAddRef(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6742, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureRelease")]
        public unsafe partial void TextureRelease(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6752, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, StringView label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6753, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewAddRef")]
        public unsafe partial void TextureViewAddRef(TextureView* textureView);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6754, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewRelease")]
        public unsafe partial void TextureViewRelease(TextureView* textureView);


        public WebGPU(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

