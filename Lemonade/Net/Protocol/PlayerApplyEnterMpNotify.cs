// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerApplyEnterMpNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from PlayerApplyEnterMpNotify.proto</summary>
  public static partial class PlayerApplyEnterMpNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerApplyEnterMpNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerApplyEnterMpNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5QbGF5ZXJBcHBseUVudGVyTXBOb3RpZnkucHJvdG8aFk9ubGluZVBsYXll",
            "ckluZm8ucHJvdG8iwwEKGFBsYXllckFwcGx5RW50ZXJNcE5vdGlmeRIqCg9z",
            "cmNfcGxheWVyX2luZm8YASABKAsyES5PbmxpbmVQbGF5ZXJJbmZvEhIKCnNy",
            "Y19hcHBfaWQYAiABKA0SGAoQc3JjX3RocmVhZF9pbmRleBgDIAEoDSJNCgVD",
            "bWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQRU5FVF9J",
            "U19SRUxJQUJMRRABEgsKBkNNRF9JRBCLDhoCEAFCGKoCFUxlbW9uYWRlLk5l",
            "dC5Qcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.OnlinePlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.PlayerApplyEnterMpNotify), global::Lemonade.Net.Protocol.PlayerApplyEnterMpNotify.Parser, new[]{ "SrcPlayerInfo", "SrcAppId", "SrcThreadIndex" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.PlayerApplyEnterMpNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerApplyEnterMpNotify : pb::IMessage<PlayerApplyEnterMpNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerApplyEnterMpNotify> _parser = new pb::MessageParser<PlayerApplyEnterMpNotify>(() => new PlayerApplyEnterMpNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerApplyEnterMpNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.PlayerApplyEnterMpNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterMpNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterMpNotify(PlayerApplyEnterMpNotify other) : this() {
      srcPlayerInfo_ = other.srcPlayerInfo_ != null ? other.srcPlayerInfo_.Clone() : null;
      srcAppId_ = other.srcAppId_;
      srcThreadIndex_ = other.srcThreadIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterMpNotify Clone() {
      return new PlayerApplyEnterMpNotify(this);
    }

    /// <summary>Field number for the "src_player_info" field.</summary>
    public const int SrcPlayerInfoFieldNumber = 1;
    private global::Lemonade.Net.Protocol.OnlinePlayerInfo srcPlayerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.OnlinePlayerInfo SrcPlayerInfo {
      get { return srcPlayerInfo_; }
      set {
        srcPlayerInfo_ = value;
      }
    }

    /// <summary>Field number for the "src_app_id" field.</summary>
    public const int SrcAppIdFieldNumber = 2;
    private uint srcAppId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SrcAppId {
      get { return srcAppId_; }
      set {
        srcAppId_ = value;
      }
    }

    /// <summary>Field number for the "src_thread_index" field.</summary>
    public const int SrcThreadIndexFieldNumber = 3;
    private uint srcThreadIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SrcThreadIndex {
      get { return srcThreadIndex_; }
      set {
        srcThreadIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerApplyEnterMpNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerApplyEnterMpNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SrcPlayerInfo, other.SrcPlayerInfo)) return false;
      if (SrcAppId != other.SrcAppId) return false;
      if (SrcThreadIndex != other.SrcThreadIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (srcPlayerInfo_ != null) hash ^= SrcPlayerInfo.GetHashCode();
      if (SrcAppId != 0) hash ^= SrcAppId.GetHashCode();
      if (SrcThreadIndex != 0) hash ^= SrcThreadIndex.GetHashCode();
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
      if (srcPlayerInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SrcPlayerInfo);
      }
      if (SrcAppId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SrcAppId);
      }
      if (SrcThreadIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SrcThreadIndex);
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
      if (srcPlayerInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SrcPlayerInfo);
      }
      if (SrcAppId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SrcAppId);
      }
      if (SrcThreadIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SrcThreadIndex);
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
      if (srcPlayerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SrcPlayerInfo);
      }
      if (SrcAppId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SrcAppId);
      }
      if (SrcThreadIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SrcThreadIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerApplyEnterMpNotify other) {
      if (other == null) {
        return;
      }
      if (other.srcPlayerInfo_ != null) {
        if (srcPlayerInfo_ == null) {
          SrcPlayerInfo = new global::Lemonade.Net.Protocol.OnlinePlayerInfo();
        }
        SrcPlayerInfo.MergeFrom(other.SrcPlayerInfo);
      }
      if (other.SrcAppId != 0) {
        SrcAppId = other.SrcAppId;
      }
      if (other.SrcThreadIndex != 0) {
        SrcThreadIndex = other.SrcThreadIndex;
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
          case 10: {
            if (srcPlayerInfo_ == null) {
              SrcPlayerInfo = new global::Lemonade.Net.Protocol.OnlinePlayerInfo();
            }
            input.ReadMessage(SrcPlayerInfo);
            break;
          }
          case 16: {
            SrcAppId = input.ReadUInt32();
            break;
          }
          case 24: {
            SrcThreadIndex = input.ReadUInt32();
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
          case 10: {
            if (srcPlayerInfo_ == null) {
              SrcPlayerInfo = new global::Lemonade.Net.Protocol.OnlinePlayerInfo();
            }
            input.ReadMessage(SrcPlayerInfo);
            break;
          }
          case 16: {
            SrcAppId = input.ReadUInt32();
            break;
          }
          case 24: {
            SrcThreadIndex = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerApplyEnterMpNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1803,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code