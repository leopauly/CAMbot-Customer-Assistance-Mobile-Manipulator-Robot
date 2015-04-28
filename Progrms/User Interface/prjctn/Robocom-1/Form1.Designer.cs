namespace Robocom_1
{
    partial class Robocom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robocom));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnstop = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // btnstop
            // 
            this.btnstop.Image = global::Robocom_1.Properties.Resources.sty;
            this.btnstop.Location = new System.Drawing.Point(266, 93);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(79, 72);
            this.btnstop.TabIndex = 3;
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btndown
            // 
            this.btndown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndown.Image = global::Robocom_1.Properties.Resources.y1;
            this.btndown.Location = new System.Drawing.Point(143, 156);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(75, 62);
            this.btndown.TabIndex = 1;
            this.btndown.Text = "DOWN";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btnup
            // 
            this.btnup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.Image = global::Robocom_1.Properties.Resources.y;
            this.btnup.Location = new System.Drawing.Point(143, 66);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 60);
            this.btnup.TabIndex = 0;
            this.btnup.Text = "UP";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 224);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Maximum = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 19);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // txtport
            // 
            this.txtport.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtport.Location = new System.Drawing.Point(143, 40);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(75, 21);
            this.txtport.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port Name";
            // 
            // Robocom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.btnup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Robocom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robocom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndown;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label label2;
    }
}

