namespace Test3
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sTERGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sTERGEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip3;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(756, 279);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.contextMenuStrip2);
            this.listBox1.ContextMenuStripChanged += new System.EventHandler(this.contextMenuStrip2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "AFISEAZA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sTERGEToolStripMenuItem
            // 
            this.sTERGEToolStripMenuItem.Name = "sTERGEToolStripMenuItem";
            this.sTERGEToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.sTERGEToolStripMenuItem.Text = "STERGE";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTERGEToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(301, 86);
            // 
            // sTERGEToolStripMenuItem1
            // 
            this.sTERGEToolStripMenuItem1.Name = "sTERGEToolStripMenuItem1";
            this.sTERGEToolStripMenuItem1.Size = new System.Drawing.Size(300, 38);
            this.sTERGEToolStripMenuItem1.Text = "STERGE";
            this.sTERGEToolStripMenuItem1.Click += new System.EventHandler(this.sTERGEToolStripMenuItem1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ContextMenuStripChanged += new System.EventHandler(this.button1_Click);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
      //  private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTERGEToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem sTERGEToolStripMenuItem1;
    }
}