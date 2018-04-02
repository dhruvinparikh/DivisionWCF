namespace DivServiceClientApp
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
            this.lblNumerator = new System.Windows.Forms.Label();
            this.lblDenominator = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbDen = new System.Windows.Forms.TextBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumerator
            // 
            this.lblNumerator.AutoSize = true;
            this.lblNumerator.Location = new System.Drawing.Point(82, 59);
            this.lblNumerator.Name = "lblNumerator";
            this.lblNumerator.Size = new System.Drawing.Size(75, 17);
            this.lblNumerator.TabIndex = 0;
            this.lblNumerator.Text = "Numerator";
            // 
            // lblDenominator
            // 
            this.lblDenominator.AutoSize = true;
            this.lblDenominator.Location = new System.Drawing.Point(82, 115);
            this.lblDenominator.Name = "lblDenominator";
            this.lblDenominator.Size = new System.Drawing.Size(89, 17);
            this.lblDenominator.TabIndex = 1;
            this.lblDenominator.Text = "Denominator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(242, 59);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 22);
            this.tbNum.TabIndex = 3;
            // 
            // tbDen
            // 
            this.tbDen.Location = new System.Drawing.Point(242, 115);
            this.tbDen.Name = "tbDen";
            this.tbDen.Size = new System.Drawing.Size(100, 22);
            this.tbDen.TabIndex = 4;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(252, 175);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "Divide";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 398);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.tbDen);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDenominator);
            this.Controls.Add(this.lblNumerator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumerator;
        private System.Windows.Forms.Label lblDenominator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbDen;
        private System.Windows.Forms.Button btnDiv;
    }
}

