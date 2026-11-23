// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeFeature")]
    public enum NativeFeature : int
    {
        [NativeName("Name", "WGPUNativeFeature_Immediates")]
        Immediates = 0x30001,
        [NativeName("Name", "WGPUNativeFeature_TextureAdapterSpecificFormatFeatures")]
        TextureAdapterSpecificFormatFeatures = 0x30002,
        [NativeName("Name", "WGPUNativeFeature_MultiDrawIndirectCount")]
        MultiDrawIndirectCount = 0x30004,
        [NativeName("Name", "WGPUNativeFeature_VertexWritableStorage")]
        VertexWritableStorage = 0x30005,
        [NativeName("Name", "WGPUNativeFeature_TextureBindingArray")]
        TextureBindingArray = 0x30006,
        [NativeName("Name", "WGPUNativeFeature_SampledTextureAndStorageBufferArrayNonUniformIndexing")]
        SampledTextureAndStorageBufferArrayNonUniformIndexing = 0x30007,
        [NativeName("Name", "WGPUNativeFeature_PipelineStatisticsQuery")]
        PipelineStatisticsQuery = 0x30008,
        [NativeName("Name", "WGPUNativeFeature_StorageResourceBindingArray")]
        StorageResourceBindingArray = 0x30009,
        [NativeName("Name", "WGPUNativeFeature_PartiallyBoundBindingArray")]
        PartiallyBoundBindingArray = 0x3000A,
        [NativeName("Name", "WGPUNativeFeature_TextureFormat16bitNorm")]
        TextureFormat16bitNorm = 0x3000B,
        [NativeName("Name", "WGPUNativeFeature_TextureCompressionAstcHdr")]
        TextureCompressionAstcHdr = 0x3000C,
        [NativeName("Name", "WGPUNativeFeature_MappablePrimaryBuffers")]
        MappablePrimaryBuffers = 0x3000E,
        [NativeName("Name", "WGPUNativeFeature_BufferBindingArray")]
        BufferBindingArray = 0x3000F,
        [NativeName("Name", "WGPUNativeFeature_StorageTextureArrayNonUniformIndexing")]
        StorageTextureArrayNonUniformIndexing = 0x30010,
        [NativeName("Name", "WGPUNativeFeature_AddressModeClampToZero")]
        AddressModeClampToZero = 0x30011,
        [NativeName("Name", "WGPUNativeFeature_AddressModeClampToBorder")]
        AddressModeClampToBorder = 0x30012,
        [NativeName("Name", "WGPUNativeFeature_PolygonModeLine")]
        PolygonModeLine = 0x30013,
        [NativeName("Name", "WGPUNativeFeature_PolygonModePoint")]
        PolygonModePoint = 0x30014,
        [NativeName("Name", "WGPUNativeFeature_ConservativeRasterization")]
        ConservativeRasterization = 0x30015,
        [NativeName("Name", "WGPUNativeFeature_ClearTexture")]
        ClearTexture = 0x30016,
        [NativeName("Name", "WGPUNativeFeature_Multiview")]
        Multiview = 0x30018,
        [NativeName("Name", "WGPUNativeFeature_VertexAttribute64bit")]
        VertexAttribute64bit = 0x30019,
        [NativeName("Name", "WGPUNativeFeature_TextureFormatNv12")]
        TextureFormatNv12 = 0x3001A,
        [NativeName("Name", "WGPUNativeFeature_RayQuery")]
        RayQuery = 0x3001C,
        [NativeName("Name", "WGPUNativeFeature_ShaderF64")]
        ShaderF64 = 0x3001D,
        [NativeName("Name", "WGPUNativeFeature_ShaderI16")]
        ShaderI16 = 0x3001E,
        [NativeName("Name", "WGPUNativeFeature_ShaderEarlyDepthTest")]
        ShaderEarlyDepthTest = 0x30020,
        [NativeName("Name", "WGPUNativeFeature_Subgroup")]
        Subgroup = 0x30021,
        [NativeName("Name", "WGPUNativeFeature_SubgroupVertex")]
        SubgroupVertex = 0x30022,
        [NativeName("Name", "WGPUNativeFeature_SubgroupBarrier")]
        SubgroupBarrier = 0x30023,
        [NativeName("Name", "WGPUNativeFeature_TimestampQueryInsideEncoders")]
        TimestampQueryInsideEncoders = 0x30024,
        [NativeName("Name", "WGPUNativeFeature_TimestampQueryInsidePasses")]
        TimestampQueryInsidePasses = 0x30025,
        [NativeName("Name", "WGPUNativeFeature_ShaderInt64")]
        ShaderInt64 = 0x30026,
        [NativeName("Name", "WGPUNativeFeature_ShaderFloat32Atomic")]
        ShaderFloat32Atomic = 0x30027,
        [NativeName("Name", "WGPUNativeFeature_TextureAtomic")]
        TextureAtomic = 0x30028,
        [NativeName("Name", "WGPUNativeFeature_TextureFormatP010")]
        TextureFormatP010 = 0x30029,
        [NativeName("Name", "WGPUNativeFeature_PipelineCache")]
        PipelineCache = 0x3002B,
        [NativeName("Name", "WGPUNativeFeature_ShaderInt64AtomicMinMax")]
        ShaderInt64AtomicMinMax = 0x3002C,
        [NativeName("Name", "WGPUNativeFeature_ShaderInt64AtomicAllOps")]
        ShaderInt64AtomicAllOps = 0x3002D,
        [NativeName("Name", "WGPUNativeFeature_TextureInt64Atomic")]
        TextureInt64Atomic = 0x30030,
        [NativeName("Name", "WGPUNativeFeature_ShaderBarycentrics")]
        ShaderBarycentrics = 0x30037,
        [NativeName("Name", "WGPUNativeFeature_SelectiveMultiview")]
        SelectiveMultiview = 0x30038,
        [NativeName("Name", "WGPUNativeFeature_MultisampleArray")]
        MultisampleArray = 0x3003A,
        [NativeName("Name", "WGPUNativeFeature_CooperativeMatrix")]
        CooperativeMatrix = 0x3003B,
        [NativeName("Name", "WGPUNativeFeature_ShaderPerVertex")]
        ShaderPerVertex = 0x3003C,
        [NativeName("Name", "WGPUNativeFeature_ShaderDrawIndex")]
        ShaderDrawIndex = 0x3003D,
        [NativeName("Name", "WGPUNativeFeature_AccelerationStructureBindingArray")]
        AccelerationStructureBindingArray = 0x3003E,
        [NativeName("Name", "WGPUNativeFeature_MemoryDecorationCoherent")]
        MemoryDecorationCoherent = 0x3003F,
        [NativeName("Name", "WGPUNativeFeature_MemoryDecorationVolatile")]
        MemoryDecorationVolatile = 0x30040,
        [NativeName("Name", "WGPUNativeFeature_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
