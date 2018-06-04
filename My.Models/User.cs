// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: User.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace My.Models {

  /// <summary>Holder for reflection information generated from User.proto</summary>
  public static partial class UserReflection {

    #region Descriptor
    /// <summary>File descriptor for User.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpVc2VyLnByb3RvEglNeS5Nb2RlbHMaH2dvb2dsZS9wcm90b2J1Zi90aW1l",
            "c3RhbXAucHJvdG8aEEdlbmRlclR5cGUucHJvdG8aEVBob25lTnVtYmVyLnBy",
            "b3RvIqEBCgRVc2VyEgoKAmlkGAEgASgFEjAKDGNyZWF0ZWRfZGF0ZRgCIAEo",
            "CzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASDAoEbmFtZRgDIAEoCRIl",
            "CgZnZW5kZXIYBCABKA4yFS5NeS5Nb2RlbHMuR2VuZGVyVHlwZRImCgZwaG9u",
            "ZXMYBSADKAsyFi5NeS5Nb2RlbHMuUGhvbmVOdW1iZXJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::My.Models.GenderTypeReflection.Descriptor, global::My.Models.PhoneNumberReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::My.Models.User), global::My.Models.User.Parser, new[]{ "Id", "CreatedDate", "Name", "Gender", "Phones" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class User : pb::IMessage<User> {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::My.Models.UserReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User(User other) : this() {
      id_ = other.id_;
      CreatedDate = other.createdDate_ != null ? other.CreatedDate.Clone() : null;
      name_ = other.name_;
      gender_ = other.gender_;
      phones_ = other.phones_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "created_date" field.</summary>
    public const int CreatedDateFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedDate {
      get { return createdDate_; }
      set {
        createdDate_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "gender" field.</summary>
    public const int GenderFieldNumber = 4;
    private global::My.Models.GenderType gender_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::My.Models.GenderType Gender {
      get { return gender_; }
      set {
        gender_ = value;
      }
    }

    /// <summary>Field number for the "phones" field.</summary>
    public const int PhonesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::My.Models.PhoneNumber> _repeated_phones_codec
        = pb::FieldCodec.ForMessage(42, global::My.Models.PhoneNumber.Parser);
    private readonly pbc::RepeatedField<global::My.Models.PhoneNumber> phones_ = new pbc::RepeatedField<global::My.Models.PhoneNumber>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::My.Models.PhoneNumber> Phones {
      get { return phones_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(CreatedDate, other.CreatedDate)) return false;
      if (Name != other.Name) return false;
      if (Gender != other.Gender) return false;
      if(!phones_.Equals(other.phones_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (createdDate_ != null) hash ^= CreatedDate.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Gender != 0) hash ^= Gender.GetHashCode();
      hash ^= phones_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (createdDate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreatedDate);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Gender != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Gender);
      }
      phones_.WriteTo(output, _repeated_phones_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (createdDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedDate);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Gender != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Gender);
      }
      size += phones_.CalculateSize(_repeated_phones_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.createdDate_ != null) {
        if (createdDate_ == null) {
          createdDate_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedDate.MergeFrom(other.CreatedDate);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Gender != 0) {
        Gender = other.Gender;
      }
      phones_.Add(other.phones_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            if (createdDate_ == null) {
              createdDate_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(createdDate_);
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 32: {
            gender_ = (global::My.Models.GenderType) input.ReadEnum();
            break;
          }
          case 42: {
            phones_.AddEntriesFrom(input, _repeated_phones_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code