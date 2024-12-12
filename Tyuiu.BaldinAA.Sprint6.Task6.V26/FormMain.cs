using Tyuiu.BaldinAA.Sprint6.Task6.V26.Lib;
namespace Tyuiu.BaldinAA.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 5, âûïîëíèëà ñòóäåíòêà ãðóïïû ÈÁÊÑá-24-1 Áàéìóõàìåòîâà Ìàäèíà Äàìèðîâíà", "Ñîîáùåíèå", MessageBoxButtons.OK);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
