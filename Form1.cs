using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PMC_2HS_Sample_Program_KOR
{
    public partial class POS_Char1 : Form
    {
        public POS_Char1()
        {
            InitializeComponent();
        }
        SerialCommunication GoSerial = new SerialCommunication();
        Protocol_Process GoProtocol = new Protocol_Process();

        public static int Port_num = 0;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //-------------------PMC 파라미터 초기화--------------------//  
            AxisList.Items.Clear();
            AxisList.Items.Add("X Axis");
            AxisList.Items.Add("Y Axis");
            AxisList.Items.Add("XY Axis");
            AxisList.SelectedIndex = 0;
            SpeedX_Textbox.Text = "100";
            SpeedY_Textbox.Text = "1000";
            GetposTextbox_X.Text = "0";
            GetposTextbox_Y.Text = "0";
            PAB_X_Textbox.Text = "1000";
            PAB_Y_Textbox.Text = "1000";
            PIC_X_Textbox.Text = "1000";
            PIC_Y_Textbox.Text = "10000";
            suspand_time1_textbox.Text = "1";
            suspand_time2_textbox.Text = "1";
            SpeedY_time1_textbox.Text = "1000";
            SpeedY_time2_textbox.Text = "1000";

            //-------------------PMC 파라미터 초기화--------------------//  

            /*double SpeedX_Textbox_int = double.Parse(SpeedX_Textbox.Text);
            double transed_SpeedX_int = SpeedX_Textbox_int * 100;
            SpeedX_Textbox.Text = transed_SpeedX_int.ToString();

            double SpeedY_Textbox_int = double.Parse(SpeedY_Textbox.Text);
            double transed_SpeedY_int = SpeedY_Textbox_int * 1000.0;
            SpeedY_Textbox.Text = transed_SpeedY_int.ToString();

            double PIC_X_Textbox_int = double.Parse(PIC_X_Textbox.Text);
            double transed_PicX_int = PIC_X_Textbox_int * 1000.0;
            PIC_X_Textbox.Text = transed_PicX_int.ToString();

            double PIC_Y_Textbox_int = double.Parse(PIC_Y_Textbox.Text);
            double transed_PicY_int = PIC_Y_Textbox_int * 10000.0;
            PIC_Y_Textbox.Text = transed_PicY_int.ToString(); */

           //double SpeedY_time1_int = double.Parse(SpeedY_time1_textbox);
           //double transed_SpeedY_1_int = SpeedY_time1_int * 100;
           //SpeedX_Textbox.Text = transed_SpeedX_int.ToString();

           //double SpeedY_time2_int = double.Parse(SpeedY_time1_textbox);
           //double transed_SpeedY_2_int = SpeedY_time2_int * 1000.0;
           //SpeedY_Textbox.Text = transed_SpeedY__int.ToString();






           //-------------------차트 구성 값--------------------//  
           POS_Chart.ChartAreas[0].AxisX.Minimum = -50000;
           POS_Chart.ChartAreas[0].AxisX.Maximum = 50000;
           POS_Chart.ChartAreas[0].AxisY.Minimum = -50000;
           POS_Chart.ChartAreas[0].AxisY.Maximum = 50000;
           POS_Chart.ChartAreas[0].AxisX.Interval = 10000;
           POS_Chart.ChartAreas[0].AxisY.Interval = 10000;

           POS_Chart.Series[0].Points.AddXY(0, 0);
           //-------------------차트 구성 값--------------------//  


           //-------------------통신 파라미터 설정 구성--------------------//  
           string[] Comlist = System.IO.Ports.SerialPort.GetPortNames();
           if (Comlist.Length > 0)
           {
               Port_CB.Items.AddRange(Comlist);
               Port_CB.SelectedIndex = 0;
           }

           Baud_CB.Items.Add("9600");
           Baud_CB.Items.Add("19200");
           Baud_CB.Items.Add("38400");
           Baud_CB.Items.Add("57600");
           Baud_CB.Items.Add("115200");
           Baud_CB.SelectedIndex = 0;
           //-------------------통신 파라미터 설정 구성--------------------//  
       }

       //-------------------포트 오픈 버튼--------------------//  
       private void Open_Btn_Click(object sender, EventArgs e)
       {
           string port = Port_CB.SelectedItem.ToString();
           Port_num = Int32.Parse(port.Replace("COM", string.Empty));
           string Baud_S = Baud_CB.SelectedItem.ToString();
           PortStateTextbox.Text = GoSerial.Comport_Open(port, Baud_S, "8", "0", "1");
       }
       //-------------------포트 오픈 버튼--------------------//  

       //-------------------포트 클로즈 버튼--------------------//  
       private void Close_btn_Click(object sender, EventArgs e)
       {
           GoSerial.CloseSerialComm();
           GoSerial.Dispose();
           PortStateTextbox.Text = "Port Close";
       }
       //-------------------포트 클로즈 버튼--------------------//  

       //-------------------커맨드 실행 버튼--------------------//  
       private void Send_btn_Click(object sender, EventArgs e)
       {
           string Command_str = Command_Textbox.Text;
           byte[] Query_Command = GoProtocol.Command_Protocol(Command_str);
           GoSerial.SendSerialComm(Query_Command, Query_Command.Length);

           GoSerial.RcvSerialComm();
           string Query_Reponse = GoProtocol.RCV_Protocol(GoSerial.Response);

           Response_Textbox.Text = Query_Reponse;

           timer1.Start();
       }
       //-------------------커맨드 실행 버튼--------------------//  

       //-------------------정방향 연속 동작 실행 버튼--------------------//  
       private void CW_btn_Click(object sender, EventArgs e)
      {
           string Command_spd = "SPD " + SpeedX_Textbox.Text + "," + SpeedY_Textbox.Text;
           byte[] Query_Speed = GoProtocol.Command_Protocol(Command_spd);
           GoSerial.SendSerialComm(Query_Speed, Query_Speed.Length);

           string Command_str = "JOG "+ AxisList.SelectedItem.ToString();
           byte[] Query_Command = GoProtocol.Command_Protocol(Command_str);
           GoSerial.SendSerialComm(Query_Command, Query_Command.Length);
           timer1.Start();
       }
       //-------------------정방향 연속 동작 실행 버튼--------------------//  

       //-------------------역방향 연속 동작 실행 버튼--------------------//  
       private void CCW_btn_Click(object sender, EventArgs e)
       {
           string Command_str;
           string Command_spd = "SPD " + SpeedX_Textbox.Text + "," + SpeedY_Textbox.Text;
           byte[] Query_Speed = GoProtocol.Command_Protocol(Command_spd);
           GoSerial.SendSerialComm(Query_Speed, Query_Speed.Length);

           if (AxisList.SelectedIndex == 2)
               Command_str = "JOG -X-Y";
           else
               Command_str = "JOG -" + AxisList.SelectedItem.ToString();

           byte[] Query_Command = GoProtocol.Command_Protocol(Command_str);
           GoSerial.SendSerialComm(Query_Command, Query_Command.Length);
           timer1.Start();
       }
       //-------------------역방향 연속 동작 실행 버튼--------------------//  

       //-------------------모터 정지 버튼--------------------//  
       private void Stop_btn_Click(object sender, EventArgs e)
       {
           string Command_str = "STO "+ AxisList.SelectedItem.ToString();
           byte[] Query_Command = GoProtocol.Command_Protocol(Command_str);
           GoSerial.SendSerialComm(Query_Command, Query_Command.Length);
           timer1.Start();
       }
       //-------------------모터 정지 버튼--------------------//  


       //-------------------리셋 버튼--------------------//  
       private void Rest_btn_Click(object sender, EventArgs e)
       {
           string Command_str = "RST";
           byte[] Query_Command = GoProtocol.Command_Protocol(Command_str);
           GoSerial.SendSerialComm(Query_Command, Query_Command.Length);
           timer1.Start();
       }
       //-------------------리셋 버튼--------------------//  

       //-------------------PAB 실행 버튼--------------------//  
       private void PAB_START_btn_Click(object sender, EventArgs e)
       {
           string Command_spd = "SPD " + SpeedX_Textbox.Text + "," + SpeedY_Textbox.Text;
           byte[] Query_Speed = GoProtocol.Command_Protocol(Command_spd);
           GoSerial.SendSerialComm(Query_Speed, Query_Speed.Length);

           string Command_str = "";

           if (AxisList.SelectedIndex == 0)
               Command_str = "PAB " + PAB_X_Textbox.Text;
           else if (AxisList.SelectedIndex == 1)
               Command_str = "PAB ," + PAB_Y_Textbox.Text;
           else if (AxisList.SelectedIndex == 2)
               Command_str = "PAB " + PAB_X_Textbox.Text + "," + PAB_Y_Textbox.Text;

           byte[] Query_Command = GoProtocol.Command_Protocol(Command_str);
           GoSerial.SendSerialComm(Query_Command, Query_Command.Length);
           timer1.Start();
       }
       //-------------------PAB 실행 버튼--------------------//  

       //-------------------PIC 실행 버튼--------------------//  
       private void PIC_START_btn_Click(object sender, EventArgs e)
       {
           string Command_spd = "SPD " + SpeedX_Textbox.Text + "," + SpeedY_Textbox.Text;
           byte[] Query_Speed = GoProtocol.Command_Protocol(Command_spd);
           GoSerial.SendSerialComm(Query_Speed, Query_Speed.Length);

           string Command_str = "";

           if (AxisList.SelectedIndex == 0)
               Command_str = "PIC " + PIC_X_Textbox.Text;
           else if (AxisList.SelectedIndex == 1)
               Command_str = "PIC ," + PIC_Y_Textbox.Text;
           else if (AxisList.SelectedIndex == 2)
               Command_str = "PIC " + PIC_X_Textbox.Text + "," + PIC_Y_Textbox.Text;

           byte[] Query_Command = GoProtocol.Command_Protocol(Command_str);
           GoSerial.SendSerialComm(Query_Command, Query_Command.Length);
           timer1.Start();

       }
       //-------------------PIC 실행 버튼--------------------//  

       //-------------------POS 실행 버튼--------------------//  
       private void Get_Pos_btn_Click(object sender, EventArgs e)
       {
           string Command_str = "POS";
           byte[] Query_Command = GoProtocol.Command_Protocol(Command_str);
           GoSerial.SendSerialComm(Query_Command, Query_Command.Length);

           GoSerial.RcvSerialComm();
           string Query_Reponse = GoProtocol.RCV_Protocol(GoSerial.Response);
           byte[] POS_val_X = new byte[8];
           byte[] POS_val_Y = new byte[8];
           Array.Copy(GoSerial.Response, 4, POS_val_X, 0, 8);
           Array.Copy(GoSerial.Response, 13, POS_val_Y, 0, 8);

           string POS_X_str = Encoding.Default.GetString(POS_val_X);
           string POS_Y_str = Encoding.Default.GetString(POS_val_Y);

           int POS_X_int = Convert.ToInt32(POS_X_str, 16);
           int POS_Y_int = Convert.ToInt32(POS_Y_str, 16);

           GetposTextbox_X.Text = POS_X_int.ToString();
           GetposTextbox_Y.Text = POS_Y_int.ToString();

           POS_Chart.Series[0].Points.Clear();
           POS_Chart.Series[0].Points.AddXY(POS_X_int,POS_Y_int);
       }
       //-------------------POS 실행 버튼--------------------//  

       //-------------------POS 초기화 버튼--------------------//  
       private void Clear_Pos_btn_Click(object sender, EventArgs e)
       {
           string Command_str = "CLL " + AxisList.SelectedItem.ToString();
           byte[] Query_Command = GoProtocol.Command_Protocol(Command_str);
           GoSerial.SendSerialComm(Query_Command, Query_Command.Length);
           Get_Pos_btn_Click(sender, e);
       }
       //-------------------POS 초기화 버튼--------------------//  

       private void timer1_Tick(object sender, EventArgs e)
       {
           string INRX_str = "INR X";
           string INRY_str = "INR Y";


           byte[] Query_INRX = GoProtocol.Command_Protocol(INRX_str);
           GoSerial.SendSerialComm(Query_INRX, Query_INRX.Length);
           GoSerial.RcvSerialComm();
           if (GoSerial.Response == null || GoSerial.Response.Length < 7)
           {
               // 처리할 예외 상황: 응답이 null이거나 응답의 길이가 충분하지 않은 경우
               // 여기서 적절한 처리를 수행합니다.
               // 예를 들어, 사용자에게 메시지를 표시하거나 다른 동작을 수행할 수 있습니다.
               // 예외 처리 후에는 이하 코드를 실행하지 않고 타이머를 중지할 수 있습니다.
               timer1.Stop();
               MessageBox.Show("응답을 받을 수 없습니다.");
               return;
           }

           byte[] INRX_by = new byte[1] { 0x00 };
           Array.Copy(GoSerial.Response, 6, INRX_by, 0, 1);
           BitArray INRX_bit = new BitArray(INRX_by);

           byte[] Query_INRY = GoProtocol.Command_Protocol(INRY_str);
           GoSerial.SendSerialComm(Query_INRY, Query_INRY.Length);
           GoSerial.RcvSerialComm();
           byte[] INRY_by = new byte[1] { 0x00 };
           Array.Copy(GoSerial.Response, 6, INRY_by, 0, 1);
           BitArray INRY_bit = new BitArray(INRY_by);


           if (INRX_bit[0] == false && INRY_bit[0] == false)
           {
               timer1.Stop();
               Get_Pos_btn_Click(sender, e);
           }

           else
           {
               Get_Pos_btn_Click(sender, e);

           }
       }


       //------------ AUTO 실행버튼 -------//
       /* private async void Auto_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // X 및 Y 축 이동 시간을 가져옴
                int timeX = Convert.ToInt32(TimeX_Textbox.Text);
                int timeY = Convert.ToInt32(TimeY_Textbox.Text);

                // X 축 및 Y 축의 속도 설정 명령 생성
                string xSpeedCommand = $"SPD {SpeedX_Textbox.Text},0";
                string ySpeedCommand = $"SPD 0,{SpeedY_Textbox.Text}";

                // 속도 설정 명령을 바이트 배열로 변환
                byte[] xSpeedQuery = GoProtocol.Command_Protocol(xSpeedCommand);
                byte[] ySpeedQuery = GoProtocol.Command_Protocol(ySpeedCommand);

                // 속도 설정 명령 전송
                GoSerial.SendSerialComm(xSpeedQuery, xSpeedQuery.Length);
                GoSerial.SendSerialComm(ySpeedQuery, ySpeedQuery.Length);

                // Y 축으로 이동 (아래 방향)
                string yAxisMoveDownCommand = $"AUTO 0,{timeY}";
                byte[] yAxisMoveDownQuery = GoProtocol.Command_Protocol(yAxisMoveDownCommand);
                GoSerial.SendSerialComm(yAxisMoveDownQuery, yAxisMoveDownQuery.Length);

                // Y 축 이동 후 대기
                await Task.Delay(timeY);

                // X 축으로 이동
                string xAxisMoveCommand = $"AUTO {timeX},0";  // X 축으로만 이동하도록 수정
                byte[] xAxisMoveQuery = GoProtocol.Command_Protocol(xAxisMoveCommand);
                GoSerial.SendSerialComm(xAxisMoveQuery, xAxisMoveQuery.Length);

                // X 축 이동 후 대기
                await Task.Delay(timeX);

                // Y 축으로 이동 (위 방향)
                string yAxisMoveUpCommand = $"AUTO 0,-{timeY}";
                byte[] yAxisMoveUpQuery = GoProtocol.Command_Protocol(yAxisMoveUpCommand);
                GoSerial.SendSerialComm(yAxisMoveUpQuery, yAxisMoveUpQuery.Length);

            }
            catch (FormatException ex)
            {
                // 숫자로 변환할 수 없는 형식의 입력이 있을 때 발생하는 예외 처리
                MessageBox.Show("숫자 형식의 값을 입력하세요.");
            }
            catch (Exception ex)
            {
                // 기타 예외를 처리하는 부분
                MessageBox.Show($"예외 발생: {ex.Message}");
            }
        }



        //----AUTO 실행버튼----//  */
            private async void Auto_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Y 축 이동 명령 실행
                string Command_spd = "SPD ," + SpeedY_time1_textbox.Text;
                byte[] Query_Speed = GoProtocol.Command_Protocol(Command_spd);
                GoSerial.SendSerialComm(Query_Speed, Query_Speed.Length);

                string Command_str = "PIC ," + PIC_Y_Textbox.Text;
                byte[] Query_Command = GoProtocol.Command_Protocol(Command_str);
                GoSerial.SendSerialComm(Query_Command, Query_Command.Length);

                // 1초간 대기
                await Task.Delay(TimeSpan.FromSeconds(double.Parse(PIC_Y_Textbox.Text) / (double.Parse(SpeedY_time1_textbox.Text)*10)) + TimeSpan.FromSeconds(double.Parse(suspand_time1_textbox.Text))); // 1초 대기

                // X 축 이동 명령 실행
                Command_spd = "SPD " + SpeedX_Textbox.Text;
                Query_Speed = GoProtocol.Command_Protocol(Command_spd);
                GoSerial.SendSerialComm(Query_Speed, Query_Speed.Length);

                Command_str = "PIC " + PIC_X_Textbox.Text;
                Query_Command = GoProtocol.Command_Protocol(Command_str);
                GoSerial.SendSerialComm(Query_Command, Query_Command.Length);

                // 1초간 대기
                await Task.Delay(TimeSpan.FromSeconds(double.Parse(PIC_X_Textbox.Text) / (double.Parse(SpeedX_Textbox.Text) *10)) + TimeSpan.FromSeconds(double.Parse(suspand_time2_textbox.Text))); // 1초 대기

                // Y 축 이동 명령 실행 (다시)
                Command_spd = "SPD ," + SpeedY_time2_textbox.Text;
                Query_Speed = GoProtocol.Command_Protocol(Command_spd);
                GoSerial.SendSerialComm(Query_Speed, Query_Speed.Length);

                Command_str = "PIC ,-" + PIC_Y_Textbox.Text;
                Query_Command = GoProtocol.Command_Protocol(Command_str);
                GoSerial.SendSerialComm(Query_Command, Query_Command.Length);

                // 1초간 대기
                await Task.Delay(TimeSpan.FromSeconds(double.Parse(PIC_Y_Textbox.Text) / (double.Parse(SpeedY_time2_textbox.Text)*10)) + TimeSpan.FromSeconds(1)); // 1초 대기
            }
            catch (FormatException ex)
            {
                // 변환 중 예외 처리
                Console.WriteLine("입력 형식이 잘못되었습니다.");
            }
            catch (Exception ex)
            {
                // 다른 예외 처리
                Console.WriteLine("오류가 발생했습니다: " + ex.Message);
            }
        }






       
    }
    //ㅇㄴㅇㄴㅁㅇㅁㅁㄴㅁㅇ






}

