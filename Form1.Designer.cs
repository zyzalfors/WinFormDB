
namespace EmployeeOrder
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.empIDLabel = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.salaryText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.empNameLabel = new System.Windows.Forms.Label();
            this.empSalaryLabel = new System.Windows.Forms.Label();
            this.empCityLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.tableGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // empIDLabel
            // 
            this.empIDLabel.AutoSize = true;
            this.empIDLabel.Location = new System.Drawing.Point(21, 28);
            this.empIDLabel.Name = "empIDLabel";
            this.empIDLabel.Size = new System.Drawing.Size(91, 17);
            this.empIDLabel.TabIndex = 0;
            this.empIDLabel.Text = "Employee ID:";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(140, 25);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(204, 22);
            this.IDText.TabIndex = 1;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(140, 62);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(204, 22);
            this.nameText.TabIndex = 2;
            // 
            // salaryText
            // 
            this.salaryText.Location = new System.Drawing.Point(140, 103);
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(204, 22);
            this.salaryText.TabIndex = 3;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(140, 147);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(204, 22);
            this.cityText.TabIndex = 4;
            // 
            // empNameLabel
            // 
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Location = new System.Drawing.Point(21, 65);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.Size = new System.Drawing.Size(115, 17);
            this.empNameLabel.TabIndex = 5;
            this.empNameLabel.Text = "Employee Name:";
            // 
            // empSalaryLabel
            // 
            this.empSalaryLabel.AutoSize = true;
            this.empSalaryLabel.Location = new System.Drawing.Point(21, 106);
            this.empSalaryLabel.Name = "empSalaryLabel";
            this.empSalaryLabel.Size = new System.Drawing.Size(118, 17);
            this.empSalaryLabel.TabIndex = 6;
            this.empSalaryLabel.Text = "Employee Salary:";
            // 
            // empCityLabel
            // 
            this.empCityLabel.AutoSize = true;
            this.empCityLabel.Location = new System.Drawing.Point(21, 150);
            this.empCityLabel.Name = "empCityLabel";
            this.empCityLabel.Size = new System.Drawing.Size(101, 17);
            this.empCityLabel.TabIndex = 7;
            this.empCityLabel.Text = "Employee City:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(19, 190);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 25);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(142, 190);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(117, 25);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.OnUpdateClick);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(388, 190);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(117, 25);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Load Orders";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.OnLoadOrders);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(265, 190);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 25);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.OnDeleteClick);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(388, 22);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(117, 25);
            this.findButton.TabIndex = 12;
            this.findButton.Text = "Find Employee";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.OnFindClick);
            // 
            // tableGrid
            // 
            this.tableGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tableGrid.AllowUserToAddRows = false;
            this.tableGrid.AllowUserToDeleteRows = false;
            this.tableGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGrid.Location = new System.Drawing.Point(12, 229);
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.ReadOnly = true;
            this.tableGrid.RowHeadersWidth = 51;
            this.tableGrid.RowTemplate.Height = 24;
            this.tableGrid.Size = new System.Drawing.Size(628, 271);
            this.tableGrid.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 512);
            this.Controls.Add(this.tableGrid);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.empCityLabel);
            this.Controls.Add(this.empSalaryLabel);
            this.Controls.Add(this.empNameLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.salaryText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.empIDLabel);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empIDLabel;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox salaryText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label empNameLabel;
        private System.Windows.Forms.Label empSalaryLabel;
        private System.Windows.Forms.Label empCityLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.DataGridView tableGrid;
    }
}

