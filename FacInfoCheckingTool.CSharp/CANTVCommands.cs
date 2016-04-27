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
            set { CANTVCommandIdx = value; }
            get { return CANTVCommandIdx; }
        }

        public int CmdLength
        {
            get { return cmdLength; }
        }

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

        string ICommands.ParseMacAddrData(Byte[] buffer)
        {
            string data = "";
            for (int i = 0; i <= buffer.Length; i++)
            {
                if ((i >= 3) && (i <= 8))
                {
                    data = data + buffer[i].ToString("X2").ToUpper();
                }
            }
            return data;
        }

        string ICommands.ParseSwVerData(Byte[] buffer)
        {
            string data = "";
            Byte[] bufTmp = new Byte[buffer.Length];
            for (int i = 0; i <= buffer.Length; i++)
            {
                if ((i >= 3) && (i <= 8))
                {
                    bufTmp[i - 3] = buffer[i];
                }
            }
            data = data + Encoding.ASCII.GetString(bufTmp);
            return data;
        }

        bool ICommands.isCmdHeaderCorrect(Byte[] buffer)
        {
            if (buffer[0] == 0x55 && 
                ((buffer[1] == 0xB0) || (buffer[1] == 0xB2) || (buffer[1] == 0xB4)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
