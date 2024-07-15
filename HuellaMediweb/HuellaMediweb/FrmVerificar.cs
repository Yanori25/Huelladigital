using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellaMediweb
{
    public partial class FrmVerificar : CaptureForm
    {

        private  DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private mediwebEntities contexto; 

        public void verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();

        }


        protected override void Init()
        {
            base.Init();
            base.Text = "Verificacion de Huella digital";
            Verificator = new DPFP.Verification.Verification();
            UpdateStatus(0);


        }

        private void UpdateStatus(int FAR)
        {
            // Show number of samples needed.
            SetStatus(String.Format("Acepta radio falso: {0}", FAR));
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and add to enroller if it's good
            if (features != null) 
                {

                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    DPFP.Template template = new DPFP.Template();
                    Stream stream;

                    foreach(var emp in contexto.usuarioHuellas )
                    {
                        stream = new MemoryStream(emp.huella);
                        template = new DPFP.Template(stream);

                        Verificator.Verify(features, template, ref result);
                        UpdateStatus(result.FARAchieved);
                        if(result.Verified)
                        {
                            MakeReport("La huealla fue verificada. Del codigo del empleado: "+ emp.usuarioid);
                            break;

                        }


                    }
                }
              
        }




        public FrmVerificar()
        {
            contexto = new mediwebEntities();
            InitializeComponent();
        }

        private void FrmVerificar_Load(object sender, EventArgs e)
        {

        }
    }
}
