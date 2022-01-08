namespace Шаг_первый
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
            this.HeroPic = new System.Windows.Forms.PictureBox();
            this.GamePan = new System.Windows.Forms.Panel();
            this.Field2Pan = new System.Windows.Forms.Panel();
            this.Field1Pan = new System.Windows.Forms.Panel();
            this.StatPan = new System.Windows.Forms.Panel();
            this.LongLab = new System.Windows.Forms.Label();
            this.SetSizeBut = new System.Windows.Forms.Button();
            this.SetSizeLab = new System.Windows.Forms.Label();
            this.SetSizePan = new System.Windows.Forms.Panel();
            this.MainMenuPan = new System.Windows.Forms.Panel();
            this.GoSetSizeBut = new System.Windows.Forms.Button();
            this.StartGameBut = new System.Windows.Forms.Button();
            this.RunningTim = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HeroPic)).BeginInit();
            this.GamePan.SuspendLayout();
            this.StatPan.SuspendLayout();
            this.SetSizePan.SuspendLayout();
            this.MainMenuPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeroPic
            // 
            this.HeroPic.BackColor = System.Drawing.Color.DarkRed;
            this.HeroPic.Location = new System.Drawing.Point(0, 133);
            this.HeroPic.Name = "HeroPic";
            this.HeroPic.Size = new System.Drawing.Size(83, 83);
            this.HeroPic.TabIndex = 0;
            this.HeroPic.TabStop = false;
            // 
            // GamePan
            // 
            this.GamePan.Controls.Add(this.HeroPic);
            this.GamePan.Controls.Add(this.Field2Pan);
            this.GamePan.Controls.Add(this.Field1Pan);
            this.GamePan.Controls.Add(this.StatPan);
            this.GamePan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePan.Location = new System.Drawing.Point(0, 0);
            this.GamePan.Name = "GamePan";
            this.GamePan.Size = new System.Drawing.Size(500, 300);
            this.GamePan.TabIndex = 1;
            this.GamePan.Visible = false;
            // 
            // Field2Pan
            // 
            this.Field2Pan.BackColor = System.Drawing.Color.Goldenrod;
            this.Field2Pan.Location = new System.Drawing.Point(500, 50);
            this.Field2Pan.Name = "Field2Pan";
            this.Field2Pan.Size = new System.Drawing.Size(500, 250);
            this.Field2Pan.TabIndex = 3;
            // 
            // Field1Pan
            // 
            this.Field1Pan.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Field1Pan.Location = new System.Drawing.Point(0, 50);
            this.Field1Pan.Name = "Field1Pan";
            this.Field1Pan.Size = new System.Drawing.Size(500, 250);
            this.Field1Pan.TabIndex = 2;
            // 
            // StatPan
            // 
            this.StatPan.BackColor = System.Drawing.Color.SkyBlue;
            this.StatPan.Controls.Add(this.LongLab);
            this.StatPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatPan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatPan.Location = new System.Drawing.Point(0, 0);
            this.StatPan.Name = "StatPan";
            this.StatPan.Size = new System.Drawing.Size(500, 50);
            this.StatPan.TabIndex = 1;
            // 
            // LongLab
            // 
            this.LongLab.AutoSize = true;
            this.LongLab.Location = new System.Drawing.Point(336, 9);
            this.LongLab.Name = "LongLab";
            this.LongLab.Size = new System.Drawing.Size(81, 24);
            this.LongLab.TabIndex = 0;
            this.LongLab.Text = "Длина:0";
            // 
            // SetSizeBut
            // 
            this.SetSizeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetSizeBut.Location = new System.Drawing.Point(117, 109);
            this.SetSizeBut.Name = "SetSizeBut";
            this.SetSizeBut.Size = new System.Drawing.Size(245, 90);
            this.SetSizeBut.TabIndex = 2;
            this.SetSizeBut.Text = "Установить";
            this.SetSizeBut.UseVisualStyleBackColor = true;
            this.SetSizeBut.Click += new System.EventHandler(this.SetSizeBut_Click);
            // 
            // SetSizeLab
            // 
            this.SetSizeLab.AutoSize = true;
            this.SetSizeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetSizeLab.Location = new System.Drawing.Point(12, 20);
            this.SetSizeLab.Name = "SetSizeLab";
            this.SetSizeLab.Size = new System.Drawing.Size(468, 25);
            this.SetSizeLab.TabIndex = 3;
            this.SetSizeLab.Text = "Настройте размер окна и нажмите на кнопку";
            // 
            // SetSizePan
            // 
            this.SetSizePan.Controls.Add(this.SetSizeLab);
            this.SetSizePan.Controls.Add(this.SetSizeBut);
            this.SetSizePan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetSizePan.Location = new System.Drawing.Point(0, 0);
            this.SetSizePan.Name = "SetSizePan";
            this.SetSizePan.Size = new System.Drawing.Size(500, 300);
            this.SetSizePan.TabIndex = 4;
            // 
            // MainMenuPan
            // 
            this.MainMenuPan.Controls.Add(this.GoSetSizeBut);
            this.MainMenuPan.Controls.Add(this.StartGameBut);
            this.MainMenuPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPan.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPan.Name = "MainMenuPan";
            this.MainMenuPan.Size = new System.Drawing.Size(500, 300);
            this.MainMenuPan.TabIndex = 0;
            this.MainMenuPan.Visible = false;
            // 
            // GoSetSizeBut
            // 
            this.GoSetSizeBut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GoSetSizeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoSetSizeBut.Location = new System.Drawing.Point(75, 170);
            this.GoSetSizeBut.Name = "GoSetSizeBut";
            this.GoSetSizeBut.Size = new System.Drawing.Size(350, 40);
            this.GoSetSizeBut.TabIndex = 1;
            this.GoSetSizeBut.Text = "Настроить размер окна";
            this.GoSetSizeBut.UseVisualStyleBackColor = true;
            this.GoSetSizeBut.Click += new System.EventHandler(this.GoSetSizeBut_Click);
            // 
            // StartGameBut
            // 
            this.StartGameBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameBut.Location = new System.Drawing.Point(75, 85);
            this.StartGameBut.Name = "StartGameBut";
            this.StartGameBut.Size = new System.Drawing.Size(350, 80);
            this.StartGameBut.TabIndex = 0;
            this.StartGameBut.Text = "Начать игру";
            this.StartGameBut.UseVisualStyleBackColor = true;
            this.StartGameBut.Click += new System.EventHandler(this.StartGameBut_Click);
            // 
            // RunningTim
            // 
            this.RunningTim.Interval = 50;
            this.RunningTim.Tick += new System.EventHandler(this.RunningTim_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.SetSizePan);
            this.Controls.Add(this.MainMenuPan);
            this.Controls.Add(this.GamePan);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.HeroPic)).EndInit();
            this.GamePan.ResumeLayout(false);
            this.StatPan.ResumeLayout(false);
            this.StatPan.PerformLayout();
            this.SetSizePan.ResumeLayout(false);
            this.SetSizePan.PerformLayout();
            this.MainMenuPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HeroPic;
        private System.Windows.Forms.Panel GamePan;
        private System.Windows.Forms.Button SetSizeBut;
        private System.Windows.Forms.Label SetSizeLab;
        private System.Windows.Forms.Panel SetSizePan;
        private System.Windows.Forms.Panel MainMenuPan;
        private System.Windows.Forms.Button GoSetSizeBut;
        private System.Windows.Forms.Button StartGameBut;
        private System.Windows.Forms.Panel Field1Pan;
        private System.Windows.Forms.Panel Field2Pan;
        private System.Windows.Forms.Panel StatPan;
        private System.Windows.Forms.Label LongLab;
        private System.Windows.Forms.Timer RunningTim;
    }
}

