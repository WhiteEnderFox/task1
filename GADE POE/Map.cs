//Rah5i  Mitchell Dreyer 18000499

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE
{
    class Map
    {
        int c = 0;

        MeleeUnit[] meleeU = new MeleeUnit[40];
        RangedUnit[] rangedUnit = new RangedUnit[40];
        TextBox t = new TextBox();
        int tracker = 0;

        int count;
        Random r = new Random();
        Button[,] btn = new Button[20, 20];


        public Map(Form frm)
        {
            t = new TextBox();

            Point p = new Point(700, 30);

            t.ReadOnly = true;
            t.Location = p;
            t.Width = 100;
            t.Height = 150;
            t.Multiline = true;

            frm.Controls.Add(t);
        }

        

        public void SpawnUnits(Form frm)
        {
            bool check = false;
            int randomUnit;
            if (c==0)
            {
                while(!check)
                {
                    meleeU[tracker] = new MeleeUnit();
                    rangedUnit[tracker] = new RangedUnit();
                    randomUnit = r.Next(0, 2);

                    int spawnLocateX = r.Next(1, 19);
                    int spawnlocateY = r.Next(1, 19);

                    btn[spawnLocateX, spawnlocateY].ForeColor = Color.Blue;

                    if (btn[spawnLocateX, spawnlocateY].Text != "X" && btn[spawnLocateX, spawnlocateY].Text != "Y")
                    {

                        switch (randomUnit)
                        {
                            case 0:

                                meleeU[tracker].X_pos = spawnLocateX;
                                meleeU[tracker].Y_pos = spawnlocateY;
                                meleeU[tracker].Attack = 10;

                                meleeU[tracker].Attack_Range = 1;

                                meleeU[tracker].Faction = "Blue";
                                meleeU[tracker].Health = 100;
                                meleeU[tracker].Speed = 1;
                                btn[spawnLocateX, spawnlocateY].Text = "X";
                                btn[spawnLocateX, spawnlocateY].Click += new EventHandler(button_Click);

                                break;
                            case 1:

                                rangedUnit[tracker].X_pos = spawnLocateX;
                                rangedUnit[tracker].Y_pos = spawnlocateY;
                                rangedUnit[tracker].Attack = 10;

                                rangedUnit[tracker].Attack_Range = 3;

                                rangedUnit[tracker].Faction = "Blue";
                                rangedUnit[tracker].Health = 100;
                                rangedUnit[tracker].Speed = 1;
                                btn[spawnLocateX, spawnlocateY].Text = "Y";
                                btn[spawnLocateX, spawnlocateY].Click += new EventHandler(button_Click);
                                break;
                        }

                        count++;
                        tracker++;
                    }

                    if (count == 10)
                    {
                        check = true;
                    }
                }
                check = false;
                count = 0;
                while (!check)
                {
                    rangedUnit[tracker] = new RangedUnit();
                    meleeU[tracker] = new MeleeUnit();

                    int spawnLocateX = r.Next(1, 19);
                    int spawnLocateY = r.Next(1, 19);

                    btn[spawnLocateX, spawnLocateY].ForeColor = Color.Orange;

                    if (btn[spawnLocateX,spawnLocateY].Text != "X" && btn[spawnLocateX,spawnLocateY].Text !="Y")
                    {
                        randomUnit = r.Next(0, 2);
                        switch (randomUnit)
                        {
                            case 0:

                                meleeU[tracker].X_pos = spawnLocateX;
                                meleeU[tracker].Y_pos = spawnLocateY;
                                meleeU[tracker].Attack = 10;

                                meleeU[tracker].Attack_Range = 1;

                                meleeU[tracker].Faction = "Orange";
                                meleeU[tracker].Health = 100;
                                meleeU[tracker].Speed = 1;
                                btn[spawnLocateX, spawnLocateY].Text = "X";
                                btn[spawnLocateX, spawnLocateY].Click += new EventHandler(button_Click);

                                break;

                            case 1:

                                rangedUnit[tracker].X_pos = spawnLocateX;
                                rangedUnit[tracker].Y_pos = spawnLocateY;
                                rangedUnit[tracker].Attack = 10;

                                rangedUnit[tracker].Attack_Range = 1;

                                rangedUnit[tracker].Faction = "Orange";
                                rangedUnit[tracker].Health = 100;
                                rangedUnit[tracker].Speed = 1;
                                btn[spawnLocateX, spawnLocateY].Text = "Y";
                                btn[spawnLocateX, spawnLocateY].Click += new EventHandler(button_Click);

                                break;
                        }
                        count++;
                        tracker++;
                    }

                    if ( count == 10)
                    {
                        check = true;
                    }
                }
            }
            //c++;
            //for(int  x = 0; x <20; x++)
            //{
            //    for(int y = 0; y<20; y++)
            //    {
            //        if(btn[x,y].Text =="X")
            //        {
            //            //btn[x + 1, y].Text = "X";
            //        }
            //    }
            //}
        }

        public void GeneratingMap(Form frm)
        {
            int Hori = 30;
            int Vert = 30;

            int y = 0;
            for (int x = 0; x < 20; x++)
            {
                Vert = 30;
                Hori = Hori + 30;
                for (y = 0; y < 20; y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].Size = new Size(30, 30);
                    btn[x, y].Location = new Point(Hori, Vert);
                    Vert = Vert + 30;
                    btn[x, y].Text = " ";
                    frm.Controls.Add(btn[x, y]);
                }
            }
        }

        public void  button_Click(object sender, EventArgs args)
        {
            Button btn = sender as Button;

            if(btn.Text=="X")
            {
                t.Text = meleeU[1].tostring();
            }
            if(btn.Text=="Y")
            {
                t.Text = rangedUnit[1].tostring();
            }
        }
    }
}
