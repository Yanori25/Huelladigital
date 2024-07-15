using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;


namespace HuellaMediweb
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrar frm = new FrmRegistrar();
            frm.ShowDialog();
        }

        private async void btnverificar_Click(object sender, EventArgs e)
        {
            Process.Start("https://localhost:7048/Usuario/Login?clave=mfunes&password=123456");
                  //  Process.Start("https://localhost:7048/Usuario/Login");
                  // await PostDataAsync();

                FrmVerificar frm = new FrmVerificar();
            frm.ShowDialog();

        }



        public async Task PostDataAsync()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("https://localhost:7048/Usuario/Login");

                var content = new StringContent(
                    "{ \"clave\": \"mfunes\", \"password\": \"123456\" }",
                    Encoding.UTF8,
                    "application/json");

                var response = await client.PostAsync(uri, content);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    // Procesa el resultado aquí...
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
         

        }
    }
}
