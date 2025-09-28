using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PaymentManager paymentManager;

        void InitializeComboBoxes() 
        {
            comboxModoPago.Items.Add(ModoPago.Tarjeta);
            comboxModoPago.Items.Add(ModoPago.MonederoElectronico);
            comboxModoPago.SelectedIndex = 0;


            comboBoxMarcaTarjeta.Items.Add(MarcaTarjeta.Visa);
            comboBoxMarcaTarjeta.Items.Add(MarcaTarjeta.MasterCard);
            comboBoxMarcaTarjeta.Items.Add(MarcaTarjeta.Amex);

            comboBoxMarcaTarjeta.SelectedIndex = 0;

            comboBoxTipoTarjeta.Items.Add(TipoTarjeta.Credito);
            comboBoxTipoTarjeta.Items.Add(TipoTarjeta.Debito);
            comboBoxTipoTarjeta.SelectedIndex = 0;



            comboBoxBanco.Items.Add("Banco Galicia");
            comboBoxBanco.Items.Add("Banco Santander");
            comboBoxBanco.Items.Add("Banco Macro");
            comboBoxBanco.Items.Add("Banco Nación");
            comboBoxBanco.SelectedIndex = 0;


            comboBoxMonedero.Items.Add("Mercado Pago");
            comboBoxMonedero.Items.Add("Ualá");
            comboBoxMonedero.Items.Add("PayPal");
            comboBoxMonedero.SelectedIndex = 0;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paymentManager = new PaymentManager(new Usuario("Juan", "Perez"));

            this.Text = $"Gestion de pagos - {paymentManager.usuario.Nombre} {paymentManager.usuario.Apellido}";

            InitializeComboBoxes();

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboxModoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboxModoPago.Items.Count > 0)
                {
                    
                    groupBoxPagoTarjeta.Visible = false;
                    groupBoxMonedero.Visible = false;

                    
                    switch ((ModoPago)comboxModoPago.SelectedItem)
                    {
                        case ModoPago.Tarjeta:
                            groupBoxPagoTarjeta.Visible = true;
                            break;
                        case ModoPago.MonederoElectronico:
                            groupBoxMonedero.Visible = true;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void mostrarPagos()
        {
            listBoxPagos.Items.Clear();
            foreach (var pago in paymentManager.Pagos)
            {
                listBoxPagos.Items.Add(pago.ToString());
            }
        }

        private void btnPagarMonedero_Click(object sender, EventArgs e)
        {
            try
            {
                IPago pago = new MonederoElectronicoAdapter((string)comboBoxMonedero.SelectedItem);
                pago.Pagar((double)numericUpDownMonedero.Value);
                paymentManager.AgregarPago(pago);


                mostrarPagos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPagarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                IPago pago = new PagoConTarjeta((string)comboBoxBanco.SelectedItem)
                {
                    Marca = (MarcaTarjeta)comboBoxMarcaTarjeta.SelectedItem,
                    Tipo = (TipoTarjeta)comboBoxTipoTarjeta.SelectedItem
                };
                pago.Pagar((double)numericUpDownBanco.Value);
                paymentManager.AgregarPago(pago);

                mostrarPagos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
