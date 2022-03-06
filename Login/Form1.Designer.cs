namespace Login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLOGIN = new System.Windows.Forms.Label();
            this.textBoxUSER = new System.Windows.Forms.TextBox();
            this.labelUSUARIO = new System.Windows.Forms.Label();
            this.labeLCONTRASEÑA = new System.Windows.Forms.Label();
            this.textBoxPASSWORD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelLOGIN
            // 
            this.labelLOGIN.AutoSize = true;
            this.labelLOGIN.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLOGIN.Location = new System.Drawing.Point(325, 53);
            this.labelLOGIN.Name = "labelLOGIN";
            this.labelLOGIN.Size = new System.Drawing.Size(137, 50);
            this.labelLOGIN.TabIndex = 0;
            this.labelLOGIN.Text = "LOGIN";
            this.labelLOGIN.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUSER
            // 
            this.textBoxUSER.Location = new System.Drawing.Point(284, 147);
            this.textBoxUSER.Name = "textBoxUSER";
            this.textBoxUSER.Size = new System.Drawing.Size(320, 31);
            this.textBoxUSER.TabIndex = 1;
            this.textBoxUSER.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelUSUARIO
            // 
            this.labelUSUARIO.AutoSize = true;
            this.labelUSUARIO.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUSUARIO.Location = new System.Drawing.Point(187, 155);
            this.labelUSUARIO.Name = "labelUSUARIO";
            this.labelUSUARIO.Size = new System.Drawing.Size(93, 23);
            this.labelUSUARIO.TabIndex = 2;
            this.labelUSUARIO.Text = "Usuario:";
            this.labelUSUARIO.Click += new System.EventHandler(this.label2_Click);
            // 
            // labeLCONTRASEÑA
            // 
            this.labeLCONTRASEÑA.AutoSize = true;
            this.labeLCONTRASEÑA.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeLCONTRASEÑA.Location = new System.Drawing.Point(149, 226);
            this.labeLCONTRASEÑA.Name = "labeLCONTRASEÑA";
            this.labeLCONTRASEÑA.Size = new System.Drawing.Size(128, 23);
            this.labeLCONTRASEÑA.TabIndex = 3;
            this.labeLCONTRASEÑA.Text = "Contraseña:";
            this.labeLCONTRASEÑA.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPASSWORD
            // 
            this.textBoxPASSWORD.Location = new System.Drawing.Point(284, 218);
            this.textBoxPASSWORD.Name = "textBoxPASSWORD";
            this.textBoxPASSWORD.Size = new System.Drawing.Size(320, 31);
            this.textBoxPASSWORD.TabIndex = 4;
            this.textBoxPASSWORD.UseSystemPasswordChar = true;
            this.textBoxPASSWORD.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPASSWORD);
            this.Controls.Add(this.labeLCONTRASEÑA);
            this.Controls.Add(this.labelUSUARIO);
            this.Controls.Add(this.textBoxUSER);
            this.Controls.Add(this.labelLOGIN);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLOGIN;
        private TextBox textBoxUSER;
        private Label labelUSUARIO;
        private Label labeLCONTRASEÑA;
        private TextBox textBoxPASSWORD;
    }
}