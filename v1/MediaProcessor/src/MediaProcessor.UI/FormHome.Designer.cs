
namespace MediaProcessor.UI
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcessamentoUnico = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProcessamentoMultiplo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::MediaProcessor.UI.Properties.Resources.save_png;
            this.pictureBox1.InitialImage = global::MediaProcessor.UI.Properties.Resources.save_png;
            this.pictureBox1.Location = new System.Drawing.Point(152, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Media Processor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcessamentoUnico
            // 
            this.btnProcessamentoUnico.Image = global::MediaProcessor.UI.Properties.Resources.gallery_one_item;
            this.btnProcessamentoUnico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessamentoUnico.Location = new System.Drawing.Point(3, 4);
            this.btnProcessamentoUnico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProcessamentoUnico.Name = "btnProcessamentoUnico";
            this.btnProcessamentoUnico.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnProcessamentoUnico.Size = new System.Drawing.Size(362, 56);
            this.btnProcessamentoUnico.TabIndex = 2;
            this.btnProcessamentoUnico.Text = "Processamento Ú&nico";
            this.btnProcessamentoUnico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessamentoUnico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcessamentoUnico.UseVisualStyleBackColor = true;
            this.btnProcessamentoUnico.Click += new System.EventHandler(this.btnProcessamentoUnico_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnProcessamentoUnico);
            this.flowLayoutPanel1.Controls.Add(this.btnProcessamentoMultiplo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 312);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 131);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnProcessamentoMultiplo
            // 
            this.btnProcessamentoMultiplo.Image = global::MediaProcessor.UI.Properties.Resources.gallery_multiple_itens;
            this.btnProcessamentoMultiplo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessamentoMultiplo.Location = new System.Drawing.Point(3, 68);
            this.btnProcessamentoMultiplo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProcessamentoMultiplo.Name = "btnProcessamentoMultiplo";
            this.btnProcessamentoMultiplo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProcessamentoMultiplo.Size = new System.Drawing.Size(362, 56);
            this.btnProcessamentoMultiplo.TabIndex = 3;
            this.btnProcessamentoMultiplo.Text = "Processamento &Multiplo";
            this.btnProcessamentoMultiplo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessamentoMultiplo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcessamentoMultiplo.UseVisualStyleBackColor = true;
            this.btnProcessamentoMultiplo.Click += new System.EventHandler(this.btnProcessamentoMultiplo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Alpha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - Media Processor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcessamentoUnico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnProcessamentoMultiplo;
        private System.Windows.Forms.Label label2;
    }
}