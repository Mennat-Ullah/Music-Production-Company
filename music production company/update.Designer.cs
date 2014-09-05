namespace WindowsFormsApplication1
{
    partial class update
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
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.music_production_companyDataSet = new WindowsFormsApplication1.music_production_companyDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edition = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.albumTableAdapter = new WindowsFormsApplication1.music_production_companyDataSetTableAdapters.AlbumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_production_companyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // album_name
            // 
            this.album_name.DataSource = this.albumBindingSource;
            this.album_name.DisplayMember = "name";
            this.album_name.FormattingEnabled = true;
            this.album_name.Location = new System.Drawing.Point(12, 86);
            this.album_name.Name = "album_name";
            this.album_name.Size = new System.Drawing.Size(145, 21);
            this.album_name.TabIndex = 0;
            this.album_name.ValueMember = "name";
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataMember = "Album";
            this.albumBindingSource.DataSource = this.music_production_companyDataSet;
            // 
            // music_production_companyDataSet
            // 
            this.music_production_companyDataSet.DataSetName = "music_production_companyDataSet";
            this.music_production_companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Album Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Editions";
            // 
            // edition
            // 
            this.edition.Location = new System.Drawing.Point(209, 87);
            this.edition.Name = "edition";
            this.edition.Size = new System.Drawing.Size(140, 20);
            this.edition.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.mu;
            this.ClientSize = new System.Drawing.Size(406, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.album_name);
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_production_companyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox album_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edition;
        private System.Windows.Forms.Button button1;
        private music_production_companyDataSet music_production_companyDataSet;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private music_production_companyDataSetTableAdapters.AlbumTableAdapter albumTableAdapter;
    }
}