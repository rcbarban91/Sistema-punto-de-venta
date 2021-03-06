﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;
using ViewModels.Library;

namespace Sistema_punto_de_venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        /***********************
         *                     *
         *  CODIGO DEL CLIENTE *
         *                     *
         ***********************/

        #region

        private ClientesVM clientes;

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            var textBoxCliente = new List<TextBox>();
            textBoxCliente.Add(textBoxCliente_NID);
            textBoxCliente.Add(textBoxCliente_Nombre);
            textBoxCliente.Add(textBoxCliente_Apellido);
            textBoxCliente.Add(textBoxCliente_Email);
            textBoxCliente.Add(textBoxCliente_Telefono);
            textBoxCliente.Add(textBoxCliente_Direccion);

            var labelCliente = new List<Label>();
            labelCliente.Add(labelCliente_NID);
            labelCliente.Add(labelCliente_Nombre);
            labelCliente.Add(labelCliente_Apellido);
            labelCliente.Add(labelCliente_Email);
            labelCliente.Add(labelCliente_Telefono);
            labelCliente.Add(labelCliente_Direccion);
            labelCliente.Add(label_PaginasClientes);            

            object[] objetos = { pictureBoxCliente, checkBoxCliente_Credito, Properties.Resources.foto_de_perfil, dataGridView_Clientes, numeric_PaginasClientes };

            clientes = new ClientesVM(objetos, textBoxCliente, labelCliente);

            tabControlPrincipal.SelectedIndex = 1;
        }
        
        private void pictureBoxCliente_Click(object sender, EventArgs e)
        {
            Objects.uploadimage.CargarImagen(pictureBoxCliente); 
        }

        private void textBoxCliente_NID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_NID.Text.Equals(""))
            {
                labelCliente_NID.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCliente_NID.Text = "NID";
                labelCliente_NID.ForeColor = Color.Green;
            }
        }

        private void textBoxCliente_NID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.numberKeyPress(e);
        }

        private void textBoxCliente_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Nombre.Text.Equals(""))
            {
                labelCliente_Nombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCliente_Nombre.Text = "Nombre";
                labelCliente_Nombre.ForeColor = Color.Green;
            }
        }

        private void textBoxCliente_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.textKeyPress(e);
        }

        private void textBoxCliente_Apellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Apellido.Text.Equals(""))
            {
                labelCliente_Apellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCliente_Apellido.Text = "Apellido";
                labelCliente_Apellido.ForeColor = Color.Green;
            }
        }

        private void textBoxCliente_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.textKeyPress(e);
        }

        private void textBoxCliente_Email_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Email.Text.Equals(""))
            {
                labelCliente_Email.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCliente_Email.Text = "Email";
                labelCliente_Email.ForeColor = Color.Green;
            }
        }

        private void textBoxCliente_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Telefono.Text.Equals(""))
            {
                labelCliente_Telefono.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCliente_Telefono.Text = "Telefono";
                labelCliente_Telefono.ForeColor = Color.Green;
            }
        }

        private void textBoxCliente_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.numberKeyPress(e);
        }

        private void textBoxCliente_Direccion_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Direccion.Text.Equals(""))
            {
                labelCliente_Direccion.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCliente_Direccion.Text = "Direccion";
                labelCliente_Direccion.ForeColor = Color.Green;
            }
        }
        
        private void buttonCliente_Agregar_Click(object sender, EventArgs e)
        {
            clientes.guardarCliente();
        }

        private void buttonCliente_Cancelar_Click(object sender, EventArgs e)
        {
            clientes.restablecer();
        }
        

        private void dataGridView_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Clientes.Rows.Count != 0)
            {
                clientes.GetCliente();
            }            
        }

        private void dataGridView_Clientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView_Clientes.Rows.Count != 0)
            {
                clientes.GetCliente();
            }
        }        

        private void buttonCliente_Pagina1_Click(object sender, EventArgs e)
        {
            clientes.Paginador("Primero");
        }

        private void buttonCliente_Pagina2_Click(object sender, EventArgs e)
        {
            clientes.Paginador("Anterior");
        }

        private void buttonCliente_Pagina3_Click(object sender, EventArgs e)
        {
            clientes.Paginador("Siguiente");
        }

        private void buttonCliente_Pagina4_Click(object sender, EventArgs e)
        {
            clientes.Paginador("Ultimo");
        }        

        private void numeric_PaginasClientes_ValueChanged(object sender, EventArgs e)
        {
            clientes.Registro_Paginas();
        }
        
        private void textBoxCliente_Buscar_TextChanged(object sender, EventArgs e)
        {
            clientes.SearchClientes(textBoxCliente_Buscar.Text);
        }

        private void tabControlCliente1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlCliente1.SelectedIndex)
            {
                case 0:
                    tabControlCliente2.SelectedIndex = 0;
                    break;
                case 1:
                    tabControlCliente2.SelectedIndex = 1;
                    break;
            }
        }

        private void tabControlCliente2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlCliente2.SelectedIndex)
            {
                case 0:
                    tabControlCliente1.SelectedIndex = 0;
                    break;
                case 1:
                    tabControlCliente1.SelectedIndex = 1;
                    break;
            }
        }
        #endregion
    }
}
