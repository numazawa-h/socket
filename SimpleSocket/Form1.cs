using SocketTool;
using SocketTool.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SocketTool.Properties.SocketBase;

namespace SimpleSocket
{
    public partial class Form1 : Form
    {
        ServerSocket accept_socket = null;
        ClientSocket connect_socket = null;

        SocketSendRecv recv_socket = null;
        SocketSendRecv send_socket = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // 受信ソケットセットアップ
            accept_socket = new ServerSocket(48, 22, 2);
            accept_socket.OnExceptionEvent += OnExceptionHandler;
            accept_socket.OnFailListenEvent += OnFailListenHandler;
            accept_socket.OnAcceptEvent += OnAcceptEventHandler;
            accept_socket.OnDisConnectEvent += OnDisConnectEventHandler;
            accept_socket.OnSendData += OnSendDatahandler;
            accept_socket.OnRecvData += OnRecvDatahandler;


            // 送信ソケットセットアップ
            connect_socket = new ClientSocket(48, 22, 2);
            connect_socket.OnExceptionEvent += OnExceptionHandler;
            connect_socket.OnSendData += OnSendDatahandler;
            connect_socket.OnRecvData += OnRecvDatahandler;
            connect_socket.OnFailConnectEvent += OnFaiConnectHandler;
            connect_socket.OnConnectEvent += OnConnectEventHandler;
            connect_socket.OnDisConnectEvent += OnDisConnectEventHandler;



            this.txt_Remort_IpAddress.Text = "10.51.46.82";
            this.txt_Self_IpAddress.Text = "10.51.46.82";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] hed = new byte[] { 0, 0, 0, 8 };
            byte[] dat = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            send_socket?.Send(hed, dat);
        }


        private async void chk_Self_AutoConnect_CheckedChanged(object sender, EventArgs e)
        {
//            this.statusStrip.Items.Clear();
            if (this.chk_Self_AutoConnect.Checked)
            {
                if (recv_socket == null)            // TODO
                {
                    await Task.Delay(500);

                    lbl_Self_Status.Text = "接続待ち...";
                    lbl_Self_Status.ForeColor = Color.DeepPink;
                    Application.DoEvents();

                    accept_socket.Listen(txt_Self_IpAddress.Text, txt_Self_PortNo.Text);
                }
            }
            else
            {
                lbl_Self_Status.Text = "切断";
                lbl_Self_Status.ForeColor = Color.Black;
                Application.DoEvents();

                accept_socket.StopListen();     // TODO
                recv_socket?.Stop();
                recv_socket = null;
            }
        }

        private async void chk_Remote_AutoConnect_CheckedChanged(object sender, EventArgs e)
        {
//            this.statusStrip.Items.Clear();
            if (this.chk_Remort_AutoConnect.Checked)
            {
                if (send_socket == null)
                {
                    this.lbl_Remote_Status.Text = "接続中...";
                    lbl_Remote_Status.ForeColor = Color.DeepPink;
                    Application.DoEvents();
                    await Task.Delay(100);

                    connect_socket.Connect(txt_Remort_IpAddress.Text, txt_Remort_PortNo.Text);
                }
            }
            else
            {
                lbl_Remote_Status.Text = "切断";
                lbl_Remote_Status.ForeColor = Color.Black;
                Application.DoEvents();

                send_socket?.Stop();
                send_socket = null;
            }
        }


        private void OnExceptionHandler(object sender, ThreadExceptionEventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ThreadExceptionEventHandler(OnExceptionHandler), new object[] { sender, args });
                return;
            }
            Log.Warn(args.Exception.Message + args.Exception.StackTrace);
            this.richTextBox.Text += args.Exception.Message + "\r\n";
        }

        private void OnFailListenHandler(object sender, EventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(OnFailListenHandler), new object[] { sender, args });
                return;
            }

            this.chk_Self_AutoConnect.Checked = false;
        }

        private async void OnFaiConnectHandler(object sender, EventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(OnFaiConnectHandler), new object[] { sender, args });
                return;
            }
            this.lbl_Remote_Status.Text = "切断";
            this.lbl_Remote_Status.ForeColor = Color.Black;
            Application.DoEvents();
            await Task.Delay(5000);
//            connect_socket = null;
            if (chk_Remort_AutoConnect.Checked)
            {
                lbl_Remote_Status.Text = "接続中...";
                lbl_Remote_Status.ForeColor = Color.DeepPink;
                Application.DoEvents();
                await Task.Delay(500);
                connect_socket.Connect(txt_Remort_IpAddress.Text, txt_Remort_PortNo.Text);
            }
        }

        private void OnAcceptEventHandler(object sender, ConnectEventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ConnectEventHandler(OnAcceptEventHandler), new object[] { sender, args });
                return;
            }

            recv_socket = args.Socket;
            this.lbl_Self_Status.Text = "接続";
            this.lbl_Self_Status.ForeColor = Color.Red;
        }

        private void OnConnectEventHandler(object sender, ConnectEventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ConnectEventHandler(OnConnectEventHandler), new object[] { sender, args });
                return;
            }

            send_socket = args.Socket;
            lbl_Remote_Status.Text = "接続";
            lbl_Remote_Status.ForeColor = Color.Red;
        }

        private async void OnDisConnectEventHandler(object sender, ConnectEventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ConnectEventHandler(OnDisConnectEventHandler), new object[] { sender, args });
                return;
            }


            if (args.Socket.isServerSocket())
            {
                lbl_Self_Status.Text = "切断";
                lbl_Self_Status.ForeColor = Color.Black;
//                accept_socket = null;
                if (chk_Self_AutoConnect.Checked)
                {
                    lbl_Self_Status.Text = "接続待ち...";
                    lbl_Self_Status.ForeColor = Color.DeepPink;
                    await Task.Delay(10);
                    accept_socket.Listen(txt_Self_IpAddress.Text, txt_Self_PortNo.Text);
                }
            }
            else
            {
                lbl_Remote_Status.Text = "切断";
                lbl_Remote_Status.ForeColor = Color.Black;
//                connect_socket = null;
                if (chk_Remort_AutoConnect.Checked)
                {
                    lbl_Remote_Status.Text = "接続中...";
                    lbl_Remote_Status.ForeColor = Color.DeepPink;
                    await Task.Delay(10);
                    connect_socket.Connect(txt_Remort_IpAddress.Text, txt_Remort_PortNo.Text);
                }
            }
        }

        private void OnSendDatahandler(object sender, CommDataEventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new CommDataHandler(OnSendDatahandler), new object[] { sender, args });
                return;
            }
            byte[] hed = args.HeadBuff;
            byte[] dat = args.DataBuff;
            //TODO
        }

        private void OnRecvDatahandler(object sender, CommDataEventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new CommDataHandler(OnRecvDatahandler), new object[] { sender, args });
                return;
            }

            byte[] hed = args.HeadBuff;
            byte[] dat = args.DataBuff;


            richTextBox.Text += dump_message(hed, dat);
        }

        private string dump_message(byte[] hed, byte[] dat)
        {
            StringBuilder sb = new StringBuilder();
            int cnt = 0;
            sb.Append("[");
            foreach (byte b in hed)
            {
                if (cnt > 0 && (cnt % 8) == 0)
                {
                    sb.Append(" ");
                }
                if (cnt > 0 && (cnt % 4) == 0)
                {
                    sb.Append(" ");
                }
                if (cnt > 0 && (cnt % 16) == 0)
                {
                    sb.Append("\r\n ");
                }
                sb.Append($"{b:X2}");
                ++cnt;
            }
            sb.Append("]\r\n");
            cnt = 0;
            sb.Append("[");
            foreach (byte b in dat)
            {
                if (cnt > 0 && (cnt % 8) == 0)
                {
                    sb.Append(" ");
                }
                if (cnt > 0 && (cnt % 4) == 0)
                {
                    sb.Append(" ");
                }
                if (cnt > 0 && (cnt % 16) == 0)
                {
                    sb.Append("\r\n ");
                }
                sb.Append($"{b:X2}");
                ++cnt;
            }
            sb.Append("]\r\n");

            return sb.ToString();
        }
    }
}
