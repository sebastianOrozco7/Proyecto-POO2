namespace CajeroAutomatico.VISTA
{
    partial class OpcionesUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesUsuarioForm));
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnConsultarSaldo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblSaldoDisponible = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.btnDepositar);
            this.grpOpciones.Controls.Add(this.btnRetirar);
            this.grpOpciones.Controls.Add(this.btnConsultarSaldo);
            this.grpOpciones.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpciones.Location = new System.Drawing.Point(28, 33);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(191, 374);
            this.grpOpciones.TabIndex = 0;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "OPCIONES";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(35, 228);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(88, 34);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Deposito";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(35, 149);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(88, 35);
            this.btnRetirar.TabIndex = 0;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnConsultarSaldo
            // 
            this.btnConsultarSaldo.Location = new System.Drawing.Point(18, 74);
            this.btnConsultarSaldo.Name = "btnConsultarSaldo";
            this.btnConsultarSaldo.Size = new System.Drawing.Size(135, 33);
            this.btnConsultarSaldo.TabIndex = 0;
            this.btnConsultarSaldo.Text = "Consultar saldo";
            this.btnConsultarSaldo.UseVisualStyleBackColor = true;
            this.btnConsultarSaldo.Click += new System.EventHandler(this.btnConsultarSaldo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblSaldoDisponible);
            this.panel1.Location = new System.Drawing.Point(251, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 342);
            this.panel1.TabIndex = 1;
            // 
            // LblSaldoDisponible
            // 
            this.LblSaldoDisponible.AutoSize = true;
            this.LblSaldoDisponible.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldoDisponible.Location = new System.Drawing.Point(221, 240);
            this.LblSaldoDisponible.Name = "LblSaldoDisponible";
            this.LblSaldoDisponible.Size = new System.Drawing.Size(36, 26);
            this.LblSaldoDisponible.TabIndex = 0;
            this.LblSaldoDisponible.Text = "$0";
            this.LblSaldoDisponible.Click += new System.EventHandler(this.LblSaldoDisponible_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Innova Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(157, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Su saldo actual es:";
            // 
            // OpcionesUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpOpciones);
            this.Name = "OpcionesUsuarioForm";
            this.Text = "UsuarioForm";
            this.grpOpciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnConsultarSaldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblSaldoDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}