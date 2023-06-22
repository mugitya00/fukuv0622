namespace fukuv0622
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int[] data = new int[10];
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] data = new int[10];
            label1.Text = "";
            int sum = 0;


            for(int i=0;i<10;i++)
            {
                data[i]= random.Next(101);
                label1.Text += $"{data[i]},";
                sum += data[i];
            }
            MessageBox.Show($"{sum / 10}");

            /*data[0]=random.Next(0,101);
            data[1]=random.Next(0,101);
            data[2]=random.Next(0,101);
            data[3]=random.Next(0, 101);
            data[4]=random.Next(0, 101);
            data[5]=random.Next(0, 101);
            data[6]=random.Next(0, 101);
            data[7]=random.Next(0, 101);
            data[8]=random.Next(0, 101);
            data[9]=random.Next(0, 101);
          int  i= 0;
            for (i=0; i < 10; i++)
            {
               label1.Text = ($"" +
                    $"{data[0]}," +
                    $"{data[1]}," +
                    $"{data[2]}," +
                    $"{data[3]}," +
                    $"{data[4]}," +
                    $"{data[5]}," +
                    $"{data[6]}," +
                    $"{data[7]}," +
                    $"{data[8]}," +
                    $"{data[9]}");
               int a =(data[0] + data[1] + data[2] + data[3] + data[4] + data[5] + data[6] + data[7] + data[8] + data[9]) / 10;
               MessageBox.Show($"{a}");
            }*/

        }
    }
}