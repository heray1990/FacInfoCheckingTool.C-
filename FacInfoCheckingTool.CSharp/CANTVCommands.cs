using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacInfoCheckingTool.CSharp
{
    class CANTVCommands : ICommands
    {
        Byte[] ICommands.ReadMacAddr()
        {
            Byte[] command =  { 0x55, 0xD8, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x27, 0xFE };
            return command; 
        }

        Byte[] ICommands.ReadSwVer()
        {
            Byte[] command = { 0x55, 0x29, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD7, 0xFE };
            return command;
        }
    }
}
