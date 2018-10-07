namespace Memory_Allocation_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HoleSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HoleStartingAddress = new System.Windows.Forms.TextBox();
            this.btn_AddHole = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ProcessSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ProcessName = new System.Windows.Forms.TextBox();
            this.btn_AddProcess = new System.Windows.Forms.Button();
            this.btn_Allocate = new System.Windows.Forms.Button();
            this.grpBox_memory = new System.Windows.Forms.GroupBox();
            this.radio_FirstFit = new System.Windows.Forms.RadioButton();
            this.radio_BestFit = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.radio_Worstfit = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.grb_boxWaitingQueue = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Allocation Algorithm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_HoleSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_HoleStartingAddress);
            this.groupBox1.Controls.Add(this.btn_AddHole);
            this.groupBox1.Location = new System.Drawing.Point(24, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Hole";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hole Size";
            // 
            // txt_HoleSize
            // 
            this.txt_HoleSize.Location = new System.Drawing.Point(157, 64);
            this.txt_HoleSize.Name = "txt_HoleSize";
            this.txt_HoleSize.Size = new System.Drawing.Size(100, 20);
            this.txt_HoleSize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hole Starting Address";
            // 
            // txt_HoleStartingAddress
            // 
            this.txt_HoleStartingAddress.Location = new System.Drawing.Point(157, 21);
            this.txt_HoleStartingAddress.Name = "txt_HoleStartingAddress";
            this.txt_HoleStartingAddress.Size = new System.Drawing.Size(100, 20);
            this.txt_HoleStartingAddress.TabIndex = 1;
            // 
            // btn_AddHole
            // 
            this.btn_AddHole.Location = new System.Drawing.Point(239, 114);
            this.btn_AddHole.Name = "btn_AddHole";
            this.btn_AddHole.Size = new System.Drawing.Size(75, 23);
            this.btn_AddHole.TabIndex = 0;
            this.btn_AddHole.Text = "Add Hole";
            this.btn_AddHole.UseVisualStyleBackColor = true;
            this.btn_AddHole.Click += new System.EventHandler(this.btn_AddHole_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_ProcessSize);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_ProcessName);
            this.groupBox2.Controls.Add(this.btn_AddProcess);
            this.groupBox2.Location = new System.Drawing.Point(24, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 141);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Process";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "P";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Process Size";
            // 
            // txt_ProcessSize
            // 
            this.txt_ProcessSize.Location = new System.Drawing.Point(157, 62);
            this.txt_ProcessSize.Name = "txt_ProcessSize";
            this.txt_ProcessSize.Size = new System.Drawing.Size(100, 20);
            this.txt_ProcessSize.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Process Number";
            // 
            // txt_ProcessName
            // 
            this.txt_ProcessName.Location = new System.Drawing.Point(157, 19);
            this.txt_ProcessName.Name = "txt_ProcessName";
            this.txt_ProcessName.Size = new System.Drawing.Size(100, 20);
            this.txt_ProcessName.TabIndex = 1;
            // 
            // btn_AddProcess
            // 
            this.btn_AddProcess.Location = new System.Drawing.Point(239, 108);
            this.btn_AddProcess.Name = "btn_AddProcess";
            this.btn_AddProcess.Size = new System.Drawing.Size(75, 23);
            this.btn_AddProcess.TabIndex = 0;
            this.btn_AddProcess.Text = "Add Process";
            this.btn_AddProcess.UseVisualStyleBackColor = true;
            this.btn_AddProcess.Click += new System.EventHandler(this.btn_AddProcess_Click);
            // 
            // btn_Allocate
            // 
            this.btn_Allocate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Allocate.Location = new System.Drawing.Point(26, 377);
            this.btn_Allocate.Name = "btn_Allocate";
            this.btn_Allocate.Size = new System.Drawing.Size(320, 31);
            this.btn_Allocate.TabIndex = 7;
            this.btn_Allocate.Text = "Allocate ";
            this.btn_Allocate.UseVisualStyleBackColor = true;
            this.btn_Allocate.Click += new System.EventHandler(this.button3_Click);
            // 
            // grpBox_memory
            // 
            this.grpBox_memory.AutoSize = true;
            this.grpBox_memory.Location = new System.Drawing.Point(390, 12);
            this.grpBox_memory.Name = "grpBox_memory";
            this.grpBox_memory.Size = new System.Drawing.Size(200, 396);
            this.grpBox_memory.TabIndex = 8;
            this.grpBox_memory.TabStop = false;
            this.grpBox_memory.Text = "Memory Representation";
            // 
            // radio_FirstFit
            // 
            this.radio_FirstFit.AutoSize = true;
            this.radio_FirstFit.Location = new System.Drawing.Point(196, 9);
            this.radio_FirstFit.Name = "radio_FirstFit";
            this.radio_FirstFit.Size = new System.Drawing.Size(58, 17);
            this.radio_FirstFit.TabIndex = 9;
            this.radio_FirstFit.Text = "First Fit";
            this.radio_FirstFit.UseVisualStyleBackColor = true;
            // 
            // radio_BestFit
            // 
            this.radio_BestFit.AutoSize = true;
            this.radio_BestFit.Location = new System.Drawing.Point(196, 32);
            this.radio_BestFit.Name = "radio_BestFit";
            this.radio_BestFit.Size = new System.Drawing.Size(60, 17);
            this.radio_BestFit.TabIndex = 10;
            this.radio_BestFit.Text = "Best Fit";
            this.radio_BestFit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "0-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "50-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "100-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "150-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "200-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "250-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(361, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "300-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 377);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "350-";
            // 
            // radio_Worstfit
            // 
            this.radio_Worstfit.AutoSize = true;
            this.radio_Worstfit.Location = new System.Drawing.Point(196, 55);
            this.radio_Worstfit.Name = "radio_Worstfit";
            this.radio_Worstfit.Size = new System.Drawing.Size(67, 17);
            this.radio_Worstfit.TabIndex = 20;
            this.radio_Worstfit.Text = "Worst Fit";
            this.radio_Worstfit.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(617, 377);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "350-";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(617, 327);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "300-";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(617, 277);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "250-";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(617, 227);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(28, 13);
            this.label26.TabIndex = 29;
            this.label26.Text = "200-";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(617, 177);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 13);
            this.label27.TabIndex = 28;
            this.label27.Text = "150-";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(617, 127);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(28, 13);
            this.label28.TabIndex = 27;
            this.label28.Text = "100-";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(623, 77);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 13);
            this.label29.TabIndex = 26;
            this.label29.Text = "50-";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(623, 28);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(16, 13);
            this.label30.TabIndex = 25;
            this.label30.Text = "0-";
            // 
            // grb_boxWaitingQueue
            // 
            this.grb_boxWaitingQueue.AutoSize = true;
            this.grb_boxWaitingQueue.Location = new System.Drawing.Point(646, 12);
            this.grb_boxWaitingQueue.Name = "grb_boxWaitingQueue";
            this.grb_boxWaitingQueue.Size = new System.Drawing.Size(200, 396);
            this.grb_boxWaitingQueue.TabIndex = 24;
            this.grb_boxWaitingQueue.TabStop = false;
            this.grb_boxWaitingQueue.Text = "Processes Waiting to execute";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(881, 437);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.grb_boxWaitingQueue);
            this.Controls.Add(this.radio_Worstfit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radio_BestFit);
            this.Controls.Add(this.radio_FirstFit);
            this.Controls.Add(this.grpBox_memory);
            this.Controls.Add(this.btn_Allocate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Memory Allocation Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HoleSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HoleStartingAddress;
        private System.Windows.Forms.Button btn_AddHole;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ProcessSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ProcessName;
        private System.Windows.Forms.Button btn_AddProcess;
        private System.Windows.Forms.Button btn_Allocate;
        private System.Windows.Forms.GroupBox grpBox_memory;
        private System.Windows.Forms.RadioButton radio_FirstFit;
        private System.Windows.Forms.RadioButton radio_BestFit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radio_Worstfit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox grb_boxWaitingQueue;
    }
}

