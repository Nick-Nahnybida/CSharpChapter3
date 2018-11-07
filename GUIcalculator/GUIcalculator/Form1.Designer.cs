namespace GUIcalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnterANumber = new System.Windows.Forms.TextBox();
            this.txtEnterAnotherNumber = new System.Windows.Forms.TextBox();
            this.lblResultAdd = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.lblResultSub = new System.Windows.Forms.Label();
            this.lblResultDiv = new System.Windows.Forms.Label();
            this.lblResultMulti = new System.Windows.Forms.Label();
            this.lblResultMod = new System.Windows.Forms.Label();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter another number";
            // 
            // txtEnterANumber
            // 
            this.txtEnterANumber.Location = new System.Drawing.Point(298, 90);
            this.txtEnterANumber.Name = "txtEnterANumber";
            this.txtEnterANumber.Size = new System.Drawing.Size(100, 20);
            this.txtEnterANumber.TabIndex = 2;
            // 
            // txtEnterAnotherNumber
            // 
            this.txtEnterAnotherNumber.Location = new System.Drawing.Point(298, 159);
            this.txtEnterAnotherNumber.Name = "txtEnterAnotherNumber";
            this.txtEnterAnotherNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEnterAnotherNumber.TabIndex = 3;
            // 
            // lblResultAdd
            // 
            this.lblResultAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultAdd.Location = new System.Drawing.Point(469, 144);
            this.lblResultAdd.Name = "lblResultAdd";
            this.lblResultAdd.Size = new System.Drawing.Size(125, 23);
            this.lblResultAdd.TabIndex = 5;
            this.lblResultAdd.Text = " ";
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(632, 86);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "Subtract";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(469, 217);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "Divide";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(632, 217);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(75, 23);
            this.btnmulti.TabIndex = 9;
            this.btnmulti.Text = "Multiply";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(469, 332);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 10;
            this.btnMod.Text = "Modulus";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // lblResultSub
            // 
            this.lblResultSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultSub.Location = new System.Drawing.Point(632, 144);
            this.lblResultSub.Name = "lblResultSub";
            this.lblResultSub.Size = new System.Drawing.Size(125, 23);
            this.lblResultSub.TabIndex = 11;
            // 
            // lblResultDiv
            // 
            this.lblResultDiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultDiv.Location = new System.Drawing.Point(469, 270);
            this.lblResultDiv.Name = "lblResultDiv";
            this.lblResultDiv.Size = new System.Drawing.Size(125, 23);
            this.lblResultDiv.TabIndex = 12;
            // 
            // lblResultMulti
            // 
            this.lblResultMulti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultMulti.Location = new System.Drawing.Point(632, 270);
            this.lblResultMulti.Name = "lblResultMulti";
            this.lblResultMulti.Size = new System.Drawing.Size(125, 23);
            this.lblResultMulti.TabIndex = 13;
            // 
            // lblResultMod
            // 
            this.lblResultMod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultMod.Location = new System.Drawing.Point(469, 380);
            this.lblResultMod.Name = "lblResultMod";
            this.lblResultMod.Size = new System.Drawing.Size(125, 23);
            this.lblResultMod.TabIndex = 14;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(469, 83);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 15;
            this.btnAdd2.Text = "+";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.lblResultMod);
            this.Controls.Add(this.lblResultMulti);
            this.Controls.Add(this.lblResultDiv);
            this.Controls.Add(this.lblResultSub);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.lblResultAdd);
            this.Controls.Add(this.txtEnterAnotherNumber);
            this.Controls.Add(this.txtEnterANumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnterANumber;
        private System.Windows.Forms.TextBox txtEnterAnotherNumber;
        private System.Windows.Forms.Label lblResultAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label lblResultSub;
        private System.Windows.Forms.Label lblResultDiv;
        private System.Windows.Forms.Label lblResultMulti;
        private System.Windows.Forms.Label lblResultMod;
        private System.Windows.Forms.Button btnAdd2;
    }
}

