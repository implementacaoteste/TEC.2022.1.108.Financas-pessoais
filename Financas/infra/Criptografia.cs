using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace infra
{
    public class Criptografia
    {

        private RSA rsa;
        public Criptografia()
        {
            rsa = RSA.Create();
        }
        public void GerarChaves()
        {
            using(RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(GetPublicKey());
                byte[] chavePublicaBytes = rsa.ExportCspBlob(false);
                new Arquivo().GravarBytesNoFinalDoArquivo(Constantes.CaminhoChavePublica, chavePublicaBytes);
            }
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(GetPrivateKey());
                byte[] chavePrivadaBytes = rsa.ExportCspBlob(true);
                new Arquivo().GravarBytesNoFinalDoArquivo(Constantes.CaminhaChavePrivada, chavePrivadaBytes);
            }

        }
        public RSAParameters GetPublicKey()
        {
            return rsa.ExportParameters(false);
        }
        public RSAParameters GetPrivateKey()
        {
            return rsa.ExportParameters(true);
        }
        public string Criptografar(string _texto)
        {
            if (!File.Exists(Constantes.CaminhoChavePublica))
                throw new Exception("A chave Pública não existe") { Data = { { "Id", 4 } } };

            byte[] chavePublicaBytes = File.ReadAllBytes(Constantes.CaminhoChavePublica);
            RSAParameters chavePublica;
            using(RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportCspBlob(chavePublicaBytes);
                chavePublica = RSA.ExportParameters(false);
            }
            rsa.ImportParameters(chavePublica);
            byte[] bytesCriptografados = rsa.Encrypt(Encoding.UTF8.GetBytes(_texto), RSAEncryptionPadding.Pkcs1);
            return Convert.ToBase64String(bytesCriptografados); 
        }
         public string Descriptografar(string _texto)
        {
            if(!File.Exists(Constantes.CaminhaChavePrivada))
                throw new Exception("A chave privada não existe") { Data= { { "Id", 4 } } };
            byte[] chavePrivadaBytes = File.ReadAllBytes(Constantes.CaminhaChavePrivada);
            RSAParameters chavePrivada;
             using(RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportCspBlob(chavePrivadaBytes);
                chavePrivada = rsa.ExportParameters(true);
            }
             rsa.ImportParameters(chavePrivada);
            byte[] bytesCriptografados = Convert.FromBase64String(_texto);
            byte[] bytesDescriptografados = rsa.Decrypt(bytesCriptografados, RSAEncryptionPadding.Pkcs1);
            return Encoding.UTF8.GetString(bytesCriptografados);
        }

        public string CriptografarSenha(string _senha)
           
        {
            string retorno = _senha;
            for (int i = 0; i < _senha.Length;i++)
            {
                retorno = GerarHash(retorno);
                retorno = ReverterTexto(retorno);
                retorno = GerarHash(retorno);
                retorno = ReverterTexto(retorno);
            }
            return GerarHash(retorno);
        }


        private string GerarHash(string _texto)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedbytws = sha256.ComputeHash(Encoding.UTF8.GetBytes(_texto));
                return Convert.ToBase64String(hashedbytws);
            }

        }
        private string ReverterTexto(string _texto)
        {
            char[] charArray = _texto.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //wmKdvuWfY4e2P/EYguGYCbf/qc+vH6/f4VtX62USj+I=
    }
}
