using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApp.Models
{
    public class Usuario
    {
        public int usu_id { get; set; }
        public string usu_usuario { get; set; }
        public string usu_password { get; set; }
        public string IdWithUsuario { get => $"{usu_id} {usu_usuario}"; }
    }
}
