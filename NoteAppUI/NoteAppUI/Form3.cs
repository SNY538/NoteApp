using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {
        private Note _note;

        public Note Note
        {
            get { return _note; }
            set
            {
                _note = value;
                if (_note != null)
                {
                    TitleTextBox.Text = _note.Name; 
                    CategorysComboBox.SelectedItem = _note.Category;
                    CreateDateTimePicker.Value = _note.TimeCreation;
                    ChangeDateTimePicker.Value = _note.TimeLastChange;
                    NoteTextBox.Text = _note.Text;
                }
            }
        }
        public NoteForm()
        {
            InitializeComponent();
            CategorysComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Category element in Enum.GetValues(typeof(Category)))
            {
                CategorysComboBox.Items.Add(element);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if ((CategorysComboBox.SelectedIndex == -1) || (NoteTextBox.Text == string.Empty) || (TitleTextBox.Text == string.Empty))
            {
                MessageBox.Show("Отсутствует либо текст, либо название, либо категория");
            }
            else
            {
                _note.TimeLastChange = DateTime.Now; 
                _note.Name = TitleTextBox.Text;
                _note.Text = NoteTextBox.Text;
                _note.Category = (Category)CategorysComboBox.Items[CategorysComboBox.SelectedIndex];
               
                DialogResult = DialogResult.OK;
                this.Close();
            }
    }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
