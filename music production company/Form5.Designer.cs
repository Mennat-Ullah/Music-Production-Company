namespace WindowsFormsApplication1
{
    partial class delete
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.album_name = new System.Windows.Forms.ComboBox();
            this.music_production_companyDataSet1 = new WindowsFormsApplication1.music_production_companyDataSet1();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumTableAdapter = new WindowsFormsApplication1.music_production_companyDataSet1TableAdapters.AlbumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.music_production_companyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Album Name";
            // 
            // album_name
            // 
            this.album_name.DataSource = this.albumBindingSource;
            this.album_name.FormattingEnabled = true;
            this.album_name.Location = new System.Drawing.Point(25, 92);
            this.album_name.Name = "album_name";
            this.album_name.Size = new System.Drawing.Size(121, 21);
            this.album_name.TabIndex = 3;
            this.album_name.ValueMember = "name";
            this.album_name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // music_production_companyDataSet1
            // 
            this.music_production_companyDataSet1.DataSetName = "music_production_companyDataSet1";
            this.music_production_companyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataMember = "Album";
            this.albumBindingSource.DataSource = this.music_production_companyDataSet1;
            this.albumBindingSource.CurrentChanged += new System.EventHandler(this.albumBindingSource_CurrentChanged);
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.mu;
            this.ClientSize = new System.Drawing.Size(272, 225);
            this.Controls.Add(this.album_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.music_production_companyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox album_name;
        private music_production_companyDataSet1 music_production_companyDataSet1;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private music_production_companyDataSet1TableAdapters.AlbumTableAdapter albumTableAdapter;
    }
}