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
            this.PreviewKeyDown += PreviewKeyDownHandler;
        }

        private StringBuilder _sbKeyEventOrder = new StringBuilder();
        private void ShowMessage()
        {
            MessageBox.Show(_sbKeyEventOrder.ToString());
        }
        private void AppendMessage(string msg)
        {
            _sbKeyEventOrder.Append($"{msg}\r\n");
        }
        private void ClearMessage()
        {
            _sbKeyEventOrder.Clear();
        }
        /// <summary>
        /// After keyboard messages reach the WndProc method of a form or control, they are processed by a set of methods that can be overridden. Each of these methods returns a Boolean value specifying whether the keyboard message has been processed and consumed by the control. If one of the methods returns true, then the message is considered handled, and it is not passed to the control's base or parent for further processing. Otherwise, the message stays in the message queue and may be processed in another method in the control's base or parent. The following table presents the methods that process keyboard messages.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            //AppendMessage("WndProc");
            base.WndProc(ref m);
        }
        public override bool PreProcessMessage(ref Message msg)
        {
            AppendMessage("PreProcessMessage");
            return base.PreProcessMessage(ref msg);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            AppendMessage($"ProcessCmdKey: {keyData}");
            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            AppendMessage("OnPreviewKeyDown");
            e.IsInputKey = true;
            base.OnPreviewKeyDown(e);
        }
        protected override bool IsInputKey(Keys keyData)
        {
            AppendMessage($"IsInputKey: {keyData}");
            return base.IsInputKey(keyData);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            //keyData == Keys.Enter
            AppendMessage($"ProcessDialogKey: {keyData}");
            return base.ProcessDialogKey(keyData);
        }

        protected override bool IsInputChar(char charCode)
        {
            AppendMessage($"IsInputChar: {charCode}");
            return base.IsInputChar(charCode);
        }
        protected override bool ProcessDialogChar(char charCode)
        {
            AppendMessage($"ProcessDialogChar: {charCode}");
            return base.ProcessDialogChar(charCode);
        }

        #region Key
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
        #endregion

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

        private void skinButton2_Click(object sender, EventArgs e)
        {
            ShowMessage();
            ClearMessage();
        }

        private void PreviewKeyDownHandler(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                e.IsInputKey = true;
            }
        }
    }
}
