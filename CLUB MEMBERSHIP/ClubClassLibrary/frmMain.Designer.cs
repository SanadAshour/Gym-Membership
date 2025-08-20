namespace ClubUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            arabicToolStripMenuItem = new ToolStripMenuItem();
            inQuiriesToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            ViewMembershipTypes = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            PayementBtn = new Button();
            MembershipsBtn = new Button();
            MemberBtn = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem, settingsToolStripMenuItem, inQuiriesToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { languageToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, arabicToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(157, 26);
            languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(139, 26);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // arabicToolStripMenuItem
            // 
            arabicToolStripMenuItem.Name = "arabicToolStripMenuItem";
            arabicToolStripMenuItem.Size = new Size(139, 26);
            arabicToolStripMenuItem.Text = "Arabic";
            arabicToolStripMenuItem.Click += arabicToolStripMenuItem_Click;
            // 
            // inQuiriesToolStripMenuItem
            // 
            inQuiriesToolStripMenuItem.Name = "inQuiriesToolStripMenuItem";
            inQuiriesToolStripMenuItem.Size = new Size(81, 24);
            inQuiriesToolStripMenuItem.Text = "InQuiries";
            inQuiriesToolStripMenuItem.Click += inQuiriesToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(58, 24);
            usersToolStripMenuItem.Text = "Users";
            // 
            // ViewMembershipTypes
            // 
            ViewMembershipTypes.BackColor = SystemColors.ButtonHighlight;
            ViewMembershipTypes.Dock = DockStyle.Fill;
            ViewMembershipTypes.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            ViewMembershipTypes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ViewMembershipTypes.Image = (Image)resources.GetObject("ViewMembershipTypes.Image");
            ViewMembershipTypes.ImageAlign = ContentAlignment.BottomCenter;
            ViewMembershipTypes.Location = new Point(12, 12);
            ViewMembershipTypes.Margin = new Padding(12);
            ViewMembershipTypes.Name = "ViewMembershipTypes";
            ViewMembershipTypes.Size = new Size(364, 125);
            ViewMembershipTypes.TabIndex = 1;
            ViewMembershipTypes.Text = "Membership Types";
            ViewMembershipTypes.TextImageRelation = TextImageRelation.ImageAboveText;
            ViewMembershipTypes.UseVisualStyleBackColor = false;
            ViewMembershipTypes.Click += ViewMembershipTypes_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 298);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(PayementBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(MembershipsBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(ViewMembershipTypes, 0, 0);
            tableLayoutPanel1.Controls.Add(MemberBtn, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(776, 298);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // PayementBtn
            // 
            PayementBtn.Dock = DockStyle.Fill;
            PayementBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PayementBtn.Image = (Image)resources.GetObject("PayementBtn.Image");
            PayementBtn.Location = new Point(400, 161);
            PayementBtn.Margin = new Padding(12);
            PayementBtn.Name = "PayementBtn";
            PayementBtn.Size = new Size(364, 125);
            PayementBtn.TabIndex = 4;
            PayementBtn.Text = "Payments";
            PayementBtn.TextAlign = ContentAlignment.BottomCenter;
            PayementBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            PayementBtn.UseVisualStyleBackColor = true;
            PayementBtn.Click += PayementBtn_Click;
            // 
            // MembershipsBtn
            // 
            MembershipsBtn.Dock = DockStyle.Fill;
            MembershipsBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            MembershipsBtn.Image = (Image)resources.GetObject("MembershipsBtn.Image");
            MembershipsBtn.Location = new Point(12, 161);
            MembershipsBtn.Margin = new Padding(12);
            MembershipsBtn.Name = "MembershipsBtn";
            MembershipsBtn.Size = new Size(364, 125);
            MembershipsBtn.TabIndex = 3;
            MembershipsBtn.Text = "Memberships";
            MembershipsBtn.TextAlign = ContentAlignment.BottomCenter;
            MembershipsBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            MembershipsBtn.UseVisualStyleBackColor = true;
            MembershipsBtn.Click += MembershipsBtn_Click;
            // 
            // MemberBtn
            // 
            MemberBtn.Dock = DockStyle.Fill;
            MemberBtn.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            MemberBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            MemberBtn.Image = (Image)resources.GetObject("MemberBtn.Image");
            MemberBtn.Location = new Point(400, 12);
            MemberBtn.Margin = new Padding(12);
            MemberBtn.Name = "MemberBtn";
            MemberBtn.Size = new Size(364, 125);
            MemberBtn.TabIndex = 2;
            MemberBtn.Text = "Members";
            MemberBtn.TextAlign = ContentAlignment.BottomCenter;
            MemberBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            MemberBtn.UseVisualStyleBackColor = true;
            MemberBtn.Click += MemberBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(152, 28);
            label1.Name = "label1";
            label1.Size = new Size(498, 35);
            label1.TabIndex = 3;
            label1.Text = "GYM MEMBERSHIP MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym Membership";
            WindowState = FormWindowState.Minimized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button ViewMembershipTypes;
        private Panel panel1;
        private Label label1;
        private Button MemberBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button PayementBtn;
        private Button MembershipsBtn;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem arabicToolStripMenuItem;
        private ToolStripMenuItem inQuiriesToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
    }
}
