using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace OOPGruppenArbeitLHOFLH
{
    public partial class DiaryEntryView : Form
    {

        IBusiness business = new DiaryBusiness();
        DiaryEntry currentEntry = null;
        List<string> tags = null;

        public DiaryEntryView()
        {
            InitializeComponent();
        }

        public void Save_Click(object sender, EventArgs e)
        {
            if (currentEntry == null)
            {
                currentEntry = new DiaryEntry();
            }

            // Daten currentEntry zuweisen
            currentEntry.DateTime = dateTimePicker1.Value;
            currentEntry.EntryText = textBoxDiaryInput.Text;
            currentEntry.Tags = string.Join(",", tags);
            currentEntry.PicturePath = pictureBox1.ImageLocation;

            // Speichern-Methode aufrufen
            business.SaveDiaryEntry(currentEntry);

            textBoxTags.AutoCompleteCustomSource.Clear();
            textBoxTags.AutoCompleteCustomSource.AddRange(business.GetAvailableTags().ToArray());
        }

        public void UploadButton_Click(object sender, EventArgs e)
        {
            // Dialogfenster zum Fileupload öffnen inkl. Filter
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Bild in pictureBox anzeigen
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.ImageLocation = ofd.FileName;
                }
            }
        }

        private void DateDecreaseButton_Click(object sender, EventArgs e)
        {
            // DateTimePicker -1 Tag
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }

        private void DateIncreaseButton_Click(object sender, EventArgs e)
        {
            // DateTimePicker +1 Tag
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Daten abrufen
            UpdateView();
        }

        // Methode zum Datenupdate
        private void UpdateView()
        {
            currentEntry = business.GetDiaryEntry(dateTimePicker1.Value);

            if (currentEntry != null)
            {
                textBoxDiaryInput.Text = currentEntry.EntryText;
                tags = currentEntry.GetTags();
                pictureBox1.ImageLocation = currentEntry.PicturePath;
            }
            else
            {
                textBoxDiaryInput.Text = string.Empty;
                tags = new List<string>();
                textBoxTags.Text = string.Empty;
                pictureBox1.ImageLocation = string.Empty;
            }

            addTagButton.Enabled = tags.Count < 3;
            lblTagView.Text = string.Join(", ", tags);
        }

        private void DiaryEntryView_Load(object sender, EventArgs e)
        {
            textBoxTags.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxTags.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxTags.AutoCompleteCustomSource.Clear();
            textBoxTags.AutoCompleteCustomSource.AddRange(business.GetAvailableTags().ToArray());

            UpdateView();
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            tags.Add(textBoxTags.Text);
            lblTagView.Text = string.Join(", ", tags);
            textBoxTags.Text = string.Empty;
            addTagButton.Enabled = tags.Count < 3;
        }
    }
}
