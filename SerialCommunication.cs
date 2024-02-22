using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Collections;
using System.Threading;

namespace PMC_2HS_Sample_Program_KOR
{
    class SerialCommunication
    {
        public ArrayList Serial_Buf_Arr = new ArrayList();
        private SerialPort Sp = new SerialPort();

        //--------------------------------------------------------
        //        Comport 열기        
        //--------------------------------------------------------
        public string Comport_Open(string port, string baud, string databits, string parity, string stop)
        {
            try
            {
                Sp.PortName = port;
                Sp.BaudRate = int.Parse(baud);
                Sp.DataBits = int.Parse(databits);
                Sp.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
                Sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stop);

                if (!Sp.IsOpen)
                {
                    Sp.Open();
                }
                if (Sp.IsOpen)
                {
                    
                    return "Success Port Open";
                }

                else
                {
                    return "Fail Port Open";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //--------------------------------------------------------
        //      수신 처리          
        //--------------------------------------------------------
        public void Reference(int number)
        {
            byte[] buf = new byte[number];
        }

        public string Response_String;
        public byte[] Response;
        public void RcvSerialComm()
        {

            try
            {
                if (Sp.IsOpen)
                {
                    int nbyte = Sp.BytesToRead;
                    byte[] rbuff = new byte[nbyte];
                    if (nbyte > 0)
                    {
                        Sp.Read(rbuff, 0, nbyte);
                    }
                    Response = rbuff;
                    Response_String = BitConverter.ToString(rbuff);

                    Serial_Buf_Arr.Clear();
                    for (int i = 0; i < nbyte; i++)
                    {
                        Serial_Buf_Arr.Add(rbuff[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                Serial_Buf_Arr.Clear();
                throw ex;
            }
        }

        //--------------------------------------------------------
        //      포트 상태 체크         
        //--------------------------------------------------------
        public bool IsOpened()
        {
            return Sp.IsOpen;
        }

        //--------------------------------------------------------
        //      수신 개수 읽기         
        //--------------------------------------------------------
        public int RcvCnt()
        {

            return Serial_Buf_Arr.Count;

        }

        //--------------------------------------------------------
        //     수신버퍼 클리어         
        //--------------------------------------------------------
        public void RcvBuffClear()
        {

            Serial_Buf_Arr.Clear();
        }

        //--------------------------------------------------------
        //    송신 처리         
        //--------------------------------------------------------
        public void SendSerialComm(byte[] SendComm_Packet, int len)
        {
            try
            {
                if (Sp.IsOpen)
                    Sp.Write(SendComm_Packet, 0, len);
                //Console.WriteLine("Sending Completed");
                Thread.Sleep(100);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //--------------------------------------------------------
        //    포트 닫기         
        //--------------------------------------------------------
        public void CloseSerialComm()

        {
            try
            {
                if (Sp != null)
                    Sp.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //--------------------------------------------------------
        //    시리얼포트 해제         
        //--------------------------------------------------------
        public void Dispose()
        {
            if (Serial_Buf_Arr.Count > 0)
            {
                Serial_Buf_Arr.Clear();
            }
            if (Sp != null)
                Sp.Dispose();
        }

    }
}
