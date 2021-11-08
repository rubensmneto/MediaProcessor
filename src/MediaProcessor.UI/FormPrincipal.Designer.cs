
namespace MediaProcessor.UI
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxIgnorarSeJaExistir = new System.Windows.Forms.CheckBox();
            this.cbxLimparDestino = new System.Windows.Forms.CheckBox();
            this.btnPesquisarCaminhoDestino = new System.Windows.Forms.Button();
            this.btnPesquisarCaminhoOrigem = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.outputWindow = new System.Windows.Forms.RichTextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caminho de origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Caminho de destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(14, 139);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.PlaceholderText = "Caminho de destino";
            this.txtDestino.Size = new System.Drawing.Size(613, 27);
            this.txtDestino.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnArquivo);
            this.groupBox2.Controls.Add(this.cbxIgnorarSeJaExistir);
            this.groupBox2.Controls.Add(this.cbxLimparDestino);
            this.groupBox2.Controls.Add(this.btnPesquisarCaminhoDestino);
            this.groupBox2.Controls.Add(this.btnPesquisarCaminhoOrigem);
            this.groupBox2.Controls.Add(this.btnProcessar);
            this.groupBox2.Controls.Add(this.outputWindow);
            this.groupBox2.Controls.Add(this.txtDestino);
            this.groupBox2.Controls.Add(this.txtOrigem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(827, 948);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações";
            // 
            // cbxIgnorarSeJaExistir
            // 
            this.cbxIgnorarSeJaExistir.AutoSize = true;
            this.cbxIgnorarSeJaExistir.Checked = true;
            this.cbxIgnorarSeJaExistir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIgnorarSeJaExistir.Location = new System.Drawing.Point(142, 181);
            this.cbxIgnorarSeJaExistir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxIgnorarSeJaExistir.Name = "cbxIgnorarSeJaExistir";
            this.cbxIgnorarSeJaExistir.Size = new System.Drawing.Size(230, 24);
            this.cbxIgnorarSeJaExistir.TabIndex = 13;
            this.cbxIgnorarSeJaExistir.Text = "Ignorar se já existir no destino";
            this.cbxIgnorarSeJaExistir.UseVisualStyleBackColor = true;
            // 
            // cbxLimparDestino
            // 
            this.cbxLimparDestino.AutoSize = true;
            this.cbxLimparDestino.Location = new System.Drawing.Point(15, 181);
            this.cbxLimparDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxLimparDestino.Name = "cbxLimparDestino";
            this.cbxLimparDestino.Size = new System.Drawing.Size(130, 24);
            this.cbxLimparDestino.TabIndex = 12;
            this.cbxLimparDestino.Text = "Limpar destino";
            this.cbxLimparDestino.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarCaminhoDestino
            // 
            this.btnPesquisarCaminhoDestino.Location = new System.Drawing.Point(635, 139);
            this.btnPesquisarCaminhoDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisarCaminhoDestino.Name = "btnPesquisarCaminhoDestino";
            this.btnPesquisarCaminhoDestino.Size = new System.Drawing.Size(86, 31);
            this.btnPesquisarCaminhoDestino.TabIndex = 11;
            this.btnPesquisarCaminhoDestino.Text = "Pesquisar";
            this.btnPesquisarCaminhoDestino.UseVisualStyleBackColor = true;
            this.btnPesquisarCaminhoDestino.Click += new System.EventHandler(this.btnPesquisarCaminhoDestino_Click);
            // 
            // btnPesquisarCaminhoOrigem
            // 
            this.btnPesquisarCaminhoOrigem.Location = new System.Drawing.Point(635, 73);
            this.btnPesquisarCaminhoOrigem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisarCaminhoOrigem.Name = "btnPesquisarCaminhoOrigem";
            this.btnPesquisarCaminhoOrigem.Size = new System.Drawing.Size(86, 31);
            this.btnPesquisarCaminhoOrigem.TabIndex = 10;
            this.btnPesquisarCaminhoOrigem.Text = "Pesquisar";
            this.btnPesquisarCaminhoOrigem.UseVisualStyleBackColor = true;
            this.btnPesquisarCaminhoOrigem.Click += new System.EventHandler(this.btnPesquisarCaminhoOrigem_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(14, 215);
            this.btnProcessar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(86, 31);
            this.btnProcessar.TabIndex = 9;
            this.btnProcessar.Text = "&Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // outputWindow
            // 
            this.outputWindow.BackColor = System.Drawing.SystemColors.Desktop;
            this.outputWindow.ForeColor = System.Drawing.Color.Yellow;
            this.outputWindow.HideSelection = false;
            this.outputWindow.Location = new System.Drawing.Point(14, 267);
            this.outputWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.ReadOnly = true;
            this.outputWindow.Size = new System.Drawing.Size(803, 664);
            this.outputWindow.TabIndex = 8;
            this.outputWindow.Text = "";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(14, 73);
            this.txtOrigem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.PlaceholderText = "Caminho de origem";
            this.txtOrigem.Size = new System.Drawing.Size(613, 27);
            this.txtOrigem.TabIndex = 5;
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(107, 215);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(94, 29);
            this.btnArquivo.TabIndex = 14;
            this.btnArquivo.Text = "&Arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 948);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processador de Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisarCaminhoOrigem;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.RichTextBox outputWindow;
        private System.Windows.Forms.Button btnPesquisarCaminhoDestino;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.CheckBox cbxLimparDestino;
        private System.Windows.Forms.CheckBox cbxIgnorarSeJaExistir;
        private System.Windows.Forms.Button btnArquivo;
    }
}

