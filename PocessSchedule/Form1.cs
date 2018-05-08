using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart;

namespace Scheduling_Assignment
{
    public partial class Form1 : Form
    {
        List l = new List();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateDynamicButton(int burst, string text, Point position,string allign)
        {
            int i = 0;
            //Point position = new Point(58,403);
            
            Button dynamicButton = new Button();
            dynamicButton.Height = 25;
            dynamicButton.Width = 0;

            dynamicButton.Text = text;
            if(allign=="M")
             dynamicButton.TextAlign = ContentAlignment.MiddleCenter;
            else
                dynamicButton.TextAlign = ContentAlignment.TopRight;
            dynamicButton.AutoEllipsis = true;
           
            dynamicButton.Enabled = false; 
            dynamicButton.Location = position;
            Controls.Add(dynamicButton);

           
                for (i = 0; i <= (burst*30); i++)
                {
                    dynamicButton.Width += 1;
                    dynamicButton.Refresh();
                    System.Threading.Thread.Sleep(50);
                }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSceduler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string check_Priority  = (comboBoxSceduler.SelectedItem).ToString();
            

            switch (check_Priority)
            {

                case "Preemptive Priority" : textBoxPriority.Enabled = true;
                                   
                    break;
                case "Non-Preemptive Priority": textBoxPriority.Enabled = true;
                    break;

                case "Preemptive SJF":     textBoxPriority.Enabled = true;
                    break;

                case "Round Roben":        textBoxQuantum.Enabled = true;
                    textBoxPriority.Enabled = false;
                    break;
                default: textBoxPriority.Enabled = false;
                    textBoxQuantum.Enabled = false;
                    break;
         
            }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string check= (comboBoxSceduler.SelectedItem).ToString();
            switch (check)
            {
                case "FCFS": l.Sort_Arrival(); l.Sort_Ideal(); l.Check_Ideal_first();  break;

                case "Non-Preemptive SJF": l.Sort_Arrival(); l.Sort_Ideal(); l.Sort_Non_Preemptie_SJF(); l.Check_Ideal_first(); break;

                case "Non-Preemptive Priority": l.Sort_Arrival(); l.Sort_Ideal(); l.Sort_Non_Premptive_Priority(); l.Check_Ideal_first(); break;

                case "Preemptive SJF": l.Sort_Arrival(); l.Sort_Preemptive_SJF(); l.Check_Ideal_first(); break;

                case "Preemptive Priority": l.Sort_Arrival(); l.Sort_Preemptive_Priority(); l.Check_Ideal_first(); break;

                case "Round Roben": l.Sort_Arrival(); l.Sort_Round_Roben(Convert.ToInt32(textBoxQuantum.Text)); l.Check_Ideal_first(); break;

                default:break;
            }

            int i = 0, size =l.Get_Size();  // to prevent decrementation of size in the for loop condition
                 Point x = new Point(100, 435);
            Point y = new Point(100,460);
            int sum = 0;

            for (i=0;i<size;i++)
                 {
                Process temp = l.Pop();
                sum+=temp.Get_Burst();
                CreateDynamicButton(temp.Get_Burst(),temp.Get_Name(),x,"M");
                CreateDynamicButton(temp.Get_Burst(), sum.ToString(),y,"L");
                x.X +=30* (temp.Get_Burst());
                y.X +=30* (temp.Get_Burst());
     
                 }
            




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxQuantum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string check= (comboBoxSceduler.SelectedItem).ToString();
            comboBoxSceduler.Enabled = false;
            int priority ;
            int Quantum ;
            string name = "p"+textBoxName.Text;
            int burst = Convert.ToInt32(textBurst.Text);
            int arrival = Convert.ToInt32(textBoxArrival.Text);
            switch (check) {
                case "FCFS": priority = 0; Quantum = 0; break;
                case "Non-Preemptive SJF": priority = 0; Quantum = 0; break;
                case "Preemptive SJF": priority = Convert.ToInt32(textBoxPriority.Text); Quantum = 0; break;
                case "Preemptive Priority": priority = Convert.ToInt32(textBoxPriority.Text); Quantum = 0; break;
                case "Non-Preemptive Priority": priority = Convert.ToInt32(textBoxPriority.Text); Quantum = 0; break;
                default:priority = 0; Quantum = Convert.ToInt32(textBoxQuantum.Text); textBoxQuantum.Enabled = false; break;
            }

            Process p = new Process(name, burst, arrival, priority);
            l.Push_front(p);

           
        }

        private void textBoxPriority_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
