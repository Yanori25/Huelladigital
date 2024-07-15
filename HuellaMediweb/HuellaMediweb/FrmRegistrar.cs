using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellaMediweb
{
    public partial class FrmRegistrar : Form
    {

        private DPFP.Template Template;
        private mediwebEntities contexto; 

        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void btnhuella_Click(object sender, EventArgs e)
        {
            FrmCapturarHuella frm = new FrmCapturarHuella();
            frm.OnTemplate += this.OnTemplate;

            frm.ShowDialog();

        }


        public void OnTemplate(DPFP.Template template)
        {

            this.Invoke(new Action(delegate () {
                Template = template;
                btnagregar.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("la huella esta lista para verificar");
                    txthuella.Text = "Huella capturada corectamente";
                }
                else
                {
                    MessageBox.Show("la huella no es valida");
                }
            }));

            //Template = template;
            //btnagregar.Enabled = (Template != null);
            //if (Template != null) {
            //    MessageBox.Show("la huella esta lista para verificar");
            //    txthuella.Text = "Huella capturada corectamente";


            //}
            //else
            //{
            //    MessageBox.Show("la huella no es valida");

            //}
        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {
            contexto = new mediwebEntities();
            Listar();


        }
        private void limpiar()
        {
            txtnombre.Text = "";

        }

        private void Listar()
        {
            try
            {
                var huellas = from hue in contexto.usuarioHuellas
                              select new
                              {
                                  ID = hue.id,
                                  usuarioid = hue.usuarioid

                              };
                              if(huellas != null)
                {
                    dgvhuellas.DataSource = huellas.ToList();
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        //      public long id { get; set; }
        //public Nullable<long> usuarioid { get; set; }
        //public byte[] huella { get; set; }
        //public string estado { get; set; }

            try
            {
                byte[] streamHuella = Template.Bytes;
                usuarioHuella huella = new usuarioHuella()
                {
                    usuarioid = Convert.ToInt64(txtnombre.Text),
                    huella = streamHuella, 
                    estado = "REGISTRADO"


                };
                contexto.usuarioHuellas.Add(huella);
                contexto.SaveChanges();
                MessageBox.Show("Registro Agregado a la BD Exitosamente");
                limpiar();
                Listar();
                Template = null;
                btnagregar.Enabled = false;



            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
