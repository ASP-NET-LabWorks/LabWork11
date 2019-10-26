using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Сводное описание для TestService
    /// </summary>
    [WebService(Namespace = "http://azvm.ru/", Description = "Тестовый ASMX-сервис")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class TestService : WebService
    {

        [WebMethod(Description = "Сложение двух чисел")]
        public int Add(int a, int b) => a + b;

        [WebMethod(Description = "Вычитание двух чисел")]
        public int Subtract(int a, int b) => a - b;

        [WebMethod(Description = "Умножение двух чисел")]
        public int Multiply(int a, int b) => a * b;
    }
}
