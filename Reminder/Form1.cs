using System.Windows.Forms;

namespace Reminder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            dtp_date.Value = DateTime.Now;
            dtp_clock.ShowUpDown = true;
            dtp_clock.Value = DateTime.Now;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string FileName = txt_title.Text + ".txt";
            string Notes = rtb_notes.Text;
            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\ReminderErsel\\";

            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
                File.WriteAllText(FilePath + FileName, Notes);
            }
            else
            {
                File.WriteAllText(FilePath + FileName, Notes);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string FileName = txt_title.Text + ".txt";
            string Notes = rtb_notes.Text;
            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\ReminderErsel\\";

            var result = MessageBox.Show("Do you want to delete currently open note?", "Delete?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (File.Exists(FilePath + FileName))
                {
                    File.Delete(FilePath + FileName);
                    txt_title.Text = "Title";
                    rtb_notes.Text = "Your notes goes here...";
                    MessageBox.Show("File deleted", "Success");
                }
                else
                {
                    MessageBox.Show("There is no file to delete", "Error");
                }
            }
            else
            {

            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\ReminderErsel\\";

            openFileDialog1.InitialDirectory = FilePath;
            openFileDialog1.Title = "Select a note to open";

            var result = openFileDialog1.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                string FileName = openFileDialog1.SafeFileName;

                txt_title.Text = FileName.Remove(FileName.Length - 4, 4);
                rtb_notes.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            txt_title.Text = "Title";
            rtb_notes.Text = "Your notes goes here...";
        }

        private void btn_setReminder_Click(object sender, EventArgs e)
        {

            var Reminder = new DateTime(dtp_date.Value.Year, dtp_date.Value.Month, dtp_date.Value.Day, dtp_clock.Value.Hour, dtp_clock.Value.Minute, 0);

            MessageBox.Show("Reminder set to " + Reminder.ToString());

            while (true)
            {
                if (DateTime.Now == Reminder)
                {
                    MessageBox.Show("ALERT");
                    break;
                }
            }


        }
    }
}
