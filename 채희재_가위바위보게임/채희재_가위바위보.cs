using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework1;  //dll파일의 네임스페이스 이름

namespace 채희재_가위바위보게임
{
    public partial class 채희재_가위바위보 : Form
    {
        public 채희재_가위바위보()
        {
            InitializeComponent();
        }

        bool result_view;
        int User_count = 0, Com_count = 0,Draw_count=0; //내가 승, 내가 패, 비김 수
        int User_S = 0,User_R=0,User_P=0;  //나의 가위 바위 보 수
        int Com_S = 0, Com_R = 0, Com_P = 0;  //컴의 가위 바위 보 수

        private void btn_View_Result_Click(object sender, EventArgs e)
        {
            Timer_View_Result.Start();

            lb_Me_Score.Text = "내가 이긴 횟수:" + Convert.ToString(User_count);  //내가 이긴 횟수 출력
            lb_Com_Score.Text = "컴이 이긴 횟수:" + Convert.ToString(Com_count);   //컴이 이긴 횟수 출력
            lb_Draw_Score.Text = "비긴 횟수:" + Convert.ToString(Draw_count);  //비긴 횟수 출력
           
            int total = User_count + Com_count + Draw_count;  //총 게임수 계산
            
            lb_Total_Count.Text = "총 게임 횟수:" + Convert.ToString(total);  //총게임수 출력


            lb_Com_S.Text ="가위 수: "+ Convert.ToString(Com_S);  //컴의 가위수 출력
            lb_Com_R.Text = "바위 수: " + Convert.ToString(Com_R); //컴의 바위수 출력
            lb_Com_P.Text = "보 수:" + Convert.ToString(Com_P);  //컴의 보의수 출력

            lb_Me_S.Text = "가위 수: " + Convert.ToString(User_S);  //나의 가위수 출력
            lb_Me_R.Text = "바위 수: " + Convert.ToString(User_R); //나의 바위 수 출력
            lb_Me_P.Text = "보 수: " + Convert.ToString(User_P); //나의 보의 수 출력


        }

        private void Timer_View_Result_Tick(object sender, EventArgs e)
        {
            int size = 20;  
            if(!result_view)
            {
                if(Width>=MaximumSize.Width)
                {
                    Width = MaximumSize.Width;
                    result_view = true;
                    btn_View_Result.Text = "결과 접기<";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width += size;
                }
            }
            else
            {
                if (Width <= MinimumSize.Width)
                {
                    Width = MinimumSize.Width;
                    result_view = false;
                    btn_View_Result.Text = "결과 보기>";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width -= size;
                }
            }
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            int my_num = 1;  //가위
            User_S += 1;  //나의 가위수 1증가
            pictureBox2.ImageLocation = "Images/gawei.jpg";
            Random su = new Random();   
            int com_num = su.Next(1, 4);  //컴퓨터의 랜덤 가위 바위 보 설정
            string ss=check.check_w(my_num, com_num);  //나와 컴퓨터중 누가 이겼는지 를 변수 ss에 저장. 가위바위보dll사용
             
            if (ss== "내가 승")
            {
                label3.Text = "내가 승"; //결과에 내가 승 출력
                User_count++;  //내가 이긴 총 횟수 1증가
            }
            else if(ss == "내가 패")
            {
                label3.Text = "내가 패"; //결과에 내가 패 출력
                Com_count++;  //컴이 이긴 총 횟수 1증가
            }
            else
            {
                label3.Text = "서로 비김";  //결과에 서로비김 출력
                Draw_count++;  //서로비긴 총 횟수 1증가

            }

            if (com_num == 1)  //컴이 가위를 냈다면
            {
                pictureBox1.ImageLocation = "Images/gawei.jpg";
                Com_S++;   //컴의 가위수 1증가 
            }
            else if (com_num == 2) //컴이 바위를 냈다면
            {
                pictureBox1.ImageLocation = "Images/bawei.jpg";
                Com_R++;  //컴의 바위수 1증가 
            }
            else  //컴이 보를 냈다면
            {
                pictureBox1.ImageLocation = "Images/bo.jpg";
                Com_P++;  //컴의 보 수 1증가
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int my_num = 2;  //바위를 선택
            User_R += 1;  //나의 바위수 1증가
            pictureBox2.ImageLocation = "Images/bawei.jpg";
            Random su = new Random();
            int com_num = su.Next(1, 4);  //컴퓨터의 랜덤 가위 바위 보 설정
            string ss=check.check_w(my_num, com_num);  //나와 컴퓨터중 누가 이겼는지 를 변수 ss에 저장. 가위바위보dll사용
             
            if (ss== "내가 승")
            {
                label3.Text = "내가 승"; //결과에 내가 승 출력
                User_count++;  //내가 이긴 총 횟수 1증가
            }
            else if(ss == "내가 패")
            {
                label3.Text = "내가 패"; //결과에 내가 패 출력
                Com_count++;  //컴이 이긴 총 횟수 1증가
            }
            else
            {
                label3.Text = "서로 비김";  //결과에 서로비김 출력
                Draw_count++;  //서로비긴 총 횟수 1증가

            }
            if (com_num == 1)  //컴이 가위를 냈다면
            {
                pictureBox1.ImageLocation = "Images/gawei.jpg";
                Com_S++;   //컴의 가위수 1증가 
            }
            else if (com_num == 2) //컴이 바위를 냈다면
            {
                pictureBox1.ImageLocation = "Images/bawei.jpg";
                Com_R++;  //컴의 바위수 1증가 
            }
            else  //컴이 보를 냈다면
            {
                pictureBox1.ImageLocation = "Images/bo.jpg";
                Com_P++;  //컴의 보 수 1증가
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int my_num = 3; //보를 선택
            User_P += 1;  //나의 보 수 1증가
            pictureBox2.ImageLocation = "Images/bo.jpg";
            Random su = new Random();
            int com_num = su.Next(1, 4);  //컴퓨터의 랜덤 가위 바위 보 설정
            string ss = check.check_w(my_num, com_num);  //나와 컴퓨터중 누가 이겼는지 를 변수 ss에 저장. 가위바위보dll사용

            if (ss == "내가 승")
            {
                label3.Text = "내가 승"; //결과에 내가 승 출력
                User_count++;  //내가 이긴 총 횟수 1증가
            }
            else if (ss == "내가 패")
            {
                label3.Text = "내가 패"; //결과에 내가 패 출력
                Com_count++;  //컴이 이긴 총 횟수 1증가
            }
            else
            {
                label3.Text = "서로 비김";  //결과에 서로비김 출력
                Draw_count++;  //서로비긴 총 횟수 1증가

            }
            if (com_num == 1)  //컴이 가위를 냈다면
            {
                pictureBox1.ImageLocation = "Images/gawei.jpg";
                Com_S++;   //컴의 가위수 1증가 
            }
            else if (com_num == 2) //컴이 바위를 냈다면
            {
                pictureBox1.ImageLocation = "Images/bawei.jpg";
                Com_R++;  //컴의 바위수 1증가 
            }
            else  //컴이 보를 냈다면
            {
                pictureBox1.ImageLocation = "Images/bo.jpg";
                Com_P++;  //컴의 보의 수 1증가
            }
        }
    }
   

}