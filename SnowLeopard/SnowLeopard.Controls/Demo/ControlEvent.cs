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
        /// <summary>
        /// Windows Forms provides the ability to handle keyboard messages at the form level, before the messages reach a control. 
        /// </summary>
        public ControlEvent()
        {
            InitializeComponent();
            this.PreviewKeyDown += PreviewKeyDownHandler;
            // set the KeyPreview property of the form to true so that keyboard messages are received by the form before they reach any controls on the form.
            this.KeyPreview = true;
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
        public override bool PreProcessMessage(ref Message m)
        {
            //AppendMessage("PreProcessMessage");
            //if (m.Msg == WM_KEYDOWN)
            //{
            //    Keys keyCode = (Keys)m.WParam & Keys.KeyCode;

            //    // Detect F1 through F9.
            //    switch (keyCode)
            //    {
            //        case Keys.F1:
            //        case Keys.F2:
            //        case Keys.F3:
            //        case Keys.F4:
            //        case Keys.F5:
            //        case Keys.F6:
            //        case Keys.F7:
            //        case Keys.F8:
            //        case Keys.F9:

            //            MessageBox.Show("Control.PreProcessMessage: '" +
            //              keyCode.ToString() + "' pressed.");

            //            // Replace F3 with F1, so that ProcessKeyMessage will  
            //            // receive F1 instead of F3.
            //            if (keyCode == Keys.F3)
            //            {
            //                m.WParam = (IntPtr)Keys.F1;
            //                MessageBox.Show("Control.PreProcessMessage: '" +
            //                    keyCode.ToString() + "' replaced by F1.");
            //            }
            //            break;
            //    }
            //}

            //// Send all other messages to the base method.
            return base.PreProcessMessage(ref m);
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
        /// <summary>
        /// Perform special input or navigation handling during a KeyPress event. For example, in a list control holding down the "r" key skips between items that begin with the letter r.
        /// navigation handling: 例如按住r，可以在开头为r的项之间快速移动
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
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
            //Get ModifierKeys
            var modifierKeys = Control.ModifierKeys;
            //Best Practice
            //None. ??
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                MessageBox.Show("Pressed " + Keys.Shift);
            }

            //Control+A => 1(\u0001)?
            _keyPressTriggerTimes++;
        }
        private void skinButton1_KeyUp(object sender, KeyEventArgs e)
        {
            //None. ??
            var modifierKeys = Control.ModifierKeys;


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
