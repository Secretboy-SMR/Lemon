// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GadgetInteractReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from GadgetInteractReq.proto</summary>
  public static partial class GadgetInteractReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GadgetInteractReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GadgetInteractReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHYWRnZXRJbnRlcmFjdFJlcS5wcm90bxoRSW50ZXJPcFR5cGUucHJvdG8a",
            "E1Jlc2luQ29zdFR5cGUucHJvdG8iiwIKEUdhZGdldEludGVyYWN0UmVxEhgK",
            "EGdhZGdldF9lbnRpdHlfaWQYASABKA0SHQoHb3BfdHlwZRgCIAEoDjIMLklu",
            "dGVyT3BUeXBlEhEKCWdhZGdldF9pZBgDIAEoDRIdChVpc191c2VfY29uZGVu",
            "c2VfcmVzaW4YBCABKAgSJwoPcmVzaW5fY29zdF90eXBlGAUgASgOMg4uUmVz",
            "aW5Db3N0VHlwZSJiCgVDbWRJZBITCg9FTkVUX0NIQU5ORUxfSUQQABIICgRO",
            "T05FEAASFAoQRU5FVF9JU19SRUxJQUJMRRABEhMKD0lTX0FMTE9XX0NMSUVO",
            "VBABEgsKBkNNRF9JRBDRBhoCEAFCGKoCFUxlbW9uYWRlLk5ldC5Qcm90b2Nv",
            "bGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.InterOpTypeReflection.Descriptor, global::Lemonade.Net.Protocol.ResinCostTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.GadgetInteractReq), global::Lemonade.Net.Protocol.GadgetInteractReq.Parser, new[]{ "GadgetEntityId", "OpType", "GadgetId", "IsUseCondenseResin", "ResinCostType" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.GadgetInteractReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GadgetInteractReq : pb::IMessage<GadgetInteractReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GadgetInteractReq> _parser = new pb::MessageParser<GadgetInteractReq>(() => new GadgetInteractReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GadgetInteractReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.GadgetInteractReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetInteractReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetInteractReq(GadgetInteractReq other) : this() {
      gadgetEntityId_ = other.gadgetEntityId_;
      opType_ = other.opType_;
      gadgetId_ = other.gadgetId_;
      isUseCondenseResin_ = other.isUseCondenseResin_;
      resinCostType_ = other.resinCostType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetInteractReq Clone() {
      return new GadgetInteractReq(this);
    }

    /// <summary>Field number for the "gadget_entity_id" field.</summary>
    public const int GadgetEntityIdFieldNumber = 1;
    private uint gadgetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetEntityId {
      get { return gadgetEntityId_; }
      set {
        gadgetEntityId_ = value;
      }
    }

    /// <summary>Field number for the "op_type" field.</summary>
    public const int OpTypeFieldNumber = 2;
    private global::Lemonade.Net.Protocol.InterOpType opType_ = global::Lemonade.Net.Protocol.InterOpType.InterOpFinish;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.InterOpType OpType {
      get { return opType_; }
      set {
        opType_ = value;
      }
    }

    /// <summary>Field number for the "gadget_id" field.</summary>
    public const int GadgetIdFieldNumber = 3;
    private uint gadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetId {
      get { return gadgetId_; }
      set {
        gadgetId_ = value;
      }
    }

    /// <summary>Field number for the "is_use_condense_resin" field.</summary>
    public const int IsUseCondenseResinFieldNumber = 4;
    private bool isUseCondenseResin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUseCondenseResin {
      get { return isUseCondenseResin_; }
      set {
        isUseCondenseResin_ = value;
      }
    }

    /// <summary>Field number for the "resin_cost_type" field.</summary>
    public const int ResinCostTypeFieldNumber = 5;
    private global::Lemonade.Net.Protocol.ResinCostType resinCostType_ = global::Lemonade.Net.Protocol.ResinCostType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.ResinCostType ResinCostType {
      get { return resinCostType_; }
      set {
        resinCostType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GadgetInteractReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GadgetInteractReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GadgetEntityId != other.GadgetEntityId) return false;
      if (OpType != other.OpType) return false;
      if (GadgetId != other.GadgetId) return false;
      if (IsUseCondenseResin != other.IsUseCondenseResin) return false;
      if (ResinCostType != other.ResinCostType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
      if (OpType != global::Lemonade.Net.Protocol.InterOpType.InterOpFinish) hash ^= OpType.GetHashCode();
      if (GadgetId != 0) hash ^= GadgetId.GetHashCode();
      if (IsUseCondenseResin != false) hash ^= IsUseCondenseResin.GetHashCode();
      if (ResinCostType != global::Lemonade.Net.Protocol.ResinCostType.None) hash ^= ResinCostType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (GadgetEntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GadgetEntityId);
      }
      if (OpType != global::Lemonade.Net.Protocol.InterOpType.InterOpFinish) {
        output.WriteRawTag(16);
        output.WriteEnum((int) OpType);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GadgetId);
      }
      if (IsUseCondenseResin != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsUseCondenseResin);
      }
      if (ResinCostType != global::Lemonade.Net.Protocol.ResinCostType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ResinCostType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GadgetEntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GadgetEntityId);
      }
      if (OpType != global::Lemonade.Net.Protocol.InterOpType.InterOpFinish) {
        output.WriteRawTag(16);
        output.WriteEnum((int) OpType);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GadgetId);
      }
      if (IsUseCondenseResin != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsUseCondenseResin);
      }
      if (ResinCostType != global::Lemonade.Net.Protocol.ResinCostType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ResinCostType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GadgetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
      }
      if (OpType != global::Lemonade.Net.Protocol.InterOpType.InterOpFinish) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
      }
      if (GadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetId);
      }
      if (IsUseCondenseResin != false) {
        size += 1 + 1;
      }
      if (ResinCostType != global::Lemonade.Net.Protocol.ResinCostType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResinCostType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GadgetInteractReq other) {
      if (other == null) {
        return;
      }
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
      }
      if (other.OpType != global::Lemonade.Net.Protocol.InterOpType.InterOpFinish) {
        OpType = other.OpType;
      }
      if (other.GadgetId != 0) {
        GadgetId = other.GadgetId;
      }
      if (other.IsUseCondenseResin != false) {
        IsUseCondenseResin = other.IsUseCondenseResin;
      }
      if (other.ResinCostType != global::Lemonade.Net.Protocol.ResinCostType.None) {
        ResinCostType = other.ResinCostType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            OpType = (global::Lemonade.Net.Protocol.InterOpType) input.ReadEnum();
            break;
          }
          case 24: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 32: {
            IsUseCondenseResin = input.ReadBool();
            break;
          }
          case 40: {
            ResinCostType = (global::Lemonade.Net.Protocol.ResinCostType) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            OpType = (global::Lemonade.Net.Protocol.InterOpType) input.ReadEnum();
            break;
          }
          case 24: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 32: {
            IsUseCondenseResin = input.ReadBool();
            break;
          }
          case 40: {
            ResinCostType = (global::Lemonade.Net.Protocol.ResinCostType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the GadgetInteractReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 849,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code