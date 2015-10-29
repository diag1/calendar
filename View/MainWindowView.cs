using System;
using System.Collections.Generic;

namespace calendar
{
	public partial class MainWindow: Gtk.Window
	{
		public  List<Session> sessions;

		public MainWindow (List<Session> sessions)
			:base(Gtk.WindowType.Toplevel)
		{
			this.sessions = sessions;
			this.Build();
		}

		private void Build(){
			SetDefaultSize (250, 200);
			var vbox = new Gtk.VBox(false, 5);

			this.cal = new Gtk.Calendar ();
			// Mark days in the calendar where an event has ocurred
			foreach (Session s in this.sessions) {

			}

			this.banner = new Gtk.Label ("Viajes Pepe");
			this.btnAdd = new Gtk.Button ("Add trip");
			this.btnList = new Gtk.Button ("List trips");

			vbox.PackStart (this.banner, true, false, 5);
			vbox.PackStart (this.btnAdd, true, false, 5);
			vbox.PackStart (this.btnList, true, false, 5);
			vbox.PackStart (this.cal, true, false, 5);

			this.Add(vbox);


			// Events
			this.DeleteEvent += (o, args) => this.OnClose();
			this.btnAdd.Clicked += (o, args) => this.ShowAddTrip();
			this.btnList.Clicked += (o, args) => this.ShowListTrips();
			this.cal.DaySelected += (o, args) => this.ShowEventsForDay ();

			//this.btnAdd.Clicked += (o, args) => this.Calculate();*/


			// Widgets
			/*
			this.edOp1 = new Gtk.Entry("0");
			this.edOp1.Alignment = 1;
			this.edOp2 = new Gtk.Entry("0");
			this.edOp2.Alignment = 1;
			this.edRes = new Gtk.Entry("0");
			this.edRes.Alignment = 1;
			this.edRes.IsEditable = false;
			this.btnAdd = new Gtk.Button("+");

			// Add widgets to layout
			vbox.PackStart(this.edOp1, true, false, 5);
			vbox.PackStart(this.edOp2, true, false, 5);
			vbox.PackStart(this.edRes, true, false, 5);
			vbox.PackStart(this.btnAdd, true, false, 5);

			this.Add(vbox);

			// Events
			this.DeleteEvent += (o, args) => this.OnClose();
			this.btnAdd.Clicked += (o, args) => this.Calculate();*/
		}

		private Gtk.Label banner;
		private Gtk.Button btnList;
		private Gtk.Button btnAdd;
		private Gtk.Calendar cal;
	}


}
