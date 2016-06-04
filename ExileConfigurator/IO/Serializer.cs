using Newtonsoft.Json;
using System;
using System.Text;

namespace ExileConfigurator.IO
{
	public class Serializer<T>
	{
		public string toJson(T obj)
		{
			string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
			return json;
		}

		public T fromJson(string json)
		{
			T obj = JsonConvert.DeserializeObject<T>(json);
			return obj;
		}

		public string base64Encode(string text)
		{
			var output = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
			return output;
		}

		public string base64Decode(string text)
		{
			var output = Encoding.UTF8.GetString(Convert.FromBase64String(text));
			return output;
		}


	}
}
