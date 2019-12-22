using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Alerter;

namespace REDPRO.I
{
    public partial class Accueil : DevExpress.XtraEditors.XtraForm
    {
        // Create a regular custom button
        AlertButton btn1 = new AlertButton();
        // Create a check custom button.
        AlertButton btn2 = new AlertButton();

        // Show a sample alert window.
        AlertInfo info = new AlertInfo("New Window", "Text");
        

        public Accueil()
        {
            InitializeComponent();
            btn1.Hint = "Open file";
            btn1.Name = "buttonOpen";

            btn2.Style = AlertButtonStyle.CheckButton;
            btn2.Down = true;
            btn2.Hint = "Alert On";
            btn2.Name = "buttonAlert";

            // Add buttons to the AlertControl and subscribe to the events to process button clicks
            alertControl1.Buttons.Add(btn1);
            alertControl1.Buttons.Add(btn2);
            alertControl1.ButtonClick += new AlertButtonClickEventHandler(alertControl1_ButtonClick);
            alertControl1.ButtonDownChanged += new AlertButtonDownChangedEventHandler(alertControl1_ButtonDownChanged);
            alertControl1.Show(this, info);
        }

        
      
        private void TileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            //navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }
        private static bool canCloseFunc(DialogResult parameter)
        {
            return parameter != DialogResult.Cancel;
        }

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Predicate<DialogResult> predicate = canCloseFunc;
            FlyoutAction action = new FlyoutAction() { Caption = "Confirm", Description = "Close the application?" };
            FlyoutCommand command1 = new FlyoutCommand() { Text = "Close", Result = System.Windows.Forms.DialogResult.Yes };
            FlyoutCommand command2 = new FlyoutCommand() { Text = "Cancel", Result = System.Windows.Forms.DialogResult.No };
            action.Commands.Add(command1);
            action.Commands.Add(command2);
            FlyoutProperties properties = new FlyoutProperties();
            properties.ButtonSize = new Size(100, 40);
            properties.Style = FlyoutStyle.MessageBox;
            if (FlyoutDialog.Show(this, action, properties, predicate) == System.Windows.Forms.DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message msg = new Message();
            alertControl1.Show(this, msg.Caption, msg.Text, "", msg.Image, msg);
        }

        private void alertControl1_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        {
           
            //Process Alert Window click
            Message msg = e.Info.Tag as Message;
            XtraMessageBox.Show(msg.Text, msg.Caption);
        }

        private void alertControl1_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            //Make the Alert Window opaque
            e.AlertForm.OpacityLevel = 1;
        }

        private void alertControl1_ButtonDownChanged(object sender, AlertButtonDownChangedEventArgs e)
        {
            if (e.ButtonName == "buttonOpen")
            {
                //...
            }
        }

        private void alertControl1_ButtonClick(object sender, AlertButtonClickEventArgs e)
        {
            if (e.ButtonName == "buttonAlert")
            {
                //...
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flyoutPanel1.Show();
        }
    }


    public class Message
    {
        public Message()
        {
            this.Caption = "LILA-Supermercado";
            this.Text = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo";
            this.Image = global::REDPRO.I.Properties.Resources.photo_2019_12_13_10_53_20;
        }
        public string Caption { get; set; }
        public string Text { get; set; }
        public Image Image { get; set; }
    }

}