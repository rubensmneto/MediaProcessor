
namespace MediaProcessor.UI
{
    partial class FormArquivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCorrigir = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.dtpDataArquivo = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraArquivo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo selecionado:";
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Location = new System.Drawing.Point(11, 28);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(38, 15);
            this.lblNomeArquivo.TabIndex = 1;
            this.lblNomeArquivo.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data do arquivo:";
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.Location = new System.Drawing.Point(11, 109);
            this.btnCorrigir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(136, 22);
            this.btnCorrigir.TabIndex = 4;
            this.btnCorrigir.Text = "&Corrigir Atual";
            this.btnCorrigir.UseVisualStyleBackColor = true;
            this.btnCorrigir.Click += new System.EventHandler(this.btnCorrigir_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(174, 109);
            this.btnCopiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(136, 22);
            this.btnCopiar.TabIndex = 5;
            this.btnCopiar.Text = "&Salvar Como";
            this.btnCopiar.UseVisualStyleBackColor = true;
            // 
            // dtpDataArquivo
            // 
            this.dtpDataArquivo.CustomFormat = "dd/MM/yyyy";
            this.dtpDataArquivo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataArquivo.Location = new System.Drawing.Point(12, 73);
            this.dtpDataArquivo.Name = "dtpDataArquivo";
            this.dtpDataArquivo.Size = new System.Drawing.Size(141, 23);
            this.dtpDataArquivo.TabIndex = 6;
            // 
            // dtpHoraArquivo
            // 
            this.dtpHoraArquivo.CustomFormat = "HH:mm:ss";
            this.dtpHoraArquivo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraArquivo.Location = new System.Drawing.Point(159, 73);
            this.dtpHoraArquivo.Name = "dtpHoraArquivo";
            this.dtpHoraArquivo.Size = new System.Drawing.Size(80, 23);
            this.dtpHoraArquivo.TabIndex = 7;
            this.dtpHoraArquivo.ValueChanged += new System.EventHandler(this.dtpHoraArquivo_ValueChanged);
            // 
            // FormArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 155);
            this.Controls.Add(this.dtpHoraArquivo);
            this.Controls.Add(this.dtpDataArquivo);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnCorrigir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArquivo";
            this.Load += new System.EventHandler(this.FormArquivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.DateTimePicker dtpDataArquivo;
        private System.Windows.Forms.DateTimePicker dtpHoraArquivo;
    }
}