// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneFishInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from SceneFishInfo.proto</summary>
  public static partial class SceneFishInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneFishInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneFishInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNTY2VuZUZpc2hJbmZvLnByb3RvGgxWZWN0b3IucHJvdG8iegoNU2NlbmVG",
            "aXNoSW5mbxIPCgdmaXNoX2lkGAEgASgNEhsKE2Zpc2hfcG9vbF9lbnRpdHlf",
            "aWQYAiABKA0SHgoNZmlzaF9wb29sX3BvcxgDIAEoCzIHLlZlY3RvchIbChNm",
            "aXNoX3Bvb2xfZ2FkZ2V0X2lkGAQgASgNQhiqAhVMZW1vbmFkZS5OZXQuUHJv",
            "dG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.SceneFishInfo), global::Lemonade.Net.Protocol.SceneFishInfo.Parser, new[]{ "FishId", "FishPoolEntityId", "FishPoolPos", "FishPoolGadgetId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneFishInfo : pb::IMessage<SceneFishInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneFishInfo> _parser = new pb::MessageParser<SceneFishInfo>(() => new SceneFishInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneFishInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.SceneFishInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneFishInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneFishInfo(SceneFishInfo other) : this() {
      fishId_ = other.fishId_;
      fishPoolEntityId_ = other.fishPoolEntityId_;
      fishPoolPos_ = other.fishPoolPos_ != null ? other.fishPoolPos_.Clone() : null;
      fishPoolGadgetId_ = other.fishPoolGadgetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneFishInfo Clone() {
      return new SceneFishInfo(this);
    }

    /// <summary>Field number for the "fish_id" field.</summary>
    public const int FishIdFieldNumber = 1;
    private uint fishId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FishId {
      get { return fishId_; }
      set {
        fishId_ = value;
      }
    }

    /// <summary>Field number for the "fish_pool_entity_id" field.</summary>
    public const int FishPoolEntityIdFieldNumber = 2;
    private uint fishPoolEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FishPoolEntityId {
      get { return fishPoolEntityId_; }
      set {
        fishPoolEntityId_ = value;
      }
    }

    /// <summary>Field number for the "fish_pool_pos" field.</summary>
    public const int FishPoolPosFieldNumber = 3;
    private global::Lemonade.Net.Protocol.Vector fishPoolPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector FishPoolPos {
      get { return fishPoolPos_; }
      set {
        fishPoolPos_ = value;
      }
    }

    /// <summary>Field number for the "fish_pool_gadget_id" field.</summary>
    public const int FishPoolGadgetIdFieldNumber = 4;
    private uint fishPoolGadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FishPoolGadgetId {
      get { return fishPoolGadgetId_; }
      set {
        fishPoolGadgetId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneFishInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneFishInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FishId != other.FishId) return false;
      if (FishPoolEntityId != other.FishPoolEntityId) return false;
      if (!object.Equals(FishPoolPos, other.FishPoolPos)) return false;
      if (FishPoolGadgetId != other.FishPoolGadgetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FishId != 0) hash ^= FishId.GetHashCode();
      if (FishPoolEntityId != 0) hash ^= FishPoolEntityId.GetHashCode();
      if (fishPoolPos_ != null) hash ^= FishPoolPos.GetHashCode();
      if (FishPoolGadgetId != 0) hash ^= FishPoolGadgetId.GetHashCode();
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
      if (FishId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FishId);
      }
      if (FishPoolEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FishPoolEntityId);
      }
      if (fishPoolPos_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(FishPoolPos);
      }
      if (FishPoolGadgetId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FishPoolGadgetId);
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
      if (FishId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FishId);
      }
      if (FishPoolEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FishPoolEntityId);
      }
      if (fishPoolPos_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(FishPoolPos);
      }
      if (FishPoolGadgetId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FishPoolGadgetId);
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
      if (FishId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FishId);
      }
      if (FishPoolEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FishPoolEntityId);
      }
      if (fishPoolPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FishPoolPos);
      }
      if (FishPoolGadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FishPoolGadgetId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneFishInfo other) {
      if (other == null) {
        return;
      }
      if (other.FishId != 0) {
        FishId = other.FishId;
      }
      if (other.FishPoolEntityId != 0) {
        FishPoolEntityId = other.FishPoolEntityId;
      }
      if (other.fishPoolPos_ != null) {
        if (fishPoolPos_ == null) {
          FishPoolPos = new global::Lemonade.Net.Protocol.Vector();
        }
        FishPoolPos.MergeFrom(other.FishPoolPos);
      }
      if (other.FishPoolGadgetId != 0) {
        FishPoolGadgetId = other.FishPoolGadgetId;
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
            FishId = input.ReadUInt32();
            break;
          }
          case 16: {
            FishPoolEntityId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (fishPoolPos_ == null) {
              FishPoolPos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(FishPoolPos);
            break;
          }
          case 32: {
            FishPoolGadgetId = input.ReadUInt32();
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
            FishId = input.ReadUInt32();
            break;
          }
          case 16: {
            FishPoolEntityId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (fishPoolPos_ == null) {
              FishPoolPos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(FishPoolPos);
            break;
          }
          case 32: {
            FishPoolGadgetId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code