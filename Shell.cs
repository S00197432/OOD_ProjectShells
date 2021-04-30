using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_ProjectShells
{
     public class Shell
     {
        string ShellPart;
       
       
        public Shell(string newShellPart)
        {
            ShellPart = newShellPart;
            
        }
        public override string ToString()
        {
            return ShellPart;
        }

    }
}
