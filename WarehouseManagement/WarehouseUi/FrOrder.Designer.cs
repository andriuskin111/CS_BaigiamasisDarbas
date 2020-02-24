namespace WarehouseUi
{
    partial class FrOrder
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
            this.dataGridPartsInOrder = new System.Windows.Forms.DataGridView();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnCloseOrder = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.dataGridAvalaibleParts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartsInOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvalaibleParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPartsInOrder
            // 
            this.dataGridPartsInOrder.AllowUserToAddRows = false;
            this.dataGridPartsInOrder.AllowUserToDeleteRows = false;
            this.dataGridPartsInOrder.AllowUserToResizeColumns = false;
            this.dataGridPartsInOrder.AllowUserToResizeRows = false;
            this.dataGridPartsInOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridPartsInOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPartsInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPartsInOrder.Location = new System.Drawing.Point(30, 60);
            this.dataGridPartsInOrder.Name = "dataGridPartsInOrder";
            this.dataGridPartsInOrder.ReadOnly = true;
            this.dataGridPartsInOrder.RowHeadersWidth = 62;
            this.dataGridPartsInOrder.RowTemplate.Height = 28;
            this.dataGridPartsInOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPartsInOrder.Size = new System.Drawing.Size(800, 850);
            this.dataGridPartsInOrder.TabIndex = 0;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(1591, 934);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(207, 53);
            this.btnDeleteOrder.TabIndex = 1;
            this.btnDeleteOrder.Text = "DELETE ORDER";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCloseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseOrder.Location = new System.Drawing.Point(1161, 934);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(208, 53);
            this.btnCloseOrder.TabIndex = 1;
            this.btnCloseOrder.Text = "CLOSE ORDER";
            this.btnCloseOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPart.Location = new System.Drawing.Point(854, 604);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(195, 53);
            this.btnAddPart.TabIndex = 1;
            this.btnAddPart.Text = "<< ADD PART";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemovePart.Location = new System.Drawing.Point(854, 724);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(195, 53);
            this.btnRemovePart.TabIndex = 1;
            this.btnRemovePart.Text = ">> REMOVE PART";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1067, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "AVAILABLE PARTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PARTS IN ORDER ID: CUSTOMER:";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(170, 959);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(184, 28);
            this.cbCustomer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 936);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CUSTOMER";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateOrder.Location = new System.Drawing.Point(534, 934);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(208, 53);
            this.btnCreateOrder.TabIndex = 1;
            this.btnCreateOrder.Text = "CREATE ORDER";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridAvalaibleParts
            // 
            this.dataGridAvalaibleParts.AllowUserToAddRows = false;
            this.dataGridAvalaibleParts.AllowUserToDeleteRows = false;
            this.dataGridAvalaibleParts.AllowUserToResizeColumns = false;
            this.dataGridAvalaibleParts.AllowUserToResizeRows = false;
            this.dataGridAvalaibleParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAvalaibleParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAvalaibleParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAvalaibleParts.Location = new System.Drawing.Point(1071, 60);
            this.dataGridAvalaibleParts.Name = "dataGridAvalaibleParts";
            this.dataGridAvalaibleParts.ReadOnly = true;
            this.dataGridAvalaibleParts.RowHeadersWidth = 62;
            this.dataGridAvalaibleParts.RowTemplate.Height = 28;
            this.dataGridAvalaibleParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAvalaibleParts.Size = new System.Drawing.Size(800, 850);
            this.dataGridAvalaibleParts.TabIndex = 0;
            // 
            // FrOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemovePart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnCloseOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.dataGridAvalaibleParts);
            this.Controls.Add(this.dataGridPartsInOrder);
            this.MinimumSize = new System.Drawing.Size(1918, 1078);
            this.Name = "FrOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartsInOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvalaibleParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridPartsInOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnCloseOrder;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DataGridView dataGridAvalaibleParts;
    }
}