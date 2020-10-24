using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModels.Library
{
    public class Uploadimage
    {
        private OpenFileDialog fd = new OpenFileDialog();

        public void CargarImagen(PictureBox pictureBox) 
        {
            //Establecer la propiedad de WaitOnLoad a true significa que la imagen se carga de forma sincronita
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Todos(*.*)|*.*|Imagenes|*.jpg;*.png;*.gif;*.bmp";
            fd.ShowDialog();

            if (fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }
    }
}
