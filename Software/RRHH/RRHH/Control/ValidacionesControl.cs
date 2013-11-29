using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRHH.Control
{
    class ValidacionesControl
    {
        
        public void SoloNumeros(System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
         }
        
        public bool SoloNumeros(Char c)
        {
            if ((c >= '0' && c <= '9') || c=='\b')
            {
                return true;
            }
            return false;
        }

        public bool SoloLetras(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c == '\b') || (c == ' '))
            {
                return true;
            }
            return false;
        }

        
        
      
    }
}
