﻿namespace Zadatak_Vjezba4
{
    partial class Izracun_Student9
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StranicaA = new System.Windows.Forms.TextBox();
            this.StranicaB = new System.Windows.Forms.TextBox();
            this.Opseg = new System.Windows.Forms.TextBox();
            this.Povrsina = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stranica A:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stranica B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opseg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Povrsina:";
            // 
            // StranicaA
            // 
            this.StranicaA.Location = new System.Drawing.Point(98, 40);
            this.StranicaA.Name = "StranicaA";
            this.StranicaA.Size = new System.Drawing.Size(100, 20);
            this.StranicaA.TabIndex = 4;
            // 
            // StranicaB
            // 
            this.StranicaB.Location = new System.Drawing.Point(98, 65);
            this.StranicaB.Name = "StranicaB";
            this.StranicaB.Size = new System.Drawing.Size(100, 20);
            this.StranicaB.TabIndex = 5;
            // 
            // Opseg
            // 
            this.Opseg.Location = new System.Drawing.Point(98, 90);
            this.Opseg.Name = "Opseg";
            this.Opseg.Size = new System.Drawing.Size(100, 20);
            this.Opseg.TabIndex = 6;
            // 
            // Povrsina
            // 
            this.Povrsina.Location = new System.Drawing.Point(98, 119);
            this.Povrsina.Name = "Povrsina";
            this.Povrsina.Size = new System.Drawing.Size(100, 20);
            this.Povrsina.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Izracunaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Izracun_Student9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Povrsina);
            this.Controls.Add(this.Opseg);
            this.Controls.Add(this.StranicaB);
            this.Controls.Add(this.StranicaA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Izracun_Student9";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Izracun_Student9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StranicaA;
        private System.Windows.Forms.TextBox StranicaB;
        private System.Windows.Forms.TextBox Opseg;
        private System.Windows.Forms.TextBox Povrsina;
        private System.Windows.Forms.Button button1;
    }
}

