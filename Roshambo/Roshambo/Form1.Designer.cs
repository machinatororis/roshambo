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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userPanelRock = new System.Windows.Forms.Panel();
            this.pictureBoxRock = new System.Windows.Forms.PictureBox();
            this.userPanelScissors = new System.Windows.Forms.Panel();
            this.pictureBoxScissors = new System.Windows.Forms.PictureBox();
            this.userPanelPaper = new System.Windows.Forms.Panel();
            this.pictureBoxPaper = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userPanelRock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).BeginInit();
            this.userPanelScissors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissors)).BeginInit();
            this.userPanelPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // userPanelRock
            // 
            this.userPanelRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelRock.Controls.Add(this.pictureBoxRock);
            this.userPanelRock.Location = new System.Drawing.Point(12, 12);
            this.userPanelRock.Name = "userPanelRock";
            this.userPanelRock.Size = new System.Drawing.Size(120, 120);
            this.userPanelRock.TabIndex = 0;
            this.userPanelRock.Tag = "Rock";
            this.userPanelRock.MouseEnter += new System.EventHandler(this.userPanel_MouseEnter);
            // 
            // pictureBoxRock
            // 
            this.pictureBoxRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRock.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRock.Image")));
            this.pictureBoxRock.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRock.Name = "pictureBoxRock";
            this.pictureBoxRock.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRock.TabIndex = 4;
            this.pictureBoxRock.TabStop = false;
            this.pictureBoxRock.Tag = "";
            this.pictureBoxRock.Visible = false;
            // 
            // userPanelScissors
            // 
            this.userPanelScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelScissors.Controls.Add(this.pictureBoxScissors);
            this.userPanelScissors.Location = new System.Drawing.Point(159, 12);
            this.userPanelScissors.Name = "userPanelScissors";
            this.userPanelScissors.Size = new System.Drawing.Size(120, 120);
            this.userPanelScissors.TabIndex = 1;
            this.userPanelScissors.Tag = "Scissors";
            this.userPanelScissors.MouseEnter += new System.EventHandler(this.userPanel_MouseEnter);
            // 
            // pictureBoxScissors
            // 
            this.pictureBoxScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxScissors.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScissors.Image")));
            this.pictureBoxScissors.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxScissors.Name = "pictureBoxScissors";
            this.pictureBoxScissors.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScissors.TabIndex = 6;
            this.pictureBoxScissors.TabStop = false;
            this.pictureBoxScissors.Visible = false;
            // 
            // userPanelPaper
            // 
            this.userPanelPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelPaper.Controls.Add(this.pictureBoxPaper);
            this.userPanelPaper.Location = new System.Drawing.Point(315, 12);
            this.userPanelPaper.Name = "userPanelPaper";
            this.userPanelPaper.Size = new System.Drawing.Size(120, 120);
            this.userPanelPaper.TabIndex = 2;
            this.userPanelPaper.Tag = "Paper";
            this.userPanelPaper.MouseEnter += new System.EventHandler(this.userPanel_MouseEnter);
            // 
            // pictureBoxPaper
            // 
            this.pictureBoxPaper.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPaper.Image")));
            this.pictureBoxPaper.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPaper.Name = "pictureBoxPaper";
            this.pictureBoxPaper.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPaper.TabIndex = 5;
            this.pictureBoxPaper.TabStop = false;
            this.pictureBoxPaper.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(616, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 120);
            this.panel4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 299);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.userPanelPaper);
            this.Controls.Add(this.userPanelScissors);
            this.Controls.Add(this.userPanelRock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камень-Ножницы-Бумага";
            this.userPanelRock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).EndInit();
            this.userPanelScissors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissors)).EndInit();
            this.userPanelPaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userPanelRock;
        private System.Windows.Forms.Panel userPanelScissors;
        private System.Windows.Forms.Panel userPanelPaper;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxRock;
        private System.Windows.Forms.PictureBox pictureBoxPaper;
        private System.Windows.Forms.PictureBox pictureBoxScissors;
    }
}

