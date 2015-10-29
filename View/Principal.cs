using System;
using Gtk;
using System.IO;

namespace calendar
{
	public class Principal
	{
		public static void Main() {
			string json = @"[{""start"":518523721,""duration"":3600, ""distance"":200},{""start"":2342324,""duration"":100, ""distance"":400} ]";
			var t = new SessionJSONTransformer ();
			var r = new StreamReader (GenerateStreamFromString (json));
			var l = t.Transform (r);

			System.Console.WriteLine (l);
			foreach (Session k in l) {
				System.Console.WriteLine (k.duration);
			}

			//var recorridos = Recorridos.Crea ();
			Gtk.Application.Init();
			var wMain = new MainWindow (l);
			wMain.ShowAll ();
			Gtk.Application.Run ();
		}

		private static Stream GenerateStreamFromString(string s)
		{
			MemoryStream stream = new MemoryStream();
			StreamWriter writer = new StreamWriter(stream);
			writer.Write(s);
			writer.Flush();
			stream.Position = 0;
			return stream;
		}
	}
}
