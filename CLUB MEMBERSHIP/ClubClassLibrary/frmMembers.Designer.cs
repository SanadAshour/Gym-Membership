namespace ClubUI
{
    partial class frmMembers
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
            clearBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            MbAddressTB = new TextBox();
            MbPhoneNumberTB = new TextBox();
            MbNameTB = new TextBox();
            DGV = new DataGridView();
            dobLabel = new Label();
            jobLabel = new Label();
            dobDT = new DateTimePicker();
            jobDT = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(534, 169);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 43);
            clearBtn.TabIndex = 15;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(394, 169);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 43);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(253, 169);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 43);
            updateBtn.TabIndex = 13;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(123, 169);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 43);
            addBtn.TabIndex = 12;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // MbAddressTB
            // 
            MbAddressTB.Location = new Point(31, 120);
            MbAddressTB.Name = "MbAddressTB";
            MbAddressTB.PlaceholderText = "Address";
            MbAddressTB.Size = new Size(173, 27);
            MbAddressTB.TabIndex = 11;
            // 
            // MbPhoneNumberTB
            // 
            MbPhoneNumberTB.Location = new Point(31, 74);
            MbPhoneNumberTB.Name = "MbPhoneNumberTB";
            MbPhoneNumberTB.PlaceholderText = "Phone Number";
            MbPhoneNumberTB.Size = new Size(173, 27);
            MbPhoneNumberTB.TabIndex = 10;
            // 
            // MbNameTB
            // 
            MbNameTB.Location = new Point(31, 26);
            MbNameTB.Name = "MbNameTB";
            MbNameTB.PlaceholderText = "Name";
            MbNameTB.Size = new Size(173, 27);
            MbNameTB.TabIndex = 9;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.BackgroundColor = SystemColors.ControlLight;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(31, 225);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersWidth = 51;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(738, 200);
            DGV.TabIndex = 8;
            DGV.CellDoubleClick += DGV_CellDoubleClick;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(321, 59);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(99, 20);
            dobLabel.TabIndex = 16;
            dobLabel.Text = "Date Of Birth:";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new Point(321, 100);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new Size(74, 20);
            jobLabel.TabIndex = 17;
            jobLabel.Text = "Join Date:";
            // 
            // dobDT
            // 
            dobDT.Location = new Point(457, 52);
            dobDT.Name = "dobDT";
            dobDT.Size = new Size(250, 27);
            dobDT.TabIndex = 18;
            // 
            // jobDT
            // 
            jobDT.Location = new Point(457, 95);
            jobDT.Name = "jobDT";
            jobDT.Size = new Size(250, 27);
            jobDT.TabIndex = 19;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(jobDT);
            Controls.Add(dobDT);
            Controls.Add(jobLabel);
            Controls.Add(dobLabel);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(MbAddressTB);
            Controls.Add(MbPhoneNumberTB);
            Controls.Add(MbNameTB);
            Controls.Add(DGV);
            Name = "frmMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Members";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clearBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private TextBox MbAddressTB;
        private TextBox MbPhoneNumberTB;
        private TextBox MbNameTB;
        private DataGridView DGV;
        private Label dobLabel;
        private Label jobLabel;
        private DateTimePicker dobDT;
        private DateTimePicker jobDT;
    }
}
