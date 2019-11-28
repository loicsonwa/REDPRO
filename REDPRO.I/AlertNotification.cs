using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REDPRO.I
{
    public partial class AlertNotification : Form
    {
        public AlertNotification()
        {
            InitializeComponent();
        }

        public enum alertTypeEnum
        {
            Success,
            Warning,
            Error,
            Info
        }

        private int x, y;

        public void setAlert(string msg, AlertNotification.alertTypeEnum type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                AlertNotification f = (AlertNotification)Application.OpenForms[fname];

                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case AlertNotification.alertTypeEnum.Success:
                    this.GunaPictureBox1.Image = Properties.Resources.Checkmark_28px;
                    this.BackColor = Color.FromArgb(42, 171, 160);
                    break;
                case AlertNotification.alertTypeEnum.Warning:
                    this.GunaPictureBox1.Image = Properties.Resources.Warning_28px;
                    this.BackColor = Color.FromArgb(255, 179, 2);
                    break;
                case AlertNotification.alertTypeEnum.Error:
                    this.GunaPictureBox1.Image = Properties.Resources.Error_28px;
                    this.BackColor = Color.FromArgb(255, 121, 70);
                    break;
                case AlertNotification.alertTypeEnum.Info:
                    this.GunaPictureBox1.Image = Properties.Resources.Info_28px;
                    this.BackColor = Color.FromArgb(71, 169, 248);
                    break;
            }
            this.GunaLabel1.Text = msg;

            //this.TopMost = false;
            //this.ShowIcon = false;
            //this.ShowInTaskbar = false;

            this.Show();
            this.action = actionEnum.start;
            this.Timer1.Interval = 1;
            this.Timer1.Start();
        }




        public enum actionEnum
        {
            wait,
            start,
            close
        }

        private AlertNotification.actionEnum action;



        private void gunaPictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Timer1.Interval = 1;
            this.action = AlertNotification.actionEnum.close;
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case AlertNotification.actionEnum.wait:
                    this.Timer1.Interval = 5000;
                    this.action = AlertNotification.actionEnum.close;
                    break;
                case AlertNotification.actionEnum.start:
                    this.Timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = AlertNotification.actionEnum.wait;
                        }
                    }
                    break;
                case AlertNotification.actionEnum.close:
                    this.Timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

    }
}
