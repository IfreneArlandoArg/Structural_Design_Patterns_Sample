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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBanco = new System.Windows.Forms.ComboBox();
            this.groupBoxMonedero = new System.Windows.Forms.GroupBox();
            this.comboBoxMonedero = new System.Windows.Forms.ComboBox();
            this.btnPagarBanco = new System.Windows.Forms.Button();
            this.btnPagarMonedero = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxPagos = new System.Windows.Forms.ListBox();
            this.numericUpDownBanco = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonedero = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxPagoTarjeta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMonedero.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonedero)).BeginInit();
            this.SuspendLayout();
            // 
            // comboxModoPago
            // 
            this.comboxModoPago.FormattingEnabled = true;
            this.comboxModoPago.Location = new System.Drawing.Point(96, 39);
            this.comboxModoPago.Name = "comboxModoPago";
            this.comboxModoPago.Size = new System.Drawing.Size(236, 24);
            this.comboxModoPago.TabIndex = 0;
            this.comboxModoPago.SelectedIndexChanged += new System.EventHandler(this.comboxModoPago_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modo :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo :";
            // 
            // comboBoxTipoTarjeta
            // 
            this.comboBoxTipoTarjeta.FormattingEnabled = true;
            this.comboBoxTipoTarjeta.Location = new System.Drawing.Point(75, 79);
            this.comboBoxTipoTarjeta.Name = "comboBoxTipoTarjeta";
            this.comboBoxTipoTarjeta.Size = new System.Drawing.Size(203, 24);
            this.comboBoxTipoTarjeta.TabIndex = 2;
            // 
            // groupBoxPagoTarjeta
            // 
            this.groupBoxPagoTarjeta.Controls.Add(this.label8);
            this.groupBoxPagoTarjeta.Controls.Add(this.label5);
            this.groupBoxPagoTarjeta.Controls.Add(this.label4);
            this.groupBoxPagoTarjeta.Controls.Add(this.numericUpDownBanco);
            this.groupBoxPagoTarjeta.Controls.Add(this.btnPagarBanco);
            this.groupBoxPagoTarjeta.Controls.Add(this.label3);
            this.groupBoxPagoTarjeta.Controls.Add(this.comboBoxBanco);
            this.groupBoxPagoTarjeta.Controls.Add(this.comboBoxMarcaTarjeta);
            this.groupBoxPagoTarjeta.Controls.Add(this.label2);
            this.groupBoxPagoTarjeta.Controls.Add(this.comboBoxTipoTarjeta);
            this.groupBoxPagoTarjeta.Location = new System.Drawing.Point(20, 105);
            this.groupBoxPagoTarjeta.Name = "groupBoxPagoTarjeta";
            this.groupBoxPagoTarjeta.Size = new System.Drawing.Size(312, 277);
            this.groupBoxPagoTarjeta.TabIndex = 4;
            this.groupBoxPagoTarjeta.TabStop = false;
            this.groupBoxPagoTarjeta.Text = "Tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca :";
            // 
            // comboBoxMarcaTarjeta
            // 
            this.comboBoxMarcaTarjeta.FormattingEnabled = true;
            this.comboBoxMarcaTarjeta.Location = new System.Drawing.Point(75, 118);
            this.comboBoxMarcaTarjeta.Name = "comboBoxMarcaTarjeta";
            this.comboBoxMarcaTarjeta.Size = new System.Drawing.Size(203, 24);
            this.comboBoxMarcaTarjeta.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxMonedero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBoxPagoTarjeta);
            this.groupBox1.Controls.Add(this.comboxModoPago);
            this.groupBox1.Location = new System.Drawing.Point(474, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 449);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Banco :";
            // 
            // comboBoxBanco
            // 
            this.comboBoxBanco.FormattingEnabled = true;
            this.comboBoxBanco.Location = new System.Drawing.Point(75, 40);
            this.comboBoxBanco.Name = "comboBoxBanco";
            this.comboBoxBanco.Size = new System.Drawing.Size(203, 24);
            this.comboBoxBanco.TabIndex = 6;
            // 
            // groupBoxMonedero
            // 
            this.groupBoxMonedero.Controls.Add(this.label6);
            this.groupBoxMonedero.Controls.Add(this.label7);
            this.groupBoxMonedero.Controls.Add(this.numericUpDownMonedero);
            this.groupBoxMonedero.Controls.Add(this.btnPagarMonedero);
            this.groupBoxMonedero.Controls.Add(this.comboBoxMonedero);
            this.groupBoxMonedero.Location = new System.Drawing.Point(92, 83);
            this.groupBoxMonedero.Name = "groupBoxMonedero";
            this.groupBoxMonedero.Size = new System.Drawing.Size(240, 176);
            this.groupBoxMonedero.TabIndex = 8;
            this.groupBoxMonedero.TabStop = false;
            this.groupBoxMonedero.Text = "Monedero";
            // 
            // comboBoxMonedero
            // 
            this.comboBoxMonedero.FormattingEnabled = true;
            this.comboBoxMonedero.Location = new System.Drawing.Point(22, 33);
            this.comboBoxMonedero.Name = "comboBoxMonedero";
            this.comboBoxMonedero.Size = new System.Drawing.Size(203, 24);
            this.comboBoxMonedero.TabIndex = 6;
            // 
            // btnPagarBanco
            // 
            this.btnPagarBanco.Location = new System.Drawing.Point(185, 210);
            this.btnPagarBanco.Name = "btnPagarBanco";
            this.btnPagarBanco.Size = new System.Drawing.Size(93, 36);
            this.btnPagarBanco.TabIndex = 6;
            this.btnPagarBanco.Text = "Pagar";
            this.btnPagarBanco.UseVisualStyleBackColor = true;
            this.btnPagarBanco.Click += new System.EventHandler(this.btnPagarBanco_Click);
            // 
            // btnPagarMonedero
            // 
            this.btnPagarMonedero.Location = new System.Drawing.Point(131, 113);
            this.btnPagarMonedero.Name = "btnPagarMonedero";
            this.btnPagarMonedero.Size = new System.Drawing.Size(93, 36);
            this.btnPagarMonedero.TabIndex = 7;
            this.btnPagarMonedero.Text = "Pagar";
            this.btnPagarMonedero.UseVisualStyleBackColor = true;
            this.btnPagarMonedero.Click += new System.EventHandler(this.btnPagarMonedero_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxPagos);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 560);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagos - Completados";
            // 
            // listBoxPagos
            // 
            this.listBoxPagos.FormattingEnabled = true;
            this.listBoxPagos.ItemHeight = 16;
            this.listBoxPagos.Location = new System.Drawing.Point(24, 41);
            this.listBoxPagos.Name = "listBoxPagos";
            this.listBoxPagos.Size = new System.Drawing.Size(407, 500);
            this.listBoxPagos.TabIndex = 0;
            // 
            // numericUpDownBanco
            // 
            this.numericUpDownBanco.Location = new System.Drawing.Point(137, 171);
            this.numericUpDownBanco.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownBanco.Name = "numericUpDownBanco";
            this.numericUpDownBanco.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownBanco.TabIndex = 10;
            this.numericUpDownBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownMonedero
            // 
            this.numericUpDownMonedero.Location = new System.Drawing.Point(72, 73);
            this.numericUpDownMonedero.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownMonedero.Name = "numericUpDownMonedero";
            this.numericUpDownMonedero.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMonedero.TabIndex = 11;
            this.numericUpDownMonedero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Monto :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Monto :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "AR$";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "AR$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPagoTarjeta.ResumeLayout(false);
            this.groupBoxPagoTarjeta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMonedero.ResumeLayout(false);
            this.groupBoxMonedero.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonedero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxModoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoTarjeta;
        private System.Windows.Forms.GroupBox groupBoxPagoTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMarcaTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBanco;
        private System.Windows.Forms.GroupBox groupBoxMonedero;
        private System.Windows.Forms.ComboBox comboBoxMonedero;
        private System.Windows.Forms.Button btnPagarBanco;
        private System.Windows.Forms.Button btnPagarMonedero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxPagos;
        private System.Windows.Forms.NumericUpDown numericUpDownBanco;
        private System.Windows.Forms.NumericUpDown numericUpDownMonedero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

