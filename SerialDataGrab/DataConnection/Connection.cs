using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialDataGrab.DataConnection
{
    class Connection
    {
        // Constants
        private const int RECEIVED_BYTES_THRESHOLD = 1;
        private const int READ_TIMEOUT = 10000;

        private string _comPort;
        private int _baudRate;
        private Parity _parityType;
        private int _dataBits;
        private StopBits _stopBits;
        private Handshake _handshakeType;

        private SerialPort serialPort = null;
        private LogFile logFile = null;

        public Connection(String comPort, int baudRate, Parity parityType, int dataBits,
                                        StopBits stopBits, Handshake handshakeType)
        {
            _comPort = comPort;
            _baudRate = baudRate;
            _parityType = parityType;
            _dataBits = dataBits;
            _stopBits = stopBits;
            _handshakeType = handshakeType;
            createNewConnection();
        }

        /// <summary>
        /// Creates and opens a new serial connection.
        /// </summary>
        private void createNewConnection()
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = _comPort;
                serialPort.BaudRate = _baudRate;
                serialPort.Parity = _parityType;
                serialPort.DataBits = _dataBits;
                serialPort.StopBits = _stopBits;
                serialPort.Handshake = _handshakeType;
                serialPort.DataReceived += DataReceivedHandler;
                serialPort.Open();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Exception occurred creating serial connection.", e.Message);
            }
        }

        /// <summary>
        /// Returns a string of connection information.
        /// </summary>
        /// <returns>String of connection information.</returns>
        public string getConnectionInfo()
        {
            return "Port: " + serialPort.PortName + " | Baud: " + serialPort.BaudRate + " | P: " + serialPort.Parity.ToString() + " | Dbits: " + serialPort.DataBits +
                " | Sbits: " + serialPort.StopBits.ToString() + " | H: " + serialPort.Handshake.ToString();
        }

        /// <summary>
        /// When the serial connection receives data, this function is run.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                //string indata = sp.ReadExisting();
                byte[] buf = new byte[sp.BytesToRead];
                sp.Read(buf, 0, buf.Length);
                string rawdata = "";
                foreach (Byte b in buf)
                {
                    rawdata += "" + b.ToString() + ", ";
                }
                String utf8 = Encoding.UTF8.GetString(buf, 0, buf.Length);
                MessageBox.Show("Raw bytes received: " + rawdata + "\n\nConverted to UTF8: " + utf8, "Data Received");
                logFile.writeLineToFile("Raw bytes received: " + rawdata);
                logFile.writeLineToFile("Converted to UTF8:");
                logFile.writeStringToFile(utf8);
                logFile.writeLineToFile("");
            }
            catch (Exception dataReceivedException)
            {
                MessageBox.Show("shite\n" + dataReceivedException.ToString());
            }
        }

        /// <summary>
        /// Pass a reference to the log file so the serial connection can log its output into it.
        /// </summary>
        /// <param name="logFile"></param>
        public void setLogFile(LogFile logFile)
        {
            this.logFile = logFile;
            logFile.writeLineToFile("Serial Connection Settings:");
            logFile.writeLineToFile(this.getConnectionInfo());
            logFile.writeLineToFile("");
        }

    }
}
