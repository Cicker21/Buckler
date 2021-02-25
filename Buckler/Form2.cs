using System;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buckler
{
   
    public partial class Form2 : Form
    {
        private cntr aye;


        public Form2(cntr sharedCntr)
        {
            aye = sharedCntr;
            InitializeComponent();
        }

        private void Save(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string ruta = path + @"\script.bat";
            string sets = path + @"\settings.txt";


            if (!File.Exists(ruta))
            {
                using (StreamWriter sw = File.CreateText(ruta))
                {
                    sw.Write(code.Text);
                }
            }
            else
            {
                using (StreamWriter se = new StreamWriter(ruta))
                {
                    se.Write(code.Text);
                }
            }
            int x = 300;
            try
            {
                 x = Int32.Parse(setTime.Text);
            }
            catch (Exception) 
            {
                 x = 300;
                setTime.Text = 300.ToString();
                
            }
            if (!File.Exists(sets))
            {
                using (StreamWriter sw = File.CreateText(sets))
                {
                    sw.Write(x);
                }
            }
            else
            {
                using (StreamWriter se = new StreamWriter(sets))
                {
                    se.Write(x);
                }
            }
            MessageBox.Show("Todos los valores se han guardado con éxito");
        }
        
        private void changedcode(object sender, EventArgs e)
        {
            this.code.ForeColor = Color.White;
            this.CheckKeyword("start", Color.Cyan, 0);
            this.CheckKeyword("@echo off", Color.Red, 0);
            this.CheckKeyword("START", Color.Cyan, 0);
            this.CheckKeyword("@ECHO OFF", Color.Red, 0);
            this.CheckKeyword("pause", Color.Yellow, 0);
            this.CheckKeyword("cd", Color.LightBlue, 0);
            this.CheckKeyword("goto", Color.NavajoWhite, 0);
            this.CheckKeyword("mkdir", Color.LightGreen, 0);
            this.CheckKeyword("echo", Color.Crimson, 0);
            this.CheckKeyword("exit", Color.Pink, 0);
        }
        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.code.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.code.SelectionStart;

                while ((index = this.code.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.code.Select((index + startIndex), word.Length);
                    this.code.SelectionColor = color;
                    this.code.Select(selectStart, 0);
                    this.code.SelectionColor = Color.White;
                }
            }
        }
        private void ReadBat()
        {
            string path = Directory.GetCurrentDirectory();
            string ruta = path + @"\script.bat";
            if (!File.Exists(ruta))
            {
                using (StreamWriter sw = File.CreateText(ruta))
                {
                    sw.Write("@echo off");
                    code.Text = "@echo off";
                }
            }
            else
            {
                string text = File.ReadAllText(ruta);
                code.Text = text;
            }
        }
        private void ReadDelay()
        {
            string path = Directory.GetCurrentDirectory();
            string ruta = path + @"\settings.txt";
            if (!File.Exists(ruta))
            {
                using (StreamWriter sw = File.CreateText(ruta))
                {
                    sw.Write("300");
                }
            }
            else
            {
                string text = File.ReadAllText(ruta);
                setTime.Text = text;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Read();
            ReadBat();
            ReadDelay();
        }

        private async void Read()
        {
            while (true)
            {
                int glob = aye.count;

                string def = glob.ToString();
                caja2.Text = "Tiempo restante: " + def;

                var moment = DateTime.Now;
                string H = moment.ToString("HH");
                string M = moment.ToString("mm");

                int h = Int32.Parse(H);
                int m = Int32.Parse(M);
                int h_m = h * 60;
                int total = h_m + m + glob;

                int total_h = total / 60;
                int total_m = total % 60;

                if (total_h > 24)
                {
                    total_h = total_h - 24;
                }

                string prox_H;
                if (total_h < 10)
                {
                    prox_H = "0" + total_h.ToString();
                }
                else
                {
                    prox_H = total_h.ToString();
                }

                string prox_M;
                if (total_m < 10)
                {
                    prox_M = "0" + total_m.ToString();
                }
                else
                {
                    prox_M = total_m.ToString();
                }

                string prox_date = prox_H + ":" + prox_M;
                caja1.Text = "Próxima ejecución: " + prox_date;
                this.Text = "Hora: " + H + ":" + M + " | " + "total: " + total + " / " + "total_h: " + total_h + " / " + "total_m: " + total_m;

                await Task.Delay(500);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                calcu.Text = (Int32.Parse(calcu.Text) * 60).ToString();
            }
            catch (Exception) { }
        }
    }


}
