using System;
using System.Collections.Generic;
using System.Web.UI;

namespace WebClient
{
    public partial class _Default : Page
    {
        public static ServiceReference.TestServiceSoapClient client;

        private delegate int ArithmeticOperation(int a, int b);

        private static Dictionary<string, ArithmeticOperation> operations = new Dictionary<string, ArithmeticOperation>
        {
            ["+"] = (int a, int b) => client.Add(a, b),
            ["−"] = (int a, int b) => client.Subtract(a, b),
            ["×"] = (int a, int b) => client.Multiply(a, b)
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                client = new ServiceReference.TestServiceSoapClient();
                client.Open();
            }
            catch (Exception error)
            {
                TextBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                var a = int.Parse(TextBoxA.Text);
                var b = int.Parse(TextBoxB.Text);
                TextBoxResult.Text = operations[DropDownListOperation.SelectedValue](a, b).ToString();
            }
            catch (Exception error)
            {
                TextBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }

        protected void ButtonMRA_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxA.Text = client.GetMemory().ToString();
            }
            catch (Exception error)
            {
                TextBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }
        protected void ButtonMRB_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxB.Text = client.GetMemory().ToString();
            }
            catch (Exception error)
            {
                TextBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }
        protected void ButtonMS_Click(object sender, EventArgs e)
        {
            try
            {
                client.SetMemory(int.Parse(TextBoxResult.Text));
            }
            catch (Exception error)
            {
                TextBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }

        protected void ButtonARA_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxA.Text = client.GetApp().ToString();
            }
            catch (Exception error)
            {
                TextBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }
        protected void ButtonARB_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxB.Text = client.GetApp().ToString();
            }
            catch (Exception error)
            {
                TextBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }

        protected void ButtonAS_Click(object sender, EventArgs e)
        {
            try
            {
                client.SetApp(int.Parse(TextBoxResult.Text));
            }
            catch (Exception error)
            {
                TextBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }
    }
}