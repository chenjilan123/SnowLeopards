using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Controls.Interface
{
    public interface ISourceIcon
    {
        void InitIcon();
        Image GetImage();
    }
}
