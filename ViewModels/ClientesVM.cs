using Models.Conexion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels.Library;

namespace ViewModels
{
    public class ClientesVM : Conexion
    {
        private List<TextBox> _textBoxCliente;
        private List<Label> _labelCliente;
        private TextBoxEvent evento;
        private string _accion = "inset";
        private PictureBox _imagePictureBox;

        public ClientesVM(object[] objetos, List<TextBox> textBoxCliente, List<Label> labelCliente)
        {
            _textBoxCliente = textBoxCliente;
            _labelCliente = labelCliente;
            evento = new TextBoxEvent();
            _imagePictureBox = (PictureBox)objetos[0];
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
                            if (evento.comprobarFormatoEmail(_textBoxCliente[3].Text))
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
                                        var cliente1 = TClientes.Where(c => c.NID.Equals(_textBoxCliente[0].Text)).ToList();
                                        var cliente2 = TClientes.Where(c => c.Email.Equals(_textBoxCliente[3].Text)).ToList();
                                        var list = cliente1.Union(cliente2).ToList();

                                        switch (_accion)
                                        {
                                            case "insert":
                                                if (list.Count.Equals(0))
                                                {
                                                    SaveDate();
                                                }
                                                else
                                                {
                                                    if (list[0].NID.Equals(_textBoxCliente[0].Text))
                                                    {
                                                        _labelCliente[0].Text = "Este NID ya esta registrado";
                                                        _labelCliente[0].ForeColor = Color.Red;
                                                        _textBoxCliente[0].Focus();
                                                    }
                                                    if (list[0].Email.Equals(_textBoxCliente[3].Text))
                                                    {
                                                        _labelCliente[3].Text = "Este Email ya esta registrado";
                                                        _labelCliente[3].ForeColor = Color.Red;
                                                        _textBoxCliente[3].Focus();
                                                    }
                                                }
                                                break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                _labelCliente[3].Text = "Email invalido";
                                _labelCliente[3].ForeColor = Color.Red;
                                _textBoxCliente[3].Focus();
                            }
                            
                        }
                    }
                }
            }
        }

        public void SaveDate()
        {
            BeginTransactionAsync();

            try
            {
                var srcImage = Objects.uploadimage.ResizeImage(_imagePictureBox.Image, 165, 100);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
