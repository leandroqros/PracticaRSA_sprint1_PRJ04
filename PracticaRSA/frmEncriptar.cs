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
    public partial class frmEncriptar : Form
    {
        public frmEncriptar()
        {
            InitializeComponent();
        }

        Encriptacion crypt = new Encriptacion();
        private byte[] dataEncrypted;
        string fileContent, filePath;

        private void btn_obtainKey_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
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
                tbx_pubkey.Font = new Font("Microsoft Sans Serif" , 11, FontStyle.Bold, GraphicsUnit.Point);
                tbx_pubkey.Text = crypt.archivoNoSeleccionado();
            }
            else
            {
                tbx_pubkey.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point);
                tbx_pubkey.Text = fileContent;
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e) //ok
        {
            if (tbx_original.Text == "" || tbx_original.Text == "No hay nada que encriptar. Escriba algo diferente.")
            {
                tbx_original.Text = "No hay nada que encriptar. Escriba algo diferente.";
            }
            else
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                string textoUsuario = tbx_original.Text;
                byte[] dataToEncrypt = ByteConverter.GetBytes(textoUsuario);

                //using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                //{
                //    byte[] encryptedData = RSA.Encrypt(dataToEncrypt, false);
                //    byte[] decryptedData = RSA.Decrypt(encryptedData, false);

                //    //Console.WriteLine("Text: {0}", ByteConverter.GetString(decryptedData));
                //}

                dataEncrypted = crypt.Encrypt(filePath, dataToEncrypt);
                //string textoEncriptado = BitConverter.ToString(cadenaEncripitada);
                tbx_crypted.Text = BitConverter.ToString(dataEncrypted);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tbx_crypted.Text != null)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "frmDesencriptar")
                    {
                        frmDesencriptar formul = (frmDesencriptar)item;
                        //formul.Show();
                        formul.recibirByte = dataEncrypted;
                    }
                }
            }
        }
    }
}