
namespace PMC_2HS_Sample_Program_KOR
{
    partial class POS_Char1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button Clear_Pos_btn;
            System.Windows.Forms.Button Rest_btn;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Baud_CB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Port_CB = new System.Windows.Forms.ComboBox();
            this.PIC_START_btn = new System.Windows.Forms.Button();
            this.PAB_START_btn = new System.Windows.Forms.Button();
            this.PIC_Y_Textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PIC_X_Textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PAB_Y_Textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PAB_X_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SpeedY_Textbox = new System.Windows.Forms.TextBox();
            this.SpeedX_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AxisList = new System.Windows.Forms.ComboBox();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.PortStateTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GetposTextbox_Y = new System.Windows.Forms.TextBox();
            this.CW_btn = new System.Windows.Forms.Button();
            this.CCW_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Open_Btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GetposTextbox_X = new System.Windows.Forms.TextBox();
            this.Get_Pos_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Command_Textbox = new System.Windows.Forms.TextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.TimeX_Textbox = new System.Windows.Forms.TextBox();
            this.TimeY_Textbox = new System.Windows.Forms.TextBox();
            this.Auto_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTimeX = new System.Windows.Forms.Label();
            this.labelTimeY = new System.Windows.Forms.Label();
            this.Response_Textbox = new System.Windows.Forms.TextBox();
            this.POS_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Clear_Pos_btn = new System.Windows.Forms.Button();
            Rest_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.POS_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Clear_Pos_btn
            // 
            Clear_Pos_btn.Location = new System.Drawing.Point(573, 462);
            Clear_Pos_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Clear_Pos_btn.Name = "Clear_Pos_btn";
            Clear_Pos_btn.Size = new System.Drawing.Size(86, 29);
            Clear_Pos_btn.TabIndex = 49;
            Clear_Pos_btn.Text = "Clear Pos ";
            Clear_Pos_btn.UseVisualStyleBackColor = true;
            Clear_Pos_btn.Click += new System.EventHandler(this.Clear_Pos_btn_Click);
            // 
            // Rest_btn
            // 
            Rest_btn.Location = new System.Drawing.Point(573, 246);
            Rest_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Rest_btn.Name = "Rest_btn";
            Rest_btn.Size = new System.Drawing.Size(86, 29);
            Rest_btn.TabIndex = 44;
            Rest_btn.Text = "Reset";
            Rest_btn.UseVisualStyleBackColor = true;
            Rest_btn.Click += new System.EventHandler(this.Rest_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(22, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 70;
            this.label12.Text = "Axis List";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(149, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(517, 34);
            this.label11.TabIndex = 69;
            this.label11.Text = "<PMC-2HS Sample Program>";
            // 
            // Baud_CB
            // 
            this.Baud_CB.FormattingEnabled = true;
            this.Baud_CB.Location = new System.Drawing.Point(261, 95);
            this.Baud_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Baud_CB.Name = "Baud_CB";
            this.Baud_CB.Size = new System.Drawing.Size(101, 23);
            this.Baud_CB.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(186, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 67;
            this.label10.Text = "Baud :";
            // 
            // Port_CB
            // 
            this.Port_CB.FormattingEnabled = true;
            this.Port_CB.Location = new System.Drawing.Point(75, 95);
            this.Port_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Port_CB.Name = "Port_CB";
            this.Port_CB.Size = new System.Drawing.Size(101, 23);
            this.Port_CB.TabIndex = 66;
            // 
            // PIC_START_btn
            // 
            this.PIC_START_btn.Location = new System.Drawing.Point(480, 382);
            this.PIC_START_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_START_btn.Name = "PIC_START_btn";
            this.PIC_START_btn.Size = new System.Drawing.Size(86, 29);
            this.PIC_START_btn.TabIndex = 64;
            this.PIC_START_btn.Text = "PIC Start";
            this.PIC_START_btn.UseVisualStyleBackColor = true;
            this.PIC_START_btn.Click += new System.EventHandler(this.PIC_START_btn_Click);
            // 
            // PAB_START_btn
            // 
            this.PAB_START_btn.Location = new System.Drawing.Point(480, 302);
            this.PAB_START_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PAB_START_btn.Name = "PAB_START_btn";
            this.PAB_START_btn.Size = new System.Drawing.Size(86, 29);
            this.PAB_START_btn.TabIndex = 65;
            this.PAB_START_btn.Text = "PAB Start";
            this.PAB_START_btn.UseVisualStyleBackColor = true;
            this.PAB_START_btn.Click += new System.EventHandler(this.PAB_START_btn_Click);
            // 
            // PIC_Y_Textbox
            // 
            this.PIC_Y_Textbox.Location = new System.Drawing.Point(360, 382);
            this.PIC_Y_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_Y_Textbox.Name = "PIC_Y_Textbox";
            this.PIC_Y_Textbox.Size = new System.Drawing.Size(114, 25);
            this.PIC_Y_Textbox.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 62;
            this.label7.Text = "Y PIC PULSE";
            // 
            // PIC_X_Textbox
            // 
            this.PIC_X_Textbox.Location = new System.Drawing.Point(119, 382);
            this.PIC_X_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_X_Textbox.Name = "PIC_X_Textbox";
            this.PIC_X_Textbox.Size = new System.Drawing.Size(114, 25);
            this.PIC_X_Textbox.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 60;
            this.label8.Text = "X PIC PULSE";
            // 
            // PAB_Y_Textbox
            // 
            this.PAB_Y_Textbox.Location = new System.Drawing.Point(360, 302);
            this.PAB_Y_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PAB_Y_Textbox.Name = "PAB_Y_Textbox";
            this.PAB_Y_Textbox.Size = new System.Drawing.Size(114, 25);
            this.PAB_Y_Textbox.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 58;
            this.label6.Text = "Y PAB PULSE";
            // 
            // PAB_X_Textbox
            // 
            this.PAB_X_Textbox.Location = new System.Drawing.Point(119, 302);
            this.PAB_X_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PAB_X_Textbox.Name = "PAB_X_Textbox";
            this.PAB_X_Textbox.Size = new System.Drawing.Size(114, 25);
            this.PAB_X_Textbox.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "X PAB PULSE";
            // 
            // SpeedY_Textbox
            // 
            this.SpeedY_Textbox.Location = new System.Drawing.Point(360, 210);
            this.SpeedY_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpeedY_Textbox.Name = "SpeedY_Textbox";
            this.SpeedY_Textbox.Size = new System.Drawing.Size(114, 25);
            this.SpeedY_Textbox.TabIndex = 55;
            // 
            // SpeedX_Textbox
            // 
            this.SpeedX_Textbox.Location = new System.Drawing.Point(119, 210);
            this.SpeedX_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpeedX_Textbox.Name = "SpeedX_Textbox";
            this.SpeedX_Textbox.Size = new System.Drawing.Size(114, 25);
            this.SpeedX_Textbox.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "Y Drive Speed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(9, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 51;
            this.label9.Text = "Port :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "X Drive Speed";
            // 
            // AxisList
            // 
            this.AxisList.FormattingEnabled = true;
            this.AxisList.Location = new System.Drawing.Point(119, 166);
            this.AxisList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AxisList.Name = "AxisList";
            this.AxisList.Size = new System.Drawing.Size(85, 23);
            this.AxisList.TabIndex = 50;
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(573, 210);
            this.Stop_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(86, 29);
            this.Stop_btn.TabIndex = 48;
            this.Stop_btn.Text = "STOP";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // PortStateTextbox
            // 
            this.PortStateTextbox.Location = new System.Drawing.Point(561, 95);
            this.PortStateTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortStateTextbox.Name = "PortStateTextbox";
            this.PortStateTextbox.ReadOnly = true;
            this.PortStateTextbox.Size = new System.Drawing.Size(186, 25);
            this.PortStateTextbox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Y Current POS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "X Current POS";
            // 
            // GetposTextbox_Y
            // 
            this.GetposTextbox_Y.Location = new System.Drawing.Point(360, 462);
            this.GetposTextbox_Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetposTextbox_Y.Name = "GetposTextbox_Y";
            this.GetposTextbox_Y.ReadOnly = true;
            this.GetposTextbox_Y.Size = new System.Drawing.Size(114, 25);
            this.GetposTextbox_Y.TabIndex = 43;
            // 
            // CW_btn
            // 
            this.CW_btn.Location = new System.Drawing.Point(665, 210);
            this.CW_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CW_btn.Name = "CW_btn";
            this.CW_btn.Size = new System.Drawing.Size(86, 29);
            this.CW_btn.TabIndex = 40;
            this.CW_btn.Text = "CW";
            this.CW_btn.UseVisualStyleBackColor = true;
            this.CW_btn.Click += new System.EventHandler(this.CW_btn_Click);
            // 
            // CCW_btn
            // 
            this.CCW_btn.Location = new System.Drawing.Point(480, 210);
            this.CCW_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CCW_btn.Name = "CCW_btn";
            this.CCW_btn.Size = new System.Drawing.Size(86, 29);
            this.CCW_btn.TabIndex = 39;
            this.CCW_btn.Text = "CCW";
            this.CCW_btn.UseVisualStyleBackColor = true;
            this.CCW_btn.Click += new System.EventHandler(this.CCW_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(466, 94);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(86, 29);
            this.Close_btn.TabIndex = 38;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Open_Btn
            // 
            this.Open_Btn.Location = new System.Drawing.Point(371, 94);
            this.Open_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Open_Btn.Name = "Open_Btn";
            this.Open_Btn.Size = new System.Drawing.Size(86, 29);
            this.Open_Btn.TabIndex = 37;
            this.Open_Btn.Text = "OPEN";
            this.Open_Btn.UseVisualStyleBackColor = true;
            this.Open_Btn.Click += new System.EventHandler(this.Open_Btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GetposTextbox_X
            // 
            this.GetposTextbox_X.Location = new System.Drawing.Point(119, 462);
            this.GetposTextbox_X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetposTextbox_X.Name = "GetposTextbox_X";
            this.GetposTextbox_X.ReadOnly = true;
            this.GetposTextbox_X.Size = new System.Drawing.Size(114, 25);
            this.GetposTextbox_X.TabIndex = 42;
            // 
            // Get_Pos_btn
            // 
            this.Get_Pos_btn.Location = new System.Drawing.Point(480, 462);
            this.Get_Pos_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Get_Pos_btn.Name = "Get_Pos_btn";
            this.Get_Pos_btn.Size = new System.Drawing.Size(86, 29);
            this.Get_Pos_btn.TabIndex = 41;
            this.Get_Pos_btn.Text = "Get Pos";
            this.Get_Pos_btn.UseVisualStyleBackColor = true;
            this.Get_Pos_btn.Click += new System.EventHandler(this.Get_Pos_btn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 534);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 71;
            this.label13.Text = "Command";
            // 
            // Command_Textbox
            // 
            this.Command_Textbox.Location = new System.Drawing.Point(103, 621);
            this.Command_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Command_Textbox.Name = "Command_Textbox";
            this.Command_Textbox.Size = new System.Drawing.Size(555, 25);
            this.Command_Textbox.TabIndex = 72;
            // 
            // Send_btn
            // 
            this.Send_btn.Location = new System.Drawing.Point(665, 521);
            this.Send_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(86, 31);
            this.Send_btn.TabIndex = 73;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = true;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // TimeX_Textbox
            // 
            this.TimeX_Textbox.Location = new System.Drawing.Point(310, 516);
            this.TimeX_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeX_Textbox.Name = "TimeX_Textbox";
            this.TimeX_Textbox.Size = new System.Drawing.Size(164, 25);
            this.TimeX_Textbox.TabIndex = 76;
            // 
            // TimeY_Textbox
            // 
            this.TimeY_Textbox.Location = new System.Drawing.Point(310, 551);
            this.TimeY_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeY_Textbox.Name = "TimeY_Textbox";
            this.TimeY_Textbox.Size = new System.Drawing.Size(164, 25);
            this.TimeY_Textbox.TabIndex = 77;
            // 
            // Auto_btn
            // 
            this.Auto_btn.Location = new System.Drawing.Point(573, 522);
            this.Auto_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Auto_btn.Name = "Auto_btn";
            this.Auto_btn.Size = new System.Drawing.Size(86, 29);
            this.Auto_btn.TabIndex = 78;
            this.Auto_btn.Text = "Auto";
            this.Auto_btn.UseVisualStyleBackColor = true;
            this.Auto_btn.Click += new System.EventHandler(this.Auto_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 575);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 15);
            this.label14.TabIndex = 71;
            this.label14.Text = "Response";
            // 
            // labelTimeX
            // 
            this.labelTimeX.AutoSize = true;
            this.labelTimeX.Location = new System.Drawing.Point(250, 519);
            this.labelTimeX.Name = "labelTimeX";
            this.labelTimeX.Size = new System.Drawing.Size(56, 15);
            this.labelTimeX.TabIndex = 78;
            this.labelTimeX.Text = "Time X:";
            // 
            // labelTimeY
            // 
            this.labelTimeY.AutoSize = true;
            this.labelTimeY.Location = new System.Drawing.Point(250, 551);
            this.labelTimeY.Name = "labelTimeY";
            this.labelTimeY.Size = new System.Drawing.Size(55, 15);
            this.labelTimeY.TabIndex = 79;
            this.labelTimeY.Text = "Time Y:";
            // 
            // Response_Textbox
            // 
            this.Response_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.Response_Textbox.Location = new System.Drawing.Point(103, 584);
            this.Response_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Response_Textbox.Name = "Response_Textbox";
            this.Response_Textbox.Size = new System.Drawing.Size(555, 25);
            this.Response_Textbox.TabIndex = 74;
            // 
            // POS_Chart
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AlignmentStyle = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Cursor)));
            chartArea1.BorderColor = System.Drawing.Color.DarkRed;
            chartArea1.Name = "ChartArea1";
            this.POS_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.POS_Chart.Legends.Add(legend1);
            this.POS_Chart.Location = new System.Drawing.Point(789, 43);
            this.POS_Chart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.POS_Chart.Name = "POS_Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "POS";
            series1.YValuesPerPoint = 2;
            this.POS_Chart.Series.Add(series1);
            this.POS_Chart.Size = new System.Drawing.Size(738, 601);
            this.POS_Chart.TabIndex = 75;
            this.POS_Chart.Text = "chart1";
            // 
            // POS_Char1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 659);
            this.Controls.Add(this.POS_Chart);
            this.Controls.Add(this.Response_Textbox);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.Command_Textbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Baud_CB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Port_CB);
            this.Controls.Add(this.PIC_START_btn);
            this.Controls.Add(this.PAB_START_btn);
            this.Controls.Add(this.PIC_Y_Textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PIC_X_Textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PAB_Y_Textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PAB_X_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SpeedY_Textbox);
            this.Controls.Add(this.SpeedX_Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AxisList);
            this.Controls.Add(Clear_Pos_btn);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.PortStateTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(Rest_btn);
            this.Controls.Add(this.GetposTextbox_Y);
            this.Controls.Add(this.CW_btn);
            this.Controls.Add(this.CCW_btn);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Open_Btn);
            this.Controls.Add(this.GetposTextbox_X);
            this.Controls.Add(this.Get_Pos_btn);
            this.Controls.Add(this.TimeX_Textbox);
            this.Controls.Add(this.TimeY_Textbox);
            this.Controls.Add(this.labelTimeX);
            this.Controls.Add(this.labelTimeY);
            this.Controls.Add(this.Auto_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "POS_Char1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.POS_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Baud_CB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Port_CB;
        private System.Windows.Forms.Button PIC_START_btn;
        private System.Windows.Forms.Button PAB_START_btn;
        private System.Windows.Forms.TextBox PIC_Y_Textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PIC_X_Textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PAB_Y_Textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PAB_X_Textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SpeedY_Textbox;
        private System.Windows.Forms.TextBox SpeedX_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AxisList;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.TextBox PortStateTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GetposTextbox_Y;
        private System.Windows.Forms.Button CW_btn;
        private System.Windows.Forms.Button CCW_btn;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button Open_Btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox GetposTextbox_X;
        private System.Windows.Forms.Button Get_Pos_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Command_Textbox;
        private System.Windows.Forms.Button Send_btn;
        private System.Windows.Forms.Button Auto_btn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTimeY;
        private System.Windows.Forms.Label labelTimeX;
        private System.Windows.Forms.TextBox TimeX_Textbox; 
        private System.Windows.Forms.TextBox TimeY_Textbox;
        private System.Windows.Forms.TextBox Response_Textbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart POS_Chart;
    }
}

