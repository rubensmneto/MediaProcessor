using MediaProcessor.UI.Core;
using MediaProcessor.UI.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaProcessor.UI
{
    public partial class frmPrincipal : Form
    {

        private readonly List<IMediaFileProcessor> _processadores;

        public frmPrincipal()
        {

            InitializeComponent();

            var logger = Program.GetService<ILogger>();

            _processadores = new List<IMediaFileProcessor>
            {
                new Services.ImageProcessor(),
                new Services.VideoProcessor()
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ActiveControl = btnProcessar;

            txtOrigem.Text = "D:\\Users\\ruben\\OneDrive\\Imagens\\Galeria Samsung\\DCIM\\Camera";

            txtDestino.Text = "D:\\Processadas";

            if (Directory.Exists(txtDestino.Text)) return;

            Directory.CreateDirectory(txtDestino.Text);

        }

        private void btnPesquisarCaminhoOrigem_Click(object sender, EventArgs e)
        {

            var folderSelector = new FolderBrowserDialog();

            var result = folderSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtOrigem.Text = folderSelector.SelectedPath;
            }

        }

        private void btnPesquisarCaminhoDestino_Click(object sender, EventArgs e)
        {

            var folderSelector = new FolderBrowserDialog
            {
                SelectedPath = "D:\\Processadas"
            };

            var result = folderSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtDestino.Text = folderSelector.SelectedPath;
            }

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {

            var origem = txtOrigem.Text;

            var destino = txtDestino.Text;

            if (!ValidarCaminhos(origem, destino))
            {
                return;
            }

            outputWindow.Clear();

            InformarInicializacao();

            var tokenSource = new CancellationTokenSource();

            ProcessarArquivos(origem, destino, tokenSource.Token);

            InformarFinalizacao();

        }

        private void InformarInicializacao()
        {
            outputWindow.AppendLine("Iniciando");
        }

        private void InformarArquivoSendoProcessado(FileInfo arquivo)
        {
            outputWindow.AppendLine($"Processando arquivo '{arquivo.Name} '");
        }

        private void ProcessarArquivos(string origem, string destino, CancellationToken cancellationToken)
        {

            if (cbxLimparDestino.Checked)
            {
                LimparPastaDestino(destino);
            }

            var arquivosParaProcessamento = ObterArquivosParaProcessamento(origem);

            foreach (var arquivo in arquivosParaProcessamento)
            {

                if (cancellationToken.IsCancellationRequested) break;

                InformarArquivoSendoProcessado(arquivo);

                DialogResult dialogResult = DialogResult.OK;

                do
                {

                    Model.MediaFileProcessorResponse processingResponse = null;

                    var task = Task.Factory.StartNew(() =>
                    {
                        processingResponse = _processadores.First(p => p.ServiceLocation(arquivo.Extension)).Processar(arquivo, destino, cbxIgnorarSeJaExistir.Checked);
                    });

                    Task.WaitAll(task);

                    if (processingResponse == null)
                    {

                        dialogResult = MessageBox.Show(
                            $@"Houve um problema ao processar o arquivo de origem '{arquivo.Name}': Retorno nulo!?",
                            @"Ops...",
                            MessageBoxButtons.AbortRetryIgnore,
                            MessageBoxIcon.Error);

                        break;

                    }

                    if (processingResponse.Success)
                    {
                        outputWindow.AppendLine(processingResponse.Message);
                        break;
                    }

                    dialogResult = MessageBox.Show(
                        $@"Houve um problema ao processar o arquivo de origem '{arquivo.Name}': {processingResponse.Message}",
                        @"Ops...",
                        MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);

                } while (dialogResult == DialogResult.OK || dialogResult == DialogResult.Retry);

                if (dialogResult == DialogResult.Abort)
                {
                    break;
                }

            }

        }

        private bool ValidarCaminhos(string origem, string destino)
        {

            if (string.IsNullOrEmpty(origem))
            {
                MessageBox.Show(@"O caminho de origem não foi informado.", @"Origem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Directory.Exists(origem))
            {
                MessageBox.Show(@"O caminho de origem não existe.", @"Origem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(destino))
            {
                MessageBox.Show(@"O caminho de destino não foi informado.", @"Origem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Directory.Exists(destino))
            {
                MessageBox.Show(@"O caminho de destino não existe.", @"Origem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void LimparPastaDestino(string destino)
        {

            outputWindow.AppendLine("Removendo possível conteúdo da pasta destino.");

            DirectoryInfo directory = new DirectoryInfo(destino);

            try
            {
                directory.GetDirectories().ToList().ForEach(dir => dir.Delete(true));
            }
            catch (Exception)
            {
                //donothing
            }

            try
            {
                directory.GetFiles().ToList().ForEach(file => file.Delete());
            }
            catch (Exception)
            {
                //donothing
            }

            outputWindow.AppendLine("Processo de limpeza executado.");

        }

        private List<FileInfo> ObterArquivosParaProcessamento(string origem)
        {

            List<FileInfo> files = new List<FileInfo>();

            /*foreach (var directory in Directory.GetDirectories(origem))
            {
                files.AddRange(ObterArquivosParaProcessamento(directory));
            }*/

            files.AddRange(Directory.GetFiles(origem).Where(ArquivoPodeSerProcessado).Select(file => new FileInfo(file)));

            return files/*.Take(1000)*/.ToList();

        }

        private bool ArquivoPodeSerProcessado(string caminho)
        {

            var extension = Path.GetExtension(caminho);

            return _processadores.Any(p => p.ServiceLocation(extension));

        }

        private void InformarFinalizacao()
        {
            outputWindow.AppendLine(@"Finalizado");
        }

    }
}
