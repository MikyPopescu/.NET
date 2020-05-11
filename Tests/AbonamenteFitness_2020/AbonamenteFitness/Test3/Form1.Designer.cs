namespace Test3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.tb_client = new System.Windows.Forms.TextBox();
            this.tb_pret = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "COD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "ACTIV";
            // 
            // tb_cod
            // 
            this.tb_cod.Location = new System.Drawing.Point(149, 51);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(421, 31);
            this.tb_cod.TabIndex = 4;
            this.tb_cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_KeyPress);
            // 
            // tb_client
            // 
            this.tb_client.Location = new System.Drawing.Point(149, 114);
            this.tb_client.Name = "tb_client";
            this.tb_client.Size = new System.Drawing.Size(421, 31);
            this.tb_client.TabIndex = 5;
            // 
            // tb_pret
            // 
            this.tb_pret.Location = new System.Drawing.Point(149, 187);
            this.tb_pret.Name = "tb_pret";
            this.tb_pret.Size = new System.Drawing.Size(421, 31);
            this.tb_pret.TabIndex = 6;
            this.tb_pret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pret_KeyPress);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(149, 249);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 29);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DA";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(149, 312);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 29);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NU";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "ADAUGA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 66);
            this.button2.TabIndex = 10;
            this.button2.Text = "FORM 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tb_pret);
            this.Controls.Add(this.tb_client);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.TextBox tb_client;
        private System.Windows.Forms.TextBox tb_pret;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
    }
}

