using System;

namespace calendar
{
	public partial class MainWindow
	{
		private void OnClose() {
			Gtk.Application.Quit();
		}

		private void ShowAddTrip() {
			/*var addWindow = new AddWindow (this);
			Gtk.ResponseType result = (Gtk.ResponseType)addWindow.Run ();

			if (result == Gtk.ResponseType.Accept) {
				var origin = addWindow.GetOrigin ();
				var dst = addWindow.GetDestination ();
				var kms = addWindow.GetKMS ();
				this.rds.Add(Recorrido.Crea (origin, dst, kms));
				this.rds.GuardaXml ();
			}
			addWindow.Destroy ();
			*/
		}


		private  void ShowListTrips() {
			/*
			var listWindow = new ListWindow (this, this.rds);
			Gtk.ResponseType result = (Gtk.ResponseType)listWindow.Run ();
			listWindow.Destroy ();
			*/
		}

		private void ShowEventsForDay() {
			System.Console.WriteLine("Day selected");
		}
	}	
}

