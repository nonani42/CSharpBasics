
namespace Exercise_07_02
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lbltxt2 = new System.Windows.Forms.Label();
            this.lbltxt1 = new System.Windows.Forms.Label();
            this.lblcheck = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox.Location = new System.Drawing.Point(261, 96);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(95, 47);
            this.txtBox.TabIndex = 0;
            // 
            // lbltxt2
            // 
            this.lbltxt2.AutoSize = true;
            this.lbltxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltxt2.Location = new System.Drawing.Point(12, 99);
            this.lbltxt2.Name = "lbltxt2";
            this.lbltxt2.Size = new System.Drawing.Size(227, 39);
            this.lbltxt2.TabIndex = 1;
            this.lbltxt2.Text = "Ваш вариант";
            // 
            // lbltxt1
            // 
            this.lbltxt1.AutoSize = true;
            this.lbltxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltxt1.Location = new System.Drawing.Point(2, 9);
            this.lbltxt1.Name = "lbltxt1";
            this.lbltxt1.Size = new System.Drawing.Size(890, 39);
            this.lbltxt1.TabIndex = 2;
            this.lbltxt1.Text = "Загадано число от 1 до 100. Попробуйте его отгадать!";
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcheck.Location = new System.Drawing.Point(415, 99);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(47, 39);
            this.lblcheck.TabIndex = 3;
            this.lblcheck.Text = "...";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(9, 171);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(883, 57);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 240);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblcheck);
            this.Controls.Add(this.lbltxt1);
            this.Controls.Add(this.lbltxt2);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lbltxt2;
        private System.Windows.Forms.Label lbltxt1;
        private System.Windows.Forms.Label lblcheck;
        private System.Windows.Forms.Button btnStart;
    }
}

