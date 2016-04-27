using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacInfoCheckingTool.CSharp
{
    interface ICommands
    {
        int CommandIdx { set; get; }
        int CmdLength { get; }
        Byte[] ReadMacAddr();
        Byte[] ReadSwVer();
    }
}
