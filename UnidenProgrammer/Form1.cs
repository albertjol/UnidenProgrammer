using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnidenProgrammer
{
    public partial class Form1 : Form
    {
        private bool _connected = false;
        private SerialPort _serialPort;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Refresh_Click(sender, e);

            cb_Bank.DataSource = new List<int> { 1, 2, 3, 4, 5, 6, 8, 9, 10 };
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            cb_Ports.Items.Clear();
            cb_Ports.Items.AddRange(portNames);
            cb_Ports.SelectedIndex = 0;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_connected)
                {
                    _serialPort = new SerialPort((string)cb_Ports.SelectedItem, 57600, Parity.None, 8, StopBits.One);
                    _serialPort.Open();
                    _serialPort.ReadTimeout = 1000;
                    _serialPort.NewLine = "\r";

                    lbl_Model.Text = Command("MDL");
                    lbl_Version.Text = Command("VER");

                    btn_Read.Enabled = true;
                    btn_Write.Enabled = true;
                    btn_Refresh.Enabled = false;
                    cb_Ports.Enabled = false;
                    btn_Connect.Text = "Disconnect";
                    _connected = true;
                }
                else
                {
                    _serialPort.Close();
                    _serialPort.Dispose();
                    _serialPort = null;
                    lbl_Model.Text = "Disconnected";
                    lbl_Version.Text = "";
                    btn_Connect.Text = "Connect";
                    btn_Read.Enabled = false;
                    btn_Write.Enabled = false;
                    btn_Refresh.Enabled = true;
                    cb_Ports.Enabled = true;
                    _connected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception occurred", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
     
        private void ReadChannels(int bank)
        {
            Command("PRG", true);

            List<Channel> channels = new List<Channel>();
            for (int i = 1 + (bank - 1) * 30; i <= 30 * bank; ++i)
            {
                channels.Add(new Channel(Command($"CIN,{i}")));
            }

            Command("EPG", true);

            grd_Channels.DataSource = channels;
            grd_Channels.Columns[nameof(Channel.Frequency)].DefaultCellStyle.Format = "0.0000";
        }

        private void WriteChannels()
        {
            Command("PRG", true);

            foreach (Channel channel in (List<Channel>)grd_Channels.DataSource)
            {
                Command(channel.GetMessage(), true);
            }

            Command("EPG", true);

            MessageBox.Show("Successfully wrote channels", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string Command(string request, bool checkOK = false)
        {
            int retry = 5;
            string logResponse = "";
            while (retry > 0)
            {
                try
                {
                    _serialPort.WriteLine(request);
                    string response = _serialPort.ReadLine();
                    logResponse += response + " - ";

                    string expectedResponse = request.Split(',')[0] + (checkOK ? ",OK" : ",");
                    if (response.StartsWith(expectedResponse))
                    {
                        return response.Remove(0, expectedResponse.Length);
                    }
                }
                catch(Exception e)
                {
                    if(retry <= 1)
                    {
                        throw;
                    }
                    logResponse += e.Message;
                }
                retry--;
            }
            logResponse = logResponse.Remove(logResponse.Length - 3, 3);
            throw new InvalidOperationException($"Command {request}: responded with {logResponse}");
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            ReadChannels((int)cb_Bank.SelectedItem);
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            WriteChannels();
        }

        private void grd_Channels_KeyDown(object sender, KeyEventArgs e)
        {
            // Thanks to https://stackoverflow.com/questions/4077260/copy-and-paste-multiple-cells-within-datagridview
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject d = grd_Channels.GetClipboardContent();
                Clipboard.SetDataObject(d);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int row = grd_Channels.CurrentCell.RowIndex;
                int col = grd_Channels.CurrentCell.ColumnIndex;
                foreach (string line in lines)
                {
                    string[] cells = line.Split('\t');
                    int cellsSelected = cells.Length;
                    if (row < grd_Channels.Rows.Count)
                    {
                        for (int i = 0; i < cellsSelected; i++)
                        {
                            if (col + i < grd_Channels.Columns.Count)
                                grd_Channels[col + i, row].Value = cells[i];
                            else
                                break;
                        }
                        row++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
