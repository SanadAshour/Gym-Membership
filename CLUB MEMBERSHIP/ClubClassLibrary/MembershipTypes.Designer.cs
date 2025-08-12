namespace ClubUI
{
    partial class frmMembershipTypes
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
            MstNameTB = new TextBox();
            MstDescriptionTB = new TextBox();
            MstBasePriceTB = new TextBox();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            clearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
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
            DGV.Location = new Point(30, 226);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersWidth = 51;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(738, 200);
            DGV.TabIndex = 0;
            DGV.CellDoubleClick += DGV_CellDoubleClick;
            // 
            // MstNameTB
            // 
            MstNameTB.Location = new Point(30, 27);
            MstNameTB.Name = "MstNameTB";
            MstNameTB.PlaceholderText = "Name";
            MstNameTB.Size = new Size(173, 27);
            MstNameTB.TabIndex = 1;
            // 
            // MstDescriptionTB
            // 
            MstDescriptionTB.Location = new Point(30, 75);
            MstDescriptionTB.Name = "MstDescriptionTB";
            MstDescriptionTB.PlaceholderText = "Description";
            MstDescriptionTB.Size = new Size(173, 27);
            MstDescriptionTB.TabIndex = 2;
            // 
            // MstBasePriceTB
            // 
            MstBasePriceTB.Location = new Point(30, 121);
            MstBasePriceTB.Name = "MstBasePriceTB";
            MstBasePriceTB.PlaceholderText = "Base Price";
            MstBasePriceTB.Size = new Size(173, 27);
            MstBasePriceTB.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(122, 170);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 43);
            addBtn.TabIndex = 4;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(252, 170);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 43);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(393, 170);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 43);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(533, 170);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 43);
            clearBtn.TabIndex = 7;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // frmMembershipTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(MstBasePriceTB);
            Controls.Add(MstDescriptionTB);
            Controls.Add(MstNameTB);
            Controls.Add(DGV);
            Name = "frmMembershipTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Membership Types";
            Load += MembershipTypes_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private TextBox MstNameTB;
        private TextBox MstDescriptionTB;
        private TextBox MstBasePriceTB;
        private Button addBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button clearBtn;
    }
}
