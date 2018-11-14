namespace TestInteractiveGUI
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
            this.lblTest1 = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.lblTest3 = new System.Windows.Forms.Label();
            this.lblTest4 = new System.Windows.Forms.Label();
            this.lblTest5 = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.txtEnterScore1 = new System.Windows.Forms.TextBox();
            this.txtEnterScore2 = new System.Windows.Forms.TextBox();
            this.txtEnterScore3 = new System.Windows.Forms.TextBox();
            this.txtEnterScore4 = new System.Windows.Forms.TextBox();
            this.txtEnterScore5 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblYourAverage = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(64, 76);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(40, 13);
            this.lblTest1.TabIndex = 0;
            this.lblTest1.Text = "Test 1:";
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(64, 116);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(40, 13);
            this.lblTest2.TabIndex = 1;
            this.lblTest2.Text = "Test 2:";
            // 
            // lblTest3
            // 
            this.lblTest3.AutoSize = true;
            this.lblTest3.Location = new System.Drawing.Point(64, 152);
            this.lblTest3.Name = "lblTest3";
            this.lblTest3.Size = new System.Drawing.Size(40, 13);
            this.lblTest3.TabIndex = 2;
            this.lblTest3.Text = "Test 3:";
            // 
            // lblTest4
            // 
            this.lblTest4.AutoSize = true;
            this.lblTest4.Location = new System.Drawing.Point(64, 196);
            this.lblTest4.Name = "lblTest4";
            this.lblTest4.Size = new System.Drawing.Size(40, 13);
            this.lblTest4.TabIndex = 3;
            this.lblTest4.Text = "Test 4:";
            // 
            // lblTest5
            // 
            this.lblTest5.AutoSize = true;
            this.lblTest5.Location = new System.Drawing.Point(64, 233);
            this.lblTest5.Name = "lblTest5";
            this.lblTest5.Size = new System.Drawing.Size(40, 13);
            this.lblTest5.TabIndex = 4;
            this.lblTest5.Text = "Test 5:";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(122, 35);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(40, 13);
            this.lblScores.TabIndex = 5;
            this.lblScores.Text = "Scores";
            // 
            // txtEnterScore1
            // 
            this.txtEnterScore1.Location = new System.Drawing.Point(125, 76);
            this.txtEnterScore1.Name = "txtEnterScore1";
            this.txtEnterScore1.Size = new System.Drawing.Size(100, 20);
            this.txtEnterScore1.TabIndex = 6;
            // 
            // txtEnterScore2
            // 
            this.txtEnterScore2.Location = new System.Drawing.Point(125, 116);
            this.txtEnterScore2.Name = "txtEnterScore2";
            this.txtEnterScore2.Size = new System.Drawing.Size(100, 20);
            this.txtEnterScore2.TabIndex = 7;
            // 
            // txtEnterScore3
            // 
            this.txtEnterScore3.Location = new System.Drawing.Point(125, 152);
            this.txtEnterScore3.Name = "txtEnterScore3";
            this.txtEnterScore3.Size = new System.Drawing.Size(100, 20);
            this.txtEnterScore3.TabIndex = 8;
            // 
            // txtEnterScore4
            // 
            this.txtEnterScore4.Location = new System.Drawing.Point(125, 196);
            this.txtEnterScore4.Name = "txtEnterScore4";
            this.txtEnterScore4.Size = new System.Drawing.Size(100, 20);
            this.txtEnterScore4.TabIndex = 9;
            // 
            // txtEnterScore5
            // 
            this.txtEnterScore5.Location = new System.Drawing.Point(125, 233);
            this.txtEnterScore5.Name = "txtEnterScore5";
            this.txtEnterScore5.Size = new System.Drawing.Size(100, 20);
            this.txtEnterScore5.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(307, 152);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(105, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblYourAverage
            // 
            this.lblYourAverage.AutoSize = true;
            this.lblYourAverage.Location = new System.Drawing.Point(547, 182);
            this.lblYourAverage.Name = "lblYourAverage";
            this.lblYourAverage.Size = new System.Drawing.Size(75, 13);
            this.lblYourAverage.TabIndex = 12;
            this.lblYourAverage.Text = "Your Average:";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(465, 223);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(242, 23);
            this.lblResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblYourAverage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterScore5);
            this.Controls.Add(this.txtEnterScore4);
            this.Controls.Add(this.txtEnterScore3);
            this.Controls.Add(this.txtEnterScore2);
            this.Controls.Add(this.txtEnterScore1);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblTest5);
            this.Controls.Add(this.lblTest4);
            this.Controls.Add(this.lblTest3);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.lblTest1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Label lblTest3;
        private System.Windows.Forms.Label lblTest4;
        private System.Windows.Forms.Label lblTest5;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.TextBox txtEnterScore1;
        private System.Windows.Forms.TextBox txtEnterScore2;
        private System.Windows.Forms.TextBox txtEnterScore3;
        private System.Windows.Forms.TextBox txtEnterScore4;
        private System.Windows.Forms.TextBox txtEnterScore5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblYourAverage;
        private System.Windows.Forms.Label lblResult;
    }
}

