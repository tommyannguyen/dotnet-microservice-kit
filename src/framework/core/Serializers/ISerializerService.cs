using DotMK.Framework.Core.Services;

namespace DotMK.Framework.Core.Serializers;

public interface ISerializerService : ITransientService
{
    string Serialize<T>(T obj);

    string Serialize<T>(T obj, Type type);

    T Deserialize<T>(string text);
}
