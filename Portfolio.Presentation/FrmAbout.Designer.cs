﻿namespace Portfolio.Presentation
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.lblGitRobson = new System.Windows.Forms.Label();
            this.lblGitMarilia = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblGitLuiza = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pnlAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.Transparent;
            this.pnlAbout.Controls.Add(this.lblGitRobson);
            this.pnlAbout.Controls.Add(this.lblGitMarilia);
            this.pnlAbout.Controls.Add(this.btnReturn);
            this.pnlAbout.Controls.Add(this.lblGitLuiza);
            this.pnlAbout.Controls.Add(this.lblAbout);
            this.pnlAbout.Location = new System.Drawing.Point(70, 263);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(938, 384);
            this.pnlAbout.TabIndex = 0;
            // 
            // lblGitRobson
            // 
            this.lblGitRobson.AutoSize = true;
            this.lblGitRobson.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGitRobson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lblGitRobson.Location = new System.Drawing.Point(321, 201);
            this.lblGitRobson.Name = "lblGitRobson";
            this.lblGitRobson.Size = new System.Drawing.Size(247, 18);
            this.lblGitRobson.TabIndex = 3;
            this.lblGitRobson.Text = "github.com/takeshinishikawa";
            // 
            // lblGitMarilia
            // 
            this.lblGitMarilia.AutoSize = true;
            this.lblGitMarilia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGitMarilia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lblGitMarilia.Location = new System.Drawing.Point(189, 150);
            this.lblGitMarilia.Name = "lblGitMarilia";
            this.lblGitMarilia.Size = new System.Drawing.Size(191, 18);
            this.lblGitMarilia.TabIndex = 2;
            this.lblGitMarilia.Text = "github.com/teatrologa";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnReturn.Location = new System.Drawing.Point(389, 327);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 45);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblGitLuiza
            // 
            this.lblGitLuiza.AutoSize = true;
            this.lblGitLuiza.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGitLuiza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lblGitLuiza.Location = new System.Drawing.Point(269, 100);
            this.lblGitLuiza.Name = "lblGitLuiza";
            this.lblGitLuiza.Size = new System.Drawing.Size(218, 18);
            this.lblGitLuiza.TabIndex = 1;
            this.lblGitLuiza.Text = "github.com/luizacampello";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblAbout.Location = new System.Drawing.Point(16, 21);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(535, 200);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "Projeto do módulo 05: Técnicas de Programação.\r\nTurma 854 do Programa Top Coders/" +
    "Let\'s Code.\r\n\r\nLuiza Motta Campello - \r\n\r\nMarilia Castro -\r\n\r\nRobson Takeshi Nis" +
    "hikawa - ";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pnlAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAbout";
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlAbout;
        private Label lblAbout;
        private Label lblGitLuiza;
        private Button btnReturn;
        private Label lblGitRobson;
        private Label lblGitMarilia;
    }
}