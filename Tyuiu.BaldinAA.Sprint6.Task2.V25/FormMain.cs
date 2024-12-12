using Tyuiu.BaldinAA.Sprint6.Task2.V25.Lib;
namespace Tyuiu.BaldinAA.Sprint6.Task2.V25;
 public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    DataService ds = new DataService();
    private void buttonDone_GTA_Click(object sender, EventArgs e)
    {
        try
        {
            int startStep = Convert.ToInt32(textBoxInOne_GTA.Text);
            int stopStep = Convert.ToInt32(textBoxInTwo_GTA.Text);
            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startStep, stopStep);
            this.chartGraf_GTA.Titles.Add("График функции");
            this.chartGraf_GTA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraf_GTA.ChartAreas[0].AxisY.Title = "Ось Y";
            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewOut_GTA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                this.chartGraf_GTA.Series[0].Points.AddXY(startStep, valueArray[i]);
                startStep++;
            }
        }
        catch
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDone_GTA_MouseEnter(object sender, EventArgs e)
    {
        buttonDone_GTA.BackColor = Color.Red;
    }

    private void buttonDone_GTA_MouseLeave(object sender, EventArgs e)
    {
        buttonDone_GTA.BackColor = Color.Green;
    }

    private void buttonDone_GTA_MouseDown(object sender, MouseEventArgs e)
    {
        buttonDone_GTA.BackColor = Color.Blue;
    }
    private void buttonInfo_GTA_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-24-1 Балдин Артём Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);