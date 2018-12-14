using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.Demo
{
    public partial class ClickDemo : BlueForm
    {
        private bool isFirstClick = true;
        private bool isDoubleClick = false;
        private Rectangle doubleClickRectangle = new Rectangle();
        private Timer doubleClickTimer = new Timer();
        private int millseconds = 0;

        public ClickDemo()
        {
            InitializeComponent();
            demoButton.MouseDown += DemoButton_MouseDown;
            doubleClickTimer.Interval = 100;
            doubleClickTimer.Tick += DoubleClickTimer_Tick;
        }

        private void DoubleClickTimer_Tick(object sender, EventArgs e)
        {
            millseconds += 100;

            //Stop timer
            if (millseconds >= SystemInformation.DoubleClickTime)
            {
                doubleClickTimer.Stop();
                var sb = new StringBuilder();
                if (isDoubleClick)
                {
                    sb.Append("Double Click");
                }
                else
                {
                    sb.Append("$Single Click");
                }
                sb.AppendLine();
                sb.Append($"Mouse Position: {Cursor.Position}");  //System.Windows.Forms.Cursor?
                //Position is a static property
                //HotSpot is a instance property
                sb.Append(Environment.NewLine);
                sb.Append($"Mouse Hotspot : {this.Cursor.HotSpot}");  //Control.Cursor?
                                                                      //Cursor.Show();
                                                                      //Cursor.Hide();
                                                                      //Cursor.DrawStretched();
                                                                      //Clip: limit the area the mouse pointer can be used be setting the Clip property
                                                                      //Position: get or set the current location of the mouse using the Position property of the Cursor
                                                                      //The clip area, by default, is the entire screen.

                //Change Cursor Position
                //Cursor.Position = new Point(5, 5);

                //Change Mouse Pointer
                //ref : https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.forms.cursor?view=netframework-4.7.2
                //The primary way to change the mouse pointer is by setting the Control.Cursor or DefaultCursor property of a control to a new Cursor. 
                //this.Cursor = new Cursor(GetType(), "MyCursor.cur"); //Wrong
                //Cursor = Cursors.Hand;

                //Limit the Cursor Area
                //Cursor.Clip = new Rectangle(5, 5, 5, 5);

                MessageBox.Show(sb.ToString());
                //Roll back intialize status
                UseWaitCursor = false;
                isFirstClick = true;
                isDoubleClick = false;
                millseconds = 0;
            }
        }

        private void DemoButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (isFirstClick)
            {
                UseWaitCursor = true;
                isFirstClick = false;
                doubleClickRectangle = new Rectangle(
                    e.X - (SystemInformation.DoubleClickSize.Width / 2), 
                    e.Y - (SystemInformation.DoubleClickSize.Height / 2),
                    SystemInformation.DoubleClickSize.Width,
                    SystemInformation.DoubleClickSize.Height);
                //Invalidate();

                doubleClickTimer.Start();
            }
            else
            {
                if (doubleClickRectangle.Contains(e.Location) &&
                    millseconds < SystemInformation.DoubleClickTime)
                {
                    isDoubleClick = true;
                }
            }
        }
    }
}
