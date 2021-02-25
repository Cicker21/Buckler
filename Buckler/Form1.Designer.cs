namespace Buckler
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem actual;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siguiente = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            actual = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actual
            // 
            actual.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
            actual.BackColor = System.Drawing.Color.DarkGreen;
            actual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            actual.ForeColor = System.Drawing.SystemColors.Control;
            actual.MergeAction = System.Windows.Forms.MergeAction.Insert;
            actual.MergeIndex = 3;
            actual.Name = "actual";
            actual.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            actual.Size = new System.Drawing.Size(155, 26);
            actual.Text = "Buckler v2.9";
            actual.VisibleChanged += new System.EventHandler(this.act);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "BallTxt";
            this.notifyIcon1.BalloonTipTitle = "BallTit";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BucklerTxt";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.contextMenuStrip1.AllowMerge = false;
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(40)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            actual,
            this.siguiente,
            this.salir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.ShowItemToolTips = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 104);
            // 
            // siguiente
            // 
            this.siguiente.ForeColor = System.Drawing.SystemColors.Control;
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(155, 26);
            this.siguiente.Text = "abrir";
            this.siguiente.Click += new System.EventHandler(this.open);
            // 
            // salir
            // 
            this.salir.ForeColor = System.Drawing.Color.Red;
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(155, 26);
            this.salir.Text = "salir";
            this.salir.Click += new System.EventHandler(this.shutdown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.LD);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siguiente;
        private System.Windows.Forms.ToolStripMenuItem salir;
    }
}