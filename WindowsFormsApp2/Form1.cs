using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        HillCipher t;
        public Form1()
        {
            InitializeComponent();
            t = new HillCipher();
        }
        OpenFileDialog openFile;
        private void button6_Click(object sender, EventArgs e)
        {
            
            openFile = new OpenFileDialog();
            openFile.Filter = "|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                inputTextBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
            keyTextBox.Text = "";
            output.Text = "";
            coun.Text = "";
        }

        private void deCode_Click(object sender, EventArgs e)
        {
            if (coun.Text == "")
            {
                MessageBox.Show("Vui long nhap bac cua ma tran! ");
                return;
            }
            string tmp = "";
            string news = "";
            string text = keyTextBox.Text;
            int j = 0;
            int[] arrs = new int[100];
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    tmp += text[i];
                }
                else
                {
                    if (tmp != "" && char.IsDigit(tmp[0]))
                    {
                    news += tmp;
                    arrs[j] = Convert.ToInt32(tmp);
                    j++;
                    }
                    tmp = "";
                }
                if( i == text.Length -1)
                {
                    arrs[j] = Convert.ToInt32(tmp);
                }
            }
            output.Text = t.enCode(inputTextBox.Text, coun.Text, arrs);
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có chắc chắn muốn thoát?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                keyTextBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (coun.Text == "")
            {
                MessageBox.Show("Vui long nhap bac cua ma tran! ");
                return;
            }
            string tmp = "";
            string news = "";
            string text = keyTextBox.Text;
            int j = 0;
            int[] arrs = new int[100];
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    tmp += text[i];
                }
                else
                {
                    if (tmp != "" && char.IsDigit(tmp[0]))
                    {
                        news += tmp;
                        arrs[j] = Convert.ToInt32(tmp);
                        j++;
                    }
                    tmp = "";
                }
                if (i == text.Length - 1)
                {
                    arrs[j] = Convert.ToInt32(tmp);
                }
            }
            output.Text = t.deCode(inputTextBox.Text, coun.Text, arrs);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(coun.Text == "")
            {
                MessageBox.Show("Vui long nhap bac cua ma tran! ");
                return;
            }
            int[,] a = new int[100, 100];
        duycong:
            int k = Convert.ToInt32(coun.Text);
            Random rd = new Random();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    a[i, j] = rd.Next(0, 11);
                }
            }

            int det = t.dinhthuc(a, k);

            if (det == 0 || t.USCLN(det, 26) != 1)
            {
                goto duycong;
            }
            else
            {
                string kt = "";
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        kt += " ";
                        kt += a[i, j];
                    }
                    if(i != k-1)
                        kt += Environment.NewLine;
                }
                kt += "\0";
                keyTextBox.Text = kt;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                string path = Application.StartupPath + "\\filedata\\" + rnd.Next(1, 1000) + ".txt";

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("text: " + output.Text);
                    sw.WriteLine("key\n" + keyTextBox.Text);
                    MessageBox.Show("luu thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_x(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có chắc chắn muốn thoát?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void keyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            void getKeyMatrix(String key, int[,] keyMatrix)
            {
                int k = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        keyMatrix[i, j] = (key[k]) % 65;
                        k++;
                    }
                }
            }
            int[,] keyMatrixs = new int[100, 100];
            getKeyMatrix(keyText.Text, keyMatrixs);
            MessageBox.Show(Convert.ToString(keyMatrixs[0, 0]));
        }
    }
}
