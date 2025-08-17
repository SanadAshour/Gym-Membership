namespace ClubUI
{
    partial class frmMemberships
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
            MemberCB = new ComboBox();
            MembershipTypeCB = new ComboBox();
            MemberLabel = new Label();
            MembershipTypeLabel = new Label();
            clearBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            DGV = new DataGridView();
            StartDatePicker = new DateTimePicker();
            EndDatePicker = new DateTimePicker();
            StartDateLabel = new Label();
            EndDateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // MemberCB
            // 
            MemberCB.DropDownStyle = ComboBoxStyle.DropDownList;
            MemberCB.FormattingEnabled = true;
            MemberCB.Location = new Point(183, 51);
            MemberCB.Name = "MemberCB";
            MemberCB.Size = new Size(151, 28);
            MemberCB.TabIndex = 0;
            // 
            // MembershipTypeCB
            // 
            MembershipTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            MembershipTypeCB.FormattingEnabled = true;
            MembershipTypeCB.Location = new Point(183, 95);
            MembershipTypeCB.Name = "MembershipTypeCB";
            MembershipTypeCB.Size = new Size(151, 28);
            MembershipTypeCB.TabIndex = 1;
            // 
            // MemberLabel
            // 
            MemberLabel.AutoSize = true;
            MemberLabel.Location = new Point(38, 54);
            MemberLabel.Name = "MemberLabel";
            MemberLabel.Size = new Size(68, 20);
            MemberLabel.TabIndex = 2;
            MemberLabel.Text = "Member:";
            // 
            // MembershipTypeLabel
            // 
            MembershipTypeLabel.AutoSize = true;
            MembershipTypeLabel.Location = new Point(38, 103);
            MembershipTypeLabel.Name = "MembershipTypeLabel";
            MembershipTypeLabel.Size = new Size(130, 20);
            MembershipTypeLabel.TabIndex = 3;
            MembershipTypeLabel.Text = "Membership Type:";
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(554, 149);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 43);
            clearBtn.TabIndex = 11;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(414, 149);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 43);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(273, 149);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 43);
            updateBtn.TabIndex = 9;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(143, 149);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 43);
            addBtn.TabIndex = 8;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.BackgroundColor = SystemColors.ControlLight;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(29, 221);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersWidth = 51;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(738, 200);
            DGV.TabIndex = 12;
            DGV.CellDoubleClick += DGV_CellDoubleClick;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Location = new Point(504, 51);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(250, 27);
            StartDatePicker.TabIndex = 13;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Location = new Point(504, 96);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(250, 27);
            EndDatePicker.TabIndex = 14;
            // 
            // StartDateLabel
            // 
            StartDateLabel.AutoSize = true;
            StartDateLabel.Location = new Point(398, 53);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new Size(79, 20);
            StartDateLabel.TabIndex = 15;
            StartDateLabel.Text = "Start Date:";
            // 
            // EndDateLabel
            // 
            EndDateLabel.AutoSize = true;
            EndDateLabel.Location = new Point(398, 101);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.Size = new Size(73, 20);
            EndDateLabel.TabIndex = 16;
            EndDateLabel.Text = "End Date:";
            // 
            // frmMemberships
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EndDateLabel);
            Controls.Add(StartDateLabel);
            Controls.Add(EndDatePicker);
            Controls.Add(StartDatePicker);
            Controls.Add(DGV);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(MembershipTypeLabel);
            Controls.Add(MemberLabel);
            Controls.Add(MembershipTypeCB);
            Controls.Add(MemberCB);
            Name = "frmMemberships";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memberships";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox MemberCB;
        private ComboBox MembershipTypeCB;
        private Label MemberLabel;
        private Label MembershipTypeLabel;
        private Button clearBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private DataGridView DGV;
        private DateTimePicker StartDatePicker;
        private DateTimePicker EndDatePicker;
        private Label StartDateLabel;
        private Label EndDateLabel;
    }
}
