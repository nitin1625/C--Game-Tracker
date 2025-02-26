namespace TrackerUI
{
    partial class CreateTournamentForm
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
            label1 = new Label();
            tournamentNameLabel = new Label();
            tournamentNameValue = new TextBox();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamLabel = new Label();
            selectTeamDropDown = new ComboBox();
            createnewTeamLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(317, 50);
            label1.TabIndex = 1;
            label1.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Microsoft Sans Serif", 16F);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(23, 126);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(193, 26);
            tournamentNameLabel.TabIndex = 2;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(23, 168);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(287, 35);
            tournamentNameValue.TabIndex = 9;
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(159, 266);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(100, 35);
            entryFeeValue.TabIndex = 11;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(28, 263);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(125, 37);
            entryFeeLabel.TabIndex = 10;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(27, 350);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(156, 37);
            selectTeamLabel.TabIndex = 12;
            selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(27, 406);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(232, 38);
            selectTeamDropDown.TabIndex = 13;
            // 
            // createnewTeamLink
            // 
            createnewTeamLink.AutoSize = true;
            createnewTeamLink.Location = new Point(189, 357);
            createnewTeamLink.Name = "createnewTeamLink";
            createnewTeamLink.Size = new Size(118, 30);
            createnewTeamLink.TabIndex = 14;
            createnewTeamLink.TabStop = true;
            createnewTeamLink.Text = "create New";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1371, 749);
            Controls.Add(createnewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private Label selectTeamLabel;
        private ComboBox selectTeamDropDown;
        private LinkLabel createnewTeamLink;
    }
}