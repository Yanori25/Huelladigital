using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HuellaMediweb
{
	/* NOTE: This form is a base for the EnrollmentForm and the VerificationForm,
		All changes in the CaptureForm will be reflected in all its derived forms.
	*/
	public partial class CaptureForm : Form, DPFP.Capture.EventHandler
	{
		public CaptureForm()
		{
			InitializeComponent();
		}

		protected virtual void Init()
		{
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if ( null != Capturer )
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    SetPrompt("No puede iniciarse la operacion de captura!");
            }
            catch
            {               
                MessageBox.Show("No puede iniciarse la operacion de captura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
		}

		protected virtual void Process(DPFP.Sample Sample)
		{
			// Draw fingerprint sample image.
			DrawPicture(ConvertSampleToBitmap(Sample));
		}

		protected void Start()
		{
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Usando el ledctor de huella, escaneando sus huellas.");
                }
                catch
                {
                    SetPrompt("No se puede iniciar la captura!");
                }
            }
		}

		protected void Stop()
		{
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("No se pudo terminar la captura!");
                }
            }
		}
		
	#region Form Event Handlers:

		private void CaptureForm_Load(object sender, EventArgs e)
		{
			Init();
			Start();												// Start capture operation.
		}

		private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Stop();
		}
	#endregion

	#region EventHandler Members:

		public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
		{
			MakeReport("La HUella del usuario fue tomada.");
			SetPrompt("escane la misma huella otra vez.");
			Process(Sample);
		}

		public void OnFingerGone(object Capture, string ReaderSerialNumber)
		{
			MakeReport("el dedo fue removido del lector de huella.");
		}

		public void OnFingerTouch(object Capture, string ReaderSerialNumber)
		{
			MakeReport("El lector de huella fue tocado.");
		}

		public void OnReaderConnect(object Capture, string ReaderSerialNumber)
		{
			MakeReport("El detector de huella esta conectado.");
		}

		public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
		{
			MakeReport("\"El detector de huella esta desconectado.");
		}

		public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
		{
			if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
				MakeReport("la calidad de la huella es buena.");
			else
				MakeReport("la calidad de la huella es pobre.");
		}
	#endregion

		protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
		{
			DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();	// Create a sample convertor.
			Bitmap bitmap = null;												            // TODO: the size doesn't matter
			Convertor.ConvertToPicture(Sample, ref bitmap);									// TODO: return bitmap as a result
			return bitmap;
		}

		protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
		{
			DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();	// Create a feature extractor
			DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
			DPFP.FeatureSet features = new DPFP.FeatureSet();
			Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);			// TODO: return features as a result?
			if (feedback == DPFP.Capture.CaptureFeedback.Good)
				return features;
			else
				return null;
		}

        protected void SetStatus(string status)
        {
            this.Invoke(new Action(delegate () {
                StatusLine.Text = status;
            }));
        }
		

  //      protected void SetStatus(string status)
		//{
		//	this.Invoke(new Function(delegate() {
		//		StatusLine.Text = status;
		//	}));
		//}

		protected void SetPrompt(string prompt)
		{
			this.Invoke(new Action /*Function*/(delegate() {
				Prompt.Text = prompt;
			}));
		}
		protected void MakeReport(string message)
		{
			this.Invoke(new Action /*Function*/(delegate() {
				StatusText.AppendText(message + "\r\n");
			}));
		}

		private void DrawPicture(Bitmap bitmap)
		{
			this.Invoke(new Action  /*Function*/(delegate() {
				Picture.Image = new Bitmap(bitmap, Picture.Size);	// fit the image into the picture box
			}));
		}

		private DPFP.Capture.Capture Capturer;

	}
}