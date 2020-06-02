namespace PrelucrariStatistice
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
            this.btnAdaugaUnitateAgricola = new System.Windows.Forms.Button();
            this.btnBd = new System.Windows.Forms.Button();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.btnDragDrop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAdaugaUnitateAgricola
            // 
            this.btnAdaugaUnitateAgricola.Location = new System.Drawing.Point(61, 65);
            this.btnAdaugaUnitateAgricola.Name = "btnAdaugaUnitateAgricola";
            this.btnAdaugaUnitateAgricola.Size = new System.Drawing.Size(164, 36);
            this.btnAdaugaUnitateAgricola.TabIndex = 0;
            this.btnAdaugaUnitateAgricola.Text = "Adauga Unitate";
            this.btnAdaugaUnitateAgricola.UseVisualStyleBackColor = true;
            this.btnAdaugaUnitateAgricola.Click += new System.EventHandler(this.btnAdaugaUnitateAgricola_Click);
            // 
            // btnBd
            // 
            this.btnBd.Location = new System.Drawing.Point(61, 145);
            this.btnBd.Name = "btnBd";
            this.btnBd.Size = new System.Drawing.Size(164, 36);
            this.btnBd.TabIndex = 1;
            this.btnBd.Text = "Vezi Baza de Date";
            this.btnBd.UseVisualStyleBackColor = true;
            this.btnBd.Click += new System.EventHandler(this.btnBd_Click);
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(61, 231);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(164, 35);
            this.btnGrafic.TabIndex = 2;
            this.btnGrafic.Text = "Vezi Grafic Suprafete";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // btnDragDrop
            // 
            this.btnDragDrop.Location = new System.Drawing.Point(61, 318);
            this.btnDragDrop.Name = "btnDragDrop";
            this.btnDragDrop.Size = new System.Drawing.Size(164, 36);
            this.btnDragDrop.TabIndex = 3;
            this.btnDragDrop.Text = "Grupare indicatori";
            this.btnDragDrop.UseVisualStyleBackColor = true;
            this.btnDragDrop.Click += new System.EventHandler(this.btnDragDrop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prelucrari Statistice In Agricultura";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PrelucrariStatistice.Properties.Resources.Teren_agricol;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(305, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 301);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDragDrop);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.btnBd);
            this.Controls.Add(this.btnAdaugaUnitateAgricola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaUnitateAgricola;
        private System.Windows.Forms.Button btnBd;
        private System.Windows.Forms.Button btnGrafic;
        private System.Windows.Forms.Button btnDragDrop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

