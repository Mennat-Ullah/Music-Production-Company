namespace WindowsFormsApplication1
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
            this.b_manipulate = new System.Windows.Forms.Button();
            this.album_songs = new System.Windows.Forms.Button();
            this.b_count = new System.Windows.Forms.Button();
            this.b_price = new System.Windows.Forms.Button();
            this.comboBox_manipulation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // b_manipulate
            // 
            this.b_manipulate.Location = new System.Drawing.Point(34, 31);
            this.b_manipulate.Name = "b_manipulate";
            this.b_manipulate.Size = new System.Drawing.Size(75, 23);
            this.b_manipulate.TabIndex = 0;
            this.b_manipulate.Text = "manipulate";
            this.b_manipulate.UseVisualStyleBackColor = true;
            this.b_manipulate.Click += new System.EventHandler(this.button1_Click);
            // 
            // album_songs
            // 
            this.album_songs.Location = new System.Drawing.Point(253, 31);
            this.album_songs.Name = "album_songs";
            this.album_songs.Size = new System.Drawing.Size(93, 23);
            this.album_songs.TabIndex = 1;
            this.album_songs.Text = "search";
            this.album_songs.UseVisualStyleBackColor = true;
            this.album_songs.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_count
            // 
            this.b_count.BackColor = System.Drawing.Color.Transparent;
            this.b_count.Location = new System.Drawing.Point(253, 75);
            this.b_count.Name = "b_count";
            this.b_count.Size = new System.Drawing.Size(93, 23);
            this.b_count.TabIndex = 2;
            this.b_count.Text = "count";
            this.b_count.UseVisualStyleBackColor = false;
            this.b_count.Click += new System.EventHandler(this.button3_Click);
            // 
            // b_price
            // 
            this.b_price.BackColor = System.Drawing.Color.Transparent;
            this.b_price.ForeColor = System.Drawing.Color.Black;
            this.b_price.Location = new System.Drawing.Point(253, 125);
            this.b_price.Name = "b_price";
            this.b_price.Size = new System.Drawing.Size(93, 23);
            this.b_price.TabIndex = 3;
            this.b_price.Text = "Album Songs";
            this.b_price.UseVisualStyleBackColor = false;
            this.b_price.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox_manipulation
            // 
            this.comboBox_manipulation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox_manipulation.FormattingEnabled = true;
            this.comboBox_manipulation.Items.AddRange(new object[] {
            "Insert",
            "Update",
            "Delete"});
            this.comboBox_manipulation.Location = new System.Drawing.Point(12, 60);
            this.comboBox_manipulation.Name = "comboBox_manipulation";
            this.comboBox_manipulation.Size = new System.Drawing.Size(121, 21);
            this.comboBox_manipulation.TabIndex = 4;
            this.comboBox_manipulation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.mu;
            this.ClientSize = new System.Drawing.Size(373, 187);
            this.Controls.Add(this.comboBox_manipulation);
            this.Controls.Add(this.b_price);
            this.Controls.Add(this.b_count);
            this.Controls.Add(this.album_songs);
            this.Controls.Add(this.b_manipulate);
            this.Name = "Form1";
            this.Text = "Music Production Company";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_manipulate;
        private System.Windows.Forms.Button album_songs;
        private System.Windows.Forms.Button b_count;
        private System.Windows.Forms.Button b_price;
        private System.Windows.Forms.ComboBox comboBox_manipulation;
    }
}

