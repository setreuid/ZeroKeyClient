using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Core;
using Data;

namespace ZeroKey
{
    public delegate void OnKeyDown(int code);
    public delegate void OnKeyUp(int code, double duration);

    public delegate bool RunStage(int num);
    public delegate bool StopStage(int num);


    public partial class Form1 : Form
    {
        private DataTable table = new DataTable();
        private static Dictionary<int, double> keys = new Dictionary<int, double>();

        private double stTime;
        private bool isHooking = false;

        private Stage sCtrl1;

        private Command.CommandClient grpcClient;


        public Form1()
        {
            InitializeComponent();


            Channel channel = new Channel("121.148.87.55:50000", ChannelCredentials.Insecure);
            grpcClient = new Command.CommandClient(channel);


            // column을 추가합니다.
            table.Columns.Add("No", typeof(string));
            table.Columns.Add("Code", typeof(int));
            table.Columns.Add("Key", typeof(string));
            table.Columns.Add("Event", typeof(string));
            table.Columns.Add("Duration", typeof(int));
            table.Columns.Add("Time", typeof(int));

            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            dataGridView1.DataSource = table;


            sCtrl1 = new Stage(1, pnCtrl1, btnCtrl1Stop, OnRequestStageRun, OnRequestStageStop);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPreset();
            Hook.SetHook(OnHookKeyDown, OnHookKeyUp);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hook.UnHook();
        }


        private void ServerHasBeenDown()
        {
            MessageBox.Show("Server has been down!");
            Close();
        }


        private bool OnRequestStageRun(int num)
        {
            var response = grpcClient.Run(new Noting { Status = num });
            return response.Status.Equals(200);
        }


        private bool OnRequestStageStop(int num)
        {
            var response = grpcClient.Stop(new Noting { Status = num });
            return response.Status.Equals(200);
        }


        private void OnHookKeyDown(int code)
        {
            if (!keys.ContainsKey(code))
            {
                keys.Add(code, Hook.GetTime());
            }


            if (!isHooking) return;

            table.Rows.Add(table.Rows.Count + 1, code, ((Keys)code).ToString(), "DOWN", 0, Convert.ToInt32(Hook.GetTime() - stTime));
        }


        private void OnHookKeyUp(int code, double duration)
        {
            keys.Remove(code);
            if (keys.ContainsKey(162) && code.Equals(49)) // Ctrl + 1
            {
                sCtrl1.Run();
            }
            else if (keys.ContainsKey(160) && code.Equals(49)) // Shift + 1
            {
                sCtrl1.Stop();
            }


            if (!isHooking) return;

            table.Rows.Add(table.Rows.Count + 1, code, ((Keys)code).ToString(), "UP", Convert.ToInt32(duration), Convert.ToInt32(Hook.GetTime() - stTime));
        }


        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (!isHooking)
            {
                stTime = Hook.GetTime();

                btnRecord.Text = "녹화중지";
                isHooking = true;
            }
            else
            {
                btnRecord.Text = "녹화시작";
                isHooking = false;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            grpcClient.Save(new Preset(table).GetData());
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadPreset();
        }


        private void LoadPreset()
        {
            try
            {
                var reply = grpcClient.Load(new Noting { Status = 100 });

                foreach (Act act in reply.Acts)
                {
                    table.Rows.Add(table.Rows.Count + 1, act.Code, ((Keys)act.Code).ToString(), act.State == 1 ? "DOWN" : "UP", act.Duration, act.Time);
                }
            }
            catch (Grpc.Core.RpcException)
            {
                ServerHasBeenDown();
            }
        }
    }
}
