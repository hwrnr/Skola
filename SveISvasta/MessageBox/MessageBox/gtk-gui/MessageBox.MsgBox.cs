
// This file has been generated by the GUI designer. Do not modify.
namespace MessageBox
{
	public partial class MsgBox
	{
		private global::Gtk.VBox vbox5;

		private global::Gtk.Label label4;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MessageBox.MsgBox
			this.Name = "MessageBox.MsgBox";
			this.Title = global::Mono.Unix.Catalog.GetString("MsgBox");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child MessageBox.MsgBox.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("label4");
			this.vbox5.Add(this.label4);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label4]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			this.Add(this.vbox5);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}