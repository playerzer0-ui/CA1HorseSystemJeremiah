namespace CA1HorseSystemJeremiah
{
    partial class HorseSystem
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
            this.managerButton = new System.Windows.Forms.Button();
            this.ownerButton = new System.Windows.Forms.Button();
            this.goerButton = new System.Windows.Forms.Button();
            this.managerControl1 = new CA1HorseSystemJeremiah.ManagerControl();
            this.ownerControl1 = new CA1HorseSystemJeremiah.OwnerControl();
            this.SuspendLayout();
            // 
            // managerButton
            // 
            this.managerButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.managerButton.Location = new System.Drawing.Point(34, 43);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(134, 45);
            this.managerButton.TabIndex = 0;
            this.managerButton.Text = "manager";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // ownerButton
            // 
            this.ownerButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ownerButton.Location = new System.Drawing.Point(34, 117);
            this.ownerButton.Name = "ownerButton";
            this.ownerButton.Size = new System.Drawing.Size(134, 39);
            this.ownerButton.TabIndex = 1;
            this.ownerButton.Text = "owner";
            this.ownerButton.UseVisualStyleBackColor = true;
            this.ownerButton.Click += new System.EventHandler(this.ownerButton_Click);
            // 
            // goerButton
            // 
            this.goerButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goerButton.Location = new System.Drawing.Point(34, 192);
            this.goerButton.Name = "goerButton";
            this.goerButton.Size = new System.Drawing.Size(134, 43);
            this.goerButton.TabIndex = 2;
            this.goerButton.Text = "goer";
            this.goerButton.UseVisualStyleBackColor = true;
            // 
            // managerControl1
            // 
            this.managerControl1.Location = new System.Drawing.Point(189, 1);
            this.managerControl1.Name = "managerControl1";
            this.managerControl1.Size = new System.Drawing.Size(1448, 810);
            this.managerControl1.TabIndex = 3;
            // 
            // ownerControl1
            // 
            this.ownerControl1.Location = new System.Drawing.Point(189, 1);
            this.ownerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ownerControl1.Name = "ownerControl1";
            this.ownerControl1.Size = new System.Drawing.Size(1448, 810);
            this.ownerControl1.TabIndex = 4;
            // 
            // HorseSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 611);
            this.Controls.Add(this.ownerControl1);
            this.Controls.Add(this.managerControl1);
            this.Controls.Add(this.goerButton);
            this.Controls.Add(this.ownerButton);
            this.Controls.Add(this.managerButton);
            this.Name = "HorseSystem";
            this.Text = "HorseSystem";
            this.Load += new System.EventHandler(this.HorseSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button managerButton;
        private Button ownerButton;
        private Button goerButton;
        private ManagerControl managerControl1;
        private OwnerControl ownerControl1;
    }
}