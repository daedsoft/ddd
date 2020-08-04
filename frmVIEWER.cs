    using System;
    using System.Drawing;
    using System.Windows.Forms;

    namespace miPictureViewer
    {
        public partial class frmVIEWER : Form
        {
            int IndiceActual = 0;
            string ImagenAMostrar = string.Empty;

        public frmVIEWER()
        {
            InitializeComponent(); 
        }

        //
        // CARGAR IMAGEN SI SE ABRE DESDE EXPLORER
        //
        private void frmVIEWER_Load(object sender, EventArgs e)
        {
            try
            {
                pVIEWER.Image = Image.FromFile(PicVi.RutaImagen);            
                PicVi.RutaCarpeta = System.IO.Path.GetDirectoryName(PicVi.RutaImagen);
                PicVi.ObtenerTodasLasImagenes();
                IndiceActual = PicVi.ListaImagenes.IndexOf(PicVi.RutaImagen);
                this.Text = $"PicVi - {PicVi.RutaImagen}";
            }
            catch { }
        }


        //
        // ABRIR IMAGEN DESDE FORM
        //
        private void btABRIR_Click(object sender, EventArgs e)
        {
            try
            {
                PicVi.ObtenerRutaImagen(); // abre el open file d
                pVIEWER.Image = Image.FromFile(PicVi.RutaImagen);
                ImagenAMostrar = PicVi.RutaImagen;
                this.Text = $"PicVi - {PicVi.RutaImagen}";

                PicVi.ObtenerTodasLasImagenes();
                IndiceActual = PicVi.ListaImagenes.IndexOf(PicVi.RutaImagen);                

            }
            catch { }
        }


        //
        // AJUSTAR TAMAÑO
        //
        bool TamOriginal = true;
        private void btTAMORI_Click(object sender, EventArgs e)
        {
            if (TamOriginal == true)
            {
                pVIEWER.SizeMode = PictureBoxSizeMode.CenterImage;
                TamOriginal = false;
            }
            else 
            {
                pVIEWER.SizeMode = PictureBoxSizeMode.Zoom;
                TamOriginal = true;
            }            
        }        

        // 
        // PASO DE IMAGENES
        //

        private void btSIGUIENTE_Click(object sender, EventArgs e)
        {
            try
            {                       
                ImagenAMostrar = PicVi.ListaImagenes[IndiceActual + 1];
                pVIEWER.Image = Image.FromFile(ImagenAMostrar);
                IndiceActual += 1;
                this.Text = $"PicVi - {ImagenAMostrar}";
            }
            catch { }
        }

        private void btANTERIOR_Click(object sender, EventArgs e)
        {
            try
            {                       
                ImagenAMostrar = PicVi.ListaImagenes[IndiceActual - 1];
                pVIEWER.Image = Image.FromFile(ImagenAMostrar);
                IndiceActual -= 1;
                this.Text = $"PicVi - {ImagenAMostrar}";
            }
            catch { }
        }

        private void MostrarImagenesDelList()
        {
            try
            {           
                pVIEWER.Image = Image.FromFile(ImagenAMostrar);
            }
            catch { }
        }

    }
}
