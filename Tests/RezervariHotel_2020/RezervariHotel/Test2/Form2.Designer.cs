namespace Test2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("REZERVARE");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eDITAREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTERGEREToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(27, 26);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "REZERVARE";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(617, 296);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "AFISARE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITAREToolStripMenuItem,
            this.sTERGEREToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(301, 124);
            // 
            // eDITAREToolStripMenuItem
            // 
            this.eDITAREToolStripMenuItem.Name = "eDITAREToolStripMenuItem";
            this.eDITAREToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.eDITAREToolStripMenuItem.Text = "EDITARE";
            this.eDITAREToolStripMenuItem.Click += new System.EventHandler(this.eDITAREToolStripMenuItem_Click);
            // 
            // sTERGEREToolStripMenuItem1
            // 
            this.sTERGEREToolStripMenuItem1.Name = "sTERGEREToolStripMenuItem1";
            this.sTERGEREToolStripMenuItem1.Size = new System.Drawing.Size(300, 38);
            this.sTERGEREToolStripMenuItem1.Text = "STERGERE";
            this.sTERGEREToolStripMenuItem1.Click += new System.EventHandler(this.sTERGEREToolStripMenuItem1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eDITAREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTERGEREToolStripMenuItem1;
    }
}