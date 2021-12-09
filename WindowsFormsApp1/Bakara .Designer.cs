
using System.Drawing;

namespace WindowsFormsApp1
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Control_Panel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_sd_off = new System.Windows.Forms.RadioButton();
            this.radio_sd_on = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label_bet_after_price = new System.Windows.Forms.Label();
            this.배팅후금액 = new System.Windows.Forms.Label();
            this.label_bet_price = new System.Windows.Forms.Label();
            this.배팅할곳 = new System.Windows.Forms.Label();
            this.label_current_price = new System.Windows.Forms.Label();
            this.현재잔액 = new System.Windows.Forms.Label();
            this.배팅금액 = new System.Windows.Forms.Label();
            this.bet_player = new System.Windows.Forms.PictureBox();
            this.bet_banker = new System.Windows.Forms.PictureBox();
            this.Result_Panel = new System.Windows.Forms.Panel();
            this.label_ai_pick = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_ai_off = new System.Windows.Forms.RadioButton();
            this.radio_ai_on = new System.Windows.Forms.RadioButton();
            this.label_how_much = new System.Windows.Forms.Label();
            this.to_who = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.뱅커수수료 = new System.Windows.Forms.Label();
            this.textbox_banker_royal = new System.Windows.Forms.TextBox();
            this.시작배팅금액 = new System.Windows.Forms.Label();
            this.textbox_start_bet_price = new System.Windows.Forms.TextBox();
            this.초기게임설정 = new System.Windows.Forms.Label();
            this.analyzer_button = new System.Windows.Forms.Button();
            this.잔액 = new System.Windows.Forms.Label();
            this.textbox_start_price = new System.Windows.Forms.TextBox();
            this.Choice_Win_Panel = new System.Windows.Forms.Panel();
            this.win_tie_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.win_player_button = new System.Windows.Forms.Button();
            this.win_banker_button = new System.Windows.Forms.Button();
            this.Main_Panel.SuspendLayout();
            this.Control_Panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bet_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet_banker)).BeginInit();
            this.Result_Panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            this.Choice_Win_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.Main_Panel.Controls.Add(this.Control_Panel);
            this.Main_Panel.Controls.Add(this.Result_Panel);
            this.Main_Panel.Controls.Add(this.Header_Panel);
            this.Main_Panel.Controls.Add(this.Choice_Win_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(428, 461);
            this.Main_Panel.TabIndex = 1;
            // 
            // Control_Panel
            // 
            this.Control_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Control_Panel.Controls.Add(this.groupBox2);
            this.Control_Panel.Controls.Add(this.label1);
            this.Control_Panel.Controls.Add(this.label_bet_after_price);
            this.Control_Panel.Controls.Add(this.배팅후금액);
            this.Control_Panel.Controls.Add(this.label_bet_price);
            this.Control_Panel.Controls.Add(this.배팅할곳);
            this.Control_Panel.Controls.Add(this.label_current_price);
            this.Control_Panel.Controls.Add(this.현재잔액);
            this.Control_Panel.Controls.Add(this.배팅금액);
            this.Control_Panel.Controls.Add(this.bet_player);
            this.Control_Panel.Controls.Add(this.bet_banker);
            this.Control_Panel.Location = new System.Drawing.Point(0, 91);
            this.Control_Panel.Name = "Control_Panel";
            this.Control_Panel.Size = new System.Drawing.Size(428, 153);
            this.Control_Panel.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radio_sd_off);
            this.groupBox2.Controls.Add(this.radio_sd_on);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Location = new System.Drawing.Point(346, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(77, 54);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "연사 모드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "ON - OFF";
            // 
            // radio_sd_off
            // 
            this.radio_sd_off.AutoSize = true;
            this.radio_sd_off.Checked = true;
            this.radio_sd_off.Location = new System.Drawing.Point(45, 30);
            this.radio_sd_off.Name = "radio_sd_off";
            this.radio_sd_off.Size = new System.Drawing.Size(14, 13);
            this.radio_sd_off.TabIndex = 22;
            this.radio_sd_off.TabStop = true;
            this.radio_sd_off.UseVisualStyleBackColor = true;
            this.radio_sd_off.CheckedChanged += new System.EventHandler(this.Radio_sd_off_CheckedChanged);
            // 
            // radio_sd_on
            // 
            this.radio_sd_on.AutoSize = true;
            this.radio_sd_on.Location = new System.Drawing.Point(19, 30);
            this.radio_sd_on.Name = "radio_sd_on";
            this.radio_sd_on.Size = new System.Drawing.Size(14, 13);
            this.radio_sd_on.TabIndex = 20;
            this.radio_sd_on.UseVisualStyleBackColor = true;
            this.radio_sd_on.CheckedChanged += new System.EventHandler(this.Radio_sd_on_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "컨트롤 박스";
            // 
            // label_bet_after_price
            // 
            this.label_bet_after_price.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_bet_after_price.ForeColor = System.Drawing.Color.Red;
            this.label_bet_after_price.Location = new System.Drawing.Point(116, 117);
            this.label_bet_after_price.Name = "label_bet_after_price";
            this.label_bet_after_price.Size = new System.Drawing.Size(222, 23);
            this.label_bet_after_price.TabIndex = 13;
            this.label_bet_after_price.Text = "10000000";
            this.label_bet_after_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 배팅후금액
            // 
            this.배팅후금액.AutoSize = true;
            this.배팅후금액.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.배팅후금액.ForeColor = System.Drawing.Color.Red;
            this.배팅후금액.Location = new System.Drawing.Point(5, 120);
            this.배팅후금액.Name = "배팅후금액";
            this.배팅후금액.Size = new System.Drawing.Size(106, 19);
            this.배팅후금액.TabIndex = 12;
            this.배팅후금액.Text = "배팅 후 금액 \\";
            // 
            // label_bet_price
            // 
            this.label_bet_price.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_bet_price.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_bet_price.Location = new System.Drawing.Point(116, 94);
            this.label_bet_price.Name = "label_bet_price";
            this.label_bet_price.Size = new System.Drawing.Size(222, 23);
            this.label_bet_price.TabIndex = 11;
            this.label_bet_price.Text = "10000000";
            this.label_bet_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 배팅할곳
            // 
            this.배팅할곳.AutoSize = true;
            this.배팅할곳.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.배팅할곳.ForeColor = System.Drawing.Color.White;
            this.배팅할곳.Location = new System.Drawing.Point(22, 30);
            this.배팅할곳.Name = "배팅할곳";
            this.배팅할곳.Size = new System.Drawing.Size(101, 19);
            this.배팅할곳.TabIndex = 10;
            this.배팅할곳.Text = "배팅 방향 선택";
            // 
            // label_current_price
            // 
            this.label_current_price.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_current_price.ForeColor = System.Drawing.Color.White;
            this.label_current_price.Location = new System.Drawing.Point(116, 71);
            this.label_current_price.Name = "label_current_price";
            this.label_current_price.Size = new System.Drawing.Size(222, 23);
            this.label_current_price.TabIndex = 9;
            this.label_current_price.Text = "10000000";
            this.label_current_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 현재잔액
            // 
            this.현재잔액.AutoSize = true;
            this.현재잔액.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.현재잔액.ForeColor = System.Drawing.Color.White;
            this.현재잔액.Location = new System.Drawing.Point(22, 75);
            this.현재잔액.Name = "현재잔액";
            this.현재잔액.Size = new System.Drawing.Size(88, 19);
            this.현재잔액.TabIndex = 1;
            this.현재잔액.Text = "현재 잔액 \\";
            // 
            // 배팅금액
            // 
            this.배팅금액.AutoSize = true;
            this.배팅금액.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.배팅금액.ForeColor = System.Drawing.SystemColors.Highlight;
            this.배팅금액.Location = new System.Drawing.Point(22, 98);
            this.배팅금액.Name = "배팅금액";
            this.배팅금액.Size = new System.Drawing.Size(88, 19);
            this.배팅금액.TabIndex = 0;
            this.배팅금액.Text = "배팅 금액 \\";
            // 
            // bet_player
            // 
            this.bet_player.BackColor = System.Drawing.Color.Transparent;
            this.bet_player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_player.BackgroundImage")));
            this.bet_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bet_player.Location = new System.Drawing.Point(203, 6);
            this.bet_player.Name = "bet_player";
            this.bet_player.Size = new System.Drawing.Size(60, 60);
            this.bet_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bet_player.TabIndex = 4;
            this.bet_player.TabStop = false;
            this.bet_player.Click += new System.EventHandler(this.Bet_player_Click);
            // 
            // bet_banker
            // 
            this.bet_banker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_banker.BackgroundImage")));
            this.bet_banker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bet_banker.Location = new System.Drawing.Point(278, 6);
            this.bet_banker.Name = "bet_banker";
            this.bet_banker.Size = new System.Drawing.Size(60, 60);
            this.bet_banker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bet_banker.TabIndex = 5;
            this.bet_banker.TabStop = false;
            this.bet_banker.Click += new System.EventHandler(this.Bet_banker_Click);
            // 
            // Result_Panel
            // 
            this.Result_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Panel.Controls.Add(this.label_ai_pick);
            this.Result_Panel.Controls.Add(this.groupBox1);
            this.Result_Panel.Controls.Add(this.label_how_much);
            this.Result_Panel.Controls.Add(this.to_who);
            this.Result_Panel.Controls.Add(this.reset_button);
            this.Result_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Result_Panel.Location = new System.Drawing.Point(0, 327);
            this.Result_Panel.Name = "Result_Panel";
            this.Result_Panel.Size = new System.Drawing.Size(428, 134);
            this.Result_Panel.TabIndex = 2;
            // 
            // label_ai_pick
            // 
            this.label_ai_pick.AutoSize = true;
            this.label_ai_pick.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_ai_pick.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_ai_pick.Location = new System.Drawing.Point(5, 63);
            this.label_ai_pick.Name = "label_ai_pick";
            this.label_ai_pick.Size = new System.Drawing.Size(167, 19);
            this.label_ai_pick.TabIndex = 21;
            this.label_ai_pick.Text = "플레이어에게 배팅하세요";
            this.label_ai_pick.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radio_ai_off);
            this.groupBox1.Controls.Add(this.radio_ai_on);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(26, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 54);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AI 픽 모드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(30, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "ON - OFF";
            // 
            // radio_ai_off
            // 
            this.radio_ai_off.AutoSize = true;
            this.radio_ai_off.Checked = true;
            this.radio_ai_off.Location = new System.Drawing.Point(58, 30);
            this.radio_ai_off.Name = "radio_ai_off";
            this.radio_ai_off.Size = new System.Drawing.Size(14, 13);
            this.radio_ai_off.TabIndex = 22;
            this.radio_ai_off.TabStop = true;
            this.radio_ai_off.UseVisualStyleBackColor = true;
            this.radio_ai_off.CheckedChanged += new System.EventHandler(this.Radio_ai_off_CheckedChanged);
            // 
            // radio_ai_on
            // 
            this.radio_ai_on.AutoSize = true;
            this.radio_ai_on.Location = new System.Drawing.Point(32, 30);
            this.radio_ai_on.Name = "radio_ai_on";
            this.radio_ai_on.Size = new System.Drawing.Size(14, 13);
            this.radio_ai_on.TabIndex = 20;
            this.radio_ai_on.UseVisualStyleBackColor = true;
            this.radio_ai_on.CheckedChanged += new System.EventHandler(this.Radio_ai_on_CheckedChanged);
            // 
            // label_how_much
            // 
            this.label_how_much.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_how_much.ForeColor = System.Drawing.Color.SandyBrown;
            this.label_how_much.Location = new System.Drawing.Point(175, 40);
            this.label_how_much.Name = "label_how_much";
            this.label_how_much.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_how_much.Size = new System.Drawing.Size(180, 31);
            this.label_how_much.TabIndex = 19;
            this.label_how_much.Text = "50000";
            this.label_how_much.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // to_who
            // 
            this.to_who.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.to_who.ForeColor = System.Drawing.Color.White;
            this.to_who.Location = new System.Drawing.Point(159, 9);
            this.to_who.Name = "to_who";
            this.to_who.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.to_who.Size = new System.Drawing.Size(231, 31);
            this.to_who.TabIndex = 17;
            this.to_who.Text = "아래 금액을 배팅하세요";
            this.to_who.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset_button
            // 
            this.reset_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.reset_button.FlatAppearance.BorderSize = 2;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_button.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reset_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reset_button.Image = ((System.Drawing.Image)(resources.GetObject("reset_button.Image")));
            this.reset_button.Location = new System.Drawing.Point(212, 75);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(100, 46);
            this.reset_button.TabIndex = 4;
            this.reset_button.Text = "리셋";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Header_Panel
            // 
            this.Header_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Header_Panel.Controls.Add(this.label6);
            this.Header_Panel.Controls.Add(this.뱅커수수료);
            this.Header_Panel.Controls.Add(this.textbox_banker_royal);
            this.Header_Panel.Controls.Add(this.시작배팅금액);
            this.Header_Panel.Controls.Add(this.textbox_start_bet_price);
            this.Header_Panel.Controls.Add(this.초기게임설정);
            this.Header_Panel.Controls.Add(this.analyzer_button);
            this.Header_Panel.Controls.Add(this.잔액);
            this.Header_Panel.Controls.Add(this.textbox_start_price);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(428, 92);
            this.Header_Panel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(268, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "%";
            // 
            // 뱅커수수료
            // 
            this.뱅커수수료.AutoSize = true;
            this.뱅커수수료.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.뱅커수수료.ForeColor = System.Drawing.Color.White;
            this.뱅커수수료.Location = new System.Drawing.Point(160, 9);
            this.뱅커수수료.Name = "뱅커수수료";
            this.뱅커수수료.Size = new System.Drawing.Size(62, 14);
            this.뱅커수수료.TabIndex = 18;
            this.뱅커수수료.Text = "뱅커수수료";
            // 
            // textbox_banker_royal
            // 
            this.textbox_banker_royal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_banker_royal.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textbox_banker_royal.Location = new System.Drawing.Point(228, 5);
            this.textbox_banker_royal.Name = "textbox_banker_royal";
            this.textbox_banker_royal.Size = new System.Drawing.Size(34, 20);
            this.textbox_banker_royal.TabIndex = 17;
            this.textbox_banker_royal.Text = "5";
            this.textbox_banker_royal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 시작배팅금액
            // 
            this.시작배팅금액.AutoSize = true;
            this.시작배팅금액.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.시작배팅금액.ForeColor = System.Drawing.Color.White;
            this.시작배팅금액.Location = new System.Drawing.Point(6, 64);
            this.시작배팅금액.Name = "시작배팅금액";
            this.시작배팅금액.Size = new System.Drawing.Size(119, 19);
            this.시작배팅금액.TabIndex = 15;
            this.시작배팅금액.Text = "시작배팅금액 \\";
            // 
            // textbox_start_bet_price
            // 
            this.textbox_start_bet_price.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_start_bet_price.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textbox_start_bet_price.Location = new System.Drawing.Point(128, 63);
            this.textbox_start_bet_price.Name = "textbox_start_bet_price";
            this.textbox_start_bet_price.Size = new System.Drawing.Size(159, 22);
            this.textbox_start_bet_price.TabIndex = 16;
            this.textbox_start_bet_price.Text = "10000";
            // 
            // 초기게임설정
            // 
            this.초기게임설정.AutoSize = true;
            this.초기게임설정.BackColor = System.Drawing.Color.Transparent;
            this.초기게임설정.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.초기게임설정.ForeColor = System.Drawing.Color.DarkGray;
            this.초기게임설정.Location = new System.Drawing.Point(2, 8);
            this.초기게임설정.Name = "초기게임설정";
            this.초기게임설정.Size = new System.Drawing.Size(87, 15);
            this.초기게임설정.TabIndex = 13;
            this.초기게임설정.Text = "초기 게임 설정";
            // 
            // analyzer_button
            // 
            this.analyzer_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.analyzer_button.FlatAppearance.BorderSize = 2;
            this.analyzer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyzer_button.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.analyzer_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.analyzer_button.Image = ((System.Drawing.Image)(resources.GetObject("analyzer_button.Image")));
            this.analyzer_button.Location = new System.Drawing.Point(293, 31);
            this.analyzer_button.Name = "analyzer_button";
            this.analyzer_button.Size = new System.Drawing.Size(131, 53);
            this.analyzer_button.TabIndex = 2;
            this.analyzer_button.Text = "슈 분석 시작";
            this.analyzer_button.UseVisualStyleBackColor = true;
            this.analyzer_button.Click += new System.EventHandler(this.Analyzer_button_Click);
            // 
            // 잔액
            // 
            this.잔액.AutoSize = true;
            this.잔액.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.잔액.ForeColor = System.Drawing.Color.White;
            this.잔액.Location = new System.Drawing.Point(31, 34);
            this.잔액.Name = "잔액";
            this.잔액.Size = new System.Drawing.Size(59, 19);
            this.잔액.TabIndex = 2;
            this.잔액.Text = "잔액 \\";
            // 
            // textbox_start_price
            // 
            this.textbox_start_price.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_start_price.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textbox_start_price.Location = new System.Drawing.Point(128, 31);
            this.textbox_start_price.Name = "textbox_start_price";
            this.textbox_start_price.Size = new System.Drawing.Size(159, 22);
            this.textbox_start_price.TabIndex = 12;
            this.textbox_start_price.Text = "1000000";
            // 
            // Choice_Win_Panel
            // 
            this.Choice_Win_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Choice_Win_Panel.Controls.Add(this.win_tie_button);
            this.Choice_Win_Panel.Controls.Add(this.label3);
            this.Choice_Win_Panel.Controls.Add(this.win_player_button);
            this.Choice_Win_Panel.Controls.Add(this.win_banker_button);
            this.Choice_Win_Panel.Location = new System.Drawing.Point(0, 236);
            this.Choice_Win_Panel.Name = "Choice_Win_Panel";
            this.Choice_Win_Panel.Size = new System.Drawing.Size(428, 92);
            this.Choice_Win_Panel.TabIndex = 0;
            // 
            // win_tie_button
            // 
            this.win_tie_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.win_tie_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.win_tie_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.win_tie_button.FlatAppearance.BorderSize = 3;
            this.win_tie_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.win_tie_button.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.win_tie_button.ForeColor = System.Drawing.Color.Lime;
            this.win_tie_button.Location = new System.Drawing.Point(179, 27);
            this.win_tie_button.Name = "win_tie_button";
            this.win_tie_button.Size = new System.Drawing.Size(65, 55);
            this.win_tie_button.TabIndex = 15;
            this.win_tie_button.Text = "타이";
            this.win_tie_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.win_tie_button.UseVisualStyleBackColor = false;
            this.win_tie_button.Click += new System.EventHandler(this.Win_tie_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "결과 선택";
            // 
            // win_player_button
            // 
            this.win_player_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.win_player_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.win_player_button.FlatAppearance.BorderSize = 3;
            this.win_player_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.win_player_button.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.win_player_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.win_player_button.Image = ((System.Drawing.Image)(resources.GetObject("win_player_button.Image")));
            this.win_player_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.win_player_button.Location = new System.Drawing.Point(3, 27);
            this.win_player_button.Name = "win_player_button";
            this.win_player_button.Size = new System.Drawing.Size(162, 55);
            this.win_player_button.TabIndex = 1;
            this.win_player_button.Text = "플레이어 승";
            this.win_player_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.win_player_button.UseVisualStyleBackColor = false;
            this.win_player_button.Click += new System.EventHandler(this.Win_player_button_Click);
            // 
            // win_banker_button
            // 
            this.win_banker_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.win_banker_button.FlatAppearance.BorderSize = 3;
            this.win_banker_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.win_banker_button.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.win_banker_button.ForeColor = System.Drawing.Color.Firebrick;
            this.win_banker_button.Image = ((System.Drawing.Image)(resources.GetObject("win_banker_button.Image")));
            this.win_banker_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.win_banker_button.Location = new System.Drawing.Point(261, 27);
            this.win_banker_button.Name = "win_banker_button";
            this.win_banker_button.Size = new System.Drawing.Size(162, 55);
            this.win_banker_button.TabIndex = 0;
            this.win_banker_button.Text = "뱅커 승 ";
            this.win_banker_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.win_banker_button.UseVisualStyleBackColor = true;
            this.win_banker_button.Click += new System.EventHandler(this.Win_banker_button_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(428, 461);
            this.Controls.Add(this.Main_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.Text = "Bacarrat Analyzer Ver.1.1.2";
            this.Main_Panel.ResumeLayout(false);
            this.Control_Panel.ResumeLayout(false);
            this.Control_Panel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bet_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet_banker)).EndInit();
            this.Result_Panel.ResumeLayout(false);
            this.Result_Panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            this.Choice_Win_Panel.ResumeLayout(false);
            this.Choice_Win_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel Choice_Win_Panel;
        private System.Windows.Forms.Button win_player_button;
        private System.Windows.Forms.Button win_banker_button;
        private System.Windows.Forms.Button analyzer_button;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Panel Control_Panel;
        private System.Windows.Forms.Panel Result_Panel;
        private System.Windows.Forms.Label 배팅금액;
        private System.Windows.Forms.Label 잔액;
        private System.Windows.Forms.Label 현재잔액;
        private System.Windows.Forms.Label label_current_price;
        private System.Windows.Forms.TextBox textbox_start_price;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label to_who;
        private System.Windows.Forms.PictureBox bet_banker;
        private System.Windows.Forms.PictureBox bet_player;
        private System.Windows.Forms.Label 초기게임설정;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label 시작배팅금액;
        private System.Windows.Forms.TextBox textbox_start_bet_price;
        private System.Windows.Forms.Label 배팅할곳;
        private System.Windows.Forms.Label label_how_much;
        private System.Windows.Forms.TextBox textbox_banker_royal;
        private System.Windows.Forms.Label 뱅커수수료;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_bet_price;
        private System.Windows.Forms.Label label_bet_after_price;
        private System.Windows.Forms.Label 배팅후금액;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button win_tie_button;
        private System.Windows.Forms.RadioButton radio_ai_on;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_ai_off;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ai_pick;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_sd_off;
        private System.Windows.Forms.RadioButton radio_sd_on;
    }
}

