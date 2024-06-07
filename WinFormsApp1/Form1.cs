namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string strRes1 = "Обо мне. Меня зовут Максим, я программист";
        private string strRes2 = "Образование. МБОУ СОШ №7 и Академия TOP";
        private string strRes3 = "Опыт работы. Я нигде еще не работал";
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(strRes1);
            MessageBox.Show(strRes2);
            int temp = (strRes1.Length + strRes2.Length + strRes3.Length) / 3;
            MessageBox.Show(strRes3, $"Среднее количество символов {temp}");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
