using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buckler
{
    
    public partial class Form1 : Form
    {
        cntr valor = new cntr();
        public Form1()
        {
            InitializeComponent();
            this.contextMenuStrip1.Renderer = new MyRenderer();
        }

        private void LD(object sender, EventArgs e)
        {
            this.Hide();
            Main();  
        }

        private async void Main()
        {
            var moment = DateTime.Now;
            string command = "script.bat";
            System.Diagnostics.Process.Start(command);

            string path = Directory.GetCurrentDirectory();
            string ruta = path + @"\settings.txt";
            int cnt = 300; // Minutos a dormir (60 * 5 -> 5h)
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
                cnt = Int32.Parse(text);
            }
            
            while (true)
            {

                if (cnt <= 0)
                {
                    // MessageBox.Show("2");
                    System.Diagnostics.Process.Start(command);
                    string text = File.ReadAllText(ruta);
                    cnt = Int32.Parse(text);
                    valor.count = cnt;

                }
                else
                {
                    cnt = cnt - 1;
                    valor.count = cnt;

                }

                
                notifyIcon1.Text = cnt.ToString();
                this.Text = "Minutos restantes: " + cnt.ToString();
                await Task.Delay(60000); // 1 (ms) * 1000 (s) * 60 (m) 
                
            }
        }

        private void iconClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    ///Form2.Close();
                    Form2 form2 = new Form2(valor);
                    
                    form2.Show();
                    break;

                case MouseButtons.Right:
                    
                    break;
            }
            
        }

        private void act(object sender, EventArgs e)
        {
            this.Text = valor.count.ToString();
        }

        private void open(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(valor);
            form2.Show();
        }

        private void shutdown(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class cntr
    {
        public int count_ = 0;

        public int count
        {
            get
            {
                return count_;
            }
            set
            {
                count_ = value;
            }
        }
    }
    public class MyRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if ( e.Item.Text == "Buckler v2.9")
            {
                Rectangle r2 = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(Brushes.DarkGreen, r2);

            }

            if (e.Item.Selected && e.Item.Text == "abrir")
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(Brushes.Navy, rc);
                e.Item.ForeColor = System.Drawing.Color.White;

            }

            if (e.Item.Selected  && e.Item.Text == "salir")
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(Brushes.Navy, rc);
                e.Item.ForeColor = System.Drawing.Color.Red;
               
            }
            
        }
    }

    
}
