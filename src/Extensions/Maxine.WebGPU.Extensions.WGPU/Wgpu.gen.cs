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
using Maxine.WebGPU;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    [Extension("wgpu.h")]
    public unsafe partial class Wgpu : NativeExtension<WebGPU>
    {
        public const string ExtensionName = "wgpu.h";
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGenerateReport")]
        public unsafe partial void GenerateReport(Instance* instance, GlobalReport* report);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGenerateReport")]
        public unsafe partial void GenerateReport(Instance* instance, ref GlobalReport report);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 12 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceEnumerateAdapterOptions* options, Adapter** adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 12 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceEnumerateAdapterOptions* options, ref Adapter* adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 12 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InstanceEnumerateAdapterOptions options, Adapter** adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 12 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InstanceEnumerateAdapterOptions options, ref Adapter* adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 25 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(Queue* queue, nuint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 25 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(Queue* queue, nuint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 11 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueGetTimestampPeriod")]
        public unsafe partial float QueueGetTimestampPeriod(Queue* queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 14 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial Silk.NET.Core.Bool32 DevicePoll(Device* device, Silk.NET.Core.Bool32 wait, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* submissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 14 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial Silk.NET.Core.Bool32 DevicePoll(Device* device, Silk.NET.Core.Bool32 wait, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ulong submissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 22 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModuleSpirV")]
        public unsafe partial ShaderModule* DeviceCreateShaderModuleSpirV(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptorSpirV* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 22 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModuleSpirV")]
        public unsafe partial ShaderModule* DeviceCreateShaderModuleSpirV(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ShaderModuleDescriptorSpirV descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public unsafe partial void SetLogCallback(PfnLogCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public partial void SetLogCallback<T0>(PfnLogCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogLevel")]
        public partial void SetLogLevel(LogLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 14 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetVersion")]
        public partial uint GetVersion();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 11 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetNativeMetalDevice")]
        public unsafe partial void* DeviceGetNativeMetalDevice(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1514, Column 11 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueGetNativeMetalCommandQueue")]
        public unsafe partial void* QueueGetNativeMetalCommandQueue(Queue* queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 11 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetNativeMetalTexture")]
        public unsafe partial void* TextureGetNativeMetalTexture(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirect(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirect(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1529, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1531, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderBeginPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderEndPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1533, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderBeginPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1534, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderEndPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1537, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 14 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceStartGraphicsDebuggerCapture")]
        public unsafe partial Silk.NET.Core.Bool32 DeviceStartGraphicsDebuggerCapture(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceStopGraphicsDebuggerCapture")]
        public unsafe partial void DeviceStopGraphicsDebuggerCapture(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearTexture")]
        public unsafe partial void CommandEncoderClearTexture(CommandEncoder* commandEncoder, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresourceRange* range);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearTexture")]
        public unsafe partial void CommandEncoderClearTexture(CommandEncoder* commandEncoder, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageSubresourceRange range);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 22 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModuleTrusted")]
        public unsafe partial ShaderModule* DeviceCreateShaderModuleTrusted(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, ulong runtimeChecks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 22 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModuleTrusted")]
        public unsafe partial ShaderModule* DeviceCreateShaderModuleTrusted(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ShaderModuleDescriptor descriptor, ulong runtimeChecks);

        public Wgpu(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

