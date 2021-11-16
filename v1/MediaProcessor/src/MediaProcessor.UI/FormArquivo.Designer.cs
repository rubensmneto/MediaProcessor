
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArquivo));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.btnCorrigir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDataArquivo = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraArquivo = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(234, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo selecionado:";
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Location = new System.Drawing.Point(272, 575);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(50, 20);
            this.lblNomeArquivo.TabIndex = 1;
            this.lblNomeArquivo.Text = "label2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCorrigir, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 254);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.txtNomeArquivo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelecionarArquivo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(643, 38);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNomeArquivo.Enabled = false;
            this.txtNomeArquivo.Location = new System.Drawing.Point(3, 7);
            this.txtNomeArquivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.PlaceholderText = "Selecione o arquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(533, 27);
            this.txtNomeArquivo.TabIndex = 10;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.AutoSize = true;
            this.btnSelecionarArquivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelecionarArquivo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelecionarArquivo.Image = global::MediaProcessor.UI.Properties.Resources.searching;
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(542, 4);
            this.btnSelecionarArquivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(98, 30);
            this.btnSelecionarArquivo.TabIndex = 8;
            this.btnSelecionarArquivo.Text = "Procurar";
            this.btnSelecionarArquivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCorrigir.Enabled = false;
            this.btnCorrigir.Image = global::MediaProcessor.UI.Properties.Resources.diskette;
            this.btnCorrigir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCorrigir.Location = new System.Drawing.Point(13, 178);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(643, 59);
            this.btnCorrigir.TabIndex = 4;
            this.btnCorrigir.Text = "&Alterar";
            this.btnCorrigir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCorrigir.UseVisualStyleBackColor = true;
            this.btnCorrigir.Click += new System.EventHandler(this.btnCorrigir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Selecione o arquivo para processamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data do arquivo:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.dtpDataArquivo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpHoraArquivo, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 117);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(264, 35);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // dtpDataArquivo
            // 
            this.dtpDataArquivo.CustomFormat = "dd/MM/yyyy";
            this.dtpDataArquivo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataArquivo.Location = new System.Drawing.Point(3, 4);
            this.dtpDataArquivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDataArquivo.Name = "dtpDataArquivo";
            this.dtpDataArquivo.Size = new System.Drawing.Size(161, 27);
            this.dtpDataArquivo.TabIndex = 6;
            // 
            // dtpHoraArquivo
            // 
            this.dtpHoraArquivo.CustomFormat = "HH:mm:ss";
            this.dtpHoraArquivo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraArquivo.Location = new System.Drawing.Point(170, 4);
            this.dtpHoraArquivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHoraArquivo.Name = "dtpHoraArquivo";
            this.dtpHoraArquivo.Size = new System.Drawing.Size(91, 27);
            this.dtpHoraArquivo.TabIndex = 7;
            // 
            // FormArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 254);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processamento Unitário - MediaProcessor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dtpDataArquivo;
        private System.Windows.Forms.DateTimePicker dtpHoraArquivo;
    }
}