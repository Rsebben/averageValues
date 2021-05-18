
namespace averageValues
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
            this.title = new System.Windows.Forms.Label();
            this.enterANumberAndPressAdd = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.sumOutput = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Maroon;
            this.title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(1, -4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 75);
            this.title.TabIndex = 0;
            this.title.Text = "Average Number Solver";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterANumberAndPressAdd
            // 
            this.enterANumberAndPressAdd.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterANumberAndPressAdd.ForeColor = System.Drawing.Color.White;
            this.enterANumberAndPressAdd.Location = new System.Drawing.Point(179, 112);
            this.enterANumberAndPressAdd.Name = "enterANumberAndPressAdd";
            this.enterANumberAndPressAdd.Size = new System.Drawing.Size(419, 94);
            this.enterANumberAndPressAdd.TabIndex = 1;
            this.enterANumberAndPressAdd.Text = "       Enter a Number and Press Add\r\n\r\n(enter 0 and press add to calculate averag" +
    "e)\r\n";
            this.enterANumberAndPressAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberInput
            // 
            this.numberInput.AcceptsReturn = true;
            this.numberInput.Location = new System.Drawing.Point(320, 295);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(67, 22);
            this.numberInput.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Black;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(393, 290);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(69, 31);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sumOutput
            // 
            this.sumOutput.BackColor = System.Drawing.Color.White;
            this.sumOutput.Location = new System.Drawing.Point(183, 375);
            this.sumOutput.Name = "sumOutput";
            this.sumOutput.Size = new System.Drawing.Size(415, 90);
            this.sumOutput.TabIndex = 4;
            this.sumOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(703, 507);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(85, 36);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sumOutput);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.enterANumberAndPressAdd);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Average Values";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label enterANumberAndPressAdd;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label sumOutput;
        private System.Windows.Forms.Button resetButton;
    }
}

