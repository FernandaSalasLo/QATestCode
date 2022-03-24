using System;
using System.Collections.Generic;
using System.Text;

namespace QATestCode.Pojo
{

    public class LoginData
    {
        public Credenciales credenciales { get; set; }
    }

    public class Credenciales
    {
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string usuarioIncorrecto { get; set; }
        public string contrasenaIncorrecta { get; set; }
    }


}
