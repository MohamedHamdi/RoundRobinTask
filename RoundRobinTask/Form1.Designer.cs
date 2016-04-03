namespace RoundRobinTask
{
    partial class RoundRobin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.processNameLabel = new System.Windows.Forms.Label();
            this.burstTimeLabel = new System.Windows.Forms.Label();
            this.arrivalTimeLabel = new System.Windows.Forms.Label();
            this.QuantomLabel = new System.Windows.Forms.Label();
            this.processNametxt = new System.Windows.Forms.TextBox();
            this.burstTime = new System.Windows.Forms.NumericUpDown();
            this.arrivalTime = new System.Windows.Forms.NumericUpDown();
            this.Quantom = new System.Windows.Forms.NumericUpDown();
            this.ProNameLst = new System.Windows.Forms.ListBox();
            this.BurstTimeLst = new System.Windows.Forms.ListBox();
            this.ArrivalTimeLst = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addProcessBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.burstTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // processNameLabel
            // 
            this.processNameLabel.AutoSize = true;
            this.processNameLabel.Location = new System.Drawing.Point(12, 9);
            this.processNameLabel.Name = "processNameLabel";
            this.processNameLabel.Size = new System.Drawing.Size(106, 16);
            this.processNameLabel.TabIndex = 0;
            this.processNameLabel.Text = "ProcessName";
            // 
            // burstTimeLabel
            // 
            this.burstTimeLabel.AutoSize = true;
            this.burstTimeLabel.Location = new System.Drawing.Point(12, 37);
            this.burstTimeLabel.Name = "burstTimeLabel";
            this.burstTimeLabel.Size = new System.Drawing.Size(78, 16);
            this.burstTimeLabel.TabIndex = 1;
            this.burstTimeLabel.Text = "BurstTime";
            // 
            // arrivalTimeLabel
            // 
            this.arrivalTimeLabel.AutoSize = true;
            this.arrivalTimeLabel.Location = new System.Drawing.Point(12, 65);
            this.arrivalTimeLabel.Name = "arrivalTimeLabel";
            this.arrivalTimeLabel.Size = new System.Drawing.Size(88, 16);
            this.arrivalTimeLabel.TabIndex = 2;
            this.arrivalTimeLabel.Text = "ArrivalTime";
            // 
            // QuantomLabel
            // 
            this.QuantomLabel.AutoSize = true;
            this.QuantomLabel.Location = new System.Drawing.Point(12, 93);
            this.QuantomLabel.Name = "QuantomLabel";
            this.QuantomLabel.Size = new System.Drawing.Size(69, 16);
            this.QuantomLabel.TabIndex = 3;
            this.QuantomLabel.Text = "Quantom";
            // 
            // processNametxt
            // 
            this.processNametxt.Location = new System.Drawing.Point(136, 6);
            this.processNametxt.Name = "processNametxt";
            this.processNametxt.Size = new System.Drawing.Size(100, 22);
            this.processNametxt.TabIndex = 4;
            // 
            // burstTime
            // 
            this.burstTime.Location = new System.Drawing.Point(127, 35);
            this.burstTime.Name = "burstTime";
            this.burstTime.Size = new System.Drawing.Size(120, 22);
            this.burstTime.TabIndex = 5;
            // 
            // arrivalTime
            // 
            this.arrivalTime.Location = new System.Drawing.Point(127, 63);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(120, 22);
            this.arrivalTime.TabIndex = 6;
            // 
            // Quantom
            // 
            this.Quantom.Location = new System.Drawing.Point(127, 91);
            this.Quantom.Name = "Quantom";
            this.Quantom.Size = new System.Drawing.Size(120, 22);
            this.Quantom.TabIndex = 7;
            // 
            // ProNameLst
            // 
            this.ProNameLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNameLst.FormattingEnabled = true;
            this.ProNameLst.Location = new System.Drawing.Point(253, 6);
            this.ProNameLst.Name = "ProNameLst";
            this.ProNameLst.Size = new System.Drawing.Size(57, 108);
            this.ProNameLst.TabIndex = 8;
            // 
            // BurstTimeLst
            // 
            this.BurstTimeLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurstTimeLst.FormattingEnabled = true;
            this.BurstTimeLst.Location = new System.Drawing.Point(316, 6);
            this.BurstTimeLst.Name = "BurstTimeLst";
            this.BurstTimeLst.Size = new System.Drawing.Size(57, 108);
            this.BurstTimeLst.TabIndex = 9;
            // 
            // ArrivalTimeLst
            // 
            this.ArrivalTimeLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalTimeLst.FormattingEnabled = true;
            this.ArrivalTimeLst.Location = new System.Drawing.Point(379, 6);
            this.ArrivalTimeLst.Name = "ArrivalTimeLst";
            this.ArrivalTimeLst.Size = new System.Drawing.Size(57, 108);
            this.ArrivalTimeLst.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 384);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(856, 261);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // addProcessBtn
            // 
            this.addProcessBtn.Location = new System.Drawing.Point(15, 120);
            this.addProcessBtn.Name = "addProcessBtn";
            this.addProcessBtn.Size = new System.Drawing.Size(210, 23);
            this.addProcessBtn.TabIndex = 0;
            this.addProcessBtn.Text = "AddProcess";
            this.addProcessBtn.UseVisualStyleBackColor = true;
            this.addProcessBtn.Click += new System.EventHandler(this.addProcessBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(231, 120);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(244, 23);
            this.orderBtn.TabIndex = 13;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.Location = new System.Drawing.Point(481, 120);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(279, 23);
            this.scheduleBtn.TabIndex = 14;
            this.scheduleBtn.Text = "Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "AverageWaitTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "AverageTurnAround";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(651, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(651, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 19;
            // 
            // RoundRobin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(889, 657);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduleBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.addProcessBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ArrivalTimeLst);
            this.Controls.Add(this.BurstTimeLst);
            this.Controls.Add(this.ProNameLst);
            this.Controls.Add(this.Quantom);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.burstTime);
            this.Controls.Add(this.processNametxt);
            this.Controls.Add(this.QuantomLabel);
            this.Controls.Add(this.arrivalTimeLabel);
            this.Controls.Add(this.burstTimeLabel);
            this.Controls.Add(this.processNameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RoundRobin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoundRobin";
            ((System.ComponentModel.ISupportInitialize)(this.burstTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processNameLabel;
        private System.Windows.Forms.Label burstTimeLabel;
        private System.Windows.Forms.Label arrivalTimeLabel;
        private System.Windows.Forms.Label QuantomLabel;
        private System.Windows.Forms.TextBox processNametxt;
        private System.Windows.Forms.NumericUpDown burstTime;
        private System.Windows.Forms.NumericUpDown arrivalTime;
        private System.Windows.Forms.NumericUpDown Quantom;
        private System.Windows.Forms.ListBox ProNameLst;
        private System.Windows.Forms.ListBox BurstTimeLst;
        private System.Windows.Forms.ListBox ArrivalTimeLst;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addProcessBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

