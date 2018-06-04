using Google.Protobuf;
using System;
using System.IO;

namespace My.Serializer.ProtoBuf
{
    public class Serializer : ISerializer
    {
        public object Serialize(object obj)
        {
            return (obj as IMessage)?.ToByteArray() ?? null;
        }
        public T Deserialize<T>(object obj)
        {
            if (obj is byte[] data)
            {
                var retObj = (IMessage)Activator.CreateInstance<T>();
                retObj.MergeFrom(data);
                return (T)retObj;
            }
            return default;
        }
    }
}