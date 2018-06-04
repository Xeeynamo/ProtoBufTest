namespace My.Serializer
{
    public interface ISerializer
    {
        object Serialize(object obj);

        T Deserialize<T>(object obj);
    }
}
