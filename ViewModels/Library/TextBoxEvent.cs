using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModels.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Condicion que solo permitre entrar datos de tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //Condicion que no permite dar saltos de linea cuando se oprime Enter
            else if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
            //Condicion que nos permite utilizar la letra backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //Condicion que nos permite utilizar la letra espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void numberKeyPress(KeyPressEventArgs e)
        {
            //Condicion que nos permitre entrar datos de tipo numerico
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //Condicion que no permitre entrar datos de tipo texto
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            //Condicion que no permite dar saltos de linea cuando se oprime Enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
            //Condicion que nos permite utilizar la letra backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //Condicion que nos permite utilizar la letra espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
