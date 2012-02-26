
// This file has been generated by the GUI designer. Do not modify.
namespace Pinta
{
	public partial class LayerPropertiesDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label1;
		private global::Gtk.Entry layerNameEntry;
		private global::Gtk.CheckButton visibilityCheckbox;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label2;
		private global::Gtk.SpinButton opacitySpinner;
		private global::Gtk.HScale opacitySlider;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
        
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Pinta.LayerPropertiesDialog
			this.Name = "Pinta.LayerPropertiesDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Layer Properties");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child Pinta.LayerPropertiesDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 10;
			this.vbox2.BorderWidth = ((uint)(9));
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.layerNameEntry = new global::Gtk.Entry ();
			this.layerNameEntry.CanFocus = true;
			this.layerNameEntry.Name = "layerNameEntry";
			this.layerNameEntry.IsEditable = true;
			this.layerNameEntry.InvisibleChar = '?';
			this.hbox1.Add (this.layerNameEntry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.layerNameEntry]));
			w3.Position = 1;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.visibilityCheckbox = new global::Gtk.CheckButton ();
			this.visibilityCheckbox.CanFocus = true;
			this.visibilityCheckbox.Name = "visibilityCheckbox";
			this.visibilityCheckbox.Label = global::Mono.Unix.Catalog.GetString ("Visible");
			this.visibilityCheckbox.DrawIndicator = true;
			this.visibilityCheckbox.UseUnderline = true;
			this.vbox2.Add (this.visibilityCheckbox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.visibilityCheckbox]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.vbox2.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hseparator2]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 16;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Opacity:");
			this.hbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.opacitySpinner = new global::Gtk.SpinButton (0, 100, 1);
			this.opacitySpinner.CanFocus = true;
			this.opacitySpinner.Name = "opacitySpinner";
			this.opacitySpinner.Adjustment.PageIncrement = 10;
			this.opacitySpinner.ClimbRate = 1;
			this.opacitySpinner.Numeric = true;
			this.hbox2.Add (this.opacitySpinner);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.opacitySpinner]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.opacitySlider = new global::Gtk.HScale (null);
			this.opacitySlider.CanFocus = true;
			this.opacitySlider.Name = "opacitySlider";
			this.opacitySlider.Adjustment.Upper = 100;
			this.opacitySlider.Adjustment.PageIncrement = 10;
			this.opacitySlider.Adjustment.StepIncrement = 1;
			this.opacitySlider.DrawValue = true;
			this.opacitySlider.Digits = 0;
			this.opacitySlider.ValuePos = ((global::Gtk.PositionType)(2));
			this.hbox2.Add (this.opacitySlider);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.opacitySlider]));
			w9.Position = 2;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Internal child Pinta.LayerPropertiesDialog.ActionArea
			global::Gtk.HButtonBox w12 = this.ActionArea;
			w12.Name = "dialog1_ActionArea";
			w12.Spacing = 10;
			w12.BorderWidth = ((uint)(5));
			w12.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonCancel]));
			w13.Expand = false;
			w13.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonOk]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 349;
			this.DefaultHeight = 224;
			this.Show ();
		}
	}
}
