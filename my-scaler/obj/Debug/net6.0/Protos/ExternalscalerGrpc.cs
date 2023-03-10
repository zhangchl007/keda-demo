// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/externalscaler.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Externalscaler {
  public static partial class ExternalScaler
  {
    static readonly string __ServiceName = "externalscaler.ExternalScaler";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Externalscaler.ScaledObjectRef> __Marshaller_externalscaler_ScaledObjectRef = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Externalscaler.ScaledObjectRef.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Externalscaler.IsActiveResponse> __Marshaller_externalscaler_IsActiveResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Externalscaler.IsActiveResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Externalscaler.GetMetricSpecResponse> __Marshaller_externalscaler_GetMetricSpecResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Externalscaler.GetMetricSpecResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Externalscaler.GetMetricsRequest> __Marshaller_externalscaler_GetMetricsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Externalscaler.GetMetricsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Externalscaler.GetMetricsResponse> __Marshaller_externalscaler_GetMetricsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Externalscaler.GetMetricsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Externalscaler.ScaledObjectRef, global::Externalscaler.IsActiveResponse> __Method_IsActive = new grpc::Method<global::Externalscaler.ScaledObjectRef, global::Externalscaler.IsActiveResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsActive",
        __Marshaller_externalscaler_ScaledObjectRef,
        __Marshaller_externalscaler_IsActiveResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Externalscaler.ScaledObjectRef, global::Externalscaler.IsActiveResponse> __Method_StreamIsActive = new grpc::Method<global::Externalscaler.ScaledObjectRef, global::Externalscaler.IsActiveResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "StreamIsActive",
        __Marshaller_externalscaler_ScaledObjectRef,
        __Marshaller_externalscaler_IsActiveResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Externalscaler.ScaledObjectRef, global::Externalscaler.GetMetricSpecResponse> __Method_GetMetricSpec = new grpc::Method<global::Externalscaler.ScaledObjectRef, global::Externalscaler.GetMetricSpecResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMetricSpec",
        __Marshaller_externalscaler_ScaledObjectRef,
        __Marshaller_externalscaler_GetMetricSpecResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Externalscaler.GetMetricsRequest, global::Externalscaler.GetMetricsResponse> __Method_GetMetrics = new grpc::Method<global::Externalscaler.GetMetricsRequest, global::Externalscaler.GetMetricsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMetrics",
        __Marshaller_externalscaler_GetMetricsRequest,
        __Marshaller_externalscaler_GetMetricsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Externalscaler.ExternalscalerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ExternalScaler</summary>
    [grpc::BindServiceMethod(typeof(ExternalScaler), "BindService")]
    public abstract partial class ExternalScalerBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Externalscaler.IsActiveResponse> IsActive(global::Externalscaler.ScaledObjectRef request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task StreamIsActive(global::Externalscaler.ScaledObjectRef request, grpc::IServerStreamWriter<global::Externalscaler.IsActiveResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Externalscaler.GetMetricSpecResponse> GetMetricSpec(global::Externalscaler.ScaledObjectRef request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Externalscaler.GetMetricsResponse> GetMetrics(global::Externalscaler.GetMetricsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ExternalScalerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_IsActive, serviceImpl.IsActive)
          .AddMethod(__Method_StreamIsActive, serviceImpl.StreamIsActive)
          .AddMethod(__Method_GetMetricSpec, serviceImpl.GetMetricSpec)
          .AddMethod(__Method_GetMetrics, serviceImpl.GetMetrics).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ExternalScalerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_IsActive, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Externalscaler.ScaledObjectRef, global::Externalscaler.IsActiveResponse>(serviceImpl.IsActive));
      serviceBinder.AddMethod(__Method_StreamIsActive, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Externalscaler.ScaledObjectRef, global::Externalscaler.IsActiveResponse>(serviceImpl.StreamIsActive));
      serviceBinder.AddMethod(__Method_GetMetricSpec, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Externalscaler.ScaledObjectRef, global::Externalscaler.GetMetricSpecResponse>(serviceImpl.GetMetricSpec));
      serviceBinder.AddMethod(__Method_GetMetrics, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Externalscaler.GetMetricsRequest, global::Externalscaler.GetMetricsResponse>(serviceImpl.GetMetrics));
    }

  }
}
#endregion
