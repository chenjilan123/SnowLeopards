using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.WFs
{
    public class ScaleProperty : Form
    {
        public new void Show()
        {
            MessageBox.Show(
                $"AutoScaleFactor    :{AutoScaleFactor}\r\n" +
                $"AutoScaleMode      :{AutoScaleMode}\r\n" +
                $"AutoScaleDimensions:{AutoScaleDimensions}\r\n");
        }

        static void Main(string[] args)
        {
            new ScaleProperty().Show();
        }
    }
}
