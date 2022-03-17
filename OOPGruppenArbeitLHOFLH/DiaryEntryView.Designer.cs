namespace OOPGruppenArbeitLHOFLH
{
    partial class DiaryEntryView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDiaryInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTags = new System.Windows.Forms.TextBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.DateIncreaseButton = new System.Windows.Forms.Button();
            this.DateDecreaseButton = new System.Windows.Forms.Button();
            this.addTagButton = new System.Windows.Forms.Button();
            this.labelTags = new System.Windows.Forms.Label();
            this.lblTagView = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTags = new System.Windows.Forms.ToolStripMenuItem();
            this.emtyEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(348, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBoxDiaryInput
            // 
            this.textBoxDiaryInput.Location = new System.Drawing.Point(6, 62);
            this.textBoxDiaryInput.MaxLength = 1000;
            this.textBoxDiaryInput.Multiline = true;
            this.textBoxDiaryInput.Name = "textBoxDiaryInput";
            this.textBoxDiaryInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDiaryInput.Size = new System.Drawing.Size(400, 265);
            this.textBoxDiaryInput.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(412, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 265);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(737, 388);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save Entry";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // textBoxTags
            // 
            this.textBoxTags.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxTags.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTags.Location = new System.Drawing.Point(91, 370);
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.Size = new System.Drawing.Size(138, 20);
            this.textBoxTags.TabIndex = 4;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(614, 331);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(198, 24);
            this.UploadButton.TabIndex = 5;
            this.UploadButton.Text = "Upload Picture";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // DateIncreaseButton
            // 
            this.DateIncreaseButton.Location = new System.Drawing.Point(386, 38);
            this.DateIncreaseButton.Name = "DateIncreaseButton";
            this.DateIncreaseButton.Size = new System.Drawing.Size(20, 20);
            this.DateIncreaseButton.TabIndex = 6;
            this.DateIncreaseButton.Text = ">";
            this.DateIncreaseButton.UseVisualStyleBackColor = true;
            this.DateIncreaseButton.Click += new System.EventHandler(this.DateIncreaseButton_Click);
            // 
            // DateDecreaseButton
            // 
            this.DateDecreaseButton.Location = new System.Drawing.Point(6, 38);
            this.DateDecreaseButton.Name = "DateDecreaseButton";
            this.DateDecreaseButton.Size = new System.Drawing.Size(20, 20);
            this.DateDecreaseButton.TabIndex = 7;
            this.DateDecreaseButton.Text = "<";
            this.DateDecreaseButton.UseVisualStyleBackColor = true;
            this.DateDecreaseButton.Click += new System.EventHandler(this.DateDecreaseButton_Click);
            // 
            // addTagButton
            // 
            this.addTagButton.Location = new System.Drawing.Point(10, 368);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(75, 23);
            this.addTagButton.TabIndex = 9;
            this.addTagButton.Text = "Add Tag";
            this.addTagButton.UseVisualStyleBackColor = true;
            this.addTagButton.Click += new System.EventHandler(this.addTagButton_Click);
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTags.Location = new System.Drawing.Point(6, 340);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(62, 24);
            this.labelTags.TabIndex = 10;
            this.labelTags.Text = "Tags: ";
            // 
            // lblTagView
            // 
            this.lblTagView.AutoSize = true;
            this.lblTagView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagView.Location = new System.Drawing.Point(68, 340);
            this.lblTagView.Name = "lblTagView";
            this.lblTagView.Size = new System.Drawing.Size(0, 24);
            this.lblTagView.TabIndex = 11;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(737, 33);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 12;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTags,
            this.emtyEntriesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // menuItemTags
            // 
            this.menuItemTags.Name = "menuItemTags";
            this.menuItemTags.Size = new System.Drawing.Size(180, 22);
            this.menuItemTags.Text = "Tags";
            // 
            // emtyEntriesToolStripMenuItem
            // 
            this.emtyEntriesToolStripMenuItem.Name = "emtyEntriesToolStripMenuItem";
            this.emtyEntriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emtyEntriesToolStripMenuItem.Text = "Emty Entries";
            // 
            // DiaryEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 457);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.lblTagView);
            this.Controls.Add(this.labelTags);
            this.Controls.Add(this.addTagButton);
            this.Controls.Add(this.DateDecreaseButton);
            this.Controls.Add(this.DateIncreaseButton);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.textBoxTags);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDiaryInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DiaryEntryView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Diary";
            this.Load += new System.EventHandler(this.DiaryEntryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.TextBox textBoxDiaryInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxTags;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button DateIncreaseButton;
        private System.Windows.Forms.Button DateDecreaseButton;
        private System.Windows.Forms.Button addTagButton;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Label lblTagView;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemTags;
        private System.Windows.Forms.ToolStripMenuItem emtyEntriesToolStripMenuItem;
    }
}

