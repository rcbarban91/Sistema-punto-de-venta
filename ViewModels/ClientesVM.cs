using LinqToDB;
using Models;
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
        private string _accion = "insert";
        private PictureBox _imagePictureBox;
        private CheckBox _checkBoxCredito;
        private Bitmap _imageBitmap;
        private static DataGridView _dataGridViewClientes;
        private int _num_pagina = 1, _reg_por_pagina = 10;

        public ClientesVM(object[] objetos, List<TextBox> textBoxCliente, List<Label> labelCliente)
        {
            _textBoxCliente = textBoxCliente;
            _labelCliente = labelCliente;
            evento = new TextBoxEvent();
            _imagePictureBox = (PictureBox)objetos[0];
            _imageBitmap = (Bitmap)objetos[2];
            _checkBoxCredito = (CheckBox)objetos[1];
            _dataGridViewClientes = (DataGridView)objetos[3];
            restablecer();
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
                                                    if (cliente1.Count > 0)
                                                    {
                                                        _labelCliente[0].Text = "Este NID ya esta registrado";
                                                        _labelCliente[0].ForeColor = Color.Red;
                                                        _textBoxCliente[0].Focus();
                                                    }
                                                    if (cliente2.Count > 0)
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
                var image = Objects.uploadimage.ImageToByte(srcImage);

                switch (_accion)
                {
                    case "insert":
                        TClientes.Value(c => c.NID, _textBoxCliente[0].Text)
                                 .Value(c => c.Nombre, _textBoxCliente[1].Text)
                                 .Value(c => c.Apellido, _textBoxCliente[2].Text)
                                 .Value(c => c.Email, _textBoxCliente[3].Text)
                                 .Value(c => c.Telefono, _textBoxCliente[4].Text)
                                 .Value(c => c.Direccion, _textBoxCliente[5].Text)
                                 .Value(c => c.Credito, _checkBoxCredito.Checked)
                                 .Value(c => c.Fecha, DateTime.Now.ToString("dd/MMMM/yyyy"))
                                 .Value(c => c.Imagen, image)
                                 .Insert();

                        var cliente = TClientes.ToList().Last();

                        TReportes_Clientes.Value(c => c.UltimoPago, 0)
                            .Value(c => c.FechaPago, "--/--/--")
                            .Value(c => c.DeudaActual, 0)
                            .Value(c => c.FechaDeuda, "--/--/--")
                            .Value(c => c.Ticket, "00000000")
                            .Value(c => c.FechaLimite, "--/--/--")
                            .Value(c => c.IdCliente, cliente.ID)
                            .Insert();
                        break;
                }
                CommitTransaction();
                restablecer();
            }
            catch (Exception ex)
            {
                RollbackTransaction();
                MessageBox.Show(ex.Message);
            }
        }

        public async Task SearchClientesAsync(string campo)
        {
            List<TClientes> query;
            int inicio = (_num_pagina - 1) * _reg_por_pagina;

            if (campo.Equals(""))
            {
                query = await TClientes.ToListAsync();
            }
            else
            {
                query = await TClientes.Where(c => c.NID.StartsWith(campo) || c.Nombre.StartsWith(campo) || c.Apellido.StartsWith(campo)).ToListAsync();
            }
            _dataGridViewClientes.DataSource = query.Skip(inicio).Take(_reg_por_pagina).ToList();
            _dataGridViewClientes.Columns[0].Visible = false;
            _dataGridViewClientes.Columns[7].Visible = false;
            _dataGridViewClientes.Columns[9].Visible = false;
            _dataGridViewClientes.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            _dataGridViewClientes.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            _dataGridViewClientes.Columns[5].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            _dataGridViewClientes.Columns[7].DefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        private int _idCliente = 0;

        public void GetCliente()
        {
            _accion = "update";
            _idCliente = Convert.ToInt16(_dataGridViewClientes.CurrentRow.Cells[0].Value);
            _textBoxCliente[0].Text = Convert.ToString(_dataGridViewClientes.CurrentRow.Cells[1].Value);
            _textBoxCliente[1].Text = Convert.ToString(_dataGridViewClientes.CurrentRow.Cells[2].Value);
            _textBoxCliente[2].Text = Convert.ToString(_dataGridViewClientes.CurrentRow.Cells[3].Value);
            _textBoxCliente[3].Text = Convert.ToString(_dataGridViewClientes.CurrentRow.Cells[4].Value);
            _textBoxCliente[4].Text = Convert.ToString(_dataGridViewClientes.CurrentRow.Cells[5].Value);
            _textBoxCliente[5].Text = Convert.ToString(_dataGridViewClientes.CurrentRow.Cells[6].Value);

            try
            {
                byte[] arrayImage = (byte[])_dataGridViewClientes.CurrentRow.Cells[9].Value;
                _imagePictureBox.Image = Objects.uploadimage.byteArrayToImage(arrayImage);
            }
            catch (Exception)
            {
                _imagePictureBox.Image = _imageBitmap;
            }

            _checkBoxCredito.Checked = Convert.ToBoolean(_dataGridViewClientes.CurrentRow.Cells[8].Value);
            _checkBoxCredito.ForeColor = _checkBoxCredito.Checked ? Color.Green : Color.Red;
        }

        public void restablecer()
        {
            _accion = "insert";
            _num_pagina = 1;
            _imagePictureBox.Image = _imageBitmap;
            _textBoxCliente[0].Text = "";
            _textBoxCliente[1].Text = "";
            _textBoxCliente[2].Text = "";
            _textBoxCliente[3].Text = "";
            _textBoxCliente[4].Text = "";
            _textBoxCliente[5].Text = "";
            _checkBoxCredito.Checked = false;
            _checkBoxCredito.ForeColor = Color.LightSlateGray;
            _labelCliente[0].Text = "NID";
            _labelCliente[0].ForeColor = Color.LightSlateGray;
            _labelCliente[1].Text = "Nombre";
            _labelCliente[1].ForeColor = Color.LightSlateGray;
            _labelCliente[2].Text = "Apellido";
            _labelCliente[2].ForeColor = Color.LightSlateGray;
            _labelCliente[3].Text = "Email";
            _labelCliente[3].ForeColor = Color.LightSlateGray;
            _labelCliente[4].Text = "Telefono";
            _labelCliente[4].ForeColor = Color.LightSlateGray;
            _labelCliente[5].Text = "Direccion";
            _labelCliente[5].ForeColor = Color.LightSlateGray;
            _ = SearchClientesAsync("");
        }
    }
}
