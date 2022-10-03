namespace WinFormUI
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(978, 246);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnContact);
            this.groupBox.Controls.Add(this.btnExcel);
            this.groupBox.Controls.Add(this.btnRemove);
            this.groupBox.Controls.Add(this.btnUpdate);
            this.groupBox.Controls.Add(this.btnAdd);
            this.groupBox.Controls.Add(this.cmbCompany);
            this.groupBox.Controls.Add(this.cmbCategory);
            this.groupBox.Controls.Add(this.tbxSearch);
            this.groupBox.Controls.Add(this.tbxAmount);
            this.groupBox.Controls.Add(this.tbxUnitPrice);
            this.groupBox.Controls.Add(this.tbxName);
            this.groupBox.Controls.Add(this.lblSearch);
            this.groupBox.Controls.Add(this.lblAmount);
            this.groupBox.Controls.Add(this.lblPrice);
            this.groupBox.Controls.Add(this.lblCompany);
            this.groupBox.Controls.Add(this.lblName);
            this.groupBox.Controls.Add(this.lblCategory);
            this.groupBox.Location = new System.Drawing.Point(12, 273);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(978, 257);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ürün Ekleme,Silme ve Güncelleme";
            // 
            // btnContact
            // 
            this.btnContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContact.Location = new System.Drawing.Point(607, 180);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(179, 67);
            this.btnContact.TabIndex = 16;
            this.btnContact.Text = "Developer İletişim Bilgileri";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.Location = new System.Drawing.Point(607, 86);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(179, 65);
            this.btnExcel.TabIndex = 15;
            this.btnExcel.Text = "Verileri Excel\'de Görüntüle";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(357, 191);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(153, 56);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Ürün Silme";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(357, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 60);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Ürün Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(357, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 60);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Ürün Ekleme";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(172, 122);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(133, 24);
            this.cmbCompany.TabIndex = 11;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(172, 43);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(133, 24);
            this.cmbCategory.TabIndex = 10;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(740, 33);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(198, 22);
            this.tbxSearch.TabIndex = 9;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(172, 212);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(133, 22);
            this.tbxAmount.TabIndex = 8;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(172, 167);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(133, 22);
            this.tbxUnitPrice.TabIndex = 7;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(172, 86);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(133, 22);
            this.tbxName.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.Location = new System.Drawing.Point(648, 33);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 20);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Arama";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.Location = new System.Drawing.Point(27, 214);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(59, 20);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Miktarı";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(27, 167);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Fiyatı";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompany.Location = new System.Drawing.Point(27, 122);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(130, 20);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "Gönderen Firma";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(27, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ürün ismi";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(27, 43);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 542);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
    }
}

