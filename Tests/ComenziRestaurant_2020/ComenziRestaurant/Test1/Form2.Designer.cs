namespace Test1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sTERGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.COD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAGAZIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DENUMIRE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CANTITATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.COD,
            this.MAGAZIN,
            this.DENUMIRE,
            this.CANTITATE});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(133, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(759, 557);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTERGEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 42);
            // 
            // sTERGEToolStripMenuItem
            // 
            this.sTERGEToolStripMenuItem.Name = "sTERGEToolStripMenuItem";
            this.sTERGEToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.sTERGEToolStripMenuItem.Text = "STERGE";
            this.sTERGEToolStripMenuItem.Click += new System.EventHandler(this.sTERGEToolStripMenuItem_Click);
            // 
            // COD
            // 
            this.COD.Text = "COD";
            // 
            // MAGAZIN
            // 
            this.MAGAZIN.Text = "MAGAZIN";
            this.MAGAZIN.Width = 111;
            // 
            // DENUMIRE
            // 
            this.DENUMIRE.Text = "DENUMIRE";
            this.DENUMIRE.Width = 135;
            // 
            // CANTITATE
            // 
            this.CANTITATE.Text = "CANTITATE";
            this.CANTITATE.Width = 283;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1009, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 82);
            this.button1.TabIndex = 2;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColumnHeader COD;
        private System.Windows.Forms.ColumnHeader MAGAZIN;
        private System.Windows.Forms.ColumnHeader DENUMIRE;
        private System.Windows.Forms.ColumnHeader CANTITATE;
        private System.Windows.Forms.ToolStripMenuItem sTERGEToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}