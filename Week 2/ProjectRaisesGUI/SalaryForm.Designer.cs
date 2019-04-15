namespace ProjectRaisesGUI
{
    partial class SalaryForm
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
            this.label_enterSalary = new System.Windows.Forms.Label();
            this.textbox_currentSalary = new System.Windows.Forms.TextBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.label_nySalary = new System.Windows.Forms.Label();
            this.label_modifiedSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_enterSalary
            // 
            this.label_enterSalary.AutoSize = true;
            this.label_enterSalary.Location = new System.Drawing.Point(32, 48);
            this.label_enterSalary.Name = "label_enterSalary";
            this.label_enterSalary.Size = new System.Drawing.Size(86, 17);
            this.label_enterSalary.TabIndex = 0;
            this.label_enterSalary.Text = "Enter Salary";
            this.label_enterSalary.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // textbox_currentSalary
            // 
            this.textbox_currentSalary.Location = new System.Drawing.Point(128, 48);
            this.textbox_currentSalary.Name = "textbox_currentSalary";
            this.textbox_currentSalary.Size = new System.Drawing.Size(100, 22);
            this.textbox_currentSalary.TabIndex = 1;
            this.textbox_currentSalary.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(120, 96);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(80, 24);
            this.button_calculate.TabIndex = 2;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.Button_calculate_Click);
            // 
            // label_nySalary
            // 
            this.label_nySalary.AutoSize = true;
            this.label_nySalary.Location = new System.Drawing.Point(32, 152);
            this.label_nySalary.Name = "label_nySalary";
            this.label_nySalary.Size = new System.Drawing.Size(128, 17);
            this.label_nySalary.TabIndex = 3;
            this.label_nySalary.Text = "Next Year\'s Salary:";
            // 
            // label_modifiedSalary
            // 
            this.label_modifiedSalary.AutoSize = true;
            this.label_modifiedSalary.Location = new System.Drawing.Point(168, 152);
            this.label_modifiedSalary.Name = "label_modifiedSalary";
            this.label_modifiedSalary.Size = new System.Drawing.Size(0, 17);
            this.label_modifiedSalary.TabIndex = 4;
            // 
            // SalaryForm
            // 
            this.AcceptButton = this.button_calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(308, 243);
            this.Controls.Add(this.label_modifiedSalary);
            this.Controls.Add(this.label_nySalary);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.textbox_currentSalary);
            this.Controls.Add(this.label_enterSalary);
            this.MaximizeBox = false;
            this.Name = "SalaryForm";
            this.ShowIcon = false;
            this.Text = "Calculate Salary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_enterSalary;
        private System.Windows.Forms.TextBox textbox_currentSalary;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Label label_nySalary;
        private System.Windows.Forms.Label label_modifiedSalary;
    }
}

