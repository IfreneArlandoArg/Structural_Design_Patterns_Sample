namespace Adapter_Client
{
    partial class Form1
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
            this.comboxModoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.groupBoxPagoTarjeta = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMarcaTarjeta = new System.Windows.Forms.ComboBox();
            this.groupBoxPagoTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboxModoPago
            // 
            this.comboxModoPago.FormattingEnabled = true;
            this.comboxModoPago.Location = new System.Drawing.Point(769, 169);
            this.comboxModoPago.Name = "comboxModoPago";
            this.comboxModoPago.Size = new System.Drawing.Size(203, 24);
            this.comboxModoPago.TabIndex = 0;
            this.comboxModoPago.SelectedIndexChanged += new System.EventHandler(this.comboxModoPago_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modo Pago :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo :";
            // 
            // comboBoxTipoTarjeta
            // 
            this.comboBoxTipoTarjeta.FormattingEnabled = true;
            this.comboBoxTipoTarjeta.Location = new System.Drawing.Point(75, 52);
            this.comboBoxTipoTarjeta.Name = "comboBoxTipoTarjeta";
            this.comboBoxTipoTarjeta.Size = new System.Drawing.Size(203, 24);
            this.comboBoxTipoTarjeta.TabIndex = 2;
            // 
            // groupBoxPagoTarjeta
            // 
            this.groupBoxPagoTarjeta.Controls.Add(this.label3);
            this.groupBoxPagoTarjeta.Controls.Add(this.comboBoxMarcaTarjeta);
            this.groupBoxPagoTarjeta.Controls.Add(this.label2);
            this.groupBoxPagoTarjeta.Controls.Add(this.comboBoxTipoTarjeta);
            this.groupBoxPagoTarjeta.Location = new System.Drawing.Point(12, 83);
            this.groupBoxPagoTarjeta.Name = "groupBoxPagoTarjeta";
            this.groupBoxPagoTarjeta.Size = new System.Drawing.Size(312, 150);
            this.groupBoxPagoTarjeta.TabIndex = 4;
            this.groupBoxPagoTarjeta.TabStop = false;
            this.groupBoxPagoTarjeta.Text = "Tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca :";
            // 
            // comboBoxMarcaTarjeta
            // 
            this.comboBoxMarcaTarjeta.FormattingEnabled = true;
            this.comboBoxMarcaTarjeta.Location = new System.Drawing.Point(75, 91);
            this.comboBoxMarcaTarjeta.Name = "comboBoxMarcaTarjeta";
            this.comboBoxMarcaTarjeta.Size = new System.Drawing.Size(203, 24);
            this.comboBoxMarcaTarjeta.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 682);
            this.Controls.Add(this.groupBoxPagoTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxModoPago);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPagoTarjeta.ResumeLayout(false);
            this.groupBoxPagoTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxModoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoTarjeta;
        private System.Windows.Forms.GroupBox groupBoxPagoTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMarcaTarjeta;
    }
}

