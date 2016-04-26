using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacInfoCheckingTool.CSharp
{
    class CANTVCommands : ICommands
    {
        private int CANTVCommandIdx = 0;
        private const int cmdLength = 12;

        public int CommandIdx
        {
            get { return CANTVCommandIdx; }
        }

        public int CmdLength
        {
            get { return cmdLength; }
        }

        Byte[] ICommands.ReadMacAddr()
        {
            CANTVCommandIdx = 1;
            Byte[] command =  { 0x55, 0xD8, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x27, 0xFE };
            return command; 
        }

        Byte[] ICommands.ReadSwVer()
        {
            CANTVCommandIdx = 2;
            Byte[] command = { 0x55, 0x29, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD7, 0xFE };
            return command;
        }
    }
}
