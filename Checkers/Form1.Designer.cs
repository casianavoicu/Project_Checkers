﻿namespace Checkers
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
            this.StartGame = new System.Windows.Forms.Button();
            this.panelCheckers = new System.Windows.Forms.Panel();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(325, 318);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 23);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // panelCheckers
            // 
            this.panelCheckers.AutoSize = true;
            this.panelCheckers.Location = new System.Drawing.Point(0, -2);
            this.panelCheckers.Name = "panelCheckers";
            this.panelCheckers.Size = new System.Drawing.Size(706, 452);
            this.panelCheckers.TabIndex = 2;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(712, 69);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(60, 30);
            this.start.TabIndex = 3;
            this.start.Text = "Play";
            this.start.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(796, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panelCheckers);
            this.Controls.Add(this.StartGame);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Panel panelCheckers;
        private System.Windows.Forms.Button start;
        public System.Windows.Forms.Label label1;
    }
}

