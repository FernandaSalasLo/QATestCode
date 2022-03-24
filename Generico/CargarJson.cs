using Newtonsoft.Json;
using System.IO;

namespace QATestCode.Generico
{
    class CargarJson
    {
        public Pojo.LoginData datos_Login()
        {
            var Json = JsonConvert.DeserializeObject<Pojo.LoginData>(File.ReadAllText(@"..\..\..\Datos\Login.json"));
            return Json;
        }
    }
}
