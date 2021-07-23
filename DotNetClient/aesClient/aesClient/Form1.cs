using EngineIOSharp.Common.Enum;
using Newtonsoft.Json.Linq;
using SocketIOSharp.Client;
using SocketIOSharp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aesClient
{
    public partial class Form1 : Form
    {

        SocketIOClient client;


        //시작 함수
        public Form1()
        {
            InitializeComponent();
            this.Text = "Chat";
            socketinit();
        }

        //소켓 연결
        public void socketinit() 
        {
            client = new SocketIOClient(new SocketIOClientOption(EngineIOScheme.http, "localhost",3000));
            InitEventHandlers(client);
            client.Connect();

        }

        //소켓 이벤트핸들러
         void InitEventHandlers(SocketIOClient client)
        {
            //연결 성공시
            client.On(SocketIOEvent.CONNECTION, () =>
            {
                //printConnected();
                Console.WriteLine("Connected!");
            });
            
            //연결 끊을시
            client.On(SocketIOEvent.DISCONNECT, () =>
            {
                Console.WriteLine();
                Console.WriteLine("Disconnected!");
            });

            //데이터 받기
            client.On("chat", (Data) =>
            {

                //Console.WriteLine("Echo : " + (Data[0].Type == JTokenType.Bytes ? BitConverter.ToString(Data[0].ToObject<byte[]>()) : Data[0]));
                string decMsg = crypthion('D', Data[0].ToString());

                txtBoxEncChat.Text += "WHO : " + Data[0] + "\r\n";
                txtBoxChat.Text += "WHO : " + decMsg;
                txtBoxChat.Text += "\r\n";

            });

            //client.On("test", (Data) =>
            //{
            //    Console.WriteLine("Echo1 : " + Data[0]);
            //    Console.WriteLine("Echo2 : " + Data[1]);
            //});
        }

        //connected 출력함수
        public void printConnected()
        {
            txtBoxChat.Text += "Connected!" + "\r\n";
        }

        //send 버튼 클릭시
        private void btnSend_Click(object sender, EventArgs e)
        {
            string Msg = msg.Text;
            string encMsg = crypthion('E', Msg);
            msg.Text = "";

            if (string.IsNullOrEmpty(Msg))
                return;

            //데이터 보내기
            client.Emit("chat", encMsg);

            txtBoxEncChat.Text += "ME : " + encMsg + "\r\n";
            txtBoxChat.Text += "ME : " + Msg + "\r\n";

            msg.Focus();
        }

        //암호화 복호화 프로세스 실행
        public string crypthion(char type, string txt)
        {
            System.Diagnostics.ProcessStartInfo proInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process pro = new System.Diagnostics.Process();

            proInfo.FileName = @"cmd";
            proInfo.CreateNoWindow = true;
            proInfo.UseShellExecute = false;
            proInfo.RedirectStandardOutput = true;
            proInfo.RedirectStandardInput = true;
            proInfo.RedirectStandardError = true;

            pro.StartInfo = proInfo;
            pro.Start();

            //CMD에 보낼 명령어를 입력
            pro.StandardInput.Write(@"cd D:" + Environment.NewLine); //경로 설정
            pro.StandardInput.Write(@"cd D:\\바탕화면의_라이브러리\\Desktop\\miracl_aes_chat\\cryptionC\\AES\\x64\\Debug" + Environment.NewLine); //경로 설정

            if(type == 'E')
                pro.StandardInput.Write(@"AES.exe E " + "\"" + txt + "\"" + Environment.NewLine);
            else if (type == 'D')
                pro.StandardInput.Write(@"AES.exe D " + "\"" + txt + "\"" + Environment.NewLine);
            
            pro.StandardInput.Close();

            string resultValue = pro.StandardOutput.ReadToEnd();
            pro.WaitForExit();
            pro.Close();

            //데이터 파싱
            string[] result = resultValue.Split(new char[] { '@' });  // @를 기준으로 잘라서 배열 result 에 넣어라.

            string afterTxt = result[1];

            return afterTxt;
        }

        //enter 입력시
        private void msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }
        

        private void txtBoxChat_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBoxEncChat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

