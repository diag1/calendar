using System;

namespace calendar
{
	public class Events
	{
		private List<Session> sessions;
		public Events (List<Session> sessions)
		{
			this.sessions = sessions;	
		}

		public List<Session> GetEventsForMonth(int month) {
			List<Session> toret = new List<Session> ();

			foreach (Session s in this.sessions) {
				var date = this.FromUnixTime (s.start);
				if (date.Month == month) {
					toret.Add (s);
				}
			}

			return toret;
		}

		private DateTime FromUnixTime(long unixTime)
		{
			var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return epoch.AddSeconds(unixTime);
		}
	}
}

