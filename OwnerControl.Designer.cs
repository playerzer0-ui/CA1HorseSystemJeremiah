namespace CA1HorseSystemJeremiah
{
    partial class OwnerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.horseNameTextBox = new System.Windows.Forms.TextBox();
            this.horsedoBTextBox = new System.Windows.Forms.DateTimePicker();
            this.addHorseToRaceButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.horseListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.raceListBox = new System.Windows.Forms.ListBox();
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "horse name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "date of birth";
            // 
            // horseNameTextBox
            // 
            this.horseNameTextBox.Location = new System.Drawing.Point(16, 375);
            this.horseNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.horseNameTextBox.Name = "horseNameTextBox";
            this.horseNameTextBox.Size = new System.Drawing.Size(204, 27);
            this.horseNameTextBox.TabIndex = 28;
            // 
            // horsedoBTextBox
            // 
            this.horsedoBTextBox.Location = new System.Drawing.Point(16, 476);
            this.horsedoBTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.horsedoBTextBox.Name = "horsedoBTextBox";
            this.horsedoBTextBox.Size = new System.Drawing.Size(271, 27);
            this.horsedoBTextBox.TabIndex = 29;
            // 
            // addHorseToRaceButton
            // 
            this.addHorseToRaceButton.Location = new System.Drawing.Point(16, 552);
            this.addHorseToRaceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addHorseToRaceButton.Name = "addHorseToRaceButton";
            this.addHorseToRaceButton.Size = new System.Drawing.Size(133, 48);
            this.addHorseToRaceButton.TabIndex = 30;
            this.addHorseToRaceButton.Text = "add horse to race";
            this.addHorseToRaceButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(760, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "HORSES";
            // 
            // horseListBox
            // 
            this.horseListBox.FormattingEnabled = true;
            this.horseListBox.HorizontalScrollbar = true;
            this.horseListBox.ItemHeight = 20;
            this.horseListBox.Location = new System.Drawing.Point(758, 36);
            this.horseListBox.Name = "horseListBox";
            this.horseListBox.ScrollAlwaysVisible = true;
            this.horseListBox.Size = new System.Drawing.Size(385, 284);
            this.horseListBox.TabIndex = 35;
            this.horseListBox.SelectedIndexChanged += new System.EventHandler(this.horseListBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "RACES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "EVENTS";
            // 
            // raceListBox
            // 
            this.raceListBox.FormattingEnabled = true;
            this.raceListBox.HorizontalScrollbar = true;
            this.raceListBox.ItemHeight = 20;
            this.raceListBox.Location = new System.Drawing.Point(382, 36);
            this.raceListBox.Name = "raceListBox";
            this.raceListBox.ScrollAlwaysVisible = true;
            this.raceListBox.Size = new System.Drawing.Size(369, 284);
            this.raceListBox.TabIndex = 32;
            this.raceListBox.SelectedIndexChanged += new System.EventHandler(this.raceListBox_SelectedIndexChanged);
            // 
            // eventListBox
            // 
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.HorizontalScrollbar = true;
            this.eventListBox.ItemHeight = 20;
            this.eventListBox.Location = new System.Drawing.Point(16, 36);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.ScrollAlwaysVisible = true;
            this.eventListBox.Size = new System.Drawing.Size(358, 284);
            this.eventListBox.TabIndex = 31;
            this.eventListBox.SelectedIndexChanged += new System.EventHandler(this.eventListBox_SelectedIndexChanged);
            // 
            // OwnerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.horseListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.raceListBox);
            this.Controls.Add(this.eventListBox);
            this.Controls.Add(this.addHorseToRaceButton);
            this.Controls.Add(this.horsedoBTextBox);
            this.Controls.Add(this.horseNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OwnerControl";
            this.Size = new System.Drawing.Size(1158, 648);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox horseNameTextBox;
        private DateTimePicker horsedoBTextBox;
        private Button addHorseToRaceButton;
        private Label label9;
        private ListBox horseListBox;
        private Label label8;
        private Label label7;
        private ListBox raceListBox;
        private ListBox eventListBox;
    }
}
