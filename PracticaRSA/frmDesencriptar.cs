using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRSA
{
    public partial class frmDesencriptar : Form
    {
        public frmDesencriptar()
        {
            InitializeComponent();
        }
        public string cadena { get; set; }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            CspParameters cspp = new CspParameters();
            //const string nomContainer = "Testemunha";
            string nomContainer = tbx_container.Text;

            cspp.KeyContainerName = nomContainer;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            string publicKey = rsa.ToXmlString(false);
            //string privateKey = rsa.ToXmlString(true);
            File.WriteAllText("c:\\carpetateste\\Publickey.xml", publicKey);

        }

        private void btn_routeXML_Click(object sender, EventArgs e)
        {
            string fileContent;
            string filePath;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader rd = new StreamReader(fileStream))
                    {
                        fileContent = rd.ReadToEnd();
                    }
                }
            }
        }



    }

}
