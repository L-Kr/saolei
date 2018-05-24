using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 扫雷
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public  int Num = 0;
        public  int Bumb = 0;
        public int[,] arr;
        public Button[,] but;

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void 难度选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eazy10104ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num = 10;
            Bumb = 10;
            arr = new int[Num, Num];
            but = new Button[Num, Num];
            start();
        }

        private void normal404016ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num = 16;
            Bumb = 40;
            arr = new int[Num, Num];
            but = new Button[Num, Num];
            start();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num = 24;
            Bumb = 60;
            arr = new int[Num, Num];
            but = new Button[Num, Num];
            start();
        }

        private void lunatic10010050ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num = 50;
            Bumb = 100;
            arr = new int[Num, Num];
            but = new Button[Num, Num];
            start();
        }

        public void start()
        {

            {

                /*埋雷*/
                for (int i = 0; i < Num; i++)
                    for (int j = 0; j < Num; j++)
                        arr[i, j] = 0;
                for (int k = 0; k < Bumb; k++)
                {
                    Random ri = new Random(Guid.NewGuid().GetHashCode());
                    Random rj = new Random(Guid.NewGuid().GetHashCode());
                    int i = ri.Next(Num);
                    int j = rj.Next(Num);
                    if (arr[i, j] == -1)
                        k--;
                    else
                    {
                        arr[i, j] = -1;
                        if (i != 0)
                        {
                            if (arr[i - 1, j] != -1)
                                arr[i - 1, j]++;
                        }
                        if (i != Num - 1)
                        {
                            if (arr[i + 1, j] != -1)
                                arr[i + 1, j]++;
                        }
                        if (j != 0)
                        {
                            if (arr[i, j - 1] != -1)
                                arr[i, j - 1]++;
                        }
                        if (j != Num - 1)
                        {
                            if (arr[i, j + 1] != -1)
                                arr[i, j + 1]++;
                        }
                        if (i != 0 && j != 0)
                        {
                            if (arr[i - 1, j - 1] != -1)
                                arr[i - 1, j - 1]++;
                        }
                        if (i != Num - 1 && j != Num - 1)
                        {
                            if (arr[i + 1, j + 1] != -1)
                                arr[i + 1, j + 1]++;
                        }
                        if (i != Num - 1 && j != 0)
                        {
                            if (arr[i + 1, j - 1] != -1)
                                arr[i + 1, j - 1]++;
                        }
                        if (i != 0 && j != Num - 1)
                        {
                            if (arr[i - 1, j + 1] != -1)
                                arr[i - 1, j + 1]++;
                        }
                    }
                }

                /*按钮设计*/
                for (int i = 0; i < Num; i++)
                    for (int j = 0; j < Num; j++)
                        but[i, j] = new Button();
                foreach (Button b in but)
                {
                    b.BackColor = Color.SpringGreen;
                    b.ForeColor = SystemColors.ControlText;
                    b.Size = new Size(25, 25);
                    b.TabIndex = 0;
                    b.UseVisualStyleBackColor = false;
                    b.Enabled = true;
                    Controls.Add(b);
                }
                but[0, 0].Location = new Point(0, 25);
                but[0, 0].Name = "but[0,0]";
                for (int i = 0; i < Num; i++)
                {
                    for (int j = 1; j < Num; j++)
                    {
                        but[i, j].Location = new Point(but[i, j - 1].Location.X + 25, but[i, j - 1].Location.Y);
                        but[i, j].Name = "but[" + i.ToString() + "," + j.ToString() + "]";
                    }
                    if (i < Num - 1)
                    {
                        but[i + 1, 0].Location = new Point(but[i, 0].Location.X, but[i, 0].Location.Y + 25);
                        but[i + 1, 0].Name = "but[" + i + 1.ToString() + ",0]";
                    }
                }
                /*for (int i = 0; i < Num; i++)
                {
                    for (int j = 0; j < Num; j++)
                    {
                        but[i, j].Click += (sender1, e1) =>
                        {
                            MessageBox.Show(arr[i, j].ToString());
                        };
                    }
                }*/
                foreach (Button b in but)
                {
                    b.MouseDown += (sender2, e2) =>
                    {
                        if (e2.Button == MouseButtons.Left)
                        {
                            int i = (b.Location.Y / 25) - 1;    /*按钮边长为25,菜单栏宽25*/
                            int j = b.Location.X / 25;    /*按钮边长为25*/
                            if (arr[i, j] != 0 && arr[i, j] != -1)
                                b.Text = arr[i, j].ToString();
                            b.BackColor = Color.AntiqueWhite;
                            b.Enabled = false;
                            if (arr[i, j] == -1)
                            {
                                MessageBox.Show("游戏结束");
                                Dispose();
                            }

                            /*当被点区域周围没有雷的时候*/
                            if (arr[i, j] == 0)
                            {
                                Stack<int> si = new Stack<int>();
                                Stack<int> sj = new Stack<int>();
                                si.Push(i);
                                sj.Push(j);
                                do
                                {
                                    i = si.Pop();
                                    j = sj.Pop();
                                    if (i != 0)
                                    {
                                        if (but[i - 1, j].Enabled == true)
                                        {
                                            but[i - 1, j].BackColor = Color.AntiqueWhite;
                                            but[i - 1, j].Enabled = false;
                                            if (arr[i - 1, j] == 0)
                                            {
                                                si.Push(i - 1);
                                                sj.Push(j);
                                            }
                                            else
                                                but[i - 1, j].Text = arr[i - 1, j].ToString();
                                        }
                                    }
                                    if (i != Num - 1)
                                    {
                                        if (but[i + 1, j].Enabled == true)
                                        {
                                            but[i + 1, j].BackColor = Color.AntiqueWhite;
                                            but[i + 1, j].Enabled = false;
                                            if (arr[i + 1, j] == 0)
                                            {
                                                si.Push(i + 1);
                                                sj.Push(j);
                                            }
                                            else
                                                but[i + 1, j].Text = arr[i + 1, j].ToString();
                                        }
                                    }
                                    if (j != 0)
                                    {
                                        if (but[i, j - 1].Enabled == true)
                                        {
                                            but[i, j - 1].BackColor = Color.AntiqueWhite;
                                            but[i, j - 1].Enabled = false;
                                            if (arr[i, j - 1] == 0)
                                            {
                                                si.Push(i);
                                                sj.Push(j - 1);
                                            }
                                            else
                                                but[i, j - 1].Text = arr[i, j - 1].ToString();
                                        }
                                    }
                                    if (j != Num - 1)
                                    {
                                        if (but[i, j + 1].Enabled == true)
                                        {
                                            but[i, j + 1].BackColor = Color.AntiqueWhite;
                                            but[i, j + 1].Enabled = false;
                                            if (arr[i, j + 1] == 0)
                                            {
                                                si.Push(i);
                                                sj.Push(j + 1);
                                            }
                                            else
                                                but[i, j + 1].Text = arr[i, j + 1].ToString();
                                        }
                                    }
                                    if (i != 0 && j != 0)
                                    {
                                        if (but[i - 1, j - 1].Enabled == true)
                                        {
                                            but[i - 1, j - 1].BackColor = Color.AntiqueWhite;
                                            but[i - 1, j - 1].Enabled = false;
                                            if (arr[i - 1, j - 1] == 0)
                                            {
                                                si.Push(i - 1);
                                                sj.Push(j - 1);
                                            }
                                            else
                                                but[i - 1, j - 1].Text = arr[i - 1, j - 1].ToString();
                                        }
                                    }
                                    if (i != Num - 1 && j != Num - 1)
                                    {
                                        if (but[i + 1, j + 1].Enabled == true)
                                        {
                                            but[i + 1, j + 1].BackColor = Color.AntiqueWhite;
                                            but[i + 1, j + 1].Enabled = false;
                                            if (arr[i + 1, j + 1] == 0)
                                            {
                                                si.Push(i + 1);
                                                sj.Push(j + 1);
                                            }
                                            else
                                                but[i + 1, j + 1].Text = arr[i + 1, j + 1].ToString();
                                        }
                                    }
                                    if (i != Num - 1 && j != 0)
                                    {
                                        if (but[i + 1, j - 1].Enabled == true)
                                        {
                                            but[i + 1, j - 1].BackColor = Color.AntiqueWhite;
                                            but[i + 1, j - 1].Enabled = false;
                                            if (arr[i + 1, j - 1] == 0)
                                            {
                                                si.Push(i + 1);
                                                sj.Push(j - 1);
                                            }
                                            else
                                                but[i + 1, j - 1].Text = arr[i + 1, j - 1].ToString();
                                        }
                                    }
                                    if (i != 0 && j != Num - 1)
                                    {
                                        if (but[i - 1, j + 1].Enabled == true)
                                        {
                                            but[i - 1, j + 1].BackColor = Color.AntiqueWhite;
                                            but[i - 1, j + 1].Enabled = false;
                                            if (arr[i - 1, j + 1] == 0)
                                            {
                                                si.Push(i - 1);
                                                sj.Push(j + 1);
                                            }
                                            else
                                                but[i - 1, j + 1].Text = arr[i - 1, j + 1].ToString();
                                        }
                                    }
                                } while (si.Count != 0 && sj.Count != 0);
                            }

                            int x = 0;
                            foreach (Button ba in but)
                            {
                                if (ba.Enabled == true)
                                    x++;
                            }
                            if (x == Bumb)
                            {
                                MessageBox.Show("恭喜通关！");
                                Dispose();
                            }
                        }
                        else if (e2.Button == MouseButtons.Right)
                        {
                            b.Text = "*";
                        }
                    };

                }
            }
        }
    }
}
