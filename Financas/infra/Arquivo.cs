using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infra
{
    public class Arquivo
    {
        public void GravarLinhaNoFinalDoArquivo(string _arquivo, string _texto)
        {
			try
			{
				using(StreamWriter arquivo = File.AppendText(_arquivo))
				{
					arquivo.WriteLine(_texto);	
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Ocorreu um erro ao tentar gravar linha no final do arquivo", ex);// { Data = { { "Id" } } };
			}
        }
		public void ExcluirArquivo(string _arquivo)
		{
			if (File.Exists(_arquivo))
				File.Delete(_arquivo);
		}

        public void GravarBytesNoFinalDoArquivo(string caminhoArquivo, byte[] _bytes)
		{
			ExcluirArquivo(caminhoArquivo);

			using(FileStream arquivo = new FileStream(caminhoArquivo, FileMode.Append))
			{
				if (!File.Exists(caminhoArquivo))
				{
					byte[] novaLinhaBytes = Encoding.UTF8.GetBytes(Environment.NewLine);
					arquivo.Write(novaLinhaBytes, 0, novaLinhaBytes.Length);
				}

				arquivo.Write(_bytes, 0, _bytes.Length);
			}
		}
    }
}
