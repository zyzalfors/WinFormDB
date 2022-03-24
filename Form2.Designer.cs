
namespace EmployeeOrder
{
    partial class OrdersForm
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
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersGrid
            // 
            this.ordersGrid.AllowUserToAddRows = false;
            this.ordersGrid.AllowUserToDeleteRows = false;
            this.ordersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Location = new System.Drawing.Point(0, 0);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.ReadOnly = true;
            this.ordersGrid.RowHeadersWidth = 51;
            this.ordersGrid.RowTemplate.Height = 24;
            this.ordersGrid.Size = new System.Drawing.Size(467, 195);
            this.ordersGrid.TabIndex = 0;
            // 
            // saveDialog
            // 
            this.saveDialog.CheckPathExists = false;
            this.saveDialog.Filter = "\"File CSV|*.csv|Tutti i file|*.*\"";
            this.saveDialog.Title = "Save as CSV";
            // 
            // saveCSV
            // 
            this.saveCSV.Location = new System.Drawing.Point(509, 12);
            this.saveCSV.Name = "saveCSV";
            this.saveCSV.Size = new System.Drawing.Size(106, 23);
            this.saveCSV.TabIndex = 1;
            this.saveCSV.Text = "Save as CSV";
            this.saveCSV.UseVisualStyleBackColor = true;
            this.saveCSV.Click += new System.EventHandler(this.OnSaveOrders);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 319);
            this.Controls.Add(this.saveCSV);
            this.Controls.Add(this.ordersGrid);
            this.Name = "OrdersForm";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OnLoadOrdersForm);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.Button saveCSV;
    }
}