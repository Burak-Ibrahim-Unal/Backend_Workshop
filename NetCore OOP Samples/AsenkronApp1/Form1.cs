using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsenkronApp1
{
    public partial class Form1 : Form
    {
        public int Counter { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnReadTxt_Click(object sender, EventArgs e)
        {
            string data = string.Empty;
            //string data = ReadTxtFile(); // to use it remove async keyword and await line
            Task<string> newData = ReadTxtFileAsync();

            richTextBox1.Text = await new HttpClient().GetStringAsync("https://www.google.com");

            data = await newData;

            richTextBoxTxt.Text = data;
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            textBoxCounter.Text = Counter++.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private string ReadTxtFile()
        {
            string data = string.Empty;
            using (StreamReader streamReader = new StreamReader("ReadMeToCs.txt"))
            {
                Thread.Sleep(4000); // this is synchronous and we cant use our software 4 seconds...
                data = streamReader.ReadToEnd();
            }
            return data;

        }


        // synchronous void = asynchronous Task


        private async Task<string> ReadTxtFileAsync()
        {
            string data = string.Empty;
            using (StreamReader streamReader = new StreamReader("ReadMeToCs.txt"))
            {
                Task<string> newData = streamReader.ReadToEndAsync();

                await Task.Delay(5000);

                data = await newData;

                return data;
            }
        }


    }


}
