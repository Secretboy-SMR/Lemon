// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerEnterSceneNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from PlayerEnterSceneNotify.proto</summary>
  public static partial class PlayerEnterSceneNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerEnterSceneNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerEnterSceneNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQbGF5ZXJFbnRlclNjZW5lTm90aWZ5LnByb3RvGgxWZWN0b3IucHJvdG8a",
            "D0VudGVyVHlwZS5wcm90byLlAwoWUGxheWVyRW50ZXJTY2VuZU5vdGlmeRIQ",
            "CghzY2VuZV9pZBgBIAEoDRIUCgNwb3MYAiABKAsyBy5WZWN0b3ISGAoQc2Nl",
            "bmVfYmVnaW5fdGltZRgDIAEoBBIYCgR0eXBlGAQgASgOMgouRW50ZXJUeXBl",
            "EhIKCnRhcmdldF91aWQYBiABKA0SFQoNcHJldl9zY2VuZV9pZBgJIAEoDRIZ",
            "CghwcmV2X3BvcxgKIAEoCzIHLlZlY3RvchISCgpkdW5nZW9uX2lkGAsgASgN",
            "EhMKC3dvcmxkX2xldmVsGAwgASgNEhkKEWVudGVyX3NjZW5lX3Rva2VuGA0g",
            "ASgNEiIKGmlzX2ZpcnN0X2xvZ2luX2VudGVyX3NjZW5lGA4gASgIEhkKEXNj",
            "ZW5lX3RhZ19pZF9saXN0GA8gAygNEhIKCmlzX3NraXBfdWkYECABKAgSFAoM",
            "ZW50ZXJfcmVhc29uGBEgASgNEhIKCndvcmxkX3R5cGUYEiABKA0SGQoRc2Nl",
            "bmVfdHJhbnNhY3Rpb24YEyABKAkiTQoFQ21kSWQSCAoETk9ORRAAEhMKD0VO",
            "RVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARILCgZDTURf",
            "SUQQ+QEaAhABQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.VectorReflection.Descriptor, global::Lemonade.Net.Protocol.EnterTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.PlayerEnterSceneNotify), global::Lemonade.Net.Protocol.PlayerEnterSceneNotify.Parser, new[]{ "SceneId", "Pos", "SceneBeginTime", "Type", "TargetUid", "PrevSceneId", "PrevPos", "DungeonId", "WorldLevel", "EnterSceneToken", "IsFirstLoginEnterScene", "SceneTagIdList", "IsSkipUi", "EnterReason", "WorldType", "SceneTransaction" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.PlayerEnterSceneNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerEnterSceneNotify : pb::IMessage<PlayerEnterSceneNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerEnterSceneNotify> _parser = new pb::MessageParser<PlayerEnterSceneNotify>(() => new PlayerEnterSceneNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerEnterSceneNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.PlayerEnterSceneNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneNotify(PlayerEnterSceneNotify other) : this() {
      sceneId_ = other.sceneId_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      sceneBeginTime_ = other.sceneBeginTime_;
      type_ = other.type_;
      targetUid_ = other.targetUid_;
      prevSceneId_ = other.prevSceneId_;
      prevPos_ = other.prevPos_ != null ? other.prevPos_.Clone() : null;
      dungeonId_ = other.dungeonId_;
      worldLevel_ = other.worldLevel_;
      enterSceneToken_ = other.enterSceneToken_;
      isFirstLoginEnterScene_ = other.isFirstLoginEnterScene_;
      sceneTagIdList_ = other.sceneTagIdList_.Clone();
      isSkipUi_ = other.isSkipUi_;
      enterReason_ = other.enterReason_;
      worldType_ = other.worldType_;
      sceneTransaction_ = other.sceneTransaction_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneNotify Clone() {
      return new PlayerEnterSceneNotify(this);
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 1;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 2;
    private global::Lemonade.Net.Protocol.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "scene_begin_time" field.</summary>
    public const int SceneBeginTimeFieldNumber = 3;
    private ulong sceneBeginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SceneBeginTime {
      get { return sceneBeginTime_; }
      set {
        sceneBeginTime_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::Lemonade.Net.Protocol.EnterType type_ = global::Lemonade.Net.Protocol.EnterType.EnterNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.EnterType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 6;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    /// <summary>Field number for the "prev_scene_id" field.</summary>
    public const int PrevSceneIdFieldNumber = 9;
    private uint prevSceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PrevSceneId {
      get { return prevSceneId_; }
      set {
        prevSceneId_ = value;
      }
    }

    /// <summary>Field number for the "prev_pos" field.</summary>
    public const int PrevPosFieldNumber = 10;
    private global::Lemonade.Net.Protocol.Vector prevPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector PrevPos {
      get { return prevPos_; }
      set {
        prevPos_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 11;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 12;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "enter_scene_token" field.</summary>
    public const int EnterSceneTokenFieldNumber = 13;
    private uint enterSceneToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterSceneToken {
      get { return enterSceneToken_; }
      set {
        enterSceneToken_ = value;
      }
    }

    /// <summary>Field number for the "is_first_login_enter_scene" field.</summary>
    public const int IsFirstLoginEnterSceneFieldNumber = 14;
    private bool isFirstLoginEnterScene_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstLoginEnterScene {
      get { return isFirstLoginEnterScene_; }
      set {
        isFirstLoginEnterScene_ = value;
      }
    }

    /// <summary>Field number for the "scene_tag_id_list" field.</summary>
    public const int SceneTagIdListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_sceneTagIdList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> sceneTagIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SceneTagIdList {
      get { return sceneTagIdList_; }
    }

    /// <summary>Field number for the "is_skip_ui" field.</summary>
    public const int IsSkipUiFieldNumber = 16;
    private bool isSkipUi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSkipUi {
      get { return isSkipUi_; }
      set {
        isSkipUi_ = value;
      }
    }

    /// <summary>Field number for the "enter_reason" field.</summary>
    public const int EnterReasonFieldNumber = 17;
    private uint enterReason_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterReason {
      get { return enterReason_; }
      set {
        enterReason_ = value;
      }
    }

    /// <summary>Field number for the "world_type" field.</summary>
    public const int WorldTypeFieldNumber = 18;
    private uint worldType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldType {
      get { return worldType_; }
      set {
        worldType_ = value;
      }
    }

    /// <summary>Field number for the "scene_transaction" field.</summary>
    public const int SceneTransactionFieldNumber = 19;
    private string sceneTransaction_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SceneTransaction {
      get { return sceneTransaction_; }
      set {
        sceneTransaction_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerEnterSceneNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerEnterSceneNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SceneId != other.SceneId) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (SceneBeginTime != other.SceneBeginTime) return false;
      if (Type != other.Type) return false;
      if (TargetUid != other.TargetUid) return false;
      if (PrevSceneId != other.PrevSceneId) return false;
      if (!object.Equals(PrevPos, other.PrevPos)) return false;
      if (DungeonId != other.DungeonId) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if (EnterSceneToken != other.EnterSceneToken) return false;
      if (IsFirstLoginEnterScene != other.IsFirstLoginEnterScene) return false;
      if(!sceneTagIdList_.Equals(other.sceneTagIdList_)) return false;
      if (IsSkipUi != other.IsSkipUi) return false;
      if (EnterReason != other.EnterReason) return false;
      if (WorldType != other.WorldType) return false;
      if (SceneTransaction != other.SceneTransaction) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (SceneBeginTime != 0UL) hash ^= SceneBeginTime.GetHashCode();
      if (Type != global::Lemonade.Net.Protocol.EnterType.EnterNone) hash ^= Type.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
      if (PrevSceneId != 0) hash ^= PrevSceneId.GetHashCode();
      if (prevPos_ != null) hash ^= PrevPos.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (EnterSceneToken != 0) hash ^= EnterSceneToken.GetHashCode();
      if (IsFirstLoginEnterScene != false) hash ^= IsFirstLoginEnterScene.GetHashCode();
      hash ^= sceneTagIdList_.GetHashCode();
      if (IsSkipUi != false) hash ^= IsSkipUi.GetHashCode();
      if (EnterReason != 0) hash ^= EnterReason.GetHashCode();
      if (WorldType != 0) hash ^= WorldType.GetHashCode();
      if (SceneTransaction.Length != 0) hash ^= SceneTransaction.GetHashCode();
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
      if (SceneId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SceneId);
      }
      if (pos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pos);
      }
      if (SceneBeginTime != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(SceneBeginTime);
      }
      if (Type != global::Lemonade.Net.Protocol.EnterType.EnterNone) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(TargetUid);
      }
      if (PrevSceneId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PrevSceneId);
      }
      if (prevPos_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PrevPos);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DungeonId);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(WorldLevel);
      }
      if (EnterSceneToken != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EnterSceneToken);
      }
      if (IsFirstLoginEnterScene != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFirstLoginEnterScene);
      }
      sceneTagIdList_.WriteTo(output, _repeated_sceneTagIdList_codec);
      if (IsSkipUi != false) {
        output.WriteRawTag(128, 1);
        output.WriteBool(IsSkipUi);
      }
      if (EnterReason != 0) {
        output.WriteRawTag(136, 1);
        output.WriteUInt32(EnterReason);
      }
      if (WorldType != 0) {
        output.WriteRawTag(144, 1);
        output.WriteUInt32(WorldType);
      }
      if (SceneTransaction.Length != 0) {
        output.WriteRawTag(154, 1);
        output.WriteString(SceneTransaction);
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
      if (SceneId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SceneId);
      }
      if (pos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pos);
      }
      if (SceneBeginTime != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(SceneBeginTime);
      }
      if (Type != global::Lemonade.Net.Protocol.EnterType.EnterNone) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(TargetUid);
      }
      if (PrevSceneId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PrevSceneId);
      }
      if (prevPos_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PrevPos);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DungeonId);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(WorldLevel);
      }
      if (EnterSceneToken != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EnterSceneToken);
      }
      if (IsFirstLoginEnterScene != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFirstLoginEnterScene);
      }
      sceneTagIdList_.WriteTo(ref output, _repeated_sceneTagIdList_codec);
      if (IsSkipUi != false) {
        output.WriteRawTag(128, 1);
        output.WriteBool(IsSkipUi);
      }
      if (EnterReason != 0) {
        output.WriteRawTag(136, 1);
        output.WriteUInt32(EnterReason);
      }
      if (WorldType != 0) {
        output.WriteRawTag(144, 1);
        output.WriteUInt32(WorldType);
      }
      if (SceneTransaction.Length != 0) {
        output.WriteRawTag(154, 1);
        output.WriteString(SceneTransaction);
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
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (SceneBeginTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SceneBeginTime);
      }
      if (Type != global::Lemonade.Net.Protocol.EnterType.EnterNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (PrevSceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PrevSceneId);
      }
      if (prevPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PrevPos);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (EnterSceneToken != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnterSceneToken);
      }
      if (IsFirstLoginEnterScene != false) {
        size += 1 + 1;
      }
      size += sceneTagIdList_.CalculateSize(_repeated_sceneTagIdList_codec);
      if (IsSkipUi != false) {
        size += 2 + 1;
      }
      if (EnterReason != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(EnterReason);
      }
      if (WorldType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(WorldType);
      }
      if (SceneTransaction.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(SceneTransaction);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerEnterSceneNotify other) {
      if (other == null) {
        return;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Lemonade.Net.Protocol.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.SceneBeginTime != 0UL) {
        SceneBeginTime = other.SceneBeginTime;
      }
      if (other.Type != global::Lemonade.Net.Protocol.EnterType.EnterNone) {
        Type = other.Type;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
      }
      if (other.PrevSceneId != 0) {
        PrevSceneId = other.PrevSceneId;
      }
      if (other.prevPos_ != null) {
        if (prevPos_ == null) {
          PrevPos = new global::Lemonade.Net.Protocol.Vector();
        }
        PrevPos.MergeFrom(other.PrevPos);
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.EnterSceneToken != 0) {
        EnterSceneToken = other.EnterSceneToken;
      }
      if (other.IsFirstLoginEnterScene != false) {
        IsFirstLoginEnterScene = other.IsFirstLoginEnterScene;
      }
      sceneTagIdList_.Add(other.sceneTagIdList_);
      if (other.IsSkipUi != false) {
        IsSkipUi = other.IsSkipUi;
      }
      if (other.EnterReason != 0) {
        EnterReason = other.EnterReason;
      }
      if (other.WorldType != 0) {
        WorldType = other.WorldType;
      }
      if (other.SceneTransaction.Length != 0) {
        SceneTransaction = other.SceneTransaction;
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
            SceneId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (pos_ == null) {
              Pos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 24: {
            SceneBeginTime = input.ReadUInt64();
            break;
          }
          case 32: {
            Type = (global::Lemonade.Net.Protocol.EnterType) input.ReadEnum();
            break;
          }
          case 48: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 72: {
            PrevSceneId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (prevPos_ == null) {
              PrevPos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(PrevPos);
            break;
          }
          case 88: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 96: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            EnterSceneToken = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFirstLoginEnterScene = input.ReadBool();
            break;
          }
          case 122:
          case 120: {
            sceneTagIdList_.AddEntriesFrom(input, _repeated_sceneTagIdList_codec);
            break;
          }
          case 128: {
            IsSkipUi = input.ReadBool();
            break;
          }
          case 136: {
            EnterReason = input.ReadUInt32();
            break;
          }
          case 144: {
            WorldType = input.ReadUInt32();
            break;
          }
          case 154: {
            SceneTransaction = input.ReadString();
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
            SceneId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (pos_ == null) {
              Pos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 24: {
            SceneBeginTime = input.ReadUInt64();
            break;
          }
          case 32: {
            Type = (global::Lemonade.Net.Protocol.EnterType) input.ReadEnum();
            break;
          }
          case 48: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 72: {
            PrevSceneId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (prevPos_ == null) {
              PrevPos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(PrevPos);
            break;
          }
          case 88: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 96: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            EnterSceneToken = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFirstLoginEnterScene = input.ReadBool();
            break;
          }
          case 122:
          case 120: {
            sceneTagIdList_.AddEntriesFrom(ref input, _repeated_sceneTagIdList_codec);
            break;
          }
          case 128: {
            IsSkipUi = input.ReadBool();
            break;
          }
          case 136: {
            EnterReason = input.ReadUInt32();
            break;
          }
          case 144: {
            WorldType = input.ReadUInt32();
            break;
          }
          case 154: {
            SceneTransaction = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerEnterSceneNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 249,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code