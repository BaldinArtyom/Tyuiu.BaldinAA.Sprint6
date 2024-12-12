using Tyuiu.BaldinAA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.BaldinAA.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openpath;
        private void panelResultFile_LAV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_LAV_Click(object sender, EventArgs e)
        {

            openFileDialog_LAV.ShowDialog();
            openpath = openFileDialog_LAV.FileName;
            textBoxFile_LAV.Text = File.ReadAllText(openpath);
            groupBoxInput_LAV.Text = groupBoxInput_LAV.Text + " " + openFileDialog_LAV.FileName;
            buttonDone_LAV.Enabled = true;
        }

        private void buttonDone_LAV_Click(object sender, EventArgs e)
        {
            textBoxResult_LAV.Text = ds.CollectTextFromFile(openpath);
        }


        private void buttonInfo_LAV_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
