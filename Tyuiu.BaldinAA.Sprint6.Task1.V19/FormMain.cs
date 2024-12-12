using Tyuiu.BaldinAA.Sprint6.Task1.V19.Lib;
namespace Tyuiu.BaldinAA.Sprint6.Task1.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_ANS);
                int stopStep = Convert.ToInt32(textBoxStopStep_ANS);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRes_ANS.Text = "";
                textBoxRes_ANS.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxRes_ANS.AppendText("|     X      |    F(x)    |" + Environment.NewLine);
                textBoxRes_ANS.AppendText("+------------+------------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}    |  {1, 5:f2}  | ", startStep, valueArray[i]);
                    textBoxRes_ANS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRes_ANS.AppendText("+------------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИБКСб-23-2 Балдин Артём Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

