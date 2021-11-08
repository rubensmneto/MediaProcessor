
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
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caminho de origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Caminho de destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(12, 104);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.PlaceholderText = "Caminho de destino";
            this.txtDestino.Size = new System.Drawing.Size(537, 23);
            this.txtDestino.TabIndex = 7;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 711);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações";
            // 
            // cbxIgnorarSeJaExistir
            // 
            this.cbxIgnorarSeJaExistir.AutoSize = true;
            this.cbxIgnorarSeJaExistir.Checked = true;
            this.cbxIgnorarSeJaExistir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIgnorarSeJaExistir.Location = new System.Drawing.Point(124, 136);
            this.cbxIgnorarSeJaExistir.Name = "cbxIgnorarSeJaExistir";
            this.cbxIgnorarSeJaExistir.Size = new System.Drawing.Size(183, 19);
            this.cbxIgnorarSeJaExistir.TabIndex = 13;
            this.cbxIgnorarSeJaExistir.Text = "Ignorar se já existir no destino";
            this.cbxIgnorarSeJaExistir.UseVisualStyleBackColor = true;
            // 
            // cbxLimparDestino
            // 
            this.cbxLimparDestino.AutoSize = true;
            this.cbxLimparDestino.Location = new System.Drawing.Point(13, 136);
            this.cbxLimparDestino.Name = "cbxLimparDestino";
            this.cbxLimparDestino.Size = new System.Drawing.Size(105, 19);
            this.cbxLimparDestino.TabIndex = 12;
            this.cbxLimparDestino.Text = "Limpar destino";
            this.cbxLimparDestino.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarCaminhoDestino
            // 
            this.btnPesquisarCaminhoDestino.Location = new System.Drawing.Point(556, 104);
            this.btnPesquisarCaminhoDestino.Name = "btnPesquisarCaminhoDestino";
            this.btnPesquisarCaminhoDestino.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCaminhoDestino.TabIndex = 11;
            this.btnPesquisarCaminhoDestino.Text = "Pesquisar";
            this.btnPesquisarCaminhoDestino.UseVisualStyleBackColor = true;
            this.btnPesquisarCaminhoDestino.Click += new System.EventHandler(this.btnPesquisarCaminhoDestino_Click);
            // 
            // btnPesquisarCaminhoOrigem
            // 
            this.btnPesquisarCaminhoOrigem.Location = new System.Drawing.Point(556, 55);
            this.btnPesquisarCaminhoOrigem.Name = "btnPesquisarCaminhoOrigem";
            this.btnPesquisarCaminhoOrigem.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCaminhoOrigem.TabIndex = 10;
            this.btnPesquisarCaminhoOrigem.Text = "Pesquisar";
            this.btnPesquisarCaminhoOrigem.UseVisualStyleBackColor = true;
            this.btnPesquisarCaminhoOrigem.Click += new System.EventHandler(this.btnPesquisarCaminhoOrigem_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(12, 161);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
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
            this.outputWindow.Location = new System.Drawing.Point(12, 200);
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.ReadOnly = true;
            this.outputWindow.Size = new System.Drawing.Size(703, 499);
            this.outputWindow.TabIndex = 8;
            this.outputWindow.Text = "";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(12, 55);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.PlaceholderText = "Caminho de origem";
            this.txtOrigem.Size = new System.Drawing.Size(537, 23);
            this.txtOrigem.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 711);
            this.Controls.Add(this.groupBox2);
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
    }
}

