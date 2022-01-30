namespace CST_150_Activity_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_farenheit = new System.Windows.Forms.TextBox();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_Kelvin = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(111, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(111, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txt_farenheit
            // 
            this.txt_farenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_farenheit.Location = new System.Drawing.Point(354, 100);
            this.txt_farenheit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_farenheit.Name = "txt_farenheit";
            this.txt_farenheit.Size = new System.Drawing.Size(148, 40);
            this.txt_farenheit.TabIndex = 3;
            // 
            // txt_celsius
            // 
            this.txt_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celsius.Location = new System.Drawing.Point(354, 215);
            this.txt_celsius.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(148, 40);
            this.txt_celsius.TabIndex = 4;
            // 
            // txt_Kelvin
            // 
            this.txt_Kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Kelvin.Location = new System.Drawing.Point(354, 332);
            this.txt_Kelvin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Kelvin.Name = "txt_Kelvin";
            this.txt_Kelvin.Size = new System.Drawing.Size(148, 40);
            this.txt_Kelvin.TabIndex = 5;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(567, 100);
            this.convert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(112, 43);
            this.convert.TabIndex = 6;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 740);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.txt_Kelvin);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.txt_farenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CST Activity 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_farenheit;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_Kelvin;
        private System.Windows.Forms.Button convert;
    }
}

