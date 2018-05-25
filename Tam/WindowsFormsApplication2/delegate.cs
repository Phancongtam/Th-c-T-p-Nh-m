using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public delegate void loginsucces(object sender, dangnhap e);
    public class dangnhap : EventArgs
    {
        public string Username { get; set; }
        public string Pass { get; set; }
    }
}
