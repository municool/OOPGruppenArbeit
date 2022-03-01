using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOPGruppenArbeitLHOFLH
{
    public partial class DiaryEntryView : Form
    {

        IBusiness business = new DiaryBusiness();
        DiaryEntry currentEntry = null;

        public DiaryEntryView()
        {
            InitializeComponent();

            // Daten abrufen (mit Methode)
            UpdateView();
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
            currentEntry.Tags = textBoxTags.Text;
            currentEntry.PicturePath = pictureBox1.ImageLocation;

            // Speichern-Methode aufrufen
            business.SaveDiaryEntry(currentEntry);
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

        private void textBoxTags_TextChanged(object sender, EventArgs e)
        {
            textBoxTags.AutoCompleteSource = AutoCompleteSource.FileSystem;
            textBoxTags.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        // Methode zum Datenabruf
        public void UpdateView()
        {
            currentEntry = business.GetDiaryEntry(dateTimePicker1.Value);
            dateTimePicker1.Value = currentEntry.DateTime;
            textBoxDiaryInput.Text = currentEntry.EntryText;
            textBoxTags.Text = string.Join(",",currentEntry.GetTags());
            pictureBox1.ImageLocation = currentEntry.PicturePath;
        }

        // Textbox Tags: Aufruf GetAvailableTags();
        // Vorschau von bereits genutzten Tags
        // AutoComplete Source?

    }
}
