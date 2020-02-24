namespace WarehouseUi
{
    partial class FrOrderOpen
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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartsInOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPartsInOrder
            // 
            this.dataGridPartsInOrder.AllowUserToAddRows = false;
            this.dataGridPartsInOrder.AllowUserToDeleteRows = false;
            this.dataGridPartsInOrder.AllowUserToResizeColumns = false;
            this.dataGridPartsInOrder.AllowUserToResizeRows = false;
            this.dataGridPartsInOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPartsInOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPartsInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPartsInOrder.Location = new System.Drawing.Point(30, 60);
            this.dataGridPartsInOrder.Name = "dataGridPartsInOrder";
            this.dataGridPartsInOrder.ReadOnly = true;
            this.dataGridPartsInOrder.RowHeadersWidth = 62;
            this.dataGridPartsInOrder.RowTemplate.Height = 28;
            this.dataGridPartsInOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPartsInOrder.Size = new System.Drawing.Size(820, 515);
            this.dataGridPartsInOrder.TabIndex = 0;
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
            // FrOrderOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 624);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridPartsInOrder);
            this.MinimumSize = new System.Drawing.Size(900, 680);
            this.Name = "FrOrderOpen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FrOrderEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartsInOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridPartsInOrder;
        private System.Windows.Forms.Label label2;
    }
}