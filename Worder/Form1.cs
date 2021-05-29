using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;

namespace Worder
{
    public partial class WorderWondow : Form
    {
        string FilePath;

        public WorderWondow()
        {
            InitializeComponent();
        }

        void FileOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
                using (StreamReader SR = new StreamReader(OFD.FileName))
                {
                    MainTextBox.Text = SR.ReadToEnd();
                    FilePath = OFD.FileName;
                }
        }

        void FileSaveButton_Click(object sender, EventArgs e)
        {
            if (FilePath == null)
            {
                SaveFileDialog SFD = new SaveFileDialog();
                if (SFD.ShowDialog() == DialogResult.OK)
                    FilePath = SFD.FileName;
                else
                    return;
            }
            FileSave();
        }

        void FileSave()
        {
            using (StreamWriter SW = new StreamWriter(FilePath))
            {
                SW.Write(MainTextBox.Text);
            }
        }

        void FileSaveAsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы|*.*";
            if (SFD.ShowDialog() == DialogResult.OK)
                FilePath = SFD.FileName;
            else
                return;
            FileSave();
        }

        void EditClearAllButton_Click(object sender, EventArgs e) => MainTextBox.Clear();

        void WorderWondow_Load(object sender, EventArgs e)
        {
            for (byte i = 8; i != 69; i++)
                FontSizeSelecter.Items.Add(i);
            InstalledFontCollection IFC = new InstalledFontCollection();
            foreach (FontFamily f in IFC.Families)
                FontCollectionSelecter.Items.Add(f.Name);
        }

        void FontSizeSelecter_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainTextBox.Font = new Font(MainTextBox.Font.Name, (float)Convert.ToDouble(FontSizeSelecter.Items[FontSizeSelecter.SelectedIndex].ToString()));
        }

        void FontCollectionSelecter_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainTextBox.Font = new Font(FontCollectionSelecter.Items[FontCollectionSelecter.SelectedIndex].ToString(), MainTextBox.Font.Size);
        }

        void TextChangeColourButton_Click(object sender, EventArgs e)
        {
            if (FontColorSelecter.ShowDialog() == DialogResult.OK)
                MainTextBox.ForeColor = FontColorSelecter.Color;
        }
    }
}
