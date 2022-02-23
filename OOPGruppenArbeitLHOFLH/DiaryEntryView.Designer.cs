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
            this.TagsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBoxDiaryInput
            // 
            this.textBoxDiaryInput.Location = new System.Drawing.Point(12, 38);
            this.textBoxDiaryInput.MaxLength = 1000;
            this.textBoxDiaryInput.Multiline = true;
            this.textBoxDiaryInput.Name = "textBoxDiaryInput";
            this.textBoxDiaryInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDiaryInput.Size = new System.Drawing.Size(400, 265);
            this.textBoxDiaryInput.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(418, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 265);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(743, 312);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save Entry";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // textBoxTags
            // 
            this.textBoxTags.Location = new System.Drawing.Point(52, 311);
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.Size = new System.Drawing.Size(198, 20);
            this.textBoxTags.TabIndex = 4;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(418, 311);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(198, 24);
            this.UploadButton.TabIndex = 5;
            this.UploadButton.Text = "Upload Picture";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // DateIncreaseButton
            // 
            this.DateIncreaseButton.Location = new System.Drawing.Point(244, 12);
            this.DateIncreaseButton.Name = "DateIncreaseButton";
            this.DateIncreaseButton.Size = new System.Drawing.Size(20, 20);
            this.DateIncreaseButton.TabIndex = 6;
            this.DateIncreaseButton.Text = ">";
            this.DateIncreaseButton.UseVisualStyleBackColor = true;
            this.DateIncreaseButton.Click += new System.EventHandler(this.DateIncreaseButton_Click);
            // 
            // DateDecreaseButton
            // 
            this.DateDecreaseButton.Location = new System.Drawing.Point(12, 12);
            this.DateDecreaseButton.Name = "DateDecreaseButton";
            this.DateDecreaseButton.Size = new System.Drawing.Size(20, 20);
            this.DateDecreaseButton.TabIndex = 7;
            this.DateDecreaseButton.Text = "<";
            this.DateDecreaseButton.UseVisualStyleBackColor = true;
            this.DateDecreaseButton.Click += new System.EventHandler(this.DateDecreaseButton_Click);
            // 
            // TagsLabel
            // 
            this.TagsLabel.AutoSize = true;
            this.TagsLabel.Location = new System.Drawing.Point(12, 314);
            this.TagsLabel.Name = "TagsLabel";
            this.TagsLabel.Size = new System.Drawing.Size(34, 13);
            this.TagsLabel.TabIndex = 8;
            this.TagsLabel.Text = "Tags:";
            // 
            // DiaryEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 343);
            this.Controls.Add(this.TagsLabel);
            this.Controls.Add(this.DateDecreaseButton);
            this.Controls.Add(this.DateIncreaseButton);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.textBoxTags);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDiaryInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DiaryEntryView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Diary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label TagsLabel;
    }
}

