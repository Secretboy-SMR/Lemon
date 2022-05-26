// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetUpAvatarTeamRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from SetUpAvatarTeamRsp.proto</summary>
  public static partial class SetUpAvatarTeamRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SetUpAvatarTeamRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetUpAvatarTeamRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhTZXRVcEF2YXRhclRlYW1Sc3AucHJvdG8ivQEKElNldFVwQXZhdGFyVGVh",
            "bVJzcBIPCgdyZXRjb2RlGAEgASgFEg8KB3RlYW1faWQYAiABKA0SHQoVYXZh",
            "dGFyX3RlYW1fZ3VpZF9saXN0GAMgAygEEhcKD2N1cl9hdmF0YXJfZ3VpZBgE",
            "IAEoBCJNCgVDbWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVMX0lEEAAS",
            "FAoQRU5FVF9JU19SRUxJQUJMRRABEgsKBkNNRF9JRBDQDRoCEAFCGKoCFUxl",
            "bW9uYWRlLk5ldC5Qcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.SetUpAvatarTeamRsp), global::Lemonade.Net.Protocol.SetUpAvatarTeamRsp.Parser, new[]{ "Retcode", "TeamId", "AvatarTeamGuidList", "CurAvatarGuid" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.SetUpAvatarTeamRsp.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetUpAvatarTeamRsp : pb::IMessage<SetUpAvatarTeamRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetUpAvatarTeamRsp> _parser = new pb::MessageParser<SetUpAvatarTeamRsp>(() => new SetUpAvatarTeamRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetUpAvatarTeamRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.SetUpAvatarTeamRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetUpAvatarTeamRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetUpAvatarTeamRsp(SetUpAvatarTeamRsp other) : this() {
      retcode_ = other.retcode_;
      teamId_ = other.teamId_;
      avatarTeamGuidList_ = other.avatarTeamGuidList_.Clone();
      curAvatarGuid_ = other.curAvatarGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetUpAvatarTeamRsp Clone() {
      return new SetUpAvatarTeamRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "team_id" field.</summary>
    public const int TeamIdFieldNumber = 2;
    private uint teamId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TeamId {
      get { return teamId_; }
      set {
        teamId_ = value;
      }
    }

    /// <summary>Field number for the "avatar_team_guid_list" field.</summary>
    public const int AvatarTeamGuidListFieldNumber = 3;
    private static readonly pb::FieldCodec<ulong> _repeated_avatarTeamGuidList_codec
        = pb::FieldCodec.ForUInt64(26);
    private readonly pbc::RepeatedField<ulong> avatarTeamGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> AvatarTeamGuidList {
      get { return avatarTeamGuidList_; }
    }

    /// <summary>Field number for the "cur_avatar_guid" field.</summary>
    public const int CurAvatarGuidFieldNumber = 4;
    private ulong curAvatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CurAvatarGuid {
      get { return curAvatarGuid_; }
      set {
        curAvatarGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetUpAvatarTeamRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetUpAvatarTeamRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (TeamId != other.TeamId) return false;
      if(!avatarTeamGuidList_.Equals(other.avatarTeamGuidList_)) return false;
      if (CurAvatarGuid != other.CurAvatarGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (TeamId != 0) hash ^= TeamId.GetHashCode();
      hash ^= avatarTeamGuidList_.GetHashCode();
      if (CurAvatarGuid != 0UL) hash ^= CurAvatarGuid.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (TeamId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TeamId);
      }
      avatarTeamGuidList_.WriteTo(output, _repeated_avatarTeamGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(CurAvatarGuid);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (TeamId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TeamId);
      }
      avatarTeamGuidList_.WriteTo(ref output, _repeated_avatarTeamGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(CurAvatarGuid);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (TeamId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TeamId);
      }
      size += avatarTeamGuidList_.CalculateSize(_repeated_avatarTeamGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CurAvatarGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetUpAvatarTeamRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.TeamId != 0) {
        TeamId = other.TeamId;
      }
      avatarTeamGuidList_.Add(other.avatarTeamGuidList_);
      if (other.CurAvatarGuid != 0UL) {
        CurAvatarGuid = other.CurAvatarGuid;
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
            Retcode = input.ReadInt32();
            break;
          }
          case 16: {
            TeamId = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            avatarTeamGuidList_.AddEntriesFrom(input, _repeated_avatarTeamGuidList_codec);
            break;
          }
          case 32: {
            CurAvatarGuid = input.ReadUInt64();
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
            Retcode = input.ReadInt32();
            break;
          }
          case 16: {
            TeamId = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            avatarTeamGuidList_.AddEntriesFrom(ref input, _repeated_avatarTeamGuidList_codec);
            break;
          }
          case 32: {
            CurAvatarGuid = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SetUpAvatarTeamRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1744,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code