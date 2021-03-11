namespace HeißeKlausur
{
    partial class GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sumPunkte = new System.Windows.Forms.Label();
            this.labelZeit1 = new System.Windows.Forms.Label();
            this.labelZeit2 = new System.Windows.Forms.Label();
            this.labelZeit3 = new System.Windows.Forms.Label();
            this.punkte1 = new System.Windows.Forms.Label();
            this.punkte2 = new System.Windows.Forms.Label();
            this.punkte3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zeit in der Hand:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Punkte:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 22);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // sumPunkte
            // 
            this.sumPunkte.Location = new System.Drawing.Point(105, 169);
            this.sumPunkte.Name = "sumPunkte";
            this.sumPunkte.Size = new System.Drawing.Size(87, 27);
            this.sumPunkte.TabIndex = 5;
            this.sumPunkte.Text = "Gesamtpunkte:";
            // 
            // labelZeit1
            // 
            this.labelZeit1.Location = new System.Drawing.Point(128, 48);
            this.labelZeit1.Name = "labelZeit1";
            this.labelZeit1.Size = new System.Drawing.Size(55, 18);
            this.labelZeit1.TabIndex = 6;
            this.labelZeit1.Text = "Zeit1";
            // 
            // labelZeit2
            // 
            this.labelZeit2.Location = new System.Drawing.Point(239, 48);
            this.labelZeit2.Name = "labelZeit2";
            this.labelZeit2.Size = new System.Drawing.Size(55, 18);
            this.labelZeit2.TabIndex = 7;
            this.labelZeit2.Text = "Zeit 2";
            // 
            // labelZeit3
            // 
            this.labelZeit3.Location = new System.Drawing.Point(355, 48);
            this.labelZeit3.Name = "labelZeit3";
            this.labelZeit3.Size = new System.Drawing.Size(55, 18);
            this.labelZeit3.TabIndex = 8;
            this.labelZeit3.Text = "Zeit 3";
            // 
            // punkte1
            // 
            this.punkte1.Location = new System.Drawing.Point(112, 111);
            this.punkte1.Name = "punkte1";
            this.punkte1.Size = new System.Drawing.Size(72, 14);
            this.punkte1.TabIndex = 9;
            this.punkte1.Text = "Punkte1";
            // 
            // punkte2
            // 
            this.punkte2.Location = new System.Drawing.Point(227, 111);
            this.punkte2.Name = "punkte2";
            this.punkte2.Size = new System.Drawing.Size(72, 14);
            this.punkte2.TabIndex = 10;
            this.punkte2.Text = "Punkte2";
            // 
            // punkte3
            // 
            this.punkte3.Location = new System.Drawing.Point(340, 111);
            this.punkte3.Name = "punkte3";
            this.punkte3.Size = new System.Drawing.Size(72, 14);
            this.punkte3.TabIndex = 11;
            this.punkte3.Text = "Punkte3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 208);
            this.Controls.Add(this.punkte3);
            this.Controls.Add(this.punkte2);
            this.Controls.Add(this.punkte1);
            this.Controls.Add(this.labelZeit3);
            this.Controls.Add(this.labelZeit2);
            this.Controls.Add(this.labelZeit1);
            this.Controls.Add(this.sumPunkte);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label sumPunkte;
        private System.Windows.Forms.Label labelZeit1;
        private System.Windows.Forms.Label labelZeit2;
        private System.Windows.Forms.Label labelZeit3;
        private System.Windows.Forms.Label punkte1;
        private System.Windows.Forms.Label punkte2;
        private System.Windows.Forms.Label punkte3;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}