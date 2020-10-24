using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModels
{
    public class ClientesVM
    {
        private List<TextBox> _textBoxCliente;
        private List<Label> _labelCliente;

        public ClientesVM(List<TextBox> textBoxCliente, List<Label> labelCliente)
        {
            _textBoxCliente = textBoxCliente;
            _labelCliente = labelCliente;
        }

        public void guardarCliente()
        {
            if (_textBoxCliente[0].Text.Equals(""))
            {
                _labelCliente[0].Text = "Este campo es requerido";
                _labelCliente[0].ForeColor = Color.Red;
                _textBoxCliente[0].Focus();
            }
            else
            {
                if (_textBoxCliente[1].Text.Equals(""))
                {
                    _labelCliente[1].Text = "Este campo es requerido";
                    _labelCliente[1].ForeColor = Color.Red;
                    _textBoxCliente[1].Focus();
                }
                else
                {
                    if (_textBoxCliente[2].Text.Equals(""))
                    {
                        _labelCliente[2].Text = "Este campo es requerido";
                        _labelCliente[2].ForeColor = Color.Red;
                        _textBoxCliente[2].Focus();
                    }
                    else
                    {
                        if (_textBoxCliente[3].Text.Equals(""))
                        {
                            _labelCliente[3].Text = "Este campo es requerido";
                            _labelCliente[3].ForeColor = Color.Red;
                            _textBoxCliente[3].Focus();
                        }
                        else
                        {
                            if (_textBoxCliente[4].Text.Equals(""))
                            {
                                _labelCliente[4].Text = "Este campo es requerido";
                                _labelCliente[4].ForeColor = Color.Red;
                                _textBoxCliente[4].Focus();
                            }
                            else
                            {
                                if (_textBoxCliente[5].Text.Equals(""))
                                {
                                    _labelCliente[5].Text = "Este campo es requerido";
                                    _labelCliente[5].ForeColor = Color.Red;
                                    _textBoxCliente[5].Focus();
                                }
                                else
                                {

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
