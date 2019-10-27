using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesktopClient
{
    public partial class FormMain : Form
    {
        public static ServiceReference.TestServiceSoapClient client;

        private delegate int ArithmeticOperation(int a, int b);

        private static Dictionary<string, ArithmeticOperation> operations = new Dictionary<string, ArithmeticOperation>
        {
            ["+"] = (int a, int b) => client.Add(a, b),
            ["−"] = (int a, int b) => client.Subtract(a, b),
            ["×"] = (int a, int b) => client.Multiply(a, b)
        };

        public FormMain()
        {
            InitializeComponent();

            comboBoxOperation.SelectedIndex = 0;

            try
            {
                client = new ServiceReference.TestServiceSoapClient();
                client.Open();
            }
            catch (Exception error)
            {
                textBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                var a = int.Parse(textBoxA.Text);
                var b = int.Parse(textBoxB.Text);
                textBoxResult.Text = operations[comboBoxOperation.Text](a, b).ToString();
            }
            catch (Exception error)
            {
                textBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }

        private void buttonMRA_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxA.Text = client.GetMemory().ToString();
            }
            catch (Exception error)
            {
                textBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }
        private void buttonMRB_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxB.Text = client.GetMemory().ToString();
            }
            catch (Exception error)
            {
                textBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }
        private void buttonMS_Click(object sender, EventArgs e)
        {
            try
            {
                client.SetMemory(int.Parse(textBoxResult.Text));
            }
            catch (Exception error)
            {
                textBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }

        private void buttonARA_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxA.Text = client.GetApp().ToString();
            }
            catch (Exception error)
            {
                textBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }
        private void buttonARB_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxB.Text = client.GetApp().ToString();
            }
            catch (Exception error)
            {
                textBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }
        private void buttonAS_Click(object sender, EventArgs e)
        {
            try
            {
                client.SetApp(int.Parse(textBoxResult.Text));
            }
            catch (Exception error)
            {
                textBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }
    }
}