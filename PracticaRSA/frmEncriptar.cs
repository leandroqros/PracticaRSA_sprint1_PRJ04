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
    public partial class frmEncriptar : Form
    {
        public frmEncriptar()
        {
            InitializeComponent();
        }
        string fileContent;

        private void btn_obtainKey_Click(object sender, EventArgs e)
        {
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



        private void btn_showKey_Click(object sender, EventArgs e)
        {
            //Si no hay xml seleccionado
            if (fileContent == null)
            {
                tbx_pubkey.Font = new Font("Microsoft Sans Serif" , 13, FontStyle.Bold, GraphicsUnit.Point);
                tbx_pubkey.Text = "No hay nigun archivo seleccionado, por favor, haga click en el boton 'Obtener clave' y busque su clave publica en formato .XML";
            }
            else
            {
                tbx_pubkey.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point);
                tbx_pubkey.Text = fileContent;
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            string textoUsuario = tbx_original.Text;
            byte[] dataToEncrypt = ByteConverter.GetBytes(textoUsuario);

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                byte[] encryptedData = RSA.Encrypt(dataToEncrypt, false);
                byte[] decryptedData = RSA.Decrypt(encryptedData, false);

                Console.WriteLine("Text: {0}", ByteConverter.GetString(decryptedData));
            }


            //using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            //{
            //    RSAParameters rsaParams = rsa.ExportParameters(false);
            //    encryptedData = RSAEncrypt(dataToEncrypt, rsaParams);
            //}

            //public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo)

            //{
            //    using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            //    {
            //        RSA.ImportParameters(RSAKeyInfo);
            //        byte[] dataEncrypted = RSA.Encrypt(DataToEncrypt, false);
            //    }
            //    return dataEncrypted;
            //}
        }
    }
}
