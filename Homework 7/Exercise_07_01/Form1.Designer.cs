
namespace Exercise_07_01
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
            this.lblNum = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblcurrenttxt = new System.Windows.Forms.Label();
            this.lblgoaltxt = new System.Windows.Forms.Label();
            this.lblcounttxt = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(319, 100);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(29, 31);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "1";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(508, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 47);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+1";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new System.Drawing.Point(508, 100);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(162, 47);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "*2";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturn.Location = new System.Drawing.Point(508, 167);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(162, 47);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(508, 234);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(162, 47);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblcurrenttxt
            // 
            this.lblcurrenttxt.AutoSize = true;
            this.lblcurrenttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcurrenttxt.Location = new System.Drawing.Point(12, 100);
            this.lblcurrenttxt.Name = "lblcurrenttxt";
            this.lblcurrenttxt.Size = new System.Drawing.Size(206, 31);
            this.lblcurrenttxt.TabIndex = 5;
            this.lblcurrenttxt.Text = "Текущее число";
            // 
            // lblgoaltxt
            // 
            this.lblgoaltxt.AutoSize = true;
            this.lblgoaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblgoaltxt.Location = new System.Drawing.Point(12, 47);
            this.lblgoaltxt.Name = "lblgoaltxt";
            this.lblgoaltxt.Size = new System.Drawing.Size(242, 31);
            this.lblgoaltxt.TabIndex = 6;
            this.lblgoaltxt.Text = "Загаданное число";
            // 
            // lblcounttxt
            // 
            this.lblcounttxt.AutoSize = true;
            this.lblcounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcounttxt.Location = new System.Drawing.Point(12, 153);
            this.lblcounttxt.Name = "lblcounttxt";
            this.lblcounttxt.Size = new System.Drawing.Size(241, 31);
            this.lblcounttxt.TabIndex = 7;
            this.lblcounttxt.Text = "Количество ходов";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGoal.Location = new System.Drawing.Point(319, 47);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(23, 31);
            this.lblGoal.TabIndex = 8;
            this.lblGoal.Text = "-";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(319, 153);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(29, 31);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "0";
            // 
            // menu1
            // 
            this.menu1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menu1.Dock = System.Windows.Forms.DockStyle.None;
            this.menu1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 406);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(233, 45);
            this.menu1.TabIndex = 10;
            this.menu1.Text = "Меню";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlay});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(105, 41);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(180, 30);
            this.btnPlay.Text = "Играть";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblcounttxt);
            this.Controls.Add(this.lblgoaltxt);
            this.Controls.Add(this.lblcurrenttxt);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.menu1);
            this.MainMenuStrip = this.menu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblcurrenttxt;
        private System.Windows.Forms.Label lblgoaltxt;
        private System.Windows.Forms.Label lblcounttxt;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPlay;
    }
}

