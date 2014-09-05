namespace WindowsFormsApplication1
{
    partial class albums
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
            this.components = new System.ComponentModel.Container();
            this.album_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.music_production_companyDataSet2 = new WindowsFormsApplication1.music_production_companyDataSet2();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumTableAdapter = new WindowsFormsApplication1.music_production_companyDataSet2TableAdapters.AlbumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.music_production_companyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // album_name
            // 
            this.album_name.DataSource = this.albumBindingSource;
            this.album_name.DisplayMember = "name";
            this.album_name.FormattingEnabled = true;
            this.album_name.Location = new System.Drawing.Point(12, 93);
            this.album_name.Name = "album_name";
            this.album_name.Size = new System.Drawing.Size(186, 21);
            this.album_name.TabIndex = 0;
            this.album_name.ValueMember = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Album Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Number of songs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // music_production_companyDataSet2
            // 
            this.music_production_companyDataSet2.DataSetName = "music_production_companyDataSet2";
            this.music_production_companyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataMember = "Album";
            this.albumBindingSource.DataSource = this.music_production_companyDataSet2;
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // albums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.mu;
            this.ClientSize = new System.Drawing.Size(444, 191);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.album_name);
            this.Name = "albums";
            this.Text = "Album";
            this.Load += new System.EventHandler(this.albums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.music_production_companyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox album_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private music_production_companyDataSet2 music_production_companyDataSet2;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private music_production_companyDataSet2TableAdapters.AlbumTableAdapter albumTableAdapter;
    }
}