namespace Scheduling_Assignment
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
            this.labelBurst = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.labelScheduler = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.textBoxBurst = new System.Windows.Forms.TextBox();
            this.textBoxArrival = new System.Windows.Forms.TextBox();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.comboBoxSceduler = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBurst = new System.Windows.Forms.TextBox();
            this.textBoxQuantum = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelQuantum = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBurst
            // 
            this.labelBurst.AutoSize = true;
            this.labelBurst.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBurst.Location = new System.Drawing.Point(11, 139);
            this.labelBurst.Name = "labelBurst";
            this.labelBurst.Size = new System.Drawing.Size(88, 21);
            this.labelBurst.TabIndex = 0;
            this.labelBurst.Text = "Burst Time";
            this.labelBurst.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelArrival
            // 
            this.labelArrival.AutoSize = true;
            this.labelArrival.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrival.Location = new System.Drawing.Point(11, 252);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(101, 21);
            this.labelArrival.TabIndex = 1;
            this.labelArrival.Text = "Arrival Time";
            // 
            // labelScheduler
            // 
            this.labelScheduler.AutoSize = true;
            this.labelScheduler.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduler.Location = new System.Drawing.Point(11, 7);
            this.labelScheduler.Name = "labelScheduler";
            this.labelScheduler.Size = new System.Drawing.Size(134, 21);
            this.labelScheduler.TabIndex = 2;
            this.labelScheduler.Text = "Choose Scheduler";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriority.Location = new System.Drawing.Point(12, 193);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(67, 21);
            this.labelPriority.TabIndex = 3;
            this.labelPriority.Text = "Priority";
            // 
            // textBoxBurst
            // 
            this.textBoxBurst.Location = new System.Drawing.Point(159, -23);
            this.textBoxBurst.Name = "textBoxBurst";
            this.textBoxBurst.Size = new System.Drawing.Size(100, 20);
            this.textBoxBurst.TabIndex = 4;
            this.textBoxBurst.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxArrival
            // 
            this.textBoxArrival.Location = new System.Drawing.Point(161, 252);
            this.textBoxArrival.Name = "textBoxArrival";
            this.textBoxArrival.Size = new System.Drawing.Size(80, 20);
            this.textBoxArrival.TabIndex = 5;
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Enabled = false;
            this.textBoxPriority.Location = new System.Drawing.Point(161, 196);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(80, 20);
            this.textBoxPriority.TabIndex = 6;
            this.textBoxPriority.TextChanged += new System.EventHandler(this.textBoxPriority_TextChanged);
            // 
            // comboBoxSceduler
            // 
            this.comboBoxSceduler.DropDownHeight = 40;
            this.comboBoxSceduler.DropDownWidth = 200;
            this.comboBoxSceduler.FormattingEnabled = true;
            this.comboBoxSceduler.IntegralHeight = false;
            this.comboBoxSceduler.Items.AddRange(new object[] {
            "FCFS",
            "Preemptive SJF",
            "Non-Preemptive SJF",
            "Preemptive Priority",
            "Non-Preemptive Priority",
            "Round Roben"});
            this.comboBoxSceduler.Location = new System.Drawing.Point(153, 7);
            this.comboBoxSceduler.Name = "comboBoxSceduler";
            this.comboBoxSceduler.Size = new System.Drawing.Size(180, 21);
            this.comboBoxSceduler.TabIndex = 7;
            this.comboBoxSceduler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSceduler_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(161, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Simulate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBurst
            // 
            this.textBurst.Location = new System.Drawing.Point(161, 142);
            this.textBurst.Name = "textBurst";
            this.textBurst.Size = new System.Drawing.Size(80, 20);
            this.textBurst.TabIndex = 10;
            this.textBurst.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxQuantum
            // 
            this.textBoxQuantum.Enabled = false;
            this.textBoxQuantum.Location = new System.Drawing.Point(161, 304);
            this.textBoxQuantum.Name = "textBoxQuantum";
            this.textBoxQuantum.Size = new System.Drawing.Size(80, 20);
            this.textBoxQuantum.TabIndex = 12;
            this.textBoxQuantum.TextChanged += new System.EventHandler(this.textBoxQuantum_TextChanged);
            // 
            // labelQuantum
            // 
            this.labelQuantum.AutoSize = true;
            this.labelQuantum.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantum.Location = new System.Drawing.Point(11, 301);
            this.labelQuantum.Name = "labelQuantum";
            this.labelQuantum.Size = new System.Drawing.Size(117, 21);
            this.labelQuantum.TabIndex = 11;
            this.labelQuantum.Text = "Quantum Time";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(161, 86);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(80, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(11, 83);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(124, 21);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Process Number";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gantt Chart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Process";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(618, 527);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxQuantum);
            this.Controls.Add(this.labelQuantum);
            this.Controls.Add(this.textBurst);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSceduler);
            this.Controls.Add(this.textBoxPriority);
            this.Controls.Add(this.textBoxArrival);
            this.Controls.Add(this.textBoxBurst);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelScheduler);
            this.Controls.Add(this.labelArrival);
            this.Controls.Add(this.labelBurst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBurst;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.Label labelScheduler;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.TextBox textBoxBurst;
        private System.Windows.Forms.TextBox textBoxArrival;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxSceduler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBurst;
        private System.Windows.Forms.TextBox textBoxQuantum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelQuantum;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

