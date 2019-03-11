using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NumberRecognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White) btn.BackColor = Color.Black;
            else btn.BackColor = Color.White;
        }

        Neuron neuron0;
        Neuron neuron1;
        Neuron neuron2;
        Neuron neuron3;
        Neuron neuron4;
        Neuron neuron5;
        Neuron neuron6;
        Neuron neuron7;
        Neuron neuron8;
        Neuron neuron9;
        int[,] input = new int[3, 5];

        private void Teach(object sender, EventArgs e)
        {
            btn_false.Visible = true;
            btn_true.Visible = true;

            int c = 0;

            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 4; y++)
                {
                    switch (c)
                    {
                        case 0:
                            if (button1.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 1:
                            if (button4.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 2:
                            if (button7.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 3:
                            if (button10.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 4:
                            if (button13.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 5:
                            if (button2.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 6:
                            if (button5.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 7:
                            if (button8.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 8:
                            if (button11.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 9:
                            if (button14.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 10:
                            if (button3.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 11:
                            if (button6.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 12:
                            if (button9.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 13:
                            if (button12.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 14:
                            if (button15.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                    }
                    c++;
                }
            }
            neuron0 = new Neuron(3, 5, input);
            neuron1 = new Neuron(3, 5, input);
            neuron2 = new Neuron(3, 5, input);
            neuron3 = new Neuron(3, 5, input);
            neuron4 = new Neuron(3, 5, input);
            neuron5 = new Neuron(3, 5, input);
            neuron6 = new Neuron(3, 5, input);
            neuron7 = new Neuron(3, 5, input);
            neuron8 = new Neuron(3, 5, input);
            neuron9 = new Neuron(3, 5, input);
            StreamReader sr0 = File.OpenText("n0.txt");
            StreamReader sr1 = File.OpenText("n1.txt");
            StreamReader sr2 = File.OpenText("n2.txt");
            StreamReader sr3 = File.OpenText("n3.txt");
            StreamReader sr4 = File.OpenText("n4.txt");
            StreamReader sr5 = File.OpenText("n5.txt");
            StreamReader sr6 = File.OpenText("n6.txt");
            StreamReader sr7 = File.OpenText("n7.txt");
            StreamReader sr8 = File.OpenText("n8.txt");
            StreamReader sr9 = File.OpenText("n9.txt");
            string line0, line1, line2, line3, line4, line5, line6, line7, line8, line9;
            string[] s0, s1, s2, s3, s4, s5, s6, s7, s8, s9;
            int k = 0;
            while (sr0.EndOfStream != true)
             {
                line0 = sr0.ReadLine();
                line1 = sr1.ReadLine();
                line2 = sr2.ReadLine();
                line3 = sr3.ReadLine();
                line4 = sr4.ReadLine();
                line5 = sr5.ReadLine();
                line6 = sr6.ReadLine();
                line7 = sr7.ReadLine();
                line8 = sr8.ReadLine();
                line9 = sr9.ReadLine();
                s0 = line0.Split(' ');
                s1 = line1.Split(' ');
                s2 = line2.Split(' ');
                s3 = line3.Split(' ');
                s4 = line4.Split(' ');
                s5 = line5.Split(' ');
                s6 = line6.Split(' ');
                s7 = line7.Split(' ');
                s8 = line8.Split(' ');
                s9 = line9.Split(' ');
                for (int i = 0; i < 3; i++)
                {
                    if (k < 5)
                    {
                        neuron0.weight[i, k] = Convert.ToInt32(s0[i]);
                        neuron1.weight[i, k] = Convert.ToInt32(s1[i]);
                        neuron2.weight[i, k] = Convert.ToInt32(s2[i]);
                        neuron3.weight[i, k] = Convert.ToInt32(s3[i]);
                        neuron4.weight[i, k] = Convert.ToInt32(s4[i]);
                        neuron5.weight[i, k] = Convert.ToInt32(s5[i]);
                        neuron6.weight[i, k] = Convert.ToInt32(s6[i]);
                        neuron7.weight[i, k] = Convert.ToInt32(s7[i]);
                        neuron8.weight[i, k] = Convert.ToInt32(s8[i]);
                        neuron9.weight[i, k] = Convert.ToInt32(s9[i]);
                    }
        
                }
                k++;
            }
            sr0.Close();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            sr4.Close();
            sr5.Close();
            sr6.Close();
            sr7.Close();
            sr8.Close();
            sr9.Close();
            switch (comboBox1.Text)
            {
                case "0":
                    if (neuron0.Result()) label2.Text = "True";
                    else label2.Text = "False";
                    break;
                case "1":
                    if (neuron1.Result()) label2.Text = "True";
                    else label2.Text = "False";
                    break;
                case "2":
                    if (neuron2.Result()) label2.Text = "True";
                    else label2.Text = "False";
                    break;
                case "3":
                    if (neuron3.Result()) label2.Text = "True";
                    else label2.Text = "False";
                    break;
                case "4":
                    if (neuron4.Result()) label2.Text = "True";
                    else label2.Text = "False";
                    break;
                case "5":
                    if (neuron5.Result()) label2.Text = "True";
                    else label2.Text = "False";
                    break;
                case "6":
                    if (neuron6.Result()) label2.Text = "True";
                    else label2.Text = "False";
                    break;
                case "7":
                    if (neuron7.Result()) label2.Text = "True";
                    else label2.Text = "False";
                    break;
                case "8":
                    if (neuron8.Result()) label2.Text = "True";
                    else label2.Text = "False";
                    break;
                case "9":
                    if (neuron9.Result()) label2.Text = "True";
                    else label2.Text = "False";
                    break;
            }
        }

        private void Btn_true_Click(object sender, EventArgs e)
        {
            btn_true.Visible = false;
            btn_false.Visible = false;
            label2.Text = "";
        }

        private void Btn_false_Click(object sender, EventArgs e)
        {
            btn_true.Visible = false;
            btn_false.Visible = false;
            label2.Text = "";

            switch (comboBox1.Text)
            {
                case "0":
                    if (neuron0.Result()) neuron0.Decrement(input);
                    else neuron0.Increment(input);
                    string s0 = "";
                    string[] sr0 = new string[5];
                    File.Delete("n0.txt");
                    FileStream fs0 = new FileStream("n0.txt", FileMode.OpenOrCreate);
                    StreamWriter sw0 = new StreamWriter(fs0);
                    for (int i = 0; i <= 4; i++)
                    {
                        s0 = Convert.ToString(neuron0.weight[0, i]) + " " + Convert.ToString(neuron0.weight[1, i])
                            + " " + Convert.ToString(neuron0.weight[2, i]);
                        sr0[i] = s0;
                        sw0.WriteLine(s0);
                    }
                    sw0.Close();
                    break;
                case "1":
                    if (neuron1.Result()) neuron1.Decrement(input);
                    else neuron1.Increment(input);
                    string s1 = "";
                    string[] sr1 = new string[5];
                    File.Delete("n1.txt");
                    FileStream fs1 = new FileStream("n1.txt", FileMode.OpenOrCreate);
                    StreamWriter sw1 = new StreamWriter(fs1);
                    for (int i = 0; i <= 4; i++)
                    {
                        s1 = Convert.ToString(neuron1.weight[0, i]) + " " + Convert.ToString(neuron1.weight[1, i])
                            + " " + Convert.ToString(neuron1.weight[2, i]);
                        sr1[i] = s1;
                        sw1.WriteLine(s1);
                    }
                    sw1.Close();
                    break;
                case "2":
                    if (neuron2.Result()) neuron2.Decrement(input);
                    else neuron2.Increment(input);
                    string s2 = "";
                    string[] sr2 = new string[5];
                    File.Delete("n2.txt");
                    FileStream fs2 = new FileStream("n2.txt", FileMode.OpenOrCreate);
                    StreamWriter sw2 = new StreamWriter(fs2);
                    for (int i = 0; i <= 4; i++)
                    {
                        s2 = Convert.ToString(neuron2.weight[0, i]) + " " + Convert.ToString(neuron2.weight[1, i])
                            + " " + Convert.ToString(neuron2.weight[2, i]);
                        sr2[i] = s2;
                        sw2.WriteLine(s2);
                    }
                    sw2.Close();
                    
                    break;
                case "3":
                    if (neuron3.Result()) neuron3.Decrement(input);
                    else neuron3.Increment(input);
                    string s3 = "";
                    string[] sr3 = new string[5];
                    File.Delete("n3.txt");
                    FileStream fs3 = new FileStream("n3.txt", FileMode.OpenOrCreate);
                    StreamWriter sw3 = new StreamWriter(fs3);
                    for (int i = 0; i <= 4; i++)
                    {
                        s3 = Convert.ToString(neuron3.weight[0, i]) + " " + Convert.ToString(neuron3.weight[1, i])
                            + " " + Convert.ToString(neuron3.weight[2, i]);
                        sr3[i] = s3;
                        sw3.WriteLine(s3);
                    }
                    sw3.Close();
                    break;
                case "4":
                    if (neuron4.Result()) neuron4.Decrement(input);
                    else neuron4.Increment(input);
                    string s4 = "";
                    string[] sr4 = new string[5];
                    File.Delete("n4.txt");
                    FileStream fs4 = new FileStream("n4.txt", FileMode.OpenOrCreate);
                    StreamWriter sw4 = new StreamWriter(fs4);
                    for (int i = 0; i <= 4; i++)
                    {
                        s4 = Convert.ToString(neuron4.weight[0, i]) + " " + Convert.ToString(neuron4.weight[1, i])
                            + " " + Convert.ToString(neuron4.weight[2, i]);
                        sr4[i] = s4;
                        sw4.WriteLine(s4);
                    }
                    sw4.Close();
                    break;
                case "5":
                    if (neuron5.Result()) neuron5.Decrement(input);
                    else neuron5.Increment(input);
                    string s5 = "";
                    string[] sr5 = new string[5];
                    File.Delete("n5.txt");
                    FileStream fs5 = new FileStream("n5.txt", FileMode.OpenOrCreate);
                    StreamWriter sw5 = new StreamWriter(fs5);
                    for (int i = 0; i <= 4; i++)
                    {
                        s5 = Convert.ToString(neuron5.weight[0, i]) + " " + Convert.ToString(neuron5.weight[1, i])
                            + " " + Convert.ToString(neuron5.weight[2, i]);
                        sr5[i] = s5;
                        sw5.WriteLine(s5);
                    }
                    sw5.Close();
                    break;
                case "6":
                    if (neuron6.Result()) neuron6.Decrement(input);
                    else neuron6.Increment(input);
                    string s6 = "";
                    string[] sr6 = new string[5];
                    File.Delete("n6.txt");
                    FileStream fs6 = new FileStream("n6.txt", FileMode.OpenOrCreate);
                    StreamWriter sw6 = new StreamWriter(fs6);
                    for (int i = 0; i <= 4; i++)
                    {
                        s6 = Convert.ToString(neuron6.weight[0, i]) + " " + Convert.ToString(neuron6.weight[1, i])
                            + " " + Convert.ToString(neuron6.weight[2, i]);
                        sr6[i] = s6;
                        sw6.WriteLine(s6);
                    }
                    sw6.Close();
                    break;
                case "7":
                    if (neuron7.Result()) neuron7.Decrement(input);
                    else neuron7.Increment(input);
                    string s7 = "";
                    string[] sr7 = new string[5];
                    File.Delete("n7.txt");
                    FileStream fs7 = new FileStream("n7.txt", FileMode.OpenOrCreate);
                    StreamWriter sw7 = new StreamWriter(fs7);
                    for (int i = 0; i <= 4; i++)
                    {
                        s7 = Convert.ToString(neuron7.weight[0, i]) + " " + Convert.ToString(neuron7.weight[1, i])
                            + " " + Convert.ToString(neuron7.weight[2, i]);
                        sr7[i] = s7;
                        sw7.WriteLine(s7);
                    }
                    sw7.Close();
                    break;
                case "8":
                    if (neuron8.Result()) neuron8.Decrement(input);
                    else neuron8.Increment(input);
                    string s8 = "";
                    string[] sr8 = new string[5];
                    File.Delete("n8.txt");
                    FileStream fs8 = new FileStream("n8.txt", FileMode.OpenOrCreate);
                    StreamWriter sw8 = new StreamWriter(fs8);
                    for (int i = 0; i <= 4; i++)
                    {
                        s8 = Convert.ToString(neuron8.weight[0, i]) + " " + Convert.ToString(neuron8.weight[1, i])
                            + " " + Convert.ToString(neuron8.weight[2, i]);
                        sr8[i] = s8;
                        sw8.WriteLine(s8);
                    }
                    sw8.Close();
                    break;
                case "9":
                    if (neuron9.Result()) neuron9.Decrement(input);
                    else neuron9.Increment(input);
                    string s9 = "";
                    string[] sr9 = new string[5];
                    File.Delete("n9.txt");
                    FileStream fs9 = new FileStream("n9.txt", FileMode.OpenOrCreate);
                    StreamWriter sw9 = new StreamWriter(fs9);
                    for (int i = 0; i <= 4; i++)
                    {
                        s9 = Convert.ToString(neuron9.weight[0, i]) + " " + Convert.ToString(neuron9.weight[1, i])
                            + " " + Convert.ToString(neuron9.weight[2, i]);
                        sr9[i] = s9;
                        sw9.WriteLine(s9);
                    }
                    sw9.Close();
                    break;
            }
        }

        private void Recognize(object sender, EventArgs e)
        {
            int c = 0;
            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 4; y++)
                {
                    switch (c)
                    {
                        case 0:
                            if (button1.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 1:
                            if (button4.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 2:
                            if (button7.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 3:
                            if (button10.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 4:
                            if (button13.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 5:
                            if (button2.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 6:
                            if (button5.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 7:
                            if (button8.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 8:
                            if (button11.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 9:
                            if (button14.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 10:
                            if (button3.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 11:
                            if (button6.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 12:
                            if (button9.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 13:
                            if (button12.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                        case 14:
                            if (button15.BackColor == Color.Black) input[x, y] = 1;
                            else input[x, y] = 0;
                            break;
                    }
                    c++;
                }
            }
            neuron0 = new Neuron(3, 5, input);
            neuron1 = new Neuron(3, 5, input);
            neuron2 = new Neuron(3, 5, input);
            neuron3 = new Neuron(3, 5, input);
            neuron4 = new Neuron(3, 5, input);
            neuron5 = new Neuron(3, 5, input);
            neuron6 = new Neuron(3, 5, input);
            neuron7 = new Neuron(3, 5, input);
            neuron8 = new Neuron(3, 5, input);
            neuron9 = new Neuron(3, 5, input);
            StreamReader sr0 = File.OpenText("n0.txt");
            StreamReader sr1 = File.OpenText("n1.txt");
            StreamReader sr2 = File.OpenText("n2.txt");
            StreamReader sr3 = File.OpenText("n3.txt");
            StreamReader sr4 = File.OpenText("n4.txt");
            StreamReader sr5 = File.OpenText("n5.txt");
            StreamReader sr6 = File.OpenText("n6.txt");
            StreamReader sr7 = File.OpenText("n7.txt");
            StreamReader sr8 = File.OpenText("n8.txt");
            StreamReader sr9 = File.OpenText("n9.txt");
            string line0, line1, line2, line3, line4, line5, line6, line7, line8, line9;
            string[] s0, s1, s2, s3, s4, s5, s6, s7, s8, s9;
            int k = 0;
            while (sr0.EndOfStream != true)
            {
                line0 = sr0.ReadLine();
                line1 = sr1.ReadLine();
                line2 = sr2.ReadLine();
                line3 = sr3.ReadLine();
                line4 = sr4.ReadLine();
                line5 = sr5.ReadLine();
                line6 = sr6.ReadLine();
                line7 = sr7.ReadLine();
                line8 = sr8.ReadLine();
                line9 = sr9.ReadLine();
                s0 = line0.Split(' ');
                s1 = line1.Split(' ');
                s2 = line2.Split(' ');
                s3 = line3.Split(' ');
                s4 = line4.Split(' ');
                s5 = line5.Split(' ');
                s6 = line6.Split(' ');
                s7 = line7.Split(' ');
                s8 = line8.Split(' ');
                s9 = line9.Split(' ');
                for (int i = 0; i < 3; i++)
                {
                    if (k < 5)
                    {
                        neuron0.weight[i, k] = Convert.ToInt32(s0[i]);
                        neuron1.weight[i, k] = Convert.ToInt32(s1[i]);
                        neuron2.weight[i, k] = Convert.ToInt32(s2[i]);
                        neuron3.weight[i, k] = Convert.ToInt32(s3[i]);
                        neuron4.weight[i, k] = Convert.ToInt32(s4[i]);
                        neuron5.weight[i, k] = Convert.ToInt32(s5[i]);
                        neuron6.weight[i, k] = Convert.ToInt32(s6[i]);
                        neuron7.weight[i, k] = Convert.ToInt32(s7[i]);
                        neuron8.weight[i, k] = Convert.ToInt32(s8[i]);
                        neuron9.weight[i, k] = Convert.ToInt32(s9[i]);
                    }

                }
                k++;
            }
            sr0.Close();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            sr4.Close();
            sr5.Close();
            sr6.Close();
            sr7.Close();
            sr8.Close();
            sr9.Close();
            if (neuron0.Result()) label2.Text = "0";
            else if (neuron1.Result()) label2.Text = "1";
            else if (neuron2.Result()) label2.Text = "2";
            else if (neuron3.Result()) label2.Text = "3";
            else if (neuron4.Result()) label2.Text = "4";
            else if (neuron5.Result()) label2.Text = "5";
            else if (neuron6.Result()) label2.Text = "6";
            else if (neuron7.Result()) label2.Text = "7";
            else if (neuron8.Result()) label2.Text = "8";
            else if (neuron9.Result()) label2.Text = "9";
            else label2.Text = "Не удалось \nраспознать";
        }
    }
}
