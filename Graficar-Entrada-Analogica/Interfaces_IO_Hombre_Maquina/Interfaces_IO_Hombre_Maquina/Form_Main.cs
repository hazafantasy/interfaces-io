/*****
* Author: Hazael Fernando Mojica Garcia
* FIME, UANL, Mexico
* Interfaces IO Hombre Maquina
* 18/ago/2016
*****/
using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Interfaces_IO_Hombre_Maquina
{
    public partial class Form_Main : Form
    {
        Arduino arduino = null;
        int[] muestreo;

        public Form_Main()
        {
            InitializeComponent();
            muestreo = new int[50];
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            serial_combo(this.comboBox_Puertos);
            for (int i = 0; i < 50; i++)
            {
                muestreo[i] = 0;
            }
            
        }

        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            if (this.comboBox_Puertos.Items.Count > 0)
            {
                if (this.comboBox_Puertos.SelectedIndex > -1)
                {//Si esta seleccionado algun puerto
                    arduino = new Arduino(this.comboBox_Puertos.Text, 115200);//Inicializamos arduino a 115200 bauds
                    arduino.Inicializa_Comunicacion();
                    this.button_Iniciar.Enabled = false;
                    this.button_Stop.Enabled = true;
                    timer.Enabled = true;
                    timer.Start();
                }
            }
        }


        //Metodo que primero limpia y despues llena la comboBox pasada como
        //parametro con los puertos serie disponibles
        private void serial_combo(ComboBox combo)
        {
            combo.Items.Clear();
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                combo.Items.Add(port);
            }
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                arduino.Stop();
            }
            catch
            {
                //Nothing to do here
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Get_Lectura();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Stop();
                arduino = null;
                this.button_Stop.Enabled = false;
                this.button_Iniciar.Enabled = true;
                this.timer.Stop();
                this.timer.Enabled = false;
            }
            catch
            {
                arduino = null;
            }
        }

        private void Get_Lectura()
        {
            int punto = 0;
            if (arduino != null)
            {
                punto = arduino.GetLecturaAnalogica();
                this.textBox_caracter.Text = Convert.ToChar(punto).ToString();
                ActualizaGrafica(punto);
            }
        }

        private void ActualizaGrafica(int punto)
        {
            RecorreArray(punto);
            this.chart_Datos.Series[0].Points.Clear();
            for (int i = 0; i < 50; i++)
            {
                this.chart_Datos.Series[0].Points.AddY(muestreo[i]);
            }
        }

        private void RecorreArray(int punto)
        {
            int[] muestreoAux = new int[50];
            for (int i = 0; i < 49; i++)
            {
                muestreoAux[i + 1] = muestreo[i];
            }
            muestreoAux[0] = punto;
            muestreo = muestreoAux;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            serial_combo(this.comboBox_Puertos);
        }

    }
}
