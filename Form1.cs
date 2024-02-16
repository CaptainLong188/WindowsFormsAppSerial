using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSerial
{

    public partial class Form1 : Form
    {

        private SerialPort serialPortReceive;
        private SerialPort serialPortSend;
        private string ledStatus = "00000";

        public Form1()
        {
            InitializeComponent();
        }

        private void CmbReceive_SelectedIndexChanged(object sender, EventArgs e)
        {

            serialPortReceive?.Close(); // Cerrar puerto 

            // Configuración del puerto serial para recibir información de la placa

            serialPortReceive = new SerialPort
            {
                PortName = cmbReceive.Text,
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DtrEnable = true
            };
            serialPortReceive.DataReceived += DataReceivedHandler;

            // Abrimos el puerto serial

            try
            {
                serialPortReceive.Open();
                serialPortReceive.Write("W");
                lblReceive.Image = Properties.Resources.checked1;
                MessageBox.Show(text: $"Puerto {serialPortReceive.PortName} abierto",
                caption: "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblReceive.Image = Properties.Resources.cancel;
                MessageBox.Show(text: $"Error al abrir el puerto serial : {ex.Message}",
                                caption: "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CmbSend_SelectedIndexChanged(object sender, EventArgs e)
        {

            serialPortSend?.Close();

            // Configuración del puerto serial para enviar información a la estampadora

            serialPortSend = new SerialPort
            {
                PortName = cmbSend.Text,
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DtrEnable = true,
                NewLine = "\r\n"
            };

            // Abrimos el puerto serial
            try
            {
                serialPortSend.Open();

                lblSend.Image = Properties.Resources.checked1;
                MessageBox.Show(text: $"Puerto {serialPortSend.PortName} abierto",
                caption: "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEnviar.Enabled = true;
            }
            catch (Exception ex)
            {
                lblSend.Image = Properties.Resources.cancel;
                MessageBox.Show(text: $"Error al abrir el puerto serial : {ex.Message}",
                                caption: "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                ledStatus = sp.ReadLine();
                ShowReceivedData(ledStatus);
                if(serialPortSend != null && serialPortSend.IsOpen) 
                { 
                    serialPortSend.WriteLine(ledStatus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: $"Error al recibir datos : {ex.Message}",
                                caption: "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ShowReceivedData(string datosRecibidos)
        {
            // Verificamos que estemos en el hilo principal

            if(txtMensaje.InvokeRequired)
            {
                txtMensaje.Invoke(new Action(() =>
                {
                    txtMensaje.AppendText(datosRecibidos);
                    txtMensaje.ScrollToCaret();
                }
                ));
            }
            else
            {
                txtMensaje.AppendText(datosRecibidos);
                txtMensaje.ScrollToCaret();
            }

            // Volver a pintar los elementos (leds) del panel
            // dependiendo de los valores de la variable ledStatus
            // la cual es modificada por los mensajes enviados desde el uC
            
            if (pnlFocos.InvokeRequired)
            {
                pnlFocos.Invoke(new Action(() => pnlFocos.Invalidate()));
            }
            else 
            {
                pnlFocos.Invalidate();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(text: "Bye :)", caption: "Cerrando...", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);

            if (serialPortReceive != null && serialPortReceive.IsOpen)
            {
                serialPortReceive.Close();
            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {

            //byte[] buffer = Encoding.UTF8.GetBytes(lblEnviar.Text);
            //puertoSerial.Write(buffer, 0 ,buffer.Length);
            if(serialPortSend != null && serialPortSend.IsOpen)
            {
                serialPortSend.WriteLine(lblEnviar.Text);
            }

        }

        private void TbrBit_Scroll(object sender, EventArgs e, int indice)
        {
            TrackBar trackBar = (TrackBar)sender;
            string bit = trackBar.Value.ToString();
            ChangeDataToSend(indice, bit);
        }  

        private void TbrBit1_Scroll(object sender, EventArgs e)
        {
            TbrBit_Scroll(sender, e, 4);
        }
        private void TbrBit2_Scroll(object sender, EventArgs e)
        {
            TbrBit_Scroll(sender, e, 3);
        }
        private void TbrBit3_Scroll(object sender, EventArgs e)
        {
            TbrBit_Scroll(sender, e, 2);
        }

        private void TbrBit4_Scroll(object sender, EventArgs e)
        {
            TbrBit_Scroll(sender, e, 1);
        }

        private void TbrBit5_Scroll(object sender, EventArgs e)
        {
            TbrBit_Scroll(sender, e, 0);
        }

        private void ChangeDataToSend(int v, string bit)
        {
            string aux = lblEnviar.Text.Substring(0, v) + bit + lblEnviar.Text.Substring(v + 1);
            lblEnviar.Text = aux;  
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtMensaje.Clear();
        }

        private void PnlFocos_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 2);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            for (int i = 10, j = 0; j < 5; i += 40, ++j) 
            {
                char led = ledStatus[j];
                g.DrawEllipse(blackPen, i, 5, 30, 30);
                
                if(led == '0')
                {
                    g.FillEllipse(whiteBrush, i, 5, 30, 30);
                }
                else
                {
                    g.FillEllipse(redBrush, i, 5, 30, 30);
                }
            }

        }

    }
}
