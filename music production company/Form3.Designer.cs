namespace WindowsFormsApplication1
{
    partial class count
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
            this.sCount = new System.Windows.Forms.Button();
            this.comboBox_occupation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sCount
            // 
            this.sCount.Location = new System.Drawing.Point(169, 179);
            this.sCount.Name = "sCount";
            this.sCount.Size = new System.Drawing.Size(95, 23);
            this.sCount.TabIndex = 0;
            this.sCount.Text = "Count Songs";
            this.sCount.UseVisualStyleBackColor = true;
            this.sCount.Click += new System.EventHandler(this.sCount_Click);
            // 
            // comboBox_occupation
            // 
            this.comboBox_occupation.FormattingEnabled = true;
            this.comboBox_occupation.Items.AddRange(new object[] {
            "singer",
            "composer",
            "writer"});
            this.comboBox_occupation.Location = new System.Drawing.Point(328, 99);
            this.comboBox_occupation.Name = "comboBox_occupation";
            this.comboBox_occupation.Size = new System.Drawing.Size(98, 21);
            this.comboBox_occupation.TabIndex = 1;
            this.comboBox_occupation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Occupation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(24, 99);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(100, 20);
            this.first_name.TabIndex = 5;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(178, 100);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(100, 20);
            this.last_name.TabIndex = 6;
            // 
            // count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.mu;
            this.ClientSize = new System.Drawing.Size(456, 228);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_occupation);
            this.Controls.Add(this.sCount);
            this.Name = "count";
            this.Text = "Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sCount;
        private System.Windows.Forms.ComboBox comboBox_occupation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox last_name;
    }
}