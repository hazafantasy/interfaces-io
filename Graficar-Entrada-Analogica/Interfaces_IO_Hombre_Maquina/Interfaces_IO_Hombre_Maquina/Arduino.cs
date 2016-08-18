/*****
* Author: Hazael Fernando Mojica Garcia
* FIME, UANL, Mexico
* Interfaces IO Hombre Maquina
* 18/ago/2016
*****/
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Interfaces_IO_Hombre_Maquina
{
    class Arduino
    {
        SerialPort serialPort;
        bool ok;

        public Arduino(string portname, int bauds)
        {
            try
            {
                serialPort = new SerialPort(portname, bauds);
                ok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la asignacion del puerto del arduino. " + ex, "Error de Inicializacion de Puerto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
        }


        public bool Inicializa_Comunicacion()
        {
            if (ok)
            {
                try
                {
                    if (!serialPort.IsOpen)
                    {//If port is closed, open it
                        serialPort.Open();
                    }
                    serialPort.ReadTimeout = 95;
                    MessageBox.Show("Comunicacion Establecida", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la asignacion del puerto del arduino. " + ex, "Error de Inicializacion de Puerto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void Stop()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        public int GetLecturaAnalogica()
        {
            int lectura = -1;
            try
            {
                if (ok)
                {
                    serialPort.Write("r");
                    lectura = serialPort.ReadChar();
                }
            }
            catch
            {
                MessageBox.Show("Error Interno al obtener Lectura, la aplicacion se cerrara", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return lectura;
        }

    }
}
