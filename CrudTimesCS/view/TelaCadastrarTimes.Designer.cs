
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
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNomeTimes;
        private System.Windows.Forms.TextBox tbxFraseTimes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrarTime;
        private System.Windows.Forms.Button button1;
    }
}