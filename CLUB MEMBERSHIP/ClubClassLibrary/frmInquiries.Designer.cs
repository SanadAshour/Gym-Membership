namespace ClubUI
{
    partial class frmInquiries
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
            Showbtn = new Button();
            Printbtn = new Button();
            MembersRB = new RadioButton();
            MembershipsRB = new RadioButton();
            PaymentsRB = new RadioButton();
            label1 = new Label();
            FromDT = new DateTimePicker();
            label2 = new Label();
            ToDT = new DateTimePicker();
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
            DGV.Location = new Point(27, 187);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersWidth = 51;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(738, 200);
            DGV.TabIndex = 1;
            // 
            // Showbtn
            // 
            Showbtn.Location = new Point(671, 152);
            Showbtn.Name = "Showbtn";
            Showbtn.Size = new Size(94, 29);
            Showbtn.TabIndex = 2;
            Showbtn.Text = "SHOW";
            Showbtn.UseVisualStyleBackColor = true;
            Showbtn.Click += Showbtn_Click;
            // 
            // Printbtn
            // 
            Printbtn.Location = new Point(671, 393);
            Printbtn.Name = "Printbtn";
            Printbtn.Size = new Size(94, 29);
            Printbtn.TabIndex = 3;
            Printbtn.Text = "PRINT";
            Printbtn.UseVisualStyleBackColor = true;
            Printbtn.Click += Printbtn_Click;
            // 
            // MembersRB
            // 
            MembersRB.AutoSize = true;
            MembersRB.Location = new Point(27, 29);
            MembersRB.Name = "MembersRB";
            MembersRB.Size = new Size(92, 24);
            MembersRB.TabIndex = 4;
            MembersRB.TabStop = true;
            MembersRB.Text = "Members";
            MembersRB.UseVisualStyleBackColor = true;
            // 
            // MembershipsRB
            // 
            MembershipsRB.AutoSize = true;
            MembershipsRB.Location = new Point(27, 70);
            MembershipsRB.Name = "MembershipsRB";
            MembershipsRB.Size = new Size(119, 24);
            MembershipsRB.TabIndex = 5;
            MembershipsRB.TabStop = true;
            MembershipsRB.Text = "Memberships";
            MembershipsRB.UseVisualStyleBackColor = true;
            // 
            // PaymentsRB
            // 
            PaymentsRB.AutoSize = true;
            PaymentsRB.Location = new Point(27, 110);
            PaymentsRB.Name = "PaymentsRB";
            PaymentsRB.Size = new Size(92, 24);
            PaymentsRB.TabIndex = 6;
            PaymentsRB.TabStop = true;
            PaymentsRB.Text = "Payments";
            PaymentsRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 31);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "From:";
            // 
            // FromDT
            // 
            FromDT.Location = new Point(213, 26);
            FromDT.Name = "FromDT";
            FromDT.Size = new Size(250, 27);
            FromDT.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 31);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 9;
            label2.Text = "To:";
            // 
            // ToDT
            // 
            ToDT.Location = new Point(525, 26);
            ToDT.Name = "ToDT";
            ToDT.Size = new Size(250, 27);
            ToDT.TabIndex = 10;
            // 
            // frmInquiries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToDT);
            Controls.Add(label2);
            Controls.Add(FromDT);
            Controls.Add(label1);
            Controls.Add(PaymentsRB);
            Controls.Add(MembershipsRB);
            Controls.Add(MembersRB);
            Controls.Add(Printbtn);
            Controls.Add(Showbtn);
            Controls.Add(DGV);
            Name = "frmInquiries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inquiries";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private Button Showbtn;
        private Button Printbtn;
        private RadioButton MembersRB;
        private RadioButton MembershipsRB;
        private RadioButton PaymentsRB;
        private Label label1;
        private DateTimePicker FromDT;
        private Label label2;
        private DateTimePicker ToDT;
    }
}