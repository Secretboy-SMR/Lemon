// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EntityAiSyncNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from EntityAiSyncNotify.proto</summary>
  public static partial class EntityAiSyncNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EntityAiSyncNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityAiSyncNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhFbnRpdHlBaVN5bmNOb3RpZnkucHJvdG8aEEFpU3luY0luZm8ucHJvdG8i",
            "wwEKEkVudGl0eUFpU3luY05vdGlmeRIeCglpbmZvX2xpc3QYASADKAsyCy5B",
            "aVN5bmNJbmZvEikKIWxvY2FsX2F2YXRhcl9hbGVydGVkX21vbnN0ZXJfbGlz",
            "dBgCIAMoDSJiCgVDbWRJZBITCg9FTkVUX0NIQU5ORUxfSUQQABIICgROT05F",
            "EAASFAoQRU5FVF9JU19SRUxJQUJMRRABEhMKD0lTX0FMTE9XX0NMSUVOVBAB",
            "EgsKBkNNRF9JRBDgAhoCEAFCGKoCFUxlbW9uYWRlLk5ldC5Qcm90b2NvbGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.AiSyncInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.EntityAiSyncNotify), global::Lemonade.Net.Protocol.EntityAiSyncNotify.Parser, new[]{ "InfoList", "LocalAvatarAlertedMonsterList" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.EntityAiSyncNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EntityAiSyncNotify : pb::IMessage<EntityAiSyncNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityAiSyncNotify> _parser = new pb::MessageParser<EntityAiSyncNotify>(() => new EntityAiSyncNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityAiSyncNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.EntityAiSyncNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAiSyncNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAiSyncNotify(EntityAiSyncNotify other) : this() {
      infoList_ = other.infoList_.Clone();
      localAvatarAlertedMonsterList_ = other.localAvatarAlertedMonsterList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAiSyncNotify Clone() {
      return new EntityAiSyncNotify(this);
    }

    /// <summary>Field number for the "info_list" field.</summary>
    public const int InfoListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.AiSyncInfo> _repeated_infoList_codec
        = pb::FieldCodec.ForMessage(10, global::Lemonade.Net.Protocol.AiSyncInfo.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.AiSyncInfo> infoList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.AiSyncInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.AiSyncInfo> InfoList {
      get { return infoList_; }
    }

    /// <summary>Field number for the "local_avatar_alerted_monster_list" field.</summary>
    public const int LocalAvatarAlertedMonsterListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_localAvatarAlertedMonsterList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> localAvatarAlertedMonsterList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LocalAvatarAlertedMonsterList {
      get { return localAvatarAlertedMonsterList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityAiSyncNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityAiSyncNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!infoList_.Equals(other.infoList_)) return false;
      if(!localAvatarAlertedMonsterList_.Equals(other.localAvatarAlertedMonsterList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= infoList_.GetHashCode();
      hash ^= localAvatarAlertedMonsterList_.GetHashCode();
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
      infoList_.WriteTo(output, _repeated_infoList_codec);
      localAvatarAlertedMonsterList_.WriteTo(output, _repeated_localAvatarAlertedMonsterList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      infoList_.WriteTo(ref output, _repeated_infoList_codec);
      localAvatarAlertedMonsterList_.WriteTo(ref output, _repeated_localAvatarAlertedMonsterList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += infoList_.CalculateSize(_repeated_infoList_codec);
      size += localAvatarAlertedMonsterList_.CalculateSize(_repeated_localAvatarAlertedMonsterList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityAiSyncNotify other) {
      if (other == null) {
        return;
      }
      infoList_.Add(other.infoList_);
      localAvatarAlertedMonsterList_.Add(other.localAvatarAlertedMonsterList_);
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
            infoList_.AddEntriesFrom(input, _repeated_infoList_codec);
            break;
          }
          case 18:
          case 16: {
            localAvatarAlertedMonsterList_.AddEntriesFrom(input, _repeated_localAvatarAlertedMonsterList_codec);
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
            infoList_.AddEntriesFrom(ref input, _repeated_infoList_codec);
            break;
          }
          case 18:
          case 16: {
            localAvatarAlertedMonsterList_.AddEntriesFrom(ref input, _repeated_localAvatarAlertedMonsterList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EntityAiSyncNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 352,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code