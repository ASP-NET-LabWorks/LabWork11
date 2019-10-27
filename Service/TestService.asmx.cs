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
        [WebMethod(Description = "Получить число, хранящееся в памяти", EnableSession = true)]
        public int GetMemory() => Session["memory"] != null ? (int)Session["memory"] : 0;
        [WebMethod(Description = "Сохранить число в память", EnableSession = true)]
        public void SetMemory(int value) => Session["memory"] = value;

        [WebMethod(Description = "Получить число, хранящееся в словаре приложения")]
        public int GetApp() => Application["memory"] != null ? (int)Application["memory"] : 0;
        [WebMethod(Description = "Сохранить число в словарь приложения")]
        public void SetApp(int value) => Application["memory"] = value;

        [WebMethod(Description = "Сложение двух чисел")]
        public int Add(int a, int b) => a + b;
        [WebMethod(Description = "Вычитание двух чисел")]
        public int Subtract(int a, int b) => a - b;
        [WebMethod(Description = "Умножение двух чисел")]
        public int Multiply(int a, int b) => a * b;
    }
}