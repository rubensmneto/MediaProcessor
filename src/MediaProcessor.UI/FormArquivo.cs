using MediaProcessor.UI.Core;
using System;
using System.IO;
using System.Windows.Forms;

namespace MediaProcessor.UI
{
    public partial class FormArquivo : Form
    {

        private readonly string _filePath;
        private readonly IMediaFileProcessor _mediaFileProcessor;

        public FormArquivo(string filePath, IMediaFileProcessor processor)
        {
            InitializeComponent();
            _filePath = filePath;
            _mediaFileProcessor = processor;
        }

        private void FormArquivo_Load(object sender, EventArgs e)
        {

            lblNomeArquivo.Text = _filePath;

            var fileInfo = new FileInfo(_filePath);

            var dataArquivo = _mediaFileProcessor.ObterData(fileInfo);

            dtpHoraArquivo.Value = dtpDataArquivo.Value = dataArquivo;

        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;

            // buscando detalhes do arquivo original
            var fileInfo = new FileInfo(_filePath);

            // Criar nome do arquivo de backup
            var backupFileName = $"{_filePath}.bkp";

            try
            {
                // criando o arquivo de backup
                File.Copy(_filePath, backupFileName);
            }
            catch (Exception ex)
            {
                var retorno = MessageBox.Show($"Houve um erro ao criar o backup do arquivo: {ex.Message}\nDeseja prosseguir sem o backup?",
                                              "Erro",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (retorno != DialogResult.Yes)
                {
                    Cursor = Cursors.Default;
                    return;
                }

            }

            // definir nome do arquivo de destino
            var target = $"{fileInfo.Directory}\\{dtpDataArquivo.Value:yyyyMMdd_HHmmss}{fileInfo.Extension}";

            try
            {
                // renomear = move do velho pro novo
                File.Move(_filePath, target);
            }
            catch (Exception ex)
            {
                File.Delete(backupFileName);
                MessageBox.Show($"Erro ao ajustar o nome do arquivo: {ex.Message}",
                                "Ops!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }

            try
            {
                // setar dados do arquivo 
                _mediaFileProcessor.SetOriginalDate(target, dtpDataArquivo.Value);
            }
            catch (Exception ex)
            {
                File.Delete(target);
                File.Move(backupFileName, _filePath);
                MessageBox.Show($"Erro ao ajustar os metadados do arquivo: {ex.Message}",
                                "Ops!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }

            try
            {
                // remoção do arquivo de backup
                File.Delete(backupFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o arquivo de backup, porém o arquivo foi ajustado!\n{ex.Message}",
                                "Ops!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Close();
            }

            // notificação
            MessageBox.Show("Processado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // finalizando
            Close();

        }

        private void dtpHoraArquivo_ValueChanged(object sender, EventArgs e)
        {

            var hour = dtpHoraArquivo.Value.ToString("HH:mm:ss");

            var date = dtpDataArquivo.Value.ToString("yyyy-MM-dd");

            dtpDataArquivo.Value = Convert.ToDateTime($"{date} {hour}");

        }
    }
}
