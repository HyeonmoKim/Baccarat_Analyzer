using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class home : Form
    {

        public int start_price = 0;
        public int first_bet_price = 0;
        public int banker_royal = 0;
        public bool is_analyzed = false;

        public string winner = null;
        public string bet_selected = null;

        public bool is_ai_on = false;
        public bool is_sd_on = false;


        public int current_price = 0;
        public int bet_price = 0;
        public int bet_after_price = 0;

        public int fail_num = 0;

        public home()
        {
            InitializeComponent();
            this.Control_Panel.Visible = false;
            this.Choice_Win_Panel.Visible = false;
            this.Result_Panel.Visible = false;

        }



       

        private void Reset_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("처음 설정 금액으로 리셋하였습니다.", "알림");
            do_reset();
        }

        //플레이어배팅
        private void Bet_player_Click(object sender, EventArgs e)
        {
            this.bet_player.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bet_banker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            bet_selected = "player";
        }

        //뱅커 배팅
        private void Bet_banker_Click(object sender, EventArgs e)
        {
            this.bet_banker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bet_player.BorderStyle = System.Windows.Forms.BorderStyle.None;
            bet_selected = "banker";
        }

        //플레이어승리버튼
        private void Win_player_button_Click(object sender, EventArgs e)
        {
            this.win_player_button.BackColor = System.Drawing.Color.Ivory;
            this.win_banker_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.win_tie_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            winner = "player";
            string result = show_result(check_is_win());
            do_cal(result);
            update_control_panel("e");
        }
        //뱅커승리버튼
        private void Win_banker_button_Click(object sender, EventArgs e)
        {
            this.win_banker_button.BackColor = System.Drawing.Color.Ivory;
            this.win_player_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.win_tie_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            winner = "banker";
            string result = show_result(check_is_win());
            do_cal(result);
            update_control_panel("e");
            if (is_ai_on)
            {

            }
        }

        //타이 버튼
        private void Win_tie_button_Click(object sender, EventArgs e)
        {
            this.win_banker_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.win_player_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.win_tie_button.BackColor = System.Drawing.Color.Ivory;

            winner = "tie";
            string result = show_result(check_is_win());
            do_cal(result);
            update_control_panel("e");
        }

        //분석 버튼 클릭
        private void Analyzer_button_Click(object sender, EventArgs e)
        {

            if (is_analyzed)
            {
                DialogResult result = MessageBox.Show("이미 분석중입니다." +
                    "\n초기설정 금액을 변경하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {


                    try
                    {
                        start_price = Convert.ToInt32(this.textbox_start_price.Text);
                        first_bet_price = Convert.ToInt32(this.textbox_start_bet_price.Text);
                        banker_royal = Convert.ToInt32(this.textbox_banker_royal.Text);

                        if (start_price > 4200000000 | start_price <= 0)
                        {
                            throw new System.Exception();
                        }

                        if (start_price < first_bet_price | (first_bet_price > 4200000000 | first_bet_price <= 0))
                        {
                            throw new System.Exception();
                        }
                        if (banker_royal > 100 | banker_royal <= 0)
                        {
                            throw new System.Exception();

                        }
                        is_analyzed = true;

                        this.analyzer_button.Text = "재분석시작";

                        do_reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("입력 값이 잘 못 되었습니다." +
                            "\n====================" +
                            "\n 시작금액 : (0원~42억원)" +
                            "\n 배팅금액 : (0원~시작금액)" +
                            "\n 뱅커수수료 : (0%~100%)" +
                            "\n====================", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }

            //슈분석시작
            else
            {
                DialogResult result = MessageBox.Show("슈 분석을 시작하시겠습니까?", "슈 분석", MessageBoxButtons.YesNo);
                string err_msg = null;
                
                if (result == DialogResult.Yes) {


                    try {
                        start_price = Convert.ToInt32(this.textbox_start_price.Text);
                        first_bet_price = Convert.ToInt32(this.textbox_start_bet_price.Text);
                        banker_royal = Convert.ToInt32(this.textbox_banker_royal.Text);

                        if (start_price > 4200000000 | start_price <= 0)
                        {
                            throw new System.Exception();
                        }

                        if (start_price < first_bet_price | (first_bet_price > 4200000000 | first_bet_price <= 0))
                        {
                            throw new System.Exception();
                        }
                        if (banker_royal > 100 | banker_royal <= 0)
                        {
                            throw new System.Exception();

                        }
                        is_analyzed = true;
                        this.Control_Panel.Visible = true;
                        this.Choice_Win_Panel.Visible = true;
                        this.Result_Panel.Visible = true;

                        this.analyzer_button.Text = "재분석시작";

                        do_reset();
                    } catch (Exception ex)
                    {
                        MessageBox.Show("입력 값이 잘 못 되었습니다." +
                            "\n====================" +
                            "\n 시작금액 : (0원~42억원)" +
                            "\n 배팅금액 : (0원~시작금액)" +
                            "\n 뱅커수수료 : (0%~100%)" +
                            "\n====================", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }


        }

        //////UDF
        //위너 체크
        private string check_is_win()
        {
            if (winner == bet_selected)
            {
                return "s"; //success
            }
            else if ((winner != bet_selected) & (winner != null & bet_selected != null))
            {
                return "f"; // fail
            }
            else
            {
                return "e"; // error
            }
        }

        //결과 버튼클릭시
        private string show_result(string type)
        {
            if (type == "s") //success
            {
                update_control_panel("e");
                MessageBox.Show("적중 하였습니다.", "결과");
                ai_pick_update();
                return "s"; //success
            }
            else if (type == "f") {//fail
                MessageBox.Show("적중하지 못하였습니다.", "결과");
                ai_pick_update();
                return "f"; // fail
            }
            else {//error
                MessageBox.Show("배팅방향을 확인하여주세요.", "결과", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "e"; // error
            }
        }

        //리셋
        private void do_reset()
        {

            current_price = start_price;
            bet_price = first_bet_price;
            bet_after_price = start_price - first_bet_price;
            fail_num = 0;
            update_control_panel("f");
        }

        //컨트롤 패널 view 업데이트
        private void update_control_panel(string s)
        {

            if (s == "f")// 슈분석 첫 시작 or reset
            {
                this.label_current_price.Text = Convert.ToString(String.Format("{0:#,###}", current_price));
                this.label_bet_price.Text = Convert.ToString(String.Format("{0:#,###}", bet_price));
                this.label_bet_after_price.Text = Convert.ToString(String.Format("{0:#,###}", bet_after_price));
                this.label_how_much.Text = Convert.ToString(String.Format("{0:#,###}", bet_price));
            }
            else if (s == "e")  //else update
            {
                this.label_current_price.Text = Convert.ToString(String.Format("{0:#,###}", current_price));
                this.label_bet_price.Text = Convert.ToString(String.Format("{0:#,###}", bet_price));
                this.label_bet_after_price.Text = Convert.ToString(String.Format("{0:#,###}", bet_after_price));
                this.label_how_much.Text = Convert.ToString(String.Format("{0:#,###}", bet_price));
            }
        }
        private void do_cal(string type)
        {
            if (type == "s") //success
            {
                fail_num = 0;
                if (winner == "player")
                {
                    current_price = current_price + bet_price;
                    bet_price = first_bet_price;
                    bet_after_price = current_price - bet_price;
                }
                else if (winner == "banker")
                {
                    current_price = current_price + bet_price * (100 - banker_royal) / 100;
                    bet_price = first_bet_price;
                    bet_after_price = current_price - bet_price;
                }


            }

            else if (type == "f")
            {//fail
                fail_num += 1;

                if (winner == "player")
                {
                    current_price = current_price - bet_price;
                    bet_price = bet_price * 2 + (first_bet_price / 4);
                    bet_after_price = current_price - bet_price;
                    check_sd(is_sd_on);
                }
                else if (winner == "banker")
                {
                    current_price = current_price - bet_price;
                    bet_price = bet_price * 2 + (first_bet_price / 4);
                    bet_after_price = current_price - bet_price;
                    check_sd(is_sd_on);
                }
                else if (winner == "tie")
                {
                    current_price = current_price;
                    bet_price = bet_price;
                    bet_after_price = current_price - bet_price;
                }
               
            }

            else if (type == "e")
            {//error
            }
        }
        private void ai_pick_update()
        {
            Random r = new Random();
            int random_num = 1;

            if (is_ai_on)
            {
                random_num = r.Next(1, 99);
                if (random_num % 2 == 0)
                {

                    this.label_ai_pick.Text = "플레이어에게 배팅하세요";
                    this.label_ai_pick.ForeColor = System.Drawing.Color.RoyalBlue;

                    this.bet_player.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    this.bet_banker.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    bet_selected = "player";
                }
                else
                {
                    this.label_ai_pick.Text = "뱅커에게 배팅하세요";
                    this.label_ai_pick.ForeColor = System.Drawing.Color.Firebrick;

                    this.bet_banker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    this.bet_player.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    bet_selected = "banker";
                }

            }
        }

        //ai on-off
        private void Radio_ai_on_CheckedChanged(object sender, EventArgs e)
        {

            is_ai_on = true;
            ai_pick_update();
            this.label_ai_pick.Visible = true;
        }

        private void Radio_ai_off_CheckedChanged(object sender, EventArgs e)
        {
            is_ai_on = false;
            this.label_ai_pick.Visible = false;
        }

        //연사 on-off
        private void Radio_sd_on_CheckedChanged(object sender, EventArgs e)
        {
            is_sd_on = true;
        }

        private void Radio_sd_off_CheckedChanged(object sender, EventArgs e)
        {
            fail_num = 0;
            is_sd_on = false;
        }

        private void check_sd(bool is_sd_on)
        {
            if (is_sd_on)
            {
                if (fail_num>2)
                {
                    MessageBox.Show("연사제어모드 작동" +
                        "\n패턴이 좋지 않습니다. 한 타임 쉬세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fail_num = 0;
                }
            }
        }
/*        private void db_connect()
        {

        }
        private void check_vaild()
        {

        }*/

    }
}
