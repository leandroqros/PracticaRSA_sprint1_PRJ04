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
        string fileContent;
        string filePath;

        private void btn_obtainKey_Click(object sender, EventArgs e)
        {
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
                tbx_pubkey.Font = new Font("Microsoft Sans Serif" , 11, FontStyle.Bold, GraphicsUnit.Point);
                tbx_pubkey.Text = crypt.archivoNoSeleccionado();
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

            byte[] cadenaEncripitada = crypt.Encrypt(filePath, dataToEncrypt);
            string textoEncriptado = crypt.byteToString(cadenaEncripitada);
            tbx_crypted.Text = textoEncriptado;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tbx_crypted.Text != null)
            {
                frmDesencriptar frm = new frmDesencriptar();
                CodifyToSend = tbx_crypted.Text;
                frm.cadena = CodifyToSend;
                frm.Show;
            }

        }
    }
}