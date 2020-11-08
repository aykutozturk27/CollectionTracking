namespace CollectionTracking.WinFormUI
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxFilmUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxTypeUpdate = new System.Windows.Forms.TextBox();
            this.tbxFilmNameUpdate = new System.Windows.Forms.TextBox();
            this.lblPublishDateUpdate = new System.Windows.Forms.Label();
            this.lblFilmTypeUpdate = new System.Windows.Forms.Label();
            this.lblFilmNameUpdate = new System.Windows.Forms.Label();
            this.gbxFilmAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.tbxFilmName = new System.Windows.Forms.TextBox();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.lblFilmType = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.dgwFilm = new System.Windows.Forms.DataGridView();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPublishDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.gbxFilmUpdate.SuspendLayout();
            this.gbxFilmAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(27, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxFilmUpdate
            // 
            this.gbxFilmUpdate.Controls.Add(this.dtpPublishDateUpdate);
            this.gbxFilmUpdate.Controls.Add(this.btnUpdate);
            this.gbxFilmUpdate.Controls.Add(this.tbxTypeUpdate);
            this.gbxFilmUpdate.Controls.Add(this.tbxFilmNameUpdate);
            this.gbxFilmUpdate.Controls.Add(this.lblPublishDateUpdate);
            this.gbxFilmUpdate.Controls.Add(this.lblFilmTypeUpdate);
            this.gbxFilmUpdate.Controls.Add(this.lblFilmNameUpdate);
            this.gbxFilmUpdate.Location = new System.Drawing.Point(27, 341);
            this.gbxFilmUpdate.Name = "gbxFilmUpdate";
            this.gbxFilmUpdate.Size = new System.Drawing.Size(604, 145);
            this.gbxFilmUpdate.TabIndex = 8;
            this.gbxFilmUpdate.TabStop = false;
            this.gbxFilmUpdate.Text = "Film Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(366, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 26);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxTypeUpdate
            // 
            this.tbxTypeUpdate.Location = new System.Drawing.Point(94, 61);
            this.tbxTypeUpdate.Name = "tbxTypeUpdate";
            this.tbxTypeUpdate.Size = new System.Drawing.Size(180, 20);
            this.tbxTypeUpdate.TabIndex = 7;
            // 
            // tbxFilmNameUpdate
            // 
            this.tbxFilmNameUpdate.Location = new System.Drawing.Point(94, 22);
            this.tbxFilmNameUpdate.Name = "tbxFilmNameUpdate";
            this.tbxFilmNameUpdate.Size = new System.Drawing.Size(180, 20);
            this.tbxFilmNameUpdate.TabIndex = 5;
            // 
            // lblPublishDateUpdate
            // 
            this.lblPublishDateUpdate.AutoSize = true;
            this.lblPublishDateUpdate.Location = new System.Drawing.Point(12, 105);
            this.lblPublishDateUpdate.Name = "lblPublishDateUpdate";
            this.lblPublishDateUpdate.Size = new System.Drawing.Size(54, 13);
            this.lblPublishDateUpdate.TabIndex = 2;
            this.lblPublishDateUpdate.Text = "Çıkış tarihi";
            // 
            // lblFilmTypeUpdate
            // 
            this.lblFilmTypeUpdate.AutoSize = true;
            this.lblFilmTypeUpdate.Location = new System.Drawing.Point(12, 64);
            this.lblFilmTypeUpdate.Name = "lblFilmTypeUpdate";
            this.lblFilmTypeUpdate.Size = new System.Drawing.Size(24, 13);
            this.lblFilmTypeUpdate.TabIndex = 1;
            this.lblFilmTypeUpdate.Text = "Tipi";
            // 
            // lblFilmNameUpdate
            // 
            this.lblFilmNameUpdate.AutoSize = true;
            this.lblFilmNameUpdate.Location = new System.Drawing.Point(12, 25);
            this.lblFilmNameUpdate.Name = "lblFilmNameUpdate";
            this.lblFilmNameUpdate.Size = new System.Drawing.Size(43, 13);
            this.lblFilmNameUpdate.TabIndex = 0;
            this.lblFilmNameUpdate.Text = "Film Adı";
            // 
            // gbxFilmAdd
            // 
            this.gbxFilmAdd.Controls.Add(this.dtpPublishDate);
            this.gbxFilmAdd.Controls.Add(this.btnAdd);
            this.gbxFilmAdd.Controls.Add(this.tbxType);
            this.gbxFilmAdd.Controls.Add(this.tbxFilmName);
            this.gbxFilmAdd.Controls.Add(this.lblPublishDate);
            this.gbxFilmAdd.Controls.Add(this.lblFilmType);
            this.gbxFilmAdd.Controls.Add(this.lblFilmName);
            this.gbxFilmAdd.Location = new System.Drawing.Point(27, 187);
            this.gbxFilmAdd.Name = "gbxFilmAdd";
            this.gbxFilmAdd.Size = new System.Drawing.Size(604, 145);
            this.gbxFilmAdd.TabIndex = 7;
            this.gbxFilmAdd.TabStop = false;
            this.gbxFilmAdd.Text = "Yeni film ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(366, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 26);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(94, 57);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(180, 20);
            this.tbxType.TabIndex = 7;
            // 
            // tbxFilmName
            // 
            this.tbxFilmName.Location = new System.Drawing.Point(94, 22);
            this.tbxFilmName.Name = "tbxFilmName";
            this.tbxFilmName.Size = new System.Drawing.Size(180, 20);
            this.tbxFilmName.TabIndex = 5;
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Location = new System.Drawing.Point(12, 105);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(54, 13);
            this.lblPublishDate.TabIndex = 2;
            this.lblPublishDate.Text = "Çıkış tarihi";
            // 
            // lblFilmType
            // 
            this.lblFilmType.AutoSize = true;
            this.lblFilmType.Location = new System.Drawing.Point(12, 64);
            this.lblFilmType.Name = "lblFilmType";
            this.lblFilmType.Size = new System.Drawing.Size(24, 13);
            this.lblFilmType.TabIndex = 1;
            this.lblFilmType.Text = "Tipi";
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.Location = new System.Drawing.Point(12, 25);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(43, 13);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.Text = "Film Adı";
            // 
            // dgwFilm
            // 
            this.dgwFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFilm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwFilm.Location = new System.Drawing.Point(0, 0);
            this.dgwFilm.Name = "dgwFilm";
            this.dgwFilm.Size = new System.Drawing.Size(654, 145);
            this.dgwFilm.TabIndex = 6;
            this.dgwFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFilm_CellClick);
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(94, 99);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(180, 20);
            this.dtpPublishDate.TabIndex = 12;
            // 
            // dtpPublishDateUpdate
            // 
            this.dtpPublishDateUpdate.Location = new System.Drawing.Point(94, 98);
            this.dtpPublishDateUpdate.Name = "dtpPublishDateUpdate";
            this.dtpPublishDateUpdate.Size = new System.Drawing.Size(180, 20);
            this.dtpPublishDateUpdate.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 505);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxFilmUpdate);
            this.Controls.Add(this.gbxFilmAdd);
            this.Controls.Add(this.dgwFilm);
            this.Name = "Form1";
            this.Text = "Filmler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxFilmUpdate.ResumeLayout(false);
            this.gbxFilmUpdate.PerformLayout();
            this.gbxFilmAdd.ResumeLayout(false);
            this.gbxFilmAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxFilmUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxTypeUpdate;
        private System.Windows.Forms.TextBox tbxFilmNameUpdate;
        private System.Windows.Forms.Label lblPublishDateUpdate;
        private System.Windows.Forms.Label lblFilmTypeUpdate;
        private System.Windows.Forms.Label lblFilmNameUpdate;
        private System.Windows.Forms.GroupBox gbxFilmAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.TextBox tbxFilmName;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.Label lblFilmType;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.DataGridView dgwFilm;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.DateTimePicker dtpPublishDateUpdate;
    }
}

