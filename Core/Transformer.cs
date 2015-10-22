using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace calendar
{
	public interface SessionTransformer
	{
		List<Session> Transform(StreamReader r); 
	}

	public class SessionJSONTransformer : SessionTransformer {
		public List<Session> Transform(StreamReader r) {
			string json = r.ReadToEnd ();
			return JsonConvert.DeserializeObject<List<Session>> (json);
		}
	}
}

