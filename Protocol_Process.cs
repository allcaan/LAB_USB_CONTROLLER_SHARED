using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC_2HS_Sample_Program_KOR
{
    class Protocol_Process
    {
        SerialCommunication GoSerial = new SerialCommunication();
        public byte[] Command_Protocol (string Command)
        {
            
            char[] charval = Command.ToCharArray();
            byte[] CR = { 0x0d };
            byte[] Command_byte = Encoding.UTF8.GetBytes(Command);
            byte[] Query_Command = new byte[charval.Length + 1];
            Array.Copy(Command_byte, Query_Command, charval.Length);
            Array.Copy(CR, 0, Query_Command, charval.Length, 1);
            byte[] Result = new byte[Query_Command.Length];
            Array.Copy(Query_Command, Result, Query_Command.Length);
            
            return Result;
        }

        public string RCV_Protocol(byte[] Response)
        {
            try
            {
                byte[] RCV_val = new byte[Response.Length - 1];
                Array.Copy(Response, 0, RCV_val, 0, Response.Length - 1);
                string result = Encoding.Default.GetString(RCV_val);

                return result;
            }
            catch(Exception)
            {
                return "NO Response";
            }
               
        }

    }
}
