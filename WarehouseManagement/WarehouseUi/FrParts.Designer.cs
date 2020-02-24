namespace WarehouseUi
{
    partial class FrParts
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
            this.dataGridParts = new System.Windows.Forms.DataGridView();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPartCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPartBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPartModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPartDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPartCategoryId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPartCategoryCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPartCategoryDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPartLocationId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPartLocationCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPartLocationDescription = new System.Windows.Forms.TextBox();
            this.cbParts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridParts
            // 
            this.dataGridParts.AllowUserToAddRows = false;
            this.dataGridParts.AllowUserToDeleteRows = false;
            this.dataGridParts.AllowUserToResizeRows = false;
            this.dataGridParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParts.Location = new System.Drawing.Point(377, 56);
            this.dataGridParts.MultiSelect = false;
            this.dataGridParts.Name = "dataGridParts";
            this.dataGridParts.ReadOnly = true;
            this.dataGridParts.RowHeadersWidth = 62;
            this.dataGridParts.RowTemplate.Height = 28;
            this.dataGridParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParts.Size = new System.Drawing.Size(878, 578);
            this.dataGridParts.TabIndex = 0;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPart.Location = new System.Drawing.Point(28, 573);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(324, 67);
            this.btnAddPart.TabIndex = 1;
            this.btnAddPart.Text = "ADD PART >>";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(130, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "PART";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(77, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "PART CATEGORY";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(77, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "PART LOCATION";
            // 
            // tbPartCode
            // 
            this.tbPartCode.Location = new System.Drawing.Point(124, 56);
            this.tbPartCode.Name = "tbPartCode";
            this.tbPartCode.Size = new System.Drawing.Size(228, 26);
            this.tbPartCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brand";
            // 
            // tbPartBrand
            // 
            this.tbPartBrand.Location = new System.Drawing.Point(124, 88);
            this.tbPartBrand.Name = "tbPartBrand";
            this.tbPartBrand.Size = new System.Drawing.Size(228, 26);
            this.tbPartBrand.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // tbPartModel
            // 
            this.tbPartModel.Location = new System.Drawing.Point(124, 120);
            this.tbPartModel.Name = "tbPartModel";
            this.tbPartModel.Size = new System.Drawing.Size(228, 26);
            this.tbPartModel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // tbPartDescription
            // 
            this.tbPartDescription.Location = new System.Drawing.Point(124, 152);
            this.tbPartDescription.Name = "tbPartDescription";
            this.tbPartDescription.Size = new System.Drawing.Size(228, 26);
            this.tbPartDescription.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id";
            // 
            // tbPartCategoryId
            // 
            this.tbPartCategoryId.Location = new System.Drawing.Point(124, 259);
            this.tbPartCategoryId.Name = "tbPartCategoryId";
            this.tbPartCategoryId.Size = new System.Drawing.Size(228, 26);
            this.tbPartCategoryId.TabIndex = 3;
            this.tbPartCategoryId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPartCategoryId_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Code";
            // 
            // tbPartCategoryCode
            // 
            this.tbPartCategoryCode.Location = new System.Drawing.Point(124, 291);
            this.tbPartCategoryCode.Name = "tbPartCategoryCode";
            this.tbPartCategoryCode.Size = new System.Drawing.Size(228, 26);
            this.tbPartCategoryCode.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Description";
            // 
            // tbPartCategoryDescription
            // 
            this.tbPartCategoryDescription.Location = new System.Drawing.Point(124, 323);
            this.tbPartCategoryDescription.Name = "tbPartCategoryDescription";
            this.tbPartCategoryDescription.Size = new System.Drawing.Size(228, 26);
            this.tbPartCategoryDescription.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Id";
            // 
            // tbPartLocationId
            // 
            this.tbPartLocationId.Location = new System.Drawing.Point(124, 433);
            this.tbPartLocationId.Name = "tbPartLocationId";
            this.tbPartLocationId.Size = new System.Drawing.Size(228, 26);
            this.tbPartLocationId.TabIndex = 3;
            this.tbPartLocationId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPartLocationId_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Code";
            // 
            // tbPartLocationCode
            // 
            this.tbPartLocationCode.Location = new System.Drawing.Point(124, 465);
            this.tbPartLocationCode.Name = "tbPartLocationCode";
            this.tbPartLocationCode.Size = new System.Drawing.Size(228, 26);
            this.tbPartLocationCode.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Description";
            // 
            // tbPartLocationDescription
            // 
            this.tbPartLocationDescription.Location = new System.Drawing.Point(124, 497);
            this.tbPartLocationDescription.Name = "tbPartLocationDescription";
            this.tbPartLocationDescription.Size = new System.Drawing.Size(228, 26);
            this.tbPartLocationDescription.TabIndex = 3;
            // 
            // cbParts
            // 
            this.cbParts.FormattingEnabled = true;
            this.cbParts.Items.AddRange(new object[] {
            "All Parts",
            "Available Parts",
            "Reserved Parts"});
            this.cbParts.Location = new System.Drawing.Point(377, 22);
            this.cbParts.Name = "cbParts";
            this.cbParts.Size = new System.Drawing.Size(195, 28);
            this.cbParts.TabIndex = 4;
            this.cbParts.Text = "All Parts";
            this.cbParts.SelectedIndexChanged += new System.EventHandler(this.cbParts_SelectedIndexChanged);
            // 
            // FrParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 664);
            this.Controls.Add(this.cbParts);
            this.Controls.Add(this.tbPartLocationDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPartLocationCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPartLocationId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPartCategoryDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPartCategoryCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPartCategoryId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPartDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPartModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPartBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPartCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.dataGridParts);
            this.MinimumSize = new System.Drawing.Size(1300, 720);
            this.Name = "FrParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridParts;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPartCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPartBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPartModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPartDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPartCategoryId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPartCategoryCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPartCategoryDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPartLocationId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPartLocationCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPartLocationDescription;
        private System.Windows.Forms.ComboBox cbParts;
    }
}