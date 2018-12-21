using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls
{
    public class DragButton : SkinButton
    {
        //There are other ways to simulate mouse input. For example, you can programmatically set a control property that represents a state that is typically set through mouse input (such as the Checked property of the CheckBox control)
        private void RightClick() =>
            //Simulate mouse right click
            base.OnMouseClick(new MouseEventArgs(MouseButtons.Right, 1, 0, 0, 0));
        private void LeftClick()
        {
            //子类不可调用基类的事件
            //MouseClick(this, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0);
        }

        private void KeyInput()
        {
            //
            //base.OnKeyDown(new KeyEventArgs(Keys.F1));

            //International Use: If your application is intended for international use with a variety of keyboards, the use of SendKeys.Send could yield unpredictable results and should be avoided.
            //SendKeys.Send("F1");
            //SendKeys.SendWait("F1");

            //            < appSettings >
            //< add key = "SendKeys" value = "SendInput" />
            //< add key = "SendKeys" value = "JournalHook" />
            //   </ appSettings >
        }
    }
}
