using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnowLeopard.Controls.Demo
{
    public partial class ControlEvent : SnowLeopard.Controls.BlueForm
    {
        private int _keyPressTriggerTimes = 0;
        private int _keyDownTriggerTimes = 0;
        private Stopwatch stopwatch = new Stopwatch();
        public ControlEvent()
        {
            InitializeComponent();
        }

        private void skinButton1_KeyDown(object sender, KeyEventArgs e)
        {
            _keyDownTriggerTimes++;
            if (!stopwatch.IsRunning)
            {
                stopwatch.Reset();
                stopwatch.Start();
            }
        }
        private void skinButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            _keyPressTriggerTimes++;
        }
        private void skinButton1_KeyUp(object sender, KeyEventArgs e)
        {
            stopwatch.Stop();

            MessageBox.Show($"KeyPress event trigger {_keyPressTriggerTimes} times in {stopwatch.Elapsed.TotalSeconds} seconds\r\n" +
                $"KeyDown event trigger {_keyDownTriggerTimes} times in {stopwatch.Elapsed.TotalSeconds} seconds\r\n" +
                $"{_keyDownTriggerTimes / stopwatch.Elapsed.TotalSeconds}/s");
            _keyPressTriggerTimes = 0;
            _keyDownTriggerTimes = 0;
            stopwatch.Stop();
        }


        // The event does not have any data, so EventHandler is adequate   
        // as the event delegate.  
        private EventHandler onValueChanged;
        // Define the event member using the event keyword.  
        // In this case, for efficiency, the event is defined   
        // using the event property construct.  
        public event EventHandler ValueChanged
        {
            add
            {
                onValueChanged += value;
            }
            remove
            {
                onValueChanged -= value;
            }
        }
        // The protected method that raises the ValueChanged  
        // event when the value has actually   
        // changed. Derived controls can override this method.    
        protected virtual void OnValueChanged(EventArgs e)
        {
            onValueChanged?.Invoke(this, e);
        }
    }
}
