// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WeaponAwakenRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from WeaponAwakenRsp.proto</summary>
  public static partial class WeaponAwakenRspReflection {

    #region Descriptor
    /// <summary>File descriptor for WeaponAwakenRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeaponAwakenRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVXZWFwb25Bd2FrZW5Sc3AucHJvdG8iwgMKD1dlYXBvbkF3YWtlblJzcBIP",
            "CgdyZXRjb2RlGAEgASgFEhoKEnRhcmdldF93ZWFwb25fZ3VpZBgCIAEoBBIi",
            "Chp0YXJnZXRfd2VhcG9uX2F3YWtlbl9sZXZlbBgDIAEoDRJDChNvbGRfYWZm",
            "aXhfbGV2ZWxfbWFwGAQgAygLMiYuV2VhcG9uQXdha2VuUnNwLk9sZEFmZml4",
            "TGV2ZWxNYXBFbnRyeRJDChNjdXJfYWZmaXhfbGV2ZWxfbWFwGAUgAygLMiYu",
            "V2VhcG9uQXdha2VuUnNwLkN1ckFmZml4TGV2ZWxNYXBFbnRyeRITCgthdmF0",
            "YXJfZ3VpZBgGIAEoBBo3ChVPbGRBZmZpeExldmVsTWFwRW50cnkSCwoDa2V5",
            "GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4ARo3ChVDdXJBZmZpeExldmVsTWFw",
            "RW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4ASJNCgVDbWRJ",
            "ZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQRU5FVF9JU19S",
            "RUxJQUJMRRABEgsKBkNNRF9JRBC0BRoCEAFCGKoCFUxlbW9uYWRlLk5ldC5Q",
            "cm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.WeaponAwakenRsp), global::Lemonade.Net.Protocol.WeaponAwakenRsp.Parser, new[]{ "Retcode", "TargetWeaponGuid", "TargetWeaponAwakenLevel", "OldAffixLevelMap", "CurAffixLevelMap", "AvatarGuid" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.WeaponAwakenRsp.Types.CmdId) }, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WeaponAwakenRsp : pb::IMessage<WeaponAwakenRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WeaponAwakenRsp> _parser = new pb::MessageParser<WeaponAwakenRsp>(() => new WeaponAwakenRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WeaponAwakenRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.WeaponAwakenRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponAwakenRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponAwakenRsp(WeaponAwakenRsp other) : this() {
      retcode_ = other.retcode_;
      targetWeaponGuid_ = other.targetWeaponGuid_;
      targetWeaponAwakenLevel_ = other.targetWeaponAwakenLevel_;
      oldAffixLevelMap_ = other.oldAffixLevelMap_.Clone();
      curAffixLevelMap_ = other.curAffixLevelMap_.Clone();
      avatarGuid_ = other.avatarGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponAwakenRsp Clone() {
      return new WeaponAwakenRsp(this);
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

    /// <summary>Field number for the "target_weapon_guid" field.</summary>
    public const int TargetWeaponGuidFieldNumber = 2;
    private ulong targetWeaponGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetWeaponGuid {
      get { return targetWeaponGuid_; }
      set {
        targetWeaponGuid_ = value;
      }
    }

    /// <summary>Field number for the "target_weapon_awaken_level" field.</summary>
    public const int TargetWeaponAwakenLevelFieldNumber = 3;
    private uint targetWeaponAwakenLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetWeaponAwakenLevel {
      get { return targetWeaponAwakenLevel_; }
      set {
        targetWeaponAwakenLevel_ = value;
      }
    }

    /// <summary>Field number for the "old_affix_level_map" field.</summary>
    public const int OldAffixLevelMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, uint>.Codec _map_oldAffixLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 34);
    private readonly pbc::MapField<uint, uint> oldAffixLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> OldAffixLevelMap {
      get { return oldAffixLevelMap_; }
    }

    /// <summary>Field number for the "cur_affix_level_map" field.</summary>
    public const int CurAffixLevelMapFieldNumber = 5;
    private static readonly pbc::MapField<uint, uint>.Codec _map_curAffixLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 42);
    private readonly pbc::MapField<uint, uint> curAffixLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> CurAffixLevelMap {
      get { return curAffixLevelMap_; }
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 6;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WeaponAwakenRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WeaponAwakenRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (TargetWeaponGuid != other.TargetWeaponGuid) return false;
      if (TargetWeaponAwakenLevel != other.TargetWeaponAwakenLevel) return false;
      if (!OldAffixLevelMap.Equals(other.OldAffixLevelMap)) return false;
      if (!CurAffixLevelMap.Equals(other.CurAffixLevelMap)) return false;
      if (AvatarGuid != other.AvatarGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (TargetWeaponGuid != 0UL) hash ^= TargetWeaponGuid.GetHashCode();
      if (TargetWeaponAwakenLevel != 0) hash ^= TargetWeaponAwakenLevel.GetHashCode();
      hash ^= OldAffixLevelMap.GetHashCode();
      hash ^= CurAffixLevelMap.GetHashCode();
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
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
      if (TargetWeaponGuid != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TargetWeaponGuid);
      }
      if (TargetWeaponAwakenLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetWeaponAwakenLevel);
      }
      oldAffixLevelMap_.WriteTo(output, _map_oldAffixLevelMap_codec);
      curAffixLevelMap_.WriteTo(output, _map_curAffixLevelMap_codec);
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(AvatarGuid);
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
      if (TargetWeaponGuid != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TargetWeaponGuid);
      }
      if (TargetWeaponAwakenLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetWeaponAwakenLevel);
      }
      oldAffixLevelMap_.WriteTo(ref output, _map_oldAffixLevelMap_codec);
      curAffixLevelMap_.WriteTo(ref output, _map_curAffixLevelMap_codec);
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(AvatarGuid);
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
      if (TargetWeaponGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetWeaponGuid);
      }
      if (TargetWeaponAwakenLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetWeaponAwakenLevel);
      }
      size += oldAffixLevelMap_.CalculateSize(_map_oldAffixLevelMap_codec);
      size += curAffixLevelMap_.CalculateSize(_map_curAffixLevelMap_codec);
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WeaponAwakenRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.TargetWeaponGuid != 0UL) {
        TargetWeaponGuid = other.TargetWeaponGuid;
      }
      if (other.TargetWeaponAwakenLevel != 0) {
        TargetWeaponAwakenLevel = other.TargetWeaponAwakenLevel;
      }
      oldAffixLevelMap_.Add(other.oldAffixLevelMap_);
      curAffixLevelMap_.Add(other.curAffixLevelMap_);
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
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
            TargetWeaponGuid = input.ReadUInt64();
            break;
          }
          case 24: {
            TargetWeaponAwakenLevel = input.ReadUInt32();
            break;
          }
          case 34: {
            oldAffixLevelMap_.AddEntriesFrom(input, _map_oldAffixLevelMap_codec);
            break;
          }
          case 42: {
            curAffixLevelMap_.AddEntriesFrom(input, _map_curAffixLevelMap_codec);
            break;
          }
          case 48: {
            AvatarGuid = input.ReadUInt64();
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
            TargetWeaponGuid = input.ReadUInt64();
            break;
          }
          case 24: {
            TargetWeaponAwakenLevel = input.ReadUInt32();
            break;
          }
          case 34: {
            oldAffixLevelMap_.AddEntriesFrom(ref input, _map_oldAffixLevelMap_codec);
            break;
          }
          case 42: {
            curAffixLevelMap_.AddEntriesFrom(ref input, _map_curAffixLevelMap_codec);
            break;
          }
          case 48: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the WeaponAwakenRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 692,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code