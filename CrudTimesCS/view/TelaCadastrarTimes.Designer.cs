
namespace CrudTimesCS.view
{
    partial class TelaCadastrarTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarTimes));
<<<<<<< HEAD
            this.lblTituloTimes = new System.Windows.Forms.Label();
            this.lblNomeTime = new System.Windows.Forms.Label();
            this.lblFraseTimes = new System.Windows.Forms.Label();
            this.tbxNomeTimes = new System.Windows.Forms.TextBox();
            this.tbxFraseTimes = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnCadastrarTimes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscarLogo = new System.Windows.Forms.Button();
            this.openFileDialogLogo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloTimes
            // 
            this.lblTituloTimes.AutoSize = true;
            this.lblTituloTimes.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloTimes.ForeColor = System.Drawing.Color.Tomato;
            this.lblTituloTimes.Location = new System.Drawing.Point(168, 27);
            this.lblTituloTimes.Name = "lblTituloTimes";
            this.lblTituloTimes.Size = new System.Drawing.Size(223, 30);
            this.lblTituloTimes.TabIndex = 0;
            this.lblTituloTimes.Text = "Cadastro de Times";
            // 
            // lblNomeTime
            // 
            this.lblNomeTime.AutoSize = true;
            this.lblNomeTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeTime.Location = new System.Drawing.Point(10, 70);
            this.lblNomeTime.Name = "lblNomeTime";
            this.lblNomeTime.Size = new System.Drawing.Size(38, 15);
            this.lblNomeTime.TabIndex = 1;
            this.lblNomeTime.Text = "Time:";
            // 
            // lblFraseTimes
            // 
            this.lblFraseTimes.AutoSize = true;
            this.lblFraseTimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFraseTimes.Location = new System.Drawing.Point(10, 134);
            this.lblFraseTimes.Name = "lblFraseTimes";
            this.lblFraseTimes.Size = new System.Drawing.Size(39, 15);
            this.lblFraseTimes.TabIndex = 2;
            this.lblFraseTimes.Text = "Frase:";
            // 
            // tbxNomeTimes
            // 
            this.tbxNomeTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeTimes.Location = new System.Drawing.Point(10, 88);
            this.tbxNomeTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNomeTimes.Name = "tbxNomeTimes";
            this.tbxNomeTimes.Size = new System.Drawing.Size(333, 32);
            this.tbxNomeTimes.TabIndex = 3;
            // 
            // tbxFraseTimes
            // 
            this.tbxFraseTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxFraseTimes.Location = new System.Drawing.Point(10, 151);
            this.tbxFraseTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFraseTimes.Name = "tbxFraseTimes";
            this.tbxFraseTimes.Size = new System.Drawing.Size(520, 32);
            this.tbxFraseTimes.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 203);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(158, 91);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnCadastrarTimes
            // 
            this.btnCadastrarTimes.Location = new System.Drawing.Point(371, 256);
            this.btnCadastrarTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarTimes.Name = "btnCadastrarTimes";
            this.btnCadastrarTimes.Size = new System.Drawing.Size(122, 38);
            this.btnCadastrarTimes.TabIndex = 6;
            this.btnCadastrarTimes.Text = "Cadastrar";
            this.btnCadastrarTimes.UseVisualStyleBackColor = true;
            this.btnCadastrarTimes.Click += new System.EventHandler(this.btnCadastrarTimes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscarLogo
            // 
            this.btnBuscarLogo.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarLogo.Location = new System.Drawing.Point(12, 299);
            this.btnBuscarLogo.Name = "btnBuscarLogo";
            this.btnBuscarLogo.Size = new System.Drawing.Size(156, 23);
            this.btnBuscarLogo.TabIndex = 8;
            this.btnBuscarLogo.Text = "Buscar Imagem";
            this.btnBuscarLogo.UseVisualStyleBackColor = true;
            this.btnBuscarLogo.Click += new System.EventHandler(this.btnBuscarLogo_Click);
            // 
            // TelaCadastrarTimes
            // 
            this.AcceptButton = this.btnCadastrarTimes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(561, 334);
            this.Controls.Add(this.btnBuscarLogo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCadastrarTimes);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.tbxFraseTimes);
            this.Controls.Add(this.tbxNomeTimes);
            this.Controls.Add(this.lblFraseTimes);
            this.Controls.Add(this.lblNomeTime);
            this.Controls.Add(this.lblTituloTimes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TelaCadastrarTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Jogos ";
            this.Load += new System.EventHandler(this.TelaCadastrarTimes_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaCadastrarTimes_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
=======
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNomeTimes = new System.Windows.Forms.TextBox();
            this.tbxFraseTimes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarTime = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro De Times";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frase:";
            // 
            // tbxNomeTimes
            // 
            this.tbxNomeTimes.Location = new System.Drawing.Point(74, 100);
            this.tbxNomeTimes.Name = "tbxNomeTimes";
            this.tbxNomeTimes.Size = new System.Drawing.Size(189, 23);
            this.tbxNomeTimes.TabIndex = 3;
            this.tbxNomeTimes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxFraseTimes
            // 
            this.tbxFraseTimes.Location = new System.Drawing.Point(88, 165);
            this.tbxFraseTimes.Name = "tbxFraseTimes";
            this.tbxFraseTimes.Size = new System.Drawing.Size(408, 23);
            this.tbxFraseTimes.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 134);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarTime
            // 
            this.btnCadastrarTime.Location = new System.Drawing.Point(419, 299);
            this.btnCadastrarTime.Name = "btnCadastrarTime";
            this.btnCadastrarTime.Size = new System.Drawing.Size(154, 77);
            this.btnCadastrarTime.TabIndex = 6;
            this.btnCadastrarTime.Text = "CADASTRAR";
            this.btnCadastrarTime.UseVisualStyleBackColor = true;
            this.btnCadastrarTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaCadastrarTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrarTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxFraseTimes);
            this.Controls.Add(this.tbxNomeTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TelaCadastrarTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gerenciamento de jogos";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaCadastrarTimes_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
>>>>>>> 52afeed9674513930bbcee5945d6c21a38b123c2
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Label lblTituloTimes;
        private System.Windows.Forms.Label lblNomeTime;
        private System.Windows.Forms.Label lblFraseTimes;
        private System.Windows.Forms.TextBox tbxNomeTimes;
        private System.Windows.Forms.TextBox tbxFraseTimes;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnCadastrarTimes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscarLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogo;
=======
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNomeTimes;
        private System.Windows.Forms.TextBox tbxFraseTimes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrarTime;
        private System.Windows.Forms.Button button1;
>>>>>>> 52afeed9674513930bbcee5945d6c21a38b123c2
    }
}