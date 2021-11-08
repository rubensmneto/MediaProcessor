using MediaProcessor.UI.Core;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MediaProcessor.UI
{
    public partial class FormArquivo : Form
    {

        private FileInfo _fileInfo;

        private IMediaFileProcessor _mediaFileProcessor;

        public FormArquivo()
        {
            InitializeComponent();
        }

        private bool SelecionarArquivo()
        {

            var fileDialog = new OpenFileDialog
            {
                Title = "Selecione o arquivo",
                Multiselect = false,
                CheckFileExists = true
            };

            if (DialogResult.OK != fileDialog.ShowDialog() ||
                string.IsNullOrEmpty(fileDialog.FileName))
            {
                MessageBox.Show("Não foi possível obter o arquivo", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _fileInfo = new FileInfo(fileDialog.FileName);

            return true;

        }

        private bool SelecionarProcessador()
        {

            var processadores = new IMediaFileProcessor[]
            {
                new Services.ImageProcessor(),
                new Services.VideoProcessor()
            };

            _mediaFileProcessor = processadores.FirstOrDefault(processador => processador.ServiceLocation(_fileInfo.Extension));

            if (_mediaFileProcessor == null)
            {
                MessageBox.Show($"Não foi possível obter o processador para arquivos com a extensão {_fileInfo.Extension}", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {

            if (!SelecionarProcessador())
            {
                MessageBox.Show($"Não foi possível encontrar um processador para o arquivo do tipo {_fileInfo.Extension}",
                                "Ops",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;

            // Criar nome do arquivo de backup
            var backupFileName = $"{_fileInfo.FullName}.bkp";

            try
            {
                // criando o arquivo de backup
                File.Copy(_fileInfo.FullName, backupFileName);
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
            var target = $"{_fileInfo.Directory}\\{dtpDataArquivo.Value:yyyyMMdd_HHmmss}{_fileInfo.Extension}";

            try
            {
                // renomear = move do velho pro novo
                File.Move(_fileInfo.FullName, target);
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
                File.Move(backupFileName, _fileInfo.FullName);
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

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {

            if (!SelecionarArquivo())
            {
                btnCorrigir.Enabled = false;
            }

            txtNomeArquivo.Text = _fileInfo.FullName;

            btnCorrigir.Enabled = true;

        }
    }
}
