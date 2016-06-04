using Newtonsoft.Json;

namespace ExileConfigurator.IO
{
	public class Serializer<T>
	{
		public string serialize(T obj)
		{
			string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
			return json;
		}

		public T deserialize(string json)
		{
			T obj = JsonConvert.DeserializeObject<T>(json);
			return obj;
		}
	}
}
