namespace PAW_Recap_TEST
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
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.tb_adresa = new System.Windows.Forms.TextBox();
            this.tb_sumaDatorata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_PF = new System.Windows.Forms.CheckBox();
            this.cb_PJ = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vectorRate = new System.Windows.Forms.TextBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cod
            // 
            this.tb_cod.Location = new System.Drawing.Point(254, 102);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(317, 26);
            this.tb_cod.TabIndex = 0;
            this.tb_cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_KeyPress);
            // 
            // tb_nume
            // 
            this.tb_nume.Location = new System.Drawing.Point(254, 150);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(317, 26);
            this.tb_nume.TabIndex = 1;
            // 
            // tb_adresa
            // 
            this.tb_adresa.Location = new System.Drawing.Point(254, 198);
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.Size = new System.Drawing.Size(317, 26);
            this.tb_adresa.TabIndex = 2;
            // 
            // tb_sumaDatorata
            // 
            this.tb_sumaDatorata.Location = new System.Drawing.Point(254, 292);
            this.tb_sumaDatorata.Name = "tb_sumaDatorata";
            this.tb_sumaDatorata.Size = new System.Drawing.Size(317, 26);
            this.tb_sumaDatorata.TabIndex = 4;
            this.tb_sumaDatorata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sumaDatorata_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "COD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NUME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADRESA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "SUMA DATORATA";
            // 
            // cb_PF
            // 
            this.cb_PF.AutoSize = true;
            this.cb_PF.Location = new System.Drawing.Point(254, 246);
            this.cb_PF.Name = "cb_PF";
            this.cb_PF.Size = new System.Drawing.Size(55, 24);
            this.cb_PF.TabIndex = 10;
            this.cb_PF.Text = "PF";
            this.cb_PF.UseVisualStyleBackColor = true;
            // 
            // cb_PJ
            // 
            this.cb_PJ.AutoSize = true;
            this.cb_PJ.Location = new System.Drawing.Point(373, 246);
            this.cb_PJ.Name = "cb_PJ";
            this.cb_PJ.Size = new System.Drawing.Size(53, 24);
            this.cb_PJ.TabIndex = 11;
            this.cb_PJ.Text = "PJ";
            this.cb_PJ.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "CLIENT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Adaugare CLIENT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "VECTOR RATE";
            // 
            // tb_vectorRate
            // 
            this.tb_vectorRate.Location = new System.Drawing.Point(254, 340);
            this.tb_vectorRate.Name = "tb_vectorRate";
            this.tb_vectorRate.Size = new System.Drawing.Size(317, 26);
            this.tb_vectorRate.TabIndex = 14;
            this.tb_vectorRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_vectorRate_KeyPress);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 56);
            this.button2.TabIndex = 16;
            this.button2.Text = "Afisare MOCKUPS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_vectorRate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_PJ);
            this.Controls.Add(this.cb_PF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_sumaDatorata);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.tb_nume);
            this.Controls.Add(this.tb_cod);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.TextBox tb_nume;
        private System.Windows.Forms.TextBox tb_adresa;
        private System.Windows.Forms.TextBox tb_sumaDatorata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_PF;
        private System.Windows.Forms.CheckBox cb_PJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_vectorRate;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button button2;
    }
}

