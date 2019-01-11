using SnowLeopard.Controls.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Controls.Container
{
    public class IconContainer : ISourceIcon
    {
        private const string IconPath = ".//Icon//DemoIcon";

        private readonly Dictionary<string, Image> _dicIcon = new Dictionary<string, Image>();

        private IEnumerator<string> KeyEnumerator;

        public Image GetImage()
        {
            return _dicIcon[GetNextKey()];
        }

        private string GetNextKey()
        {
            if (KeyEnumerator == null)
            {
                KeyEnumerator = _dicIcon.Keys.GetEnumerator();
            }
            KeyEnumerator.MoveNext();
            if (KeyEnumerator.Current == null)
            {
                KeyEnumerator.Reset();
                KeyEnumerator.MoveNext();
            }
            return KeyEnumerator.Current;
        }

        public void InitIcon()
        {
            if (Directory.Exists(IconPath))
            {
                foreach (var file in Directory.GetFiles(IconPath, "*.png"))
                {
                    var png = Image.FromFile(file);
                    _dicIcon.Add(file, png);
                }
            }
        }


    }
}
