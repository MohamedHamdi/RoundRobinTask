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


namespace RoundRobinTask
{
    public partial class RoundRobin : Form
    {
        public string[] processesNames;
        public int[] processesBurstTime;
        public int[] processesArrivalTime;
       
        public RoundRobin()
        {
            InitializeComponent();
            burstTime.Text = arrivalTime.Text = Quantom.Text = "";
        }
        public void addProcessBtn_Click(object sender, EventArgs e)
        {

            ProNameLst.Items.Add(processNametxt.Text);
            BurstTimeLst.Items.Add(burstTime.Value);
            ArrivalTimeLst.Items.Add(arrivalTime.Value);

        }

        private void orderBtn_Click(object sender, EventArgs e)
        {

            #region fillMyArrays
             processesNames = new string[ProNameLst.Items.Count];
             processesBurstTime = new int[BurstTimeLst.Items.Count];
             processesArrivalTime = new int[ArrivalTimeLst.Items.Count];

            for (int i = 0; i < processesNames.Length; i++)
            {
                processesNames[i] = ProNameLst.Items[i].ToString();
                processesBurstTime[i] = int.Parse(BurstTimeLst.Items[i].ToString());
                processesArrivalTime[i] = int.Parse(ArrivalTimeLst.Items[i].ToString());
            }
            #endregion
            #region sortByArrival
            int k = 0;
            for (int j = 1; j < processesNames.Length; j++)
            {
                k = j - 1;
                string nkey = processesNames[j];
                int bkey = processesBurstTime[j];
                int akey = processesArrivalTime[j];
                while (k > -1 && processesArrivalTime[k] > akey)
                {
                    processesArrivalTime[k + 1] = processesArrivalTime[k];
                    processesBurstTime[k + 1] = processesBurstTime[k];
                    processesNames[k + 1] = processesNames[k];
                    k--;
                }
                processesNames[k + 1] = nkey;
                processesBurstTime[k + 1] = bkey;
                processesArrivalTime[k + 1] = akey;
            }

            ProNameLst.Items.Clear();
            BurstTimeLst.Items.Clear();
            ArrivalTimeLst.Items.Clear();

            for (int i = 0; i < processesNames.Length; i++)
            {
                ProNameLst.Items.Add(processesNames[i]);
                BurstTimeLst.Items.Add(processesBurstTime[i]);
                ArrivalTimeLst.Items.Add(processesArrivalTime[i]);
            }
            #endregion

        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            
            #region fillArrayOfProcesses
            int quantom = (int)Quantom.Value;
            Process[] FprocessList = new Process[ProNameLst.Items.Count];
            for (int i = 0; i < FprocessList.Length; i++)
            {
                FprocessList[i] = (new Process(processesNames[i], processesArrivalTime[i], processesBurstTime[i]));
            }
            #endregion
            #region NumberOfSlices
            List<int> numOfLog = new List<int>();
            
            for (int i = 0; i < FprocessList.Length; i++)
            {
                if (FprocessList[i].burstTime % quantom < quantom && FprocessList[i].burstTime % quantom > 0)
                {
                    numOfLog.Add((FprocessList[i].burstTime / quantom) + 1);
                }
                else if (FprocessList[i].burstTime < quantom)
                {
                    numOfLog.Add(1);
                }
                else
                {
                    numOfLog.Add(FprocessList[i].burstTime / quantom);
                }
            }

            int sumNumOfLog = 0;
            for (int kk = 0; kk < numOfLog.Count; kk++)
            {
                sumNumOfLog += numOfLog[kk];
            }
            #endregion
            #region Scheduling
            bool flag = false;
            int start = FprocessList[0].arrival;
            int count = 0 ;
            for (int kkkk=0; kkkk<sumNumOfLog;kkkk++ )
            {
                for (int i = 0; i < FprocessList.Length; i++)
                {
                    if (count == 0)
                    {
                        start = FprocessList[i].arrival;
                        FprocessList[i].start = start;
                    }

                    if (FprocessList[i].reminder > quantom)
                    {
                   
                        #region Draw
                        Label ss = new Label();
                        ss.BackColor = Color.SeaGreen;
                        ss.ForeColor = Color.White;
                        ss.Text = start.ToString();
                    
                        ss.TextAlign = ContentAlignment.BottomCenter;
                        Label nn = new Label();
                        nn.BackColor = Color.White;
                        nn.ForeColor = Color.Red;
                        nn.TextAlign = ContentAlignment.BottomCenter;
                        if (count < FprocessList.Length)
                        {
                            FprocessList[i].start = start;
                        }
                        nn.Text = FprocessList[i].processName;
                        start += quantom;
                  
                      
                        Label eee = new Label();
                        eee.BackColor = Color.SeaGreen;
                        eee.ForeColor = Color.White;
                        eee.Text = start.ToString();
                        eee.TextAlign = ContentAlignment.BottomCenter;
                        flowLayoutPanel1.Controls.Add(ss);
                        flowLayoutPanel1.Controls.Add(nn);
                        flowLayoutPanel1.Controls.Add(eee);
                        #endregion
                        count++;
                        FprocessList[i].reminder -= quantom;
                       
                    }
                    else if (FprocessList[i].reminder < quantom)
                    {
                    
                        if (FprocessList[i].reminder <= 0)
                        {
                            continue;
                        }
                        else
                        {
                            #region Draw
                            Label ss = new Label();
                            ss.BackColor = Color.SeaGreen;
                            ss.ForeColor = Color.White;
                            ss.TextAlign = ContentAlignment.BottomCenter;
                            ss.Text = start.ToString();

                            Label nn = new Label();
                            nn.BackColor = Color.White;
                            nn.ForeColor = Color.Red;
                            nn.TextAlign = ContentAlignment.BottomCenter;
                            if (count < FprocessList.Length)
                            {
                                FprocessList[i].start = start;
                            }
                            nn.Text = FprocessList[i].processName;
                            start += FprocessList[i].reminder;
                            FprocessList[i].LastEnd = start;
                            Label eee = new Label();
                            eee.BackColor = Color.SeaGreen;
                            eee.ForeColor = Color.White;
                            eee.Text = start.ToString();
                            eee.TextAlign = ContentAlignment.BottomCenter;
                            flowLayoutPanel1.Controls.Add(ss);
                            flowLayoutPanel1.Controls.Add(nn);
                            flowLayoutPanel1.Controls.Add(eee);
                            #endregion
                            count++;
                            FprocessList[i].reminder = 0;
                        }

                    }
                    else if (FprocessList[i].reminder == quantom)
                    {
                   
                        #region Draw
                        Label ss = new Label();
                        ss.BackColor = Color.SeaGreen;
                        ss.ForeColor = Color.White;
                        ss.Text = start.ToString();
                        ss.TextAlign = ContentAlignment.BottomCenter;
                        Label nn = new Label();
                        nn.BackColor = Color.White;
                        nn.ForeColor = Color.Red;
                        if (count < FprocessList.Length)
                        {
                            FprocessList[i].start = start;
                        }
                        nn.Text = FprocessList[i].processName;
                        nn.TextAlign = ContentAlignment.BottomCenter;
                        start += FprocessList[i].reminder;
                        FprocessList[i].LastEnd = start;
                        Label eee = new Label();
                        eee.BackColor = Color.SeaGreen;
                        eee.ForeColor = Color.White;
                        eee.Text = start.ToString();
                        eee.TextAlign = ContentAlignment.BottomCenter;
                        flowLayoutPanel1.Controls.Add(ss);
                        flowLayoutPanel1.Controls.Add(nn);
                        flowLayoutPanel1.Controls.Add(eee);
                        #endregion
                        count++;
                        FprocessList[i].reminder = 0;
                    }

                    for (int j = 0; j < FprocessList.Length; j++)
                    {
                        if (FprocessList[j].reminder > 0)
                        {
                            flag = true;
                        }
                    }

                    if (flag == false)
                    {
                        break;
                    }
                }
                if (flag == false)
                {
                    break;
                }
            }
            #endregion
            #region TurnAround,Waiting

            for (int i = 0; i < FprocessList.Length; i++)
            {
                FprocessList[i].turnAround = FprocessList[i].LastEnd - FprocessList[i].arrival;
                FprocessList[i].waiting = FprocessList[i].LastEnd - FprocessList[i].burstTime;
                if (FprocessList[i].arrival<=FprocessList[i].start)
                {
                    FprocessList[i].waiting = FprocessList[i].LastEnd -( FprocessList[i].burstTime+FprocessList[i].arrival);
                }
            }
            #endregion
            #region datagridview
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ProcessName";
            dataGridView1.Columns[1].Name = "Arrival";
            dataGridView1.Columns[2].Name = "Burst";
            dataGridView1.Columns[3].Name = "TurnAround";
            dataGridView1.Columns[4].Name = "Waiting";
            dataGridView1.Columns[5].Name = "Start";
            dataGridView1.Columns[6].Name = "End";

            ArrayList ar;
            for (int i = 0; i < FprocessList.Length; i++)
            {
                ar = new ArrayList();
                ar.Add(FprocessList[i].processName);
                ar.Add(FprocessList[i].arrival);
                ar.Add(FprocessList[i].burstTime);
                ar.Add(FprocessList[i].turnAround);
                ar.Add(FprocessList[i].waiting);
                ar.Add(FprocessList[i].start);
                ar.Add(FprocessList[i].LastEnd);
                dataGridView1.Rows.Add(ar.ToArray());
            }
            #endregion
            #region Average
            double turn=0;
            double wait=0;
            for (int i = 0; i < FprocessList.Length; i++)
            {
                turn += FprocessList[i].turnAround;
                wait += FprocessList[i].waiting;
            }

            label3.Text = (wait / FprocessList.Length).ToString();
            label4.Text = (turn / FprocessList.Length).ToString();
            #endregion

        }

           
    }
}


























