namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string strRes1 = "��� ���. ���� ����� ������, � �����������";
        private string strRes2 = "�����������. ���� ��� �7 � �������� TOP";
        private string strRes3 = "���� ������. � ����� ��� �� �������";
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(strRes1);
            MessageBox.Show(strRes2);
            int temp = (strRes1.Length + strRes2.Length + strRes3.Length) / 3;
            MessageBox.Show(strRes3, $"������� ���������� �������� {temp}");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
