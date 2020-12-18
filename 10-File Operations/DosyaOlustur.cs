using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaIslemleriLib
{
    public class DosyaOlustur
    {
        public void DosyaOlusturmaFonk(string dosya,string path)
        {
            FileStream fs = null;
            StreamWriter sw = null;
           
            fs = new FileStream(path, FileMode.Append);
            sw = new StreamWriter(fs);
            
            sw.Write(dosya);
            fs.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
