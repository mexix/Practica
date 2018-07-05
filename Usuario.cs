using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lavanderia
{
    public partial class Usuario : Form
    {
        ClienteTabla obje = new ClienteTabla();



        public Usuario()
        {
            InitializeComponent();
        }



        private void btnQR_Click(object sender, EventArgs e)
        {

            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            string valorQR = "Hola profe me gustaria que me sacara un 10";
            qrEncoder.TryEncode(valorQR, out qrCode);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(199, 199)));
            imgQR.BackgroundImage = imagen;
            imagen.Save("qr.png", ImageFormat.Png);



        }

        public static iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance("qr.png");









        private void btnPdf_Click(object sender, EventArgs e)
        {

            //Document document = new Document();
            //PdfWriter.GetInstance(document, new FileStream("pdf/prueba.pdf", FileMode.Create));
            //document.Open();
            //document.Add(new Paragraph("Hola Mundo"));
            //////P1.Alignment = Element.ALIGN_JUSTIFIED;
            //////document.Add(P1);
            //document.Close();

            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite,
                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                img.ScaleToFit(125f, 60F);
                doc.Add(img);

                string envio = "Fecha:" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("                                                                      ALUMNOS", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                img2.ScaleToFit(150f, 100F);
                img2.SetAbsolutePosition(0, 0);
                doc.Add(img2);
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph("Creado por Mariana y Edgar"));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                Generardocumento(doc);
                doc.AddCreationDate();
                doc.Add(new Paragraph("", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));



            doc.Close();
                Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }





        }

       

        public void Generardocumento(Document document)
        {
            //int i, j;
            string consulta = "select * from alumno";
            MySqlConnection conectar = Conexion.conexion();
            conectar.Open();
            MySqlCommand command = new MySqlCommand(consulta, conectar);
            MySqlDataReader reader = command.ExecuteReader();
            PdfPTable datatable = new PdfPTable(7);
            datatable.AddCell("matricula");
            datatable.AddCell("nombre_a");
            datatable.AddCell("apaterno");
            datatable.AddCell("amaterno");
            datatable.AddCell("grado_a");
            datatable.AddCell("sexo");
            datatable.AddCell("fecha_nacimiento");
            while (reader.Read())
            {
                datatable.AddCell(reader.GetString(0));
                datatable.AddCell(reader.GetString(1));
                datatable.AddCell(reader.GetString(2));
                datatable.AddCell(reader.GetString(3));
                datatable.AddCell(reader.GetString(4));
                datatable.AddCell(reader.GetString(5));
                datatable.AddCell(reader.GetString(6));
            }
            document.Add(datatable);
            //datatable.DefaultCell.Padding = 3;
            //float[] headerwidths = GetTamañoColumnas(dataGridView1);
            //datatable.SetWidths(headerwidths);
            //datatable.WidthPercentage = 100;
            //datatable.DefaultCell.BorderWidth = 2;
            //datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            //for (i = 0; i < dataGridView1.ColumnCount; i++)
            //{
            //    datatable.AddCell(dataGridView1.Columns[i].HeaderText);

        
            //}
            //datatable.HeaderRows = 1;
            //datatable.DefaultCell.BorderWidth = 1;
            //for (i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    for (j = 0; j < dataGridView1.Columns.Count; j++)
            //    {
            //        if (dataGridView1[j, i].Value != null)
            //        {
            //            datatable.AddCell(new Phrase(dataGridView1[j, i].Value.ToString()));
                        

            //        }
            //        datatable.CompleteRow();
            //    }
            //    document.Add(datatable);
            //}







        }

        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        public static iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("imag.png");
        

        private void CrearPDFConImagen()
        {
            try
            {
                Document doc = new Document(PageSize.LETTER.Rotate(), 10f, 10f, 10f, 0f);//Horizontal
                //Document Doc = new Document(PageSize.LETTER, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(doc
                    , new System.IO.FileStream(
                        System.IO.Directory.GetCurrentDirectory()
                        + "\\EjemploImagen" + Guid.NewGuid() + ".pdf",
                        System.IO.FileMode.Create));

                doc.Open();

                /*
                 Agego la imagen
                 */
                img.ScaleToFit(125f, 60F);
                doc.Add(img);


                // Le colocamos el título y el autor
                // **Nota: Esto no será visible en el documento
                doc.AddTitle("Reporte de ejemplo Con imagen");
                doc.AddCreator("Cristina Carrasco - cristina.carrasco.angulo@gmail.com");

                //Titulo del documento
                var parrafo = new Paragraph("Titulo del PDF");
                parrafo.SpacingBefore = 10;
                parrafo.SpacingAfter = 20;
                parrafo.Alignment = 1; //0-Left, 1 middle,2 Right
                doc.Add(parrafo);
                doc.Add(Chunk.NEWLINE);

                doc.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
        }





        private void Usuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obje.VistaTabla();
        }

     

        

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(fila.Cells[0].Value);
            textBox2.Text = Convert.ToString(fila.Cells[1].Value);
            textBox3.Text = Convert.ToString(fila.Cells[2].Value);
            textBox4.Text = Convert.ToString(fila.Cells[3].Value);
            textBox5.Text = Convert.ToString(fila.Cells[4].Value);
            textBox6.Text = Convert.ToString(fila.Cells[5].Value);
            textBox7.Text = Convert.ToString(fila.Cells[6].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.Rows.Count.ToString();
            if (obje.insertar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text))
            {
                MessageBox.Show("Datos insertados");
                dataGridView1.DataSource = obje.VistaTabla();
            }
            else MessageBox.Show("No se han podido insertar los datos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (obje.Eliminar(textBox2.Text))
            {
                MessageBox.Show("Datos eliminados");
                dataGridView1.DataSource = obje.VistaTabla();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (obje.Actualizar(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text))
            {
                MessageBox.Show("Datos actualizados");
                dataGridView1.DataSource = obje.VistaTabla();
            }
            else MessageBox.Show("No se han podido actualizar los datos");
        }
    }
}

        



