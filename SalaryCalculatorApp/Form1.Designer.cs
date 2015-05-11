namespace SalaryCalculatorApp
{
    partial class CalculatorSalaryUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.rentTextBox = new System.Windows.Forms.TextBox();
            this.medicalTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic amount\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Allowence";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(226, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(348, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(226, 61);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(204, 20);
            this.amountTextBox.TabIndex = 5;
            // 
            // rentTextBox
            // 
            this.rentTextBox.Location = new System.Drawing.Point(226, 105);
            this.rentTextBox.Name = "rentTextBox";
            this.rentTextBox.Size = new System.Drawing.Size(204, 20);
            this.rentTextBox.TabIndex = 6;
            // 
            // medicalTextBox
            // 
            this.medicalTextBox.Location = new System.Drawing.Point(226, 147);
            this.medicalTextBox.Name = "medicalTextBox";
            this.medicalTextBox.Size = new System.Drawing.Size(204, 20);
            this.medicalTextBox.TabIndex = 7;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(256, 190);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(141, 30);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show Me Salary";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "% Of Basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "% Of Basic";
            // 
            // CalculatorSalaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 293);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.medicalTextBox);
            this.Controls.Add(this.rentTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorSalaryUI";
            this.Text = "Calculator Salary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox rentTextBox;
        private System.Windows.Forms.TextBox medicalTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

