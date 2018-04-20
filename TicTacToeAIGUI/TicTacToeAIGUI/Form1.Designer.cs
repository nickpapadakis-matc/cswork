namespace TicTacToeAIGUI
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
            this.btnTLeft = new System.Windows.Forms.Button();
            this.btnTMiddle = new System.Windows.Forms.Button();
            this.btnTRight = new System.Windows.Forms.Button();
            this.btnCLeft = new System.Windows.Forms.Button();
            this.btnCMiddle = new System.Windows.Forms.Button();
            this.btnCRight = new System.Windows.Forms.Button();
            this.btnBLeft = new System.Windows.Forms.Button();
            this.btnBMiddle = new System.Windows.Forms.Button();
            this.btnBRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTLeft
            // 
            this.btnTLeft.Location = new System.Drawing.Point(39, 30);
            this.btnTLeft.Name = "btnTLeft";
            this.btnTLeft.Size = new System.Drawing.Size(75, 62);
            this.btnTLeft.TabIndex = 0;
            this.btnTLeft.UseVisualStyleBackColor = true;
            this.btnTLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTMiddle
            // 
            this.btnTMiddle.Location = new System.Drawing.Point(120, 30);
            this.btnTMiddle.Name = "btnTMiddle";
            this.btnTMiddle.Size = new System.Drawing.Size(75, 62);
            this.btnTMiddle.TabIndex = 1;
            this.btnTMiddle.UseVisualStyleBackColor = true;
            this.btnTMiddle.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTRight
            // 
            this.btnTRight.Location = new System.Drawing.Point(201, 30);
            this.btnTRight.Name = "btnTRight";
            this.btnTRight.Size = new System.Drawing.Size(75, 62);
            this.btnTRight.TabIndex = 2;
            this.btnTRight.UseVisualStyleBackColor = true;
            this.btnTRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCLeft
            // 
            this.btnCLeft.Location = new System.Drawing.Point(39, 98);
            this.btnCLeft.Name = "btnCLeft";
            this.btnCLeft.Size = new System.Drawing.Size(75, 62);
            this.btnCLeft.TabIndex = 3;
            this.btnCLeft.UseVisualStyleBackColor = true;
            this.btnCLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCMiddle
            // 
            this.btnCMiddle.Location = new System.Drawing.Point(120, 98);
            this.btnCMiddle.Name = "btnCMiddle";
            this.btnCMiddle.Size = new System.Drawing.Size(75, 62);
            this.btnCMiddle.TabIndex = 4;
            this.btnCMiddle.UseVisualStyleBackColor = true;
            this.btnCMiddle.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCRight
            // 
            this.btnCRight.Location = new System.Drawing.Point(201, 98);
            this.btnCRight.Name = "btnCRight";
            this.btnCRight.Size = new System.Drawing.Size(75, 62);
            this.btnCRight.TabIndex = 5;
            this.btnCRight.UseVisualStyleBackColor = true;
            this.btnCRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBLeft
            // 
            this.btnBLeft.Location = new System.Drawing.Point(39, 166);
            this.btnBLeft.Name = "btnBLeft";
            this.btnBLeft.Size = new System.Drawing.Size(75, 62);
            this.btnBLeft.TabIndex = 6;
            this.btnBLeft.UseVisualStyleBackColor = true;
            this.btnBLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBMiddle
            // 
            this.btnBMiddle.Location = new System.Drawing.Point(120, 166);
            this.btnBMiddle.Name = "btnBMiddle";
            this.btnBMiddle.Size = new System.Drawing.Size(75, 62);
            this.btnBMiddle.TabIndex = 7;
            this.btnBMiddle.UseVisualStyleBackColor = true;
            this.btnBMiddle.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBRight
            // 
            this.btnBRight.Location = new System.Drawing.Point(201, 166);
            this.btnBRight.Name = "btnBRight";
            this.btnBRight.Size = new System.Drawing.Size(75, 62);
            this.btnBRight.TabIndex = 8;
            this.btnBRight.UseVisualStyleBackColor = true;
            this.btnBRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 259);
            this.Controls.Add(this.btnBRight);
            this.Controls.Add(this.btnBMiddle);
            this.Controls.Add(this.btnBLeft);
            this.Controls.Add(this.btnCRight);
            this.Controls.Add(this.btnCMiddle);
            this.Controls.Add(this.btnCLeft);
            this.Controls.Add(this.btnTRight);
            this.Controls.Add(this.btnTMiddle);
            this.Controls.Add(this.btnTLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTLeft;
        private System.Windows.Forms.Button btnTMiddle;
        private System.Windows.Forms.Button btnTRight;
        private System.Windows.Forms.Button btnCLeft;
        private System.Windows.Forms.Button btnCMiddle;
        private System.Windows.Forms.Button btnCRight;
        private System.Windows.Forms.Button btnBLeft;
        private System.Windows.Forms.Button btnBMiddle;
        private System.Windows.Forms.Button btnBRight;
    }
}

