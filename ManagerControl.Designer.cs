namespace CA1HorseSystemJeremiah
{
    partial class ManagerControl
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
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.raceListBox = new System.Windows.Forms.ListBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.addRaceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.eventLocationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.raceNameTextBox = new System.Windows.Forms.TextBox();
            this.hoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.horseListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).BeginInit();
            this.SuspendLayout();
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
            this.eventListBox.TabIndex = 0;
            this.eventListBox.SelectedIndexChanged += new System.EventHandler(this.eventListBox_SelectedIndexChanged);
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
            this.raceListBox.TabIndex = 1;
            this.raceListBox.SelectedIndexChanged += new System.EventHandler(this.raceListBox_SelectedIndexChanged);
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(13, 532);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(141, 39);
            this.addEventButton.TabIndex = 2;
            this.addEventButton.Text = "add event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // addRaceButton
            // 
            this.addRaceButton.Location = new System.Drawing.Point(382, 532);
            this.addRaceButton.Name = "addRaceButton";
            this.addRaceButton.Size = new System.Drawing.Size(142, 39);
            this.addRaceButton.TabIndex = 3;
            this.addRaceButton.Text = "add race";
            this.addRaceButton.UseVisualStyleBackColor = true;
            this.addRaceButton.Click += new System.EventHandler(this.addRaceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "event name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "location";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(13, 376);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(203, 27);
            this.eventNameTextBox.TabIndex = 6;
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.eventNameTextBox_TextChanged);
            // 
            // eventLocationTextBox
            // 
            this.eventLocationTextBox.Location = new System.Drawing.Point(13, 461);
            this.eventLocationTextBox.Name = "eventLocationTextBox";
            this.eventLocationTextBox.Size = new System.Drawing.Size(203, 27);
            this.eventLocationTextBox.TabIndex = 7;
            this.eventLocationTextBox.TextChanged += new System.EventHandler(this.eventLocationTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "race name";
            // 
            // raceNameTextBox
            // 
            this.raceNameTextBox.Location = new System.Drawing.Point(382, 377);
            this.raceNameTextBox.Name = "raceNameTextBox";
            this.raceNameTextBox.Size = new System.Drawing.Size(212, 27);
            this.raceNameTextBox.TabIndex = 9;
            this.raceNameTextBox.TextChanged += new System.EventHandler(this.raceNameTextBox_TextChanged);
            // 
            // hoursUpDown
            // 
            this.hoursUpDown.Location = new System.Drawing.Point(382, 463);
            this.hoursUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursUpDown.Name = "hoursUpDown";
            this.hoursUpDown.Size = new System.Drawing.Size(48, 27);
            this.hoursUpDown.TabIndex = 10;
            this.hoursUpDown.ValueChanged += new System.EventHandler(this.hoursUpDown_ValueChanged);
            // 
            // minutesUpDown
            // 
            this.minutesUpDown.Location = new System.Drawing.Point(473, 463);
            this.minutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesUpDown.Name = "minutesUpDown";
            this.minutesUpDown.Size = new System.Drawing.Size(50, 27);
            this.minutesUpDown.TabIndex = 11;
            this.minutesUpDown.ValueChanged += new System.EventHandler(this.minutesUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "start time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "minutes";
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(760, 374);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(286, 29);
            this.uploadButton.TabIndex = 15;
            this.uploadButton.Text = "upload horse list (JSON)";
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "EVENTS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "RACES";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(760, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 19;
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
            this.horseListBox.TabIndex = 18;
            this.horseListBox.SelectedIndexChanged += new System.EventHandler(this.horseListBox_SelectedIndexChanged);
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.horseListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minutesUpDown);
            this.Controls.Add(this.hoursUpDown);
            this.Controls.Add(this.raceNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventLocationTextBox);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addRaceButton);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.raceListBox);
            this.Controls.Add(this.eventListBox);
            this.Name = "ManagerControl";
            this.Size = new System.Drawing.Size(1158, 648);
            this.Load += new System.EventHandler(this.ManagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox eventListBox;
        private ListBox raceListBox;
        private Button addEventButton;
        private Button addRaceButton;
        private Label label1;
        private Label label2;
        private TextBox eventNameTextBox;
        private TextBox eventLocationTextBox;
        private Label label3;
        private TextBox raceNameTextBox;
        private NumericUpDown hoursUpDown;
        private NumericUpDown minutesUpDown;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button uploadButton;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox horseListBox;
    }
}
