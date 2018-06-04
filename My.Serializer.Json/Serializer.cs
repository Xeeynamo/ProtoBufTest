using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace My.Serializer.Json
{
    public class Serializer : ISerializer
    {
        public object Serialize(object obj)
        {
            using (var stream = new MemoryStream())
            {
                new DataContractJsonSerializer(obj.GetType()).WriteObject(stream, obj);
                return Encoding.UTF8.GetString(stream.GetBuffer(), 0, (int)stream.Length);
            }
        }
        public T Deserialize<T>(object obj)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(obj.ToString())))
            {
                var retObj = new DataContractJsonSerializer(typeof(T)).ReadObject(stream);
                return (T)retObj;
            }
        }
    }
}