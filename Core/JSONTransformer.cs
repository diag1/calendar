using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace calendar
{
	public class JSONTransformer {

		public static List<RunSession> ToRunSessions(StreamReader r) {
			string json = r.ReadToEnd ();
			return JsonConvert.DeserializeObject<List<RunSession>> (json);
		} 

		public static List<WeightSession> ToWeightSessions(StreamReader r) {
			string json = r.ReadToEnd ();
			return JsonConvert.DeserializeObject<List<WeightSession>> (json);
		}
	}

}

