using Tyuiu.BaldinAA.Sprint6.Task5.V18.Lib;
namespace Tyuiu.BaldinAA.Sprint6.Task5.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Artyom\source\repos\Tyuiu.BaldinAA.Sprint6\Tyuiu.BaldinAA.Sprint6.Task5.V18\bin\Debug\InPutFileTask5V18.txt";
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxResult_SME_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxTask_SME_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxData_SME_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_SME_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SME.ColumnCount = 2;
            dataGridViewResult_SME.Columns[0].Width = 40;
            dataGridViewResult_SME.Columns[1].Width = 60;

            this.chartDiagramm_SME.ChartAreas[0].AxisX.Title = "��� X";
            this.chartDiagramm_SME.ChartAreas[0].AxisY.Title = "��� Y";
            this.chartDiagramm_SME.Series[0].Points.Clear();

            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);
            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewResult_SME.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartDiagramm_SME.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonOpen_SME_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\Artyom\source\repos\Tyuiu.BaldinAA.Sprint6\Tyuiu.BaldinAA.Sprint6.Task5.V18\bin\Debug\InPutFileTask5V18.txt";

                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("���� ��� �������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 6 �������� ������� ������ �����-24-1 ������ ���� �������������",
                "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
