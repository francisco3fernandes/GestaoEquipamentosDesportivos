using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GestaoEquipamentosDesportivos.Models;

namespace GestaoEquipamentosDesportivos.TextFiles
{
    public static class FileHelper
    {
        private static readonly string basePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFiles");

        static FileHelper()
        {
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);
        }

        public static void GuardarEquipamentos(List<EquipamentoModel> equipamentos)
        {
            string ficheiro = Path.Combine(basePath, "equipamentos.txt");

            using StreamWriter writer = new StreamWriter(ficheiro, false);
            foreach (var e in equipamentos)
            {
                writer.WriteLine(
                    $"{e.IdEquipamento};{e.Nome};{e.Tipo};{e.Estado};{e.DataAquisicao:yyyy-MM-dd}");
            }
        }

        public static void GuardarModalidades(List<ModalidadeModel> modalidades)
        {
            string ficheiro = Path.Combine(basePath, "modalidades.txt");

            using StreamWriter writer = new StreamWriter(ficheiro, false);
            foreach (var m in modalidades)
            {
                writer.WriteLine(
                    $"{m.IdModalidade};{m.Nome};{m.Descricao}");
            }
        }
    }
}
