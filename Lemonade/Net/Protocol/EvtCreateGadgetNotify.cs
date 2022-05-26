// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtCreateGadgetNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from EvtCreateGadgetNotify.proto</summary>
  public static partial class EvtCreateGadgetNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtCreateGadgetNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtCreateGadgetNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtFdnRDcmVhdGVHYWRnZXROb3RpZnkucHJvdG8aEUZvcndhcmRUeXBlLnBy",
            "b3RvGgxWZWN0b3IucHJvdG8i8AMKFUV2dENyZWF0ZUdhZGdldE5vdGlmeRIi",
            "Cgxmb3J3YXJkX3R5cGUYASABKA4yDC5Gb3J3YXJkVHlwZRIRCgllbnRpdHlf",
            "aWQYAiABKA0SEQoJY29uZmlnX2lkGAMgASgNEg8KB2NhbXBfaWQYBCABKA0S",
            "EQoJY2FtcF90eXBlGAUgASgNEhkKCGluaXRfcG9zGAYgASgLMgcuVmVjdG9y",
            "EiIKEWluaXRfZXVsZXJfYW5nbGVzGAcgASgLMgcuVmVjdG9yEgwKBGd1aWQY",
            "CCABKAQSFwoPb3duZXJfZW50aXR5X2lkGAkgASgNEhgKEHRhcmdldF9lbnRp",
            "dHlfaWQYCiABKA0SFQoNaXNfYXN5bmNfbG9hZBgLIAEoCBIfChd0YXJnZXRf",
            "bG9ja19wb2ludF9pbmRleBgMIAEoDRIPCgdyb29tX2lkGA0gASgNEhwKFHBy",
            "b3Bfb3duZXJfZW50aXR5X2lkGA4gASgNEh4KFnNpZ2h0X2dyb3VwX3dpdGhf",
            "b3duZXIYDyABKAgiYgoFQ21kSWQSEwoPRU5FVF9DSEFOTkVMX0lEEAASCAoE",
            "Tk9ORRAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARITCg9JU19BTExPV19DTElF",
            "TlQQARILCgZDTURfSUQQkAMaAhABQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9j",
            "b2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.ForwardTypeReflection.Descriptor, global::Lemonade.Net.Protocol.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.EvtCreateGadgetNotify), global::Lemonade.Net.Protocol.EvtCreateGadgetNotify.Parser, new[]{ "ForwardType", "EntityId", "ConfigId", "CampId", "CampType", "InitPos", "InitEulerAngles", "Guid", "OwnerEntityId", "TargetEntityId", "IsAsyncLoad", "TargetLockPointIndex", "RoomId", "PropOwnerEntityId", "SightGroupWithOwner" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.EvtCreateGadgetNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtCreateGadgetNotify : pb::IMessage<EvtCreateGadgetNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtCreateGadgetNotify> _parser = new pb::MessageParser<EvtCreateGadgetNotify>(() => new EvtCreateGadgetNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtCreateGadgetNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.EvtCreateGadgetNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCreateGadgetNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCreateGadgetNotify(EvtCreateGadgetNotify other) : this() {
      forwardType_ = other.forwardType_;
      entityId_ = other.entityId_;
      configId_ = other.configId_;
      campId_ = other.campId_;
      campType_ = other.campType_;
      initPos_ = other.initPos_ != null ? other.initPos_.Clone() : null;
      initEulerAngles_ = other.initEulerAngles_ != null ? other.initEulerAngles_.Clone() : null;
      guid_ = other.guid_;
      ownerEntityId_ = other.ownerEntityId_;
      targetEntityId_ = other.targetEntityId_;
      isAsyncLoad_ = other.isAsyncLoad_;
      targetLockPointIndex_ = other.targetLockPointIndex_;
      roomId_ = other.roomId_;
      propOwnerEntityId_ = other.propOwnerEntityId_;
      sightGroupWithOwner_ = other.sightGroupWithOwner_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCreateGadgetNotify Clone() {
      return new EvtCreateGadgetNotify(this);
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 1;
    private global::Lemonade.Net.Protocol.ForwardType forwardType_ = global::Lemonade.Net.Protocol.ForwardType.ForwardLocal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 2;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 3;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "camp_id" field.</summary>
    public const int CampIdFieldNumber = 4;
    private uint campId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampId {
      get { return campId_; }
      set {
        campId_ = value;
      }
    }

    /// <summary>Field number for the "camp_type" field.</summary>
    public const int CampTypeFieldNumber = 5;
    private uint campType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampType {
      get { return campType_; }
      set {
        campType_ = value;
      }
    }

    /// <summary>Field number for the "init_pos" field.</summary>
    public const int InitPosFieldNumber = 6;
    private global::Lemonade.Net.Protocol.Vector initPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector InitPos {
      get { return initPos_; }
      set {
        initPos_ = value;
      }
    }

    /// <summary>Field number for the "init_euler_angles" field.</summary>
    public const int InitEulerAnglesFieldNumber = 7;
    private global::Lemonade.Net.Protocol.Vector initEulerAngles_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector InitEulerAngles {
      get { return initEulerAngles_; }
      set {
        initEulerAngles_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 8;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "owner_entity_id" field.</summary>
    public const int OwnerEntityIdFieldNumber = 9;
    private uint ownerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerEntityId {
      get { return ownerEntityId_; }
      set {
        ownerEntityId_ = value;
      }
    }

    /// <summary>Field number for the "target_entity_id" field.</summary>
    public const int TargetEntityIdFieldNumber = 10;
    private uint targetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetEntityId {
      get { return targetEntityId_; }
      set {
        targetEntityId_ = value;
      }
    }

    /// <summary>Field number for the "is_async_load" field.</summary>
    public const int IsAsyncLoadFieldNumber = 11;
    private bool isAsyncLoad_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAsyncLoad {
      get { return isAsyncLoad_; }
      set {
        isAsyncLoad_ = value;
      }
    }

    /// <summary>Field number for the "target_lock_point_index" field.</summary>
    public const int TargetLockPointIndexFieldNumber = 12;
    private uint targetLockPointIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetLockPointIndex {
      get { return targetLockPointIndex_; }
      set {
        targetLockPointIndex_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 13;
    private uint roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "prop_owner_entity_id" field.</summary>
    public const int PropOwnerEntityIdFieldNumber = 14;
    private uint propOwnerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropOwnerEntityId {
      get { return propOwnerEntityId_; }
      set {
        propOwnerEntityId_ = value;
      }
    }

    /// <summary>Field number for the "sight_group_with_owner" field.</summary>
    public const int SightGroupWithOwnerFieldNumber = 15;
    private bool sightGroupWithOwner_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SightGroupWithOwner {
      get { return sightGroupWithOwner_; }
      set {
        sightGroupWithOwner_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtCreateGadgetNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtCreateGadgetNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ForwardType != other.ForwardType) return false;
      if (EntityId != other.EntityId) return false;
      if (ConfigId != other.ConfigId) return false;
      if (CampId != other.CampId) return false;
      if (CampType != other.CampType) return false;
      if (!object.Equals(InitPos, other.InitPos)) return false;
      if (!object.Equals(InitEulerAngles, other.InitEulerAngles)) return false;
      if (Guid != other.Guid) return false;
      if (OwnerEntityId != other.OwnerEntityId) return false;
      if (TargetEntityId != other.TargetEntityId) return false;
      if (IsAsyncLoad != other.IsAsyncLoad) return false;
      if (TargetLockPointIndex != other.TargetLockPointIndex) return false;
      if (RoomId != other.RoomId) return false;
      if (PropOwnerEntityId != other.PropOwnerEntityId) return false;
      if (SightGroupWithOwner != other.SightGroupWithOwner) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) hash ^= ForwardType.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (CampId != 0) hash ^= CampId.GetHashCode();
      if (CampType != 0) hash ^= CampType.GetHashCode();
      if (initPos_ != null) hash ^= InitPos.GetHashCode();
      if (initEulerAngles_ != null) hash ^= InitEulerAngles.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (OwnerEntityId != 0) hash ^= OwnerEntityId.GetHashCode();
      if (TargetEntityId != 0) hash ^= TargetEntityId.GetHashCode();
      if (IsAsyncLoad != false) hash ^= IsAsyncLoad.GetHashCode();
      if (TargetLockPointIndex != 0) hash ^= TargetLockPointIndex.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (PropOwnerEntityId != 0) hash ^= PropOwnerEntityId.GetHashCode();
      if (SightGroupWithOwner != false) hash ^= SightGroupWithOwner.GetHashCode();
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
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ForwardType);
      }
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntityId);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ConfigId);
      }
      if (CampId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CampId);
      }
      if (CampType != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CampType);
      }
      if (initPos_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(InitPos);
      }
      if (initEulerAngles_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(InitEulerAngles);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(Guid);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OwnerEntityId);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TargetEntityId);
      }
      if (IsAsyncLoad != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsAsyncLoad);
      }
      if (TargetLockPointIndex != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TargetLockPointIndex);
      }
      if (RoomId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RoomId);
      }
      if (PropOwnerEntityId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PropOwnerEntityId);
      }
      if (SightGroupWithOwner != false) {
        output.WriteRawTag(120);
        output.WriteBool(SightGroupWithOwner);
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
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ForwardType);
      }
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntityId);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ConfigId);
      }
      if (CampId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CampId);
      }
      if (CampType != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CampType);
      }
      if (initPos_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(InitPos);
      }
      if (initEulerAngles_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(InitEulerAngles);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(Guid);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OwnerEntityId);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TargetEntityId);
      }
      if (IsAsyncLoad != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsAsyncLoad);
      }
      if (TargetLockPointIndex != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TargetLockPointIndex);
      }
      if (RoomId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RoomId);
      }
      if (PropOwnerEntityId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PropOwnerEntityId);
      }
      if (SightGroupWithOwner != false) {
        output.WriteRawTag(120);
        output.WriteBool(SightGroupWithOwner);
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
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (CampId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampId);
      }
      if (CampType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampType);
      }
      if (initPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InitPos);
      }
      if (initEulerAngles_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InitEulerAngles);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (OwnerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerEntityId);
      }
      if (TargetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetEntityId);
      }
      if (IsAsyncLoad != false) {
        size += 1 + 1;
      }
      if (TargetLockPointIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetLockPointIndex);
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
      }
      if (PropOwnerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropOwnerEntityId);
      }
      if (SightGroupWithOwner != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtCreateGadgetNotify other) {
      if (other == null) {
        return;
      }
      if (other.ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        ForwardType = other.ForwardType;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.CampId != 0) {
        CampId = other.CampId;
      }
      if (other.CampType != 0) {
        CampType = other.CampType;
      }
      if (other.initPos_ != null) {
        if (initPos_ == null) {
          InitPos = new global::Lemonade.Net.Protocol.Vector();
        }
        InitPos.MergeFrom(other.InitPos);
      }
      if (other.initEulerAngles_ != null) {
        if (initEulerAngles_ == null) {
          InitEulerAngles = new global::Lemonade.Net.Protocol.Vector();
        }
        InitEulerAngles.MergeFrom(other.InitEulerAngles);
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.OwnerEntityId != 0) {
        OwnerEntityId = other.OwnerEntityId;
      }
      if (other.TargetEntityId != 0) {
        TargetEntityId = other.TargetEntityId;
      }
      if (other.IsAsyncLoad != false) {
        IsAsyncLoad = other.IsAsyncLoad;
      }
      if (other.TargetLockPointIndex != 0) {
        TargetLockPointIndex = other.TargetLockPointIndex;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.PropOwnerEntityId != 0) {
        PropOwnerEntityId = other.PropOwnerEntityId;
      }
      if (other.SightGroupWithOwner != false) {
        SightGroupWithOwner = other.SightGroupWithOwner;
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
            ForwardType = (global::Lemonade.Net.Protocol.ForwardType) input.ReadEnum();
            break;
          }
          case 16: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 32: {
            CampId = input.ReadUInt32();
            break;
          }
          case 40: {
            CampType = input.ReadUInt32();
            break;
          }
          case 50: {
            if (initPos_ == null) {
              InitPos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(InitPos);
            break;
          }
          case 58: {
            if (initEulerAngles_ == null) {
              InitEulerAngles = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(InitEulerAngles);
            break;
          }
          case 64: {
            Guid = input.ReadUInt64();
            break;
          }
          case 72: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 80: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            IsAsyncLoad = input.ReadBool();
            break;
          }
          case 96: {
            TargetLockPointIndex = input.ReadUInt32();
            break;
          }
          case 104: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 112: {
            PropOwnerEntityId = input.ReadUInt32();
            break;
          }
          case 120: {
            SightGroupWithOwner = input.ReadBool();
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
            ForwardType = (global::Lemonade.Net.Protocol.ForwardType) input.ReadEnum();
            break;
          }
          case 16: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 32: {
            CampId = input.ReadUInt32();
            break;
          }
          case 40: {
            CampType = input.ReadUInt32();
            break;
          }
          case 50: {
            if (initPos_ == null) {
              InitPos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(InitPos);
            break;
          }
          case 58: {
            if (initEulerAngles_ == null) {
              InitEulerAngles = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(InitEulerAngles);
            break;
          }
          case 64: {
            Guid = input.ReadUInt64();
            break;
          }
          case 72: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 80: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            IsAsyncLoad = input.ReadBool();
            break;
          }
          case 96: {
            TargetLockPointIndex = input.ReadUInt32();
            break;
          }
          case 104: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 112: {
            PropOwnerEntityId = input.ReadUInt32();
            break;
          }
          case 120: {
            SightGroupWithOwner = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EvtCreateGadgetNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 400,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code