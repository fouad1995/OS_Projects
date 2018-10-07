using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Allocation_Project
{
   
    public partial class Form1 : Form
    {
        public class Memory
        {
            int HoleStartingAddress;
           
            string HoleTag;  // Tag is used to remove the hole
           public  int HoleSize;
            public Memory()
            {
                HoleStartingAddress = 0;
                HoleSize = 0;
                HoleTag = "";
            }

            public Memory(int Hstarting_Address,int Hole_Size,string Tag)
            {
                HoleStartingAddress = Hstarting_Address;
                HoleSize = Hole_Size;
                HoleTag =Tag;
            }
            public void Set_Hstarting_Address(int s)
            {
                HoleStartingAddress = s;
            }

            public void Set_Hole_Size(int h)
            {
                HoleSize = h;
            }
            public void Set_Hole_Tag(string T)
            {
                HoleTag = T;
            }
            public int Get_Hstarting_Address()
            {
                return HoleStartingAddress;
            }
            public int Get_Hole_Size()
            {
                return HoleSize;
            }
            public string Get_Hole_Tag()
            {
                return HoleTag;
            }
        };

        public class Process
        {
            string ProcessName,ProcessTag;  //Tag is used to deallocate the process
            int ProcessSize;

            public Process()
            {
                ProcessName = "";
                ProcessTag = "";
                ProcessSize = 0;
            }
            public Process(string Pname,string Ptag,int Psize)
            {
                ProcessName = Pname;
                ProcessTag = Ptag;
                ProcessSize = Psize;
            }

            public void Set_Process_Name(string name)
            {
                ProcessName = name;
            }
            public void Set_Process_Size(int s)
            {
                ProcessSize = s;
            }
            public void Set_Process_Tag(string T)
            {
                ProcessTag = T;
            }
            public string Get_Process_Name()
            {
                return ProcessName;
            }
            public int Get_Process_Size()
            {
                return ProcessSize;
            }
            public string Get_Process_Tag()
            {
                return ProcessTag;
            }
        };

        //starting address by default is in location (6,22) "First location in group box"
        // 0x00 at location (6,22) , 0x01 (6,23) and so on 
        int Xlocation=6, Ylocation=22,processbuttontag=0,Holelabeltag=0,HolesIndex=0,ProcessIndex=0,counter=0,CombinedHoleCount=0;
       // Memory memory = new Memory();       
      //  Process process = new Process();
        int y_loc = 22;
        
        List<Memory> holes = new List<Memory>();
        List<Process> WaitingQueue = new List<Process>();
        List<Process> ExecutingQueue = new List<Process>();
        List<Memory> Sorted_Holes;
        public Form1()
        {
            InitializeComponent();
        }

        //for Holes
        private void CreateDynamiclabel(string text, int HoleSize,int StartingAddress,string type,string Tag)
        {
            //Point position = new Point(6,28);
            Point Hole_Location = new Point(Xlocation,StartingAddress);
            Label dynamiclabel = new Label();
            dynamiclabel.AutoSize = false;
            dynamiclabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;  
            dynamiclabel.Height = HoleSize ;  
            dynamiclabel.Width = 188;  //188 // dh daymn sabet
            dynamiclabel.Text = text;
            dynamiclabel.TextAlign = ContentAlignment.MiddleCenter;
            dynamiclabel.Font = new Font("Arial", 12, FontStyle.Bold);
            dynamiclabel.ForeColor = System.Drawing.Color.Gold;
            dynamiclabel.Location = Hole_Location;
            dynamiclabel.Name = Tag;

            // el H m3naha en dy hole m4 process
            if (type == "H")
                dynamiclabel.BackColor = System.Drawing.Color.White;
            else if (type == "R")
                dynamiclabel.BackColor = System.Drawing.Color.DarkGray;
            else
                dynamiclabel.BackColor = System.Drawing.Color.Indigo;

            grpBox_memory.Controls.Add(dynamiclabel);
        } 
        private void CreateDynamicbutton(string text,int ProcessSize,int startingAddress,string Tag)
        {
            Point Process_Location = new Point(Xlocation, startingAddress);
            Button dynamicbutton = new Button();
            dynamicbutton.AutoSize = false;
            dynamicbutton.Height = ProcessSize;
            dynamicbutton.Width = 188;   // dh daymn sabet
            dynamicbutton.Text = text;
            dynamicbutton.Location =Process_Location;
            dynamicbutton.BackColor = System.Drawing.Color.LightSteelBlue;
            dynamicbutton.Name = Tag;
            dynamicbutton.Click += (s, e) =>
            {
                int startaddress = dynamicbutton.Location.Y;
                int i = 0;
                for (i = 0; i < holes.Count; i++)
                {
                    
                        if (startaddress == (holes[i].Get_Hstarting_Address() - dynamicbutton.Height))
                        {

                            holes[i].Set_Hole_Size(dynamicbutton.Height+holes[i].Get_Hole_Size());
                            holes[i].Set_Hstarting_Address(dynamicbutton.Location.Y);
                            break;

                        }
                 
                    }
                
                CreateDynamiclabel("Free " + dynamicbutton.Height + " bytes", dynamicbutton.Height, dynamicbutton.Location.Y, "H", "B");
                grpBox_memory.Controls.Remove(dynamicbutton);

            };
            grpBox_memory.Controls.Add(dynamicbutton);
        }

        private void CreateDynamicbutton1(string text, int ProcessSize, int startingAddress, string Tag)
        {
            Point Process_Location = new Point(Xlocation, startingAddress);
            Button dynamicbutton1 = new Button();
            dynamicbutton1.AutoSize = false;
            dynamicbutton1.Height = ProcessSize;
            dynamicbutton1.Width = 188;   // dh daymn sabet
            dynamicbutton1.Text = text;
            dynamicbutton1.Location = Process_Location;
            dynamicbutton1.BackColor = System.Drawing.Color.LightSteelBlue;
            dynamicbutton1.Name = Tag;
            grb_boxWaitingQueue.Controls.Add(dynamicbutton1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        { /////////////////////////////////// first fit ////////////////////////////////////////////////////////////////////////////////
            if (radio_FirstFit.Checked)
            {
                    //list.count  btgeb 3dd el elments elly fe el list 
                    //list.removeAt(index) btms7 element fe index mo3yan
                    int NewHoleSize, NewAddressSpace;
                    int HoleNumber = holes.Count;   
                    int ProcessNumber = WaitingQueue.Count;
                    int i = 0, j = 0;
                    
                    for(i=0;i<ProcessNumber;i++)
                    {
                        for (j = 0; j < holes.Count; j++)
                        {
                            if (WaitingQueue[0].Get_Process_Size() <= holes[j].Get_Hole_Size())
                            {

                                NewHoleSize = holes[j].Get_Hole_Size() - WaitingQueue[0].Get_Process_Size();
                                NewAddressSpace = WaitingQueue[0].Get_Process_Size() + holes[j].Get_Hstarting_Address();

                                var removedeallocatedhole = grpBox_memory.Controls["B"];
                                 grpBox_memory.Controls.Remove(removedeallocatedhole);

                                //remove the hole 
                                var removehole = grpBox_memory.Controls[holes[j].Get_Hole_Tag()];
                                grpBox_memory.Controls.Remove(removehole);
                           
                                //draw the process
                                CreateDynamicbutton(WaitingQueue[0].Get_Process_Name(), WaitingQueue[0].Get_Process_Size(), holes[j].Get_Hstarting_Address(), WaitingQueue[0].Get_Process_Tag());

                                //update the orignal hole with the new size and address space
                                holes[j].Set_Hole_Size(NewHoleSize);
                                holes[j].Set_Hstarting_Address(NewAddressSpace);

                                //draw the updated hole
                                if(holes[j].Get_Hole_Size()>=50)
                                CreateDynamiclabel("Free "+holes[j].Get_Hole_Size()+" bytes", holes[j].Get_Hole_Size(), holes[j].Get_Hstarting_Address(), "H", holes[j].Get_Hole_Tag());
                                else
                                CreateDynamiclabel("" , holes[j].Get_Hole_Size(), holes[j].Get_Hstarting_Address(), "R", holes[j].Get_Hole_Tag());

                                //remove the process from waiting queue and push it into executing queue
                                WaitingQueue.RemoveAt(0);
                                ProcessIndex--;
                            

                                //break to go to the second process if the process fitted into the hole
                                break;
                            }
                        }
                    }
                ///hna add algorithm
               grb_boxWaitingQueue.Controls.Clear();
                y_loc = 22;
                int m = 0;
                for(m=0;m< WaitingQueue.Count;m++)
                {
                    CreateDynamicbutton1(WaitingQueue[m].Get_Process_Name(), WaitingQueue[m].Get_Process_Size(), y_loc, WaitingQueue[m].Get_Process_Tag());
                    y_loc += WaitingQueue[m].Get_Process_Size();

                }
            }
      
////////////////////////////////////////////////////// end of first fit ///////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////start of best fit ///////////////////////////////////////////////////////////////////////////

   if (radio_BestFit.Checked)
            {
                List<Memory> Sorted_Holes = holes.OrderBy(o => o.HoleSize).ToList();

                    //list.count  btgeb 3dd el elments elly fe el list 
                    //list.removeAt(index) btms7 element fe index mo3yan
                    int NewHoleSize, NewAddressSpace;
                    int HoleNumber = Sorted_Holes.Count;   
                    int ProcessNumber = WaitingQueue.Count;
                    int i = 0, j = 0;
                    
                    for (i = 0; i < ProcessNumber; i++)
                    {
                        for (j = 0; j < Sorted_Holes.Count; j++)
                        {
                            if (WaitingQueue[0].Get_Process_Size() <= Sorted_Holes[j].Get_Hole_Size())
                            {

                                NewHoleSize = Sorted_Holes[j].Get_Hole_Size() - WaitingQueue[0].Get_Process_Size();
                                NewAddressSpace = WaitingQueue[0].Get_Process_Size() + Sorted_Holes[j].Get_Hstarting_Address();

                               var removedeallocatedhole = grpBox_memory.Controls["B"];
                                grpBox_memory.Controls.Remove(removedeallocatedhole);

                            //remove the hole 
                            var removehole = grpBox_memory.Controls[Sorted_Holes[j].Get_Hole_Tag()];
                                grpBox_memory.Controls.Remove(removehole);

                                //draw the process
                                CreateDynamicbutton(WaitingQueue[0].Get_Process_Name(), WaitingQueue[0].Get_Process_Size(), Sorted_Holes[j].Get_Hstarting_Address(), WaitingQueue[0].Get_Process_Tag());

                                //update the orignal hole with the new size and address space
                                Sorted_Holes[j].Set_Hole_Size(NewHoleSize);
                                Sorted_Holes[j].Set_Hstarting_Address(NewAddressSpace);

                                //draw the updated hole
                                if (Sorted_Holes[j].Get_Hole_Size() >= 50)
                                    CreateDynamiclabel("Free " + Sorted_Holes[j].Get_Hole_Size() + " bytes", Sorted_Holes[j].Get_Hole_Size(), Sorted_Holes[j].Get_Hstarting_Address(), "H", Sorted_Holes[j].Get_Hole_Tag());
                                else
                                    CreateDynamiclabel("", Sorted_Holes[j].Get_Hole_Size(), Sorted_Holes[j].Get_Hstarting_Address(), "R", Sorted_Holes[j].Get_Hole_Tag());

                                //remove the process from waiting queue and push it into executing queue
                                WaitingQueue.RemoveAt(0);
                                ProcessIndex--;
                                

                                Sorted_Holes = Sorted_Holes.OrderBy(o => o.HoleSize).ToList();
                                //break to go to the second process if the process fitted into the hole
                                break;
                            }
                        }
                    }
                grb_boxWaitingQueue.Controls.Clear();
                y_loc = 22;
                int m = 0;
                for (m = 0; m < WaitingQueue.Count; m++)
                {
                    CreateDynamicbutton1(WaitingQueue[m].Get_Process_Name(), WaitingQueue[m].Get_Process_Size(), y_loc, WaitingQueue[m].Get_Process_Tag());
                    y_loc += WaitingQueue[m].Get_Process_Size();
                }

            }

//////////////////////////////////////end of best fit//////////////////////////////////////////////////////////////////////
//////////////////////////////////////start of worst fit///////////////////////////////////////////////////////////////////
            if(radio_Worstfit.Checked)
            {
               Sorted_Holes = holes.OrderByDescending(o => o.HoleSize).ToList();
              
                    //list.count  btgeb 3dd el elments elly fe el list 
                    //list.removeAt(index) btms7 element fe index mo3yan
                    int NewHoleSize, NewAddressSpace;
                    int HoleNumber = Sorted_Holes.Count;
                    int ProcessNumber = WaitingQueue.Count;
                    int i = 0, j = 0;

                    for (i = 0; i < ProcessNumber; i++)
                    {
                        for (j = 0; j < Sorted_Holes.Count; j++)
                        {
                            if (WaitingQueue[0].Get_Process_Size() <= Sorted_Holes[j].Get_Hole_Size())
                            {

                                NewHoleSize = Sorted_Holes[j].Get_Hole_Size() - WaitingQueue[0].Get_Process_Size();
                                NewAddressSpace = WaitingQueue[0].Get_Process_Size() + Sorted_Holes[j].Get_Hstarting_Address();

                                 var removedeallocatedhole = grpBox_memory.Controls["B"];
                                 grpBox_memory.Controls.Remove(removedeallocatedhole);

                            //remove the hole 
                            var removehole = grpBox_memory.Controls[Sorted_Holes[j].Get_Hole_Tag()];
                                grpBox_memory.Controls.Remove(removehole);

                                //draw the process
                                CreateDynamicbutton(WaitingQueue[0].Get_Process_Name(), WaitingQueue[0].Get_Process_Size(), Sorted_Holes[j].Get_Hstarting_Address(), WaitingQueue[0].Get_Process_Tag());

                                //update the orignal hole with the new size and address space
                                Sorted_Holes[j].Set_Hole_Size(NewHoleSize);
                                Sorted_Holes[j].Set_Hstarting_Address(NewAddressSpace);

                                //draw the updated hole
                                if (Sorted_Holes[j].Get_Hole_Size() >= 50)
                                    CreateDynamiclabel("Free " + Sorted_Holes[j].Get_Hole_Size() + " bytes", Sorted_Holes[j].Get_Hole_Size(), Sorted_Holes[j].Get_Hstarting_Address(), "H", Sorted_Holes[j].Get_Hole_Tag());
                                else
                                    CreateDynamiclabel("", Sorted_Holes[j].Get_Hole_Size(), Sorted_Holes[j].Get_Hstarting_Address(), "R", Sorted_Holes[j].Get_Hole_Tag());

                                //remove the process from waiting queue and push it into executing queue
                                WaitingQueue.RemoveAt(0);
                                ProcessIndex--;

                                Sorted_Holes = Sorted_Holes.OrderByDescending(o => o.HoleSize).ToList();
                                //break to go to the second process if the process fitted into the hole
                                break;
                            }
                        }
                    }

                grb_boxWaitingQueue.Controls.Clear();
                y_loc = 22;
                int m = 0;
                for (m = 0; m < WaitingQueue.Count; m++)
                {
                    CreateDynamicbutton1(WaitingQueue[m].Get_Process_Name(), WaitingQueue[m].Get_Process_Size(), y_loc, WaitingQueue[m].Get_Process_Tag());
                    y_loc += WaitingQueue[m].Get_Process_Size();
                }

            }

            }
        private void btn_AddProcess_Click(object sender, EventArgs e)
        {
           // int x_loc = 6, y_loc = 28,counter = 0;
            
            
            string processname = "P" + Convert.ToString(txt_ProcessName.Text);
            int processsize = Convert.ToInt32(txt_ProcessSize.Text);
            WaitingQueue.Insert(ProcessIndex, new Process(processname,"A"+processbuttontag,processsize));
            CreateDynamicbutton1(WaitingQueue[ProcessIndex].Get_Process_Name(), WaitingQueue[ProcessIndex].Get_Process_Size(), y_loc, WaitingQueue[ProcessIndex].Get_Process_Tag());
            processbuttontag++;
            y_loc += WaitingQueue[ProcessIndex].Get_Process_Size();
            ProcessIndex++;

        }

        private void btn_AddHole_Click(object sender, EventArgs e)
        {
              
            int holesize = Convert.ToInt32(txt_HoleSize.Text);
            int StartAddress = Convert.ToInt32(txt_HoleStartingAddress.Text);
            StartAddress += 22; // to be inside group box
            
            if (StartAddress > Ylocation)
            {
                holes.Insert(HolesIndex,new Memory(StartAddress,holesize,Holelabeltag.ToString()));
                Holelabeltag++;
                CreateDynamiclabel("", StartAddress-Ylocation, Ylocation, "N",""); //if there is a gap between 2 processes
                CreateDynamiclabel("Free "+holesize.ToString()+" bytes", holesize, StartAddress, "H",holes[HolesIndex].Get_Hole_Tag());
                Ylocation = StartAddress + holesize;  //update Ylocation 
                HolesIndex++;
            }

            else if(StartAddress==Ylocation)
            {
                //3l4an awl mra 5ales m4 h3rf a3mel index l holes list h2nha lsa fadya f awel mra 
                if(CombinedHoleCount==0)
                {
                    holes.Insert(HolesIndex, new Memory(StartAddress, holesize, Holelabeltag.ToString()));
                    Holelabeltag++;
                    CreateDynamiclabel("Free "+holesize.ToString()+" bytes", holesize, StartAddress, "H", holes[HolesIndex].Get_Hole_Tag());
                    Ylocation = StartAddress + holesize;  //update Ylocation 
                    HolesIndex++;
                    CombinedHoleCount++;
                }

                else{

                    //awl mra el HolesIndex=0 -> HolesIndex-1=-1  f hy7sl error out of bound m4 hy3rf ygeb holes[index-1]
                    //34an kda 3mlt global variable CombinedHoleCount=0 w awl mra 5ales hy5o4 el if elly fo2 w b3d kda yb2a =1 
                    //f kda dmnt en 3omro m hy3mel out of bound 
                    holes[HolesIndex - 1].Set_Hole_Size(holes[HolesIndex - 1].Get_Hole_Size() + holesize);

                    //remove the old hole 
                    var removehole = grpBox_memory.Controls[holes[HolesIndex-1].Get_Hole_Tag()];
                    grpBox_memory.Controls.Remove(removehole);
                    
                    //draw the new hole "Combiation of 2 holes"
                    CreateDynamiclabel("Free "+(holes[HolesIndex-1].Get_Hole_Size()).ToString()+" bytes", holes[HolesIndex - 1].Get_Hole_Size(), holes[HolesIndex-1].Get_Hstarting_Address(), "H", holes[HolesIndex - 1].Get_Hole_Tag());
                    Ylocation = StartAddress + holesize;
                    }
            }
            
            else
                MessageBox.Show("You can't add hole in this address space because it's a preserved address , Try another address ");   
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }




}

