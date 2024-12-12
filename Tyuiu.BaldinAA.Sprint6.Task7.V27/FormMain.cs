using Tyuiu.BaldinAA.Sprint6.Task7.V27.Lib;
namespace Tyuiu.BaldinAA.Sprint6.Task7.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DataService ds = new();
            openFileDialogTask.ShowDialog();
            string path = openFileDialogTask.FileName;
            string[] s = File.ReadAllText(path).Split('\n');
            string[,] input = new string[s.Length, s[0].Split(';').Length];

            GridInput.ColumnCount = input.GetLength(0);
            GridOutput.ColumnCount = input.GetLength(0);
            GridInput.RowCount = input.GetLength(1);
            GridOutput.RowCount = input.GetLength(1);

            int[,] output = ds.GetMatrix(path);

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    GridInput.Rows[i].Cells[j].Value = s[j].Split(';')[i];
                    GridOutput.Rows[i].Cells[j].Value = Convert.ToString(output[i, j]);
                }
            }

        }



        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e);
    }
}
