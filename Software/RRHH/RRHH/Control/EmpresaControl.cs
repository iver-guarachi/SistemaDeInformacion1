using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
using System.Drawing; 
using System.Net; 
using System.Drawing.Imaging;
using RRHH.Entidades; 

namespace RRHH.Control
{

    class EmpresaControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Empresa emp;

        public void guardarEmpresa(String nombre, String direccion, String ImagenDir)
        {
            emp = new Empresa();
            emp.Nombre = nombre;
            emp.Direccion = direccion;
            System.Drawing.Image img = new Bitmap(ImagenDir);
            emp.Logo = imageToByteArray(img);

            rrhh.Empresas.AddObject(emp);
            rrhh.SaveChanges();
        }
        

        //Esta es la función que realiza la conversión

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }

	
}
