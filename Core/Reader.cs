using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace calendar
{	
	public interface Reader {
		List<Session> Read (String fn);
	}
	public class JSONReader :Reader
	{
		private List<Session> lst;

		public List<Session> Read (String fn){
			using (StreamReader r = new StreamReader (fn)) {
				string json = r.ReadToEnd ();
				this.lst = JsonConvert.DeserializeObject<List<Session>> (json);
				return this.lst;
			}
		}
		
	}
}