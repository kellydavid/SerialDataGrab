using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialDataGrab
{
    public partial class SerialDataGrab : Form
    {
        DataConnection.Connection serialCon;
        LogFile logFile;

        public SerialDataGrab()
        {
            InitializeComponent();
            initialiseSettingsValues();
            serialConGroupBox.Enabled = false;
            logFileGroupBox.Enabled = true;
        }

        // Set Form Field Values.

        private void initialiseSettingsValues() {
            updateComPortComboBox();
            updateParityTypeComboBox();
            updateStopBitsComboBox();
            updateHandshakeComboBox();
        }

        private void updateComPortComboBox() {
            string[] arrayComPortsNames = SerialPort.GetPortNames();
            comPortComboBox.Items.Clear();
            for (int i = 0; i < arrayComPortsNames.Length; i++)
            {
                comPortComboBox.Items.Add(arrayComPortsNames[i]);
            }
        }

        private void updateParityTypeComboBox() {
            parityTypeComboBox.DataSource = Enum.GetValues(typeof(Parity));
        }

        private void updateStopBitsComboBox() {
            stopBitsComboBox.DataSource = Enum.GetValues(typeof(StopBits));
        }

        private void updateHandshakeComboBox() {
            handshakeComboBox.DataSource = Enum.GetValues(typeof(Handshake));
        }

        // Get Form Field Values

        private String getComPortName() {
            return comPortComboBox.SelectedItem.ToString();
        }

        private int getBaudRate() {
            return (int)baudRateUpDown.Value;
        }

        private Parity getParityType() {
            String parityType = parityTypeComboBox.SelectedItem.ToString();
            return (Parity)Enum.Parse(typeof(Parity), parityType, true);
        }

        private int getDataBits() {
            return (int)dataBitsUpDown.Value;
        }

        private StopBits getStopBits(){
            String stopBitsType = stopBitsComboBox.SelectedItem.ToString();
            return (StopBits)Enum.Parse(typeof(StopBits), stopBitsType, true);
        }

        private Handshake getHandshake() {
            String handshakeType = handshakeComboBox.SelectedItem.ToString();
            return (Handshake)Enum.Parse(typeof(Handshake), handshakeType, true);
        }

        private void openConnectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                String comPort = getComPortName();
                int baudRate = getBaudRate();
                Parity parity = getParityType();
                int dataBits = getDataBits();
                StopBits stopBits = getStopBits();
                Handshake handshake = getHandshake();
                serialCon = new DataConnection.Connection(comPort, baudRate, parity, dataBits, stopBits, handshake);
                serialCon.setLogFile(logFile);
            }
            catch (Exception exception) {
                MessageBox.Show("Make sure the form is filled out correctly.\n\n" + exception.Message, "Error!");
            }
        }

        private void selectFileLocationButton_Click(object sender, EventArgs e)
        {
            try
            {
                logFile = new LogFile(saveFileDialog1);
                saveLocationLabel.Text += logFile.fileLocation;
                serialConGroupBox.Enabled = true;
                logFileGroupBox.Enabled = false;
            }
            catch (Exception exception) {
                MessageBox.Show("Problem trying to select save file location.\n\n" +
                                    exception.Message, "Problem selecting save file location.");
            }
        }    
        
    }
}
