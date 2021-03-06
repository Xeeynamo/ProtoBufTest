// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Family.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace My.Models {

  /// <summary>Holder for reflection information generated from Family.proto</summary>
  public static partial class FamilyReflection {

    #region Descriptor
    /// <summary>File descriptor for Family.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FamilyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxGYW1pbHkucHJvdG8SCU15Lk1vZGVscxoKVXNlci5wcm90byJMCgZGYW1p",
            "bHkSHwoGcGFyZW50GAEgASgLMg8uTXkuTW9kZWxzLlVzZXISIQoIY2hpbGRy",
            "ZW4YAiADKAsyDy5NeS5Nb2RlbHMuVXNlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::My.Models.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::My.Models.Family), global::My.Models.Family.Parser, new[]{ "Parent", "Children" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Family : pb::IMessage<Family> {
    private static readonly pb::MessageParser<Family> _parser = new pb::MessageParser<Family>(() => new Family());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Family> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::My.Models.FamilyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Family() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Family(Family other) : this() {
      Parent = other.parent_ != null ? other.Parent.Clone() : null;
      children_ = other.children_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Family Clone() {
      return new Family(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private global::My.Models.User parent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::My.Models.User Parent {
      get { return parent_; }
      set {
        parent_ = value;
      }
    }

    /// <summary>Field number for the "children" field.</summary>
    public const int ChildrenFieldNumber = 2;
    private static readonly pb::FieldCodec<global::My.Models.User> _repeated_children_codec
        = pb::FieldCodec.ForMessage(18, global::My.Models.User.Parser);
    private readonly pbc::RepeatedField<global::My.Models.User> children_ = new pbc::RepeatedField<global::My.Models.User>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::My.Models.User> Children {
      get { return children_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Family);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Family other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Parent, other.Parent)) return false;
      if(!children_.Equals(other.children_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (parent_ != null) hash ^= Parent.GetHashCode();
      hash ^= children_.GetHashCode();
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
      if (parent_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Parent);
      }
      children_.WriteTo(output, _repeated_children_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (parent_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Parent);
      }
      size += children_.CalculateSize(_repeated_children_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Family other) {
      if (other == null) {
        return;
      }
      if (other.parent_ != null) {
        if (parent_ == null) {
          parent_ = new global::My.Models.User();
        }
        Parent.MergeFrom(other.Parent);
      }
      children_.Add(other.children_);
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
          case 10: {
            if (parent_ == null) {
              parent_ = new global::My.Models.User();
            }
            input.ReadMessage(parent_);
            break;
          }
          case 18: {
            children_.AddEntriesFrom(input, _repeated_children_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
