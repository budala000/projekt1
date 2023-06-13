
namespace WindowsFormsApp1
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sustav = new System.Windows.Forms.ToolStripMenuItem();
            this.kvadrat = new System.Windows.Forms.ToolStripMenuItem();
            this.linearna = new System.Windows.Forms.ToolStripMenuItem();
            this.iracionalna = new System.Windows.Forms.ToolStripMenuItem();
            this.kubna = new System.Windows.Forms.ToolStripMenuItem();
            this.ekspo = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.TextBox();
            this.izr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spremiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sustav,
            this.kvadrat,
            this.linearna,
            this.iracionalna,
            this.kubna,
            this.ekspo});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItem1.Text = "Jednadzbe";
            // 
            // sustav
            // 
            this.sustav.Name = "sustav";
            this.sustav.Size = new System.Drawing.Size(159, 22);
            this.sustav.Text = "Sustav";
            this.sustav.Click += new System.EventHandler(this.sustav_Click);
            // 
            // kvadrat
            // 
            this.kvadrat.Name = "kvadrat";
            this.kvadrat.Size = new System.Drawing.Size(159, 22);
            this.kvadrat.Text = "Kvadratna";
            this.kvadrat.Click += new System.EventHandler(this.kvadrat_Click);
            // 
            // linearna
            // 
            this.linearna.Name = "linearna";
            this.linearna.Size = new System.Drawing.Size(159, 22);
            this.linearna.Text = "Linearna";
            this.linearna.Click += new System.EventHandler(this.linearna_Click);
            // 
            // iracionalna
            // 
            this.iracionalna.Name = "iracionalna";
            this.iracionalna.Size = new System.Drawing.Size(159, 22);
            this.iracionalna.Text = "Iracionalna";
            this.iracionalna.Click += new System.EventHandler(this.iracionalna_Click);
            // 
            // kubna
            // 
            this.kubna.Name = "kubna";
            this.kubna.Size = new System.Drawing.Size(159, 22);
            this.kubna.Text = "Kubna";
            this.kubna.Click += new System.EventHandler(this.kubna_Click);
            // 
            // ekspo
            // 
            this.ekspo.Name = "ekspo";
            this.ekspo.Size = new System.Drawing.Size(159, 22);
            this.ekspo.Text = "Eksponencijalna";
            this.ekspo.Click += new System.EventHandler(this.ekspo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rješenje:";
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(155, 397);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(372, 20);
            this.rez.TabIndex = 2;
            // 
            // izr
            // 
            this.izr.Location = new System.Drawing.Point(604, 160);
            this.izr.Name = "izr";
            this.izr.Size = new System.Drawing.Size(75, 23);
            this.izr.TabIndex = 3;
            this.izr.Text = "Izračunaj";
            this.izr.UseVisualStyleBackColor = true;
            this.izr.Click += new System.EventHandler(this.izr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(58, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 221);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(533, 200);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 134);
            this.listBox1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spremiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // spremiToolStripMenuItem
            // 
            this.spremiToolStripMenuItem.Name = "spremiToolStripMenuItem";
            this.spremiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spremiToolStripMenuItem.Text = "Spremi";
            this.spremiToolStripMenuItem.Click += new System.EventHandler(this.spremiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.izr);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sustav;
        private System.Windows.Forms.ToolStripMenuItem kvadrat;
        private System.Windows.Forms.ToolStripMenuItem linearna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Button izr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem iracionalna;
        private System.Windows.Forms.ToolStripMenuItem kubna;
        private System.Windows.Forms.ToolStripMenuItem ekspo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spremiToolStripMenuItem;
    }
}

