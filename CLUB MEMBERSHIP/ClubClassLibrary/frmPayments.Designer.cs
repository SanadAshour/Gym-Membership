namespace ClubUI
{
    partial class frmPayments
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
            DGV = new DataGridView();
            DGV2 = new DataGridView();
            PrintRecBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.BackgroundColor = SystemColors.ControlLight;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(28, 50);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersWidth = 51;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(738, 200);
            DGV.TabIndex = 13;
            DGV.CellDoubleClick += DGV_CellDoubleClick;
            // 
            // DGV2
            // 
            DGV2.AllowUserToAddRows = false;
            DGV2.AllowUserToDeleteRows = false;
            DGV2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV2.BackgroundColor = SystemColors.ControlLight;
            DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV2.Location = new Point(28, 283);
            DGV2.MultiSelect = false;
            DGV2.Name = "DGV2";
            DGV2.ReadOnly = true;
            DGV2.RowHeadersWidth = 51;
            DGV2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV2.Size = new Size(738, 58);
            DGV2.TabIndex = 14;
            // 
            // PrintRecBtn
            // 
            PrintRecBtn.Location = new Point(319, 371);
            PrintRecBtn.Name = "PrintRecBtn";
            PrintRecBtn.Size = new Size(158, 67);
            PrintRecBtn.TabIndex = 15;
            PrintRecBtn.Text = "PRINT RECEIPT";
            PrintRecBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(246, 20);
            label1.TabIndex = 16;
            label1.Text = "SELECT MEMBER TO ISSUE RECEIPT:";
            // 
            // frmPayments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(PrintRecBtn);
            Controls.Add(DGV2);
            Controls.Add(DGV);
            Name = "frmPayments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private DataGridView DGV2;
        private Button PrintRecBtn;
        private Label label1;
    }
}
