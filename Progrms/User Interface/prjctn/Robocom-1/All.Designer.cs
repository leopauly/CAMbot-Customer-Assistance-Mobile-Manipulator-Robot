namespace Robocom_1
{
    partial class RoBo
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
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.Red;
            this.btnA.Location = new System.Drawing.Point(32, 70);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(60, 32);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "SOAP";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnB.Location = new System.Drawing.Point(98, 70);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(60, 32);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "PASTE";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnC.Location = new System.Drawing.Point(164, 70);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(60, 32);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "PEPSI";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.Color.Blue;
            this.btnD.Location = new System.Drawing.Point(230, 70);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(60, 32);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "OIL";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port Name";
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnE.Location = new System.Drawing.Point(32, 108);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(60, 32);
            this.btnE.TabIndex = 8;
            this.btnE.Text = "BISCUIT";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.ForeColor = System.Drawing.Color.Teal;
            this.btnF.Location = new System.Drawing.Point(98, 108);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(60, 32);
            this.btnF.TabIndex = 9;
            this.btnF.Text = "SUGAR";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.ForeColor = System.Drawing.Color.Olive;
            this.btnG.Location = new System.Drawing.Point(164, 108);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(60, 32);
            this.btnG.TabIndex = 10;
            this.btnG.Text = "MILK";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(230, 108);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(60, 32);
            this.btnH.TabIndex = 11;
            this.btnH.Text = "BREAD";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(185, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time";
            // 
            // txtport
            // 
            this.txtport.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtport.Location = new System.Drawing.Point(124, 18);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(75, 21);
            this.txtport.TabIndex = 13;
            // 
            // RoBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(310, 182);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RoBo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoBo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtport;
    }
}