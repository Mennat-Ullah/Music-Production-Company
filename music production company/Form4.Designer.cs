namespace WindowsFormsApplication1
{
    partial class search
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
            this.songname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.s_singer = new System.Windows.Forms.TextBox();
            this.s_writer = new System.Windows.Forms.TextBox();
            this.s_composer = new System.Windows.Forms.TextBox();
            this.s_album = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songname
            // 
            this.songname.Location = new System.Drawing.Point(12, 44);
            this.songname.Name = "songname";
            this.songname.Size = new System.Drawing.Size(132, 20);
            this.songname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter song name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // s_singer
            // 
            this.s_singer.Location = new System.Drawing.Point(173, 133);
            this.s_singer.Name = "s_singer";
            this.s_singer.Size = new System.Drawing.Size(132, 20);
            this.s_singer.TabIndex = 3;
            // 
            // s_writer
            // 
            this.s_writer.Location = new System.Drawing.Point(173, 198);
            this.s_writer.Name = "s_writer";
            this.s_writer.Size = new System.Drawing.Size(132, 20);
            this.s_writer.TabIndex = 4;
            // 
            // s_composer
            // 
            this.s_composer.Location = new System.Drawing.Point(15, 198);
            this.s_composer.Name = "s_composer";
            this.s_composer.Size = new System.Drawing.Size(132, 20);
            this.s_composer.TabIndex = 5;
            // 
            // s_album
            // 
            this.s_album.Location = new System.Drawing.Point(15, 133);
            this.s_album.Name = "s_album";
            this.s_album.Size = new System.Drawing.Size(132, 20);
            this.s_album.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Singer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Writer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Composer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Album name";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.mu;
            this.ClientSize = new System.Drawing.Size(390, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.s_album);
            this.Controls.Add(this.s_composer);
            this.Controls.Add(this.s_writer);
            this.Controls.Add(this.s_singer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songname);
            this.Name = "search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox songname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox s_singer;
        private System.Windows.Forms.TextBox s_writer;
        private System.Windows.Forms.TextBox s_composer;
        private System.Windows.Forms.TextBox s_album;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}