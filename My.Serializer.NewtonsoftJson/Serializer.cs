namespace My.Serializer.NewtonsoftJson
{
    public class Serializer : ISerializer
    {
        public object Serialize(object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
        }
        public T Deserialize<T>(object obj)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(obj.ToString());
        }
    }
}