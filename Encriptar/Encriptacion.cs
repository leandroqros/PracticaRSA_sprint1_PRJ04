using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encriptar
{
    public class Encriptacion
    {
        private RSACryptoServiceProvider rsaEnc;
        //Funccion EncryptRSA
        private byte[] dataToEncryptRSA;
        private byte[] dataEncryptedRSA;
        //Funccion Encrypt
        private byte[] encryptedData;
        private byte[] DataToEncrypt;
        //Funccion Decrypt
        private byte[] decryptedData;
        private byte[] DataToDecrypt;

        public string EncryptRSA()
        {
            string salida;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                RSAParameters rsaParams = rsa.ExportParameters(false);
                byte[] encryptedData = RSAEncrypt(dataToEncryptRSA, rsaParams);
            }

            byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo)
            {
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKeyInfo);
                    dataEncryptedRSA = RSA.Encrypt(DataToEncrypt, false);
                }
                return dataEncryptedRSA;
            }
            salida = BitConverter.ToString(dataEncryptedRSA);
            return salida;
        }

        public void DecryptRSA()
        {

        }

        public byte[] Encrypt(string ruta,byte[] rutaByte)
        {
            rsaEnc = new RSACryptoServiceProvider();
            string xmlKey = File.ReadAllText(ruta);
            rsaEnc.FromXmlString(xmlKey);
            encryptedData = rsaEnc.Encrypt(rutaByte, false);

            return encryptedData;
        }

        public byte[] Decrypt(string container, byte[] rutaByte)
        {
            //string keyName = "Shakira";

            CspParameters cspp = new CspParameters();
            string keyName = container;
            cspp.KeyContainerName = keyName;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
            decryptedData = rsa.Decrypt(rutaByte, false);

            return decryptedData;
        }

        public string byteToString(byte[] cadenaByte)
        {
            Encoding ecode = Encoding.UTF8;
            string texto = ecode.GetString(cadenaByte);
            return texto;
        }

        public string archivoNoSeleccionado()
        {
            string mensaje = "No hay nigun archivo seleccionado, por favor siga esos pasos:\r\n " +
                       "1.Haga click en el boton 'Obtener clave'.\r\n " +
                       "2.Busque en tus archivos la clave publica en formato XML.\r\n " +
                       "3.Despues de seleccionada, haga click en abrir.\r\n " +
                       "4. Vuelva a hacer click en el boton 'Obtener Clave'";
            return mensaje;
        }
    }
}
