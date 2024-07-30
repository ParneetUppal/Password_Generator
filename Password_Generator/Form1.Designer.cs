namespace Password_Generator
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
            this.txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngenerate = new System.Windows.Forms.Button();
            this.btncopy = new System.Windows.Forms.Button();
            this.chkboxlower = new System.Windows.Forms.CheckBox();
            this.chkboxSymbol = new System.Windows.Forms.CheckBox();
            this.chkboxDigit = new System.Windows.Forms.CheckBox();
            this.chkboxUpper = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(108, 137);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(209, 20);
            this.txtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "PASSWORD GENERATOR ";
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(120, 163);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(75, 23);
            this.btngenerate.TabIndex = 2;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = true;
            // 
            // btncopy
            // 
            this.btncopy.Location = new System.Drawing.Point(220, 163);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(75, 23);
            this.btncopy.TabIndex = 3;
            this.btncopy.Text = "Copy";
            this.btncopy.UseVisualStyleBackColor = true;
            // 
            // chkboxlower
            // 
            this.chkboxlower.AutoSize = true;
            this.chkboxlower.Location = new System.Drawing.Point(172, 114);
            this.chkboxlower.Name = "chkboxlower";
            this.chkboxlower.Size = new System.Drawing.Size(79, 17);
            this.chkboxlower.TabIndex = 4;
            this.chkboxlower.Text = "LowerCase";
            this.chkboxlower.UseVisualStyleBackColor = true;
            // 
            // chkboxSymbol
            // 
            this.chkboxSymbol.AutoSize = true;
            this.chkboxSymbol.Location = new System.Drawing.Point(172, 91);
            this.chkboxSymbol.Name = "chkboxSymbol";
            this.chkboxSymbol.Size = new System.Drawing.Size(68, 17);
            this.chkboxSymbol.TabIndex = 5;
            this.chkboxSymbol.Text = "Symbols ";
            this.chkboxSymbol.UseVisualStyleBackColor = true;
            // 
            // chkboxDigit
            // 
            this.chkboxDigit.AutoSize = true;
            this.chkboxDigit.Location = new System.Drawing.Point(172, 68);
            this.chkboxDigit.Name = "chkboxDigit";
            this.chkboxDigit.Size = new System.Drawing.Size(55, 17);
            this.chkboxDigit.TabIndex = 6;
            this.chkboxDigit.Text = "Digits ";
            this.chkboxDigit.UseVisualStyleBackColor = true;
            // 
            // chkboxUpper
            // 
            this.chkboxUpper.AutoSize = true;
            this.chkboxUpper.Location = new System.Drawing.Point(172, 45);
            this.chkboxUpper.Name = "chkboxUpper";
            this.chkboxUpper.Size = new System.Drawing.Size(79, 17);
            this.chkboxUpper.TabIndex = 7;
            this.chkboxUpper.Text = "UpperCase";
            this.chkboxUpper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 198);
            this.Controls.Add(this.chkboxUpper);
            this.Controls.Add(this.chkboxDigit);
            this.Controls.Add(this.chkboxSymbol);
            this.Controls.Add(this.chkboxlower);
            this.Controls.Add(this.btncopy);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox);
            this.Name = "Form1";
            this.Text = "Password_Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.Button btncopy;
        private System.Windows.Forms.CheckBox chkboxlower;
        private System.Windows.Forms.CheckBox chkboxSymbol;
        private System.Windows.Forms.CheckBox chkboxDigit;
        private System.Windows.Forms.CheckBox chkboxUpper;
    }
}

