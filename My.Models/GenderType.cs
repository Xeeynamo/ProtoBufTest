// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GenderType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace My.Models {

  /// <summary>Holder for reflection information generated from GenderType.proto</summary>
  public static partial class GenderTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for GenderType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GenderTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBHZW5kZXJUeXBlLnByb3RvEglNeS5Nb2RlbHMqLQoKR2VuZGVyVHlwZRIJ",
            "CgVPVEhFUhAAEggKBE1BTEUQARIKCgZGRU1BTEUQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::My.Models.GenderType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum GenderType {
    [pbr::OriginalName("OTHER")] Other = 0,
    [pbr::OriginalName("MALE")] Male = 1,
    [pbr::OriginalName("FEMALE")] Female = 2,
  }

  #endregion

}

#endregion Designer generated code
