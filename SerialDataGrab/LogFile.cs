using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SerialDataGrab
{
    class LogFile
    {
        public string fileLocation;

        public LogFile(SaveFileDialog saveFileDialog) {
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Select location to save log file";
            DialogResult saveFileResult = saveFileDialog.ShowDialog();
            if(saveFileResult != DialogResult.OK)
                throw new Exception("Could not select log file location.");
            fileLocation = saveFileDialog.FileName;
            if (!File.Exists(fileLocation))
                File.Create(fileLocation);
            writeLineToFile("");
            writeLineToFile("");
            writeLineToFile("--------------------------------------------------------");
            writeLineToFile("Log File Entry at " + DateTime.Now.ToString());
            writeLineToFile("");
        }

        public void writeStringToFile(String write) {
            try
            {
                using (StreamWriter sw = File.AppendText(fileLocation))
                {
                    sw.Write(write);
                }	
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Problem writing to log file.");
            }
        }

        public void writeLineToFile(String write) {
            try
            {
                using (StreamWriter sw = File.AppendText(fileLocation))
                {
                    sw.WriteLine(write);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Problem writing to log file.");
            }
        }
    }
}
