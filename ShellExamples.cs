using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_ProjectShells
{
    class ShellExamples
    {
        string ShellExample;
        public ShellExamples(string newShellExample)
        {
            ShellExample = newShellExample;
        }
        public override string ToString()
        {
            return ShellExample;
        }
    }
}
