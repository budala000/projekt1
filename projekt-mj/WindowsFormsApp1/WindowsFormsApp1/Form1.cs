using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            x.Text = "x";
            y.Text = "y";
            x2.Text = "x^2";
            y2.Text = "y";
            plus.Text = "+";
            plus1.Text = "+";
            jedn.Text = "=";
            jedn1.Text = "=";
            nula.Text = "0";
            kor1.Text = "√(";
            kor2.Text = "√(";
            zag1.Text = ")";
            zag2.Text = ")";
        }

        int odabir;
        double b1, b2, b3, rj1, rj2;
        double b4, b5, b6;
        double[,] nep = new double[2, 2];
        double[] broj = new double[2];

        TextBox a = new TextBox();
        TextBox b = new TextBox();
        TextBox c = new TextBox();
        TextBox ax = new TextBox();
        TextBox by = new TextBox();
        TextBox cb = new TextBox();
        Label x = new Label();
        Label y = new Label();
        Label x2 = new Label();
        Label y2 = new Label();
        Label plus = new Label();
        Label plus1 = new Label();
        Label jedn = new Label();
        Label jedn1 = new Label();
        Label nula = new Label();
        Label kor1 = new Label();
        Label kor2 = new Label();
        Label zag1 = new Label();
        Label zag2 = new Label();
        OpenFileDialog opf1 = new OpenFileDialog();

        private void sustav_Click(object sender, EventArgs e)
        {
            otvori_sus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linearna_Click(object sender, EventArgs e)
        {
            odabir = 0;
            rez.Text = "";
            panel1.Controls.Clear();
            panel1.Controls.Add(a);
            a.Text = " ";
            panel1.Controls.Add(b);
            b.Text = " ";
            panel1.Controls.Add(c);
            c.Text = " ";
            a.Location = new Point(10, 52);
            a.Size = new Size(100, 20);
            b.Location = new Point(170, 52);
            b.Size = new Size(100, 20);
            c.Location = new Point(330, 52);
            c.Size = new Size(100, 20);
            panel1.Controls.Add(x);
            panel1.Controls.Add(plus);
            panel1.Controls.Add(jedn);
            x.Location = new Point(111, 54);
            x.Size = new Size(10, 20);
            plus.Location = new Point(133, 54);
            jedn.Location = new Point(293, 54);
        }

        private void kvadrat_Click(object sender, EventArgs e)
        {
            odabir = 1;
            rez.Text = "";
            panel1.Controls.Clear();
            panel1.Controls.Add(a);
            a.Text = " ";
            panel1.Controls.Add(b);
            b.Text = " ";
            panel1.Controls.Add(c);
            c.Text = " ";
            a.Location = new Point(10, 52);
            a.Size = new Size(50, 20);
            b.Location = new Point(120, 52);
            b.Size = new Size(50, 20);
            c.Location = new Point(230, 52);
            c.Size = new Size(50, 20);
            panel1.Controls.Add(x2);
            panel1.Controls.Add(x);
            panel1.Controls.Add(plus);
            panel1.Controls.Add(plus1);
            panel1.Controls.Add(jedn);
            panel1.Controls.Add(nula);
            x2.Text = "x^2";
            x2.Location = new Point(61, 54);
            x2.Size = new Size(30, 20);
            plus.Location = new Point(90, 54);
            plus.Size = new Size(10, 20);
            x.Location = new Point(171, 54);
            x.Size = new Size(10, 20);
            plus1.Location = new Point(193, 54);
            jedn.Location = new Point(300, 54);
            jedn.Size = new Size(10, 20);
            nula.Location = new Point(330, 54);

        }

        private void iracionalna_Click(object sender, EventArgs e)
        {
            odabir = 3;
            rez.Text = "";
            panel1.Controls.Clear();
            panel1.Controls.Add(a);
            a.Text = " ";
            panel1.Controls.Add(b);
            b.Text = " ";
            panel1.Controls.Add(c);
            c.Text = " ";
            panel1.Controls.Add(ax);
            ax.Text = " ";
            panel1.Controls.Add(by);
            by.Text = " ";
            panel1.Controls.Add(kor1);
            panel1.Controls.Add(kor2);
            kor1.Location = new Point(4, 54);
            kor1.Size = new Size(16, 20);
            a.Location = new Point(20, 52);
            a.Size = new Size(50, 20);
            ax.Location = new Point(110, 52);
            ax.Size = new Size(50, 20);
            kor2.Location = new Point(200, 54);
            kor2.Size = new Size(19, 20);
            b.Location = new Point(220, 52);
            b.Size = new Size(50, 20);
            by.Location = new Point(310, 52);
            by.Size = new Size(50, 20);
            c.Location = new Point(410, 52);
            c.Size = new Size(50, 20);
            panel1.Controls.Add(x2);
            panel1.Controls.Add(x);
            panel1.Controls.Add(plus);
            panel1.Controls.Add(plus1);
            panel1.Controls.Add(jedn);
            panel1.Controls.Add(jedn1);
            panel1.Controls.Add(zag1);
            panel1.Controls.Add(zag2);
            x2.Text = "x";
            x2.Location = new Point(71, 54);
            x2.Size = new Size(20, 20);
            plus.Location = new Point(90, 54);
            plus.Size = new Size(10, 20);
            zag1.Location = new Point(161, 54);
            zag1.Size = new Size(10, 20);
            x.Location = new Point(271, 54);
            x.Size = new Size(10, 20);
            plus1.Location = new Point(291, 54);
            plus1.Size = new Size(10, 20);
            zag2.Text = ")";
            zag2.Location = new Point(361, 54);
            zag2.Size = new Size(10, 20);
            jedn.Location = new Point(180, 54);
            jedn.Size = new Size(10, 20);
            jedn1.Text = "+";
            jedn1.Location = new Point(380, 54);
            jedn1.Size = new Size(10, 20);
        }

        private void izr_Click(object sender, EventArgs e)
        {
            if (odabir == 0)
            {
                try
                {
                    b1 = double.Parse(a.Text.ToString());
                    b2 = double.Parse(b.Text.ToString());
                    b3 = double.Parse(c.Text.ToString());

                    rj1 = (b3 - b2) / b1;
                    if (rj1 == double.NaN)
                    {
                        rez.Text = "Nema rješenja";
                    }
                    else
                    {
                        rez.Text = "x = " + rj1.ToString();
                    }

                    string tekst = b1 + "x + " + b2 + " = " + b3 + "\t x = " + rj1;
                    listBox1.Items.Add(tekst);
                }
                catch
                {
                    rez.Text = "Greska";
                }
            }
            else if (odabir == 1)
            {
                try
                {
                    b1 = double.Parse(a.Text.ToString());
                    b2 = double.Parse(b.Text.ToString());
                    b3 = double.Parse(c.Text.ToString());

                    double d = b2 * b2 - 4 * b1 * b3;
                    if (d < 0)
                    {
                        rez.Text = "Nema realnih rješenja";
                    }
                    else
                    {
                        rj1 = (-b2 + Math.Sqrt(d)) / (2 * b1);
                        rj2 = (-b2 - Math.Sqrt(d)) / (2 * b1);
                        rez.Text = "x1 = " + rj1.ToString() + ", x2 = " + rj2.ToString();
                    }

                    string tekst = b1 + "x2 + " + b2 + "x + " + b3 + " = " + 0 + "\t x1 = " + rj1 + ", x2 = " + rj2;
                    listBox1.Items.Add(tekst);
                }
                catch
                {
                    rez.Text = "Greska";
                }
            }
            else if (odabir == 2)
            {
                try
                {
                    nep[0, 0] = double.Parse(a.Text.ToString());
                    nep[0, 1] = double.Parse(b.Text.ToString());
                    nep[1, 0] = double.Parse(ax.Text.ToString());
                    nep[1, 1] = double.Parse(by.Text.ToString());
                    broj[0] = double.Parse(c.Text.ToString());
                    broj[1] = double.Parse(cb.Text.ToString());
                    double[] rjes = sustavizr(nep, broj);
                    if (rjes[0] == double.PositiveInfinity || rjes[0] == double.NegativeInfinity)
                    {
                        rez.Text = "Nema rjesenja";
                    }
                    else if (rjes[0].ToString() == "NaN")
                    {
                        rez.Text = "Nema rjesenja";
                    }
                    else
                    {
                        rez.Text = "x = " + rjes[0].ToString() + ", y = " + rjes[1].ToString();
                    }

                    string tekst = nep[0, 0] + "x + " + nep[1, 0] + "y = " + broj[0] + "  " +
                        nep[0, 1] + "x + " + nep[1, 1] + "y = " + broj[1] + "    x = " + rjes[0] + ", y = " + rjes[1];
                    listBox1.Items.Add(tekst);
                }
                catch
                {
                    rez.Text = "Greska";
                }
            }
            else if (odabir == 3)
            {
                try
                {
                    b1 = double.Parse(a.Text.ToString());
                    b2 = double.Parse(ax.Text.ToString());
                    b3 = double.Parse(b.Text.ToString());
                    b4 = double.Parse(by.Text.ToString());
                    b5 = double.Parse(c.Text.ToString());
                    double root = iracizr(b1, b2, b3, b4, b5);
                    if (Math.Round(root) - root < 0.001)
                    {
                        root = Math.Round(root);
                        rez.Text = "x = " + root.ToString();
                    }
                    else
                    {
                        rez.Text = "x = " + root.ToString();
                    }
                    string tekst = "√( " + b1 + "x + " + b2 + ") = √( " + b3 + "x + " + b4 + ") + " + b5 + "\t x = " + root;
                    listBox1.Items.Add(tekst);
                }
                catch (Exception ee)
                {
                    rez.Text = (ee.Message);
                }
            }
            else if (odabir == 4) {
                try
                {
                    b1 = double.Parse(a.Text.ToString());
                    b2 = double.Parse(b.Text.ToString());
                    b3 = double.Parse(c.Text.ToString());
                    b4 = double.Parse(cb.Text.ToString());
                    double[] rjesk = kubizr(b1, b2, b3, b4);
                    if (rjesk.Length == 3)
                    {
                        rez.Text = "x1 = " + rjesk[0] + ", x2 = " + rjesk[1] + ", x3 = " + rjesk[2];
                        string tekst = b1 + "x3 + " + b2 + "x2 + " + b3 + "x + " + b4 + " = 0" + "\t x1 = " + rjesk[0] + ", x2 = " + rjesk[1] + ", x3 = " + rjesk[2];
                        listBox1.Items.Add(tekst);
                    }
                    else if (rjesk.Length == 5)
                    {
                        rez.Text = "x1 = " + rjesk[0] + ", x2 real = " + rjesk[1] + ", x2 imag = " + rjesk[2] + ", x3 real = " + rjesk[3] + ", x3 imag = " + rjesk[4];
                        string tekst = b1 + "x3 + " + b2 + "x2 + " + b3 + "x + " + b4 + " = 0" + "\t x1 = " + rjesk[0] + ", x2 = " + rjesk[2];
                        listBox1.Items.Add(tekst);
                    }
                }
                catch (Exception ee)
                {
                    rez.Text = ee.Message;
                }
            }
            else if (odabir == 5)
            {
                try
                {
                    b1 = double.Parse(a.Text.ToString());
                    b2 = double.Parse(b.Text.ToString());
                    b3 = double.Parse(ax.Text.ToString());
                    b4 = double.Parse(by.Text.ToString());
                    b5 = double.Parse(c.Text.ToString());
                    b6 = double.Parse(cb.Text.ToString());
                }
                catch
                {
                    rez.Text = "Greska";
                }

                if (b1 <= 0 || b2 <= 0)
                {
                    rez.Text = "Baze nisu kompatibilne";
                }
                else
                {
                    try {
                        double eks = Math.Log(b2) / Math.Log(b1);
                        if (b3 - eks * b4 == 0)
                        {
                            rez.Text = "Nema rjesenja";
                        }
                        else
                        {
                            double r = ekspizr(eks, b3, b4, b5, b6);
                            rez.Text = "x = " + r.ToString();
                            string tekst = b1 + "^(" + b3 + "x + " + b5 + ") = " + b2 + "^(" + b4 + "x + " + b6 + ") \t x = " + r;
                            listBox1.Items.Add(tekst);
                        }
                    }
                    catch (Exception ee)
                    {
                        rez.Text = ee.Message;
                    }
                    }
            }
        }

        private void kubna_Click(object sender, EventArgs e)
        {
            odabir = 4;
            rez.Text = "";
            panel1.Controls.Clear();
            panel1.Controls.Add(a);
            a.Text = " ";
            panel1.Controls.Add(b);
            b.Text = " ";
            panel1.Controls.Add(c);
            c.Text = " ";
            panel1.Controls.Add(cb);
            cb.Text = " ";
            a.Location = new Point(10, 52);
            a.Size = new Size(50, 20);
            b.Location = new Point(110, 52);
            b.Size = new Size(50, 20);
            c.Location = new Point(210, 52);
            c.Size = new Size(50, 20);
            cb.Location = new Point(300, 52);
            cb.Size = new Size(50, 20);

            panel1.Controls.Add(y);
            y.Text = "x^3";
            y.Location = new Point(61, 54);
            y.Size = new Size(25, 20);
            panel1.Controls.Add(plus);
            plus.Location = new Point(90, 54);
            plus.Size = new Size(10, 20);
            panel1.Controls.Add(x2);
            x2.Text = "x^2";
            x2.Location = new Point(161, 54);
            x2.Size = new Size(25, 20);
            panel1.Controls.Add(plus1);
            plus1.Location = new Point(190, 54);
            plus1.Size = new Size(10, 20);
            panel1.Controls.Add(x);
            x.Location = new Point(261, 54);
            x.Size = new Size(10, 20);
            panel1.Controls.Add(jedn1);
            jedn1.Text = "+";
            jedn1.Location = new Point(280, 54);
            jedn1.Size = new Size(10, 20);
            panel1.Controls.Add(jedn);
            jedn.Location = new Point(360, 54);
            jedn.Size = new Size(10, 20);
            panel1.Controls.Add(nula);
            nula.Location = new Point(380, 54);
            nula.Size = new Size(10, 20);
        }

        private void ekspo_Click(object sender, EventArgs e)
        {
            odabir = 5;
            rez.Text = "";
            panel1.Controls.Clear();
            panel1.Controls.Add(a);
            a.Text = " ";
            panel1.Controls.Add(b);
            b.Text = " ";
            panel1.Controls.Add(c);
            c.Text = " ";
            panel1.Controls.Add(ax);
            ax.Text = " ";
            panel1.Controls.Add(by);
            by.Text = " ";
            panel1.Controls.Add(cb);
            cb.Text = " ";
            a.Location = new Point(10, 52);
            a.Size = new Size(50, 20);
            ax.Location = new Point(61, 37);
            ax.Size = new Size(30, 20);
            c.Location = new Point(130, 37);
            c.Size = new Size(30, 20);
            b.Location = new Point(190, 52);
            b.Size = new Size(50, 20);
            by.Location = new Point(241, 37);
            by.Size = new Size(30, 20);
            cb.Location = new Point(310, 37);
            cb.Size = new Size(30, 20);

            panel1.Controls.Add(x);
            x.Location = new Point(92, 39);
            x.Size = new Size(10, 20);
            panel1.Controls.Add(plus);
            plus.Location = new Point(110, 39);
            plus.Size = new Size(10, 20);
            panel1.Controls.Add(jedn);
            jedn.Location = new Point(170, 54);
            jedn.Size = new Size(10, 20);
            panel1.Controls.Add(x2);
            x2.Location = new Point(272, 39);
            x2.Text = "x";
            x2.Size = new Size(10, 20);
            panel1.Controls.Add(plus1);
            plus1.Location = new Point(290, 39);
            plus1.Size = new Size(10, 20);
        }

        private void spremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opf1.ShowDialog() == DialogResult.OK)
            {
                string put = opf1.FileName;
                try
                {
                    using (StreamWriter sw = new StreamWriter(put))
                    {
                        foreach (var item in listBox1.Items)
                        {
                            sw.WriteLine(item.ToString());
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Greska: " + ex.Message);                }
            }
        }

        public static double[] sustavizr(double[,] nepoz, double[] broji)
        {
            int red = nepoz.GetLength(0);
            int stup = nepoz.GetLength(1);
            double[,] matrica = new double[red, stup + 1];

            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stup; j++)
                {
                    matrica[i, j] = nepoz[i, j];
                }

                matrica[i, stup] = broji[i];
            }

            for (int k = 0; k < red; k++)
            {
                double pivot = matrica[k, k];
                for (int j = k; j <= stup; j++)
                {
                    matrica[k, j] /= pivot;
                }

                for (int i = 0; i < red; i++)
                {
                    if (i != k)
                    {
                        double f = matrica[i, k];
                        for (int j = k; j <= stup; j++)
                        {
                            matrica[i, j] -= f * matrica[k, j];
                        }
                    }
                }
            }

            double[] rjes = new double[red];
            for (int i = 0; i < red; i++)
            {
                rjes[i] = matrica[i, stup];

            }

            return rjes;
        }

        public void otvori_sus()
        {
            odabir = 2;
            rez.Text = "";
            panel1.Controls.Clear();
            panel1.Controls.Add(a);
            a.Text = " ";
            panel1.Controls.Add(b);
            b.Text = " ";
            panel1.Controls.Add(c);
            c.Text = " ";
            panel1.Controls.Add(ax);
            ax.Text = " ";
            panel1.Controls.Add(by);
            by.Text = " ";
            panel1.Controls.Add(cb);
            cb.Text = " ";
            a.Location = new Point(10, 52);
            a.Size = new Size(100, 20);
            b.Location = new Point(170, 52);
            b.Size = new Size(100, 20);
            c.Location = new Point(330, 52);
            c.Size = new Size(100, 20);
            ax.Location = new Point(10, 75);
            ax.Size = new Size(100, 20);
            by.Location = new Point(170, 75);
            by.Size = new Size(100, 20);
            cb.Location = new Point(330, 75);
            cb.Size = new Size(100, 20);

            panel1.Controls.Add(x);
            panel1.Controls.Add(y);
            panel1.Controls.Add(plus);
            panel1.Controls.Add(jedn);
            x.Location = new Point(111, 54);
            x.Size = new Size(10, 20);
            y.Location = new Point(271, 54);
            y.Size = new Size(10, 20);
            y.Text = "y";
            plus.Location = new Point(133, 54);
            jedn.Location = new Point(293, 54);

            panel1.Controls.Add(x2);
            x2.Text = "x";
            panel1.Controls.Add(y2);
            panel1.Controls.Add(plus1);
            panel1.Controls.Add(jedn1);
            jedn1.Text = "=";
            x2.Location = new Point(111, 77);
            x2.Size = new Size(10, 20);
            y2.Location = new Point(271, 77);
            y2.Text = "y";
            y2.Size = new Size(10, 20);
            plus1.Location = new Point(133, 77);
            jedn1.Location = new Point(293, 77);

        }

        public static double iracizr(double b1, double b2, double b3, double b4, double b5)
        {
            double pokizr(double x)
            {
                return Math.Sqrt(b1 * x + b2) - (Math.Sqrt(b3 * x + b4) + b5);
            }
            double pok = 1.0;
            double tolerancija = 0.00001;
            int makspok = 1000;

            for (int i = 0; i < makspok; i++)
            {
                double f = pokizr(pok);
                double fprost = (pokizr(pok + tolerancija) - pokizr(pok - tolerancija)) / (2 * tolerancija);
                double sljed = pok - f / fprost;

                if (Math.Abs(sljed - pok) < tolerancija)
                {
                    return sljed;
                }

                pok = sljed;
            }
            throw new Exception("Greska");
        }
        public static double[] kubizr(double a, double b, double c, double d)
        {
            if (Math.Abs(a) < double.Epsilon)
            {
                throw new ArgumentException("a ne smije biti 0, probaj kvadratnu jednadzbu");
            }

            double diskriminanta = (18 * a * b * c * d) - (4 * b * b * b * d) + (b * b * c * c) - (4 * a * c * c * c) - (27 * a * a * d * d);
            if (diskriminanta > 0 && b==0 && d==0)
            {
                throw new ArgumentException("x1 = " + 0 + ", x2 = " + Math.Sqrt(-c / a));
            }
            else if(diskriminanta > 0)
            {
                throw new ArgumentException("Jednadzba ima samo 1 realan korijen");
            }
            else if (Math.Abs(diskriminanta) < double.Epsilon)
            {
                double root = -b / (3 * a);
                return new double[] { root, root, root };
            }
            else
            {
                double p = (3 * a * c - b * b) / (3 * a * a);
                double q = (2 * b * b * b - 9 * a * b * c + 27 * a * a * d) / (27 * a * a * a);

                double diskrimKor = Math.Sqrt((q * q) / 4 + (p * p * p) / 27);
                double u = Cbrt(-q / 2 + diskrimKor);
                double v = Cbrt(-q / 2 - diskrimKor);

                double root1 = u + v - (b / (3 * a));
                double root2r = -(u + v) / 2 - (b / (3 * a));
                double root2i = Math.Abs((u - v) * Math.Sqrt(3) / 2);
                double root3r = -(u + v) / 2 - (b / (3 * a));
                double root3i = -Math.Abs((u - v) * Math.Sqrt(3) / 2);

                return new double[] { root1, root2r, root2i, root3r, root3i };
            }
        }
        private static double Cbrt(double value)
        {
            if (value >= 0)
            {
                return Math.Pow(value, 1.0 / 3.0);
            }
            else
            {
                return -Math.Pow(Math.Abs(value), 1.0 / 3.0);
            }
        }

        private static double ekspizr(double eks, double eks1, double eks2, double c1, double c2)
        {

            double rj1 = (eks*c2 - c1) / (eks1-eks*eks2);
            if (rj1 == double.NaN)
            {
                throw new Exception("Nema rjesenja");

            }
            else
            {
                return rj1;
            }
        }
    }
}
