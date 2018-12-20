using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Util
{
    public class MemoryDiagnostics
    {
        private Process _process;

        public long WorkingSet => _process.WorkingSet64;

        public MemoryDiagnostics()
        {
            _process = Process.GetCurrentProcess();
        }
    }
}
