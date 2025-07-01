namespace Project5_DapperNorthwind
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
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnCategoryCreate = new System.Windows.Forms.Button();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSeafoodProductTotalprice = new System.Windows.Forms.Label();
            this.lblAvgProductStock = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.Location = new System.Drawing.Point(563, 28);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(212, 37);
            this.btnCategoryList.TabIndex = 0;
            this.btnCategoryList.Text = "Kategori Listesi";
            this.btnCategoryList.UseVisualStyleBackColor = true;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(763, 352);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(228, 66);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(311, 26);
            this.txtCategoryName.TabIndex = 2;
            // 
            // btnCategoryCreate
            // 
            this.btnCategoryCreate.Location = new System.Drawing.Point(563, 77);
            this.btnCategoryCreate.Name = "btnCategoryCreate";
            this.btnCategoryCreate.Size = new System.Drawing.Size(212, 38);
            this.btnCategoryCreate.TabIndex = 3;
            this.btnCategoryCreate.Text = "Kategori Ekle";
            this.btnCategoryCreate.UseVisualStyleBackColor = true;
            this.btnCategoryCreate.Click += new System.EventHandler(this.btnCategoryCreate_Click);
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(228, 101);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(311, 113);
            this.txtCategoryDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategori Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori Açıklaması:";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(228, 28);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(311, 26);
            this.txtCategoryId.TabIndex = 8;
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(563, 176);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(212, 38);
            this.btnCategoryUpdate.TabIndex = 10;
            this.btnCategoryUpdate.Text = "Kategori Güncelle";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(563, 128);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(212, 37);
            this.btnCategoryDelete.TabIndex = 9;
            this.btnCategoryDelete.Text = "Kategori Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryCount.Location = new System.Drawing.Point(6, 38);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(70, 26);
            this.lblCategoryCount.TabIndex = 11;
            this.lblCategoryCount.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblSeafoodProductTotalprice);
            this.groupBox1.Controls.Add(this.lblAvgProductStock);
            this.groupBox1.Controls.Add(this.lblProductCount);
            this.groupBox1.Controls.Add(this.lblCategoryCount);
            this.groupBox1.Location = new System.Drawing.Point(798, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 546);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dapper İstatistikler";
            // 
            // lblSeafoodProductTotalprice
            // 
            this.lblSeafoodProductTotalprice.AutoSize = true;
            this.lblSeafoodProductTotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeafoodProductTotalprice.Location = new System.Drawing.Point(6, 221);
            this.lblSeafoodProductTotalprice.Name = "lblSeafoodProductTotalprice";
            this.lblSeafoodProductTotalprice.Size = new System.Drawing.Size(70, 26);
            this.lblSeafoodProductTotalprice.TabIndex = 14;
            this.lblSeafoodProductTotalprice.Text = "label4";
            // 
            // lblAvgProductStock
            // 
            this.lblAvgProductStock.AutoSize = true;
            this.lblAvgProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAvgProductStock.Location = new System.Drawing.Point(6, 165);
            this.lblAvgProductStock.Name = "lblAvgProductStock";
            this.lblAvgProductStock.Size = new System.Drawing.Size(70, 26);
            this.lblAvgProductStock.TabIndex = 13;
            this.lblAvgProductStock.Text = "label4";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCount.Location = new System.Drawing.Point(6, 97);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(70, 26);
            this.lblProductCount.TabIndex = 12;
            this.lblProductCount.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCategoryUpdate);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.btnCategoryCreate);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCategoryList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnCategoryCreate;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSeafoodProductTotalprice;
        private System.Windows.Forms.Label lblAvgProductStock;
        private System.Windows.Forms.Label lblProductCount;
    }
}

