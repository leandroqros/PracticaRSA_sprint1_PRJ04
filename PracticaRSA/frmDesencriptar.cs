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
using Encriptar;

namespace PracticaRSA
{
    public partial class frmDesencriptar : Form
    {
        public frmDesencriptar()
        {
            InitializeComponent();
        }

        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        Encriptacion crypt = new Encriptacion();
        private byte[] myVar;
        string container;

        private void btn_generate_Click(object sender, EventArgs e)
        {
            CspParameters cspp = new CspParameters();
            //string nomContainer = "Shakira";
            string nomContainer = tbx_container.Text;
            container = nomContainer;

            cspp.KeyContainerName = nomContainer;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            string publicKey = rsa.ToXmlString(false);
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
                    tbx_routeXML.Text = filePath;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader rd = new StreamReader(fileStream))
                    {
                        fileContent = rd.ReadToEnd();
                    }
                }
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            byte[] hola = crypt.Decrypt(container, recibirByte);

            tbx_decrypted.Text = ByteConverter.GetString(hola);
        }

        //Propiedad
        public byte[] recibirByte
        {
            get { return myVar; }
            set { myVar = value;
                //convertir el texto
            tbx_crypted.Text = BitConverter.ToString(myVar);
            }
        }
    }

}
