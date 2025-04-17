namespace CajeroAutomatico.VISTA
{
    partial class ConsignarForm
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
            this.btnConsignar = new System.Windows.Forms.Button();
            this.txbValorConsignacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor a consignar";
            // 
            // btnConsignar
            // 
            this.btnConsignar.Location = new System.Drawing.Point(372, 103);
            this.btnConsignar.Name = "btnConsignar";
            this.btnConsignar.Size = new System.Drawing.Size(75, 23);
            this.btnConsignar.TabIndex = 1;
            this.btnConsignar.Text = "consignar";
            this.btnConsignar.UseVisualStyleBackColor = true;
            this.btnConsignar.Click += new System.EventHandler(this.btnConsignar_Click);
            // 
            // txbValorConsignacion
            // 
            this.txbValorConsignacion.Location = new System.Drawing.Point(372, 48);
            this.txbValorConsignacion.Name = "txbValorConsignacion";
            this.txbValorConsignacion.Size = new System.Drawing.Size(100, 20);
            this.txbValorConsignacion.TabIndex = 2;
            // 
            // ConsignarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbValorConsignacion);
            this.Controls.Add(this.btnConsignar);
            this.Controls.Add(this.label1);
            this.Name = "ConsignarForm";
            this.Text = "ConsignarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsignar;
        private System.Windows.Forms.TextBox txbValorConsignacion;
    }
}