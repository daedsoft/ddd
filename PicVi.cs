using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

namespace miPictureViewer
{
    public static class PicVi
    {
        public static string RutaImagen { get; set; }        
        public static int AltoImagen { get; set; }
        public static int AnchoImagen { get; set; }
        public static string RutaCarpeta { get; set; }

        public static List<string> ListaImagenes = new List<string>();

        public static void ObtenerRutaImagen()
        {
            using (OpenFileDialog AbrirImagen = new OpenFileDialog())
            {
                if (AbrirImagen.ShowDialog() == DialogResult.OK)
                {
                    RutaImagen = AbrirImagen.FileName;
                    RutaCarpeta = Path.GetDirectoryName(AbrirImagen.FileName);                    
                }
            }
        }

        public static void ObtenerTodasLasImagenes()
        {            
            try
            {               
                ListaImagenes.Clear();                
                foreach (string imagen in Directory.EnumerateFiles(RutaCarpeta)
                    .Where(s => s.EndsWith(".jpg") || 
                    s.EndsWith(".png") || 
                    s.EndsWith(".bmp") || 
                    s.EndsWith(".jpeg")))
                {
                    ListaImagenes.Add(imagen);                    
                }                
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        
        public static void ObtenerMedidasImagen()
        {
            try
            {
                using (Bitmap Imagen = new Bitmap(RutaImagen))
                {
                    AltoImagen = Imagen.Height;
                    AnchoImagen = Imagen.Width;
                }
            }
            catch { }
        }
    }
}
