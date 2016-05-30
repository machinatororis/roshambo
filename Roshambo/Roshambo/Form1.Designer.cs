namespace Roshambo
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userPanelRock = new System.Windows.Forms.Panel();
            this.pictureBoxRockUser = new System.Windows.Forms.PictureBox();
            this.userPanelScissors = new System.Windows.Forms.Panel();
            this.pictureBoxScissorsUser = new System.Windows.Forms.PictureBox();
            this.userPanelPaper = new System.Windows.Forms.Panel();
            this.pictureBoxPaperUser = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxRockComp = new System.Windows.Forms.PictureBox();
            this.pictureBoxPaperComp = new System.Windows.Forms.PictureBox();
            this.pictureBoxScissorsComp = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.userPanelRock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRockUser)).BeginInit();
            this.userPanelScissors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissorsUser)).BeginInit();
            this.userPanelPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaperUser)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRockComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaperComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissorsComp)).BeginInit();
            this.SuspendLayout();
            // 
            // userPanelRock
            // 
            this.userPanelRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelRock.Controls.Add(this.pictureBoxRockUser);
            this.userPanelRock.Location = new System.Drawing.Point(11, 81);
            this.userPanelRock.Name = "userPanelRock";
            this.userPanelRock.Size = new System.Drawing.Size(120, 120);
            this.userPanelRock.TabIndex = 0;
            this.userPanelRock.Tag = "Rock";
            this.userPanelRock.MouseEnter += new System.EventHandler(this.userPanel_MouseEnter);
            // 
            // pictureBoxRockUser
            // 
            this.pictureBoxRockUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRockUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRockUser.Image")));
            this.pictureBoxRockUser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRockUser.Name = "pictureBoxRockUser";
            this.pictureBoxRockUser.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxRockUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRockUser.TabIndex = 4;
            this.pictureBoxRockUser.TabStop = false;
            this.pictureBoxRockUser.Tag = "";
            this.pictureBoxRockUser.Visible = false;
            // 
            // userPanelScissors
            // 
            this.userPanelScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelScissors.Controls.Add(this.pictureBoxScissorsUser);
            this.userPanelScissors.Location = new System.Drawing.Point(158, 81);
            this.userPanelScissors.Name = "userPanelScissors";
            this.userPanelScissors.Size = new System.Drawing.Size(120, 120);
            this.userPanelScissors.TabIndex = 1;
            this.userPanelScissors.Tag = "Scissors";
            this.userPanelScissors.MouseEnter += new System.EventHandler(this.userPanel_MouseEnter);
            // 
            // pictureBoxScissorsUser
            // 
            this.pictureBoxScissorsUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxScissorsUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScissorsUser.Image")));
            this.pictureBoxScissorsUser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxScissorsUser.Name = "pictureBoxScissorsUser";
            this.pictureBoxScissorsUser.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxScissorsUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScissorsUser.TabIndex = 6;
            this.pictureBoxScissorsUser.TabStop = false;
            this.pictureBoxScissorsUser.Visible = false;
            // 
            // userPanelPaper
            // 
            this.userPanelPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelPaper.Controls.Add(this.pictureBoxPaperUser);
            this.userPanelPaper.Location = new System.Drawing.Point(314, 81);
            this.userPanelPaper.Name = "userPanelPaper";
            this.userPanelPaper.Size = new System.Drawing.Size(120, 120);
            this.userPanelPaper.TabIndex = 2;
            this.userPanelPaper.Tag = "Paper";
            this.userPanelPaper.MouseEnter += new System.EventHandler(this.userPanel_MouseEnter);
            // 
            // pictureBoxPaperUser
            // 
            this.pictureBoxPaperUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPaperUser.Image")));
            this.pictureBoxPaperUser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPaperUser.Name = "pictureBoxPaperUser";
            this.pictureBoxPaperUser.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxPaperUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPaperUser.TabIndex = 5;
            this.pictureBoxPaperUser.TabStop = false;
            this.pictureBoxPaperUser.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBoxRockComp);
            this.panel4.Controls.Add(this.pictureBoxPaperComp);
            this.panel4.Controls.Add(this.pictureBoxScissorsComp);
            this.panel4.Location = new System.Drawing.Point(615, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 120);
            this.panel4.TabIndex = 3;
            // 
            // pictureBoxRockComp
            // 
            this.pictureBoxRockComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRockComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRockComp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRockComp.Image")));
            this.pictureBoxRockComp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRockComp.Name = "pictureBoxRockComp";
            this.pictureBoxRockComp.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxRockComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRockComp.TabIndex = 5;
            this.pictureBoxRockComp.TabStop = false;
            this.pictureBoxRockComp.Tag = "";
            this.pictureBoxRockComp.Visible = false;
            // 
            // pictureBoxPaperComp
            // 
            this.pictureBoxPaperComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPaperComp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPaperComp.Image")));
            this.pictureBoxPaperComp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPaperComp.Name = "pictureBoxPaperComp";
            this.pictureBoxPaperComp.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxPaperComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPaperComp.TabIndex = 6;
            this.pictureBoxPaperComp.TabStop = false;
            this.pictureBoxPaperComp.Visible = false;
            // 
            // pictureBoxScissorsComp
            // 
            this.pictureBoxScissorsComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxScissorsComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxScissorsComp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScissorsComp.Image")));
            this.pictureBoxScissorsComp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxScissorsComp.Name = "pictureBoxScissorsComp";
            this.pictureBoxScissorsComp.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxScissorsComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScissorsComp.TabIndex = 7;
            this.pictureBoxScissorsComp.TabStop = false;
            this.pictureBoxScissorsComp.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelMessage
            // 
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessage.Location = new System.Drawing.Point(12, 19);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(423, 40);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "Выбери свою фигуру!";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelComp
            // 
            this.labelComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelComp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComp.Location = new System.Drawing.Point(615, 19);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(120, 40);
            this.labelComp.TabIndex = 5;
            this.labelComp.Text = "Рука компьютера";
            this.labelComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(11, 238);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(724, 43);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "label3";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 299);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.userPanelPaper);
            this.Controls.Add(this.userPanelScissors);
            this.Controls.Add(this.userPanelRock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камень-Ножницы-Бумага";
            this.userPanelRock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRockUser)).EndInit();
            this.userPanelScissors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissorsUser)).EndInit();
            this.userPanelPaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaperUser)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRockComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaperComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissorsComp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userPanelRock;
        private System.Windows.Forms.Panel userPanelScissors;
        private System.Windows.Forms.Panel userPanelPaper;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxRockUser;
        private System.Windows.Forms.PictureBox pictureBoxPaperUser;
        private System.Windows.Forms.PictureBox pictureBoxScissorsUser;
        private System.Windows.Forms.PictureBox pictureBoxPaperComp;
        private System.Windows.Forms.PictureBox pictureBoxScissorsComp;
        private System.Windows.Forms.PictureBox pictureBoxRockComp;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.Label labelScore;
    }
}

