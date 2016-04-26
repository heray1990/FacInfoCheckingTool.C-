using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacInfoCheckingTool.CSharp
{
    interface ICommands
    {
        Byte[] ReadMacAddr();
        Byte[] ReadSwVer();
    }
}
