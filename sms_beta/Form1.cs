using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GsmComm.PduConverter;
using GsmComm.PduConverter.SmartMessaging;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.Server;

namespace sms_beta
{
    public partial class SMS_beta : Form
    {
        public SMS_beta()
        {
            InitializeComponent();
        }
        /// <summary>
        /// funkcja odpowiedzialna za ładowanie aktywnych portów do comboboxa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SMS_beta_Load(object sender, EventArgs e)
        {
            port_init();
        }

        /// <summary>
        /// wyczyszczenie starej listy aktywnych portów, uzupełnienie jej o aktualne
        /// </summary>
        public void port_init()
        {
            cb_port_name.Items.Clear();
            refresh_port(cb_port_name);
            cb_port_name.SelectedIndex = -1;
        }

        /// <summary>
        /// funkcja odpowiedzialna za odświeżenie aktywnych portów
        /// </summary>
        /// <param name="avaliable_ports"></param>
        public void refresh_port(object avaliable_ports)
        {
            foreach (string port in System.IO.Ports.SerialPort.GetPortNames())
            {
                ((ComboBox)avaliable_ports).Items.Add(port);
            }
        }

        /// <summary>
        /// funkcja odpowiedzialna za wysyłanie wiadomości tekstowej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_send_message_Click(object sender, EventArgs e)
        {
            try
            {
                //sp_connection.PortName = cb_port_name.Text; ;
                //sp_connection.Open();
                send_message();
                //sp_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem z obsługą portu " + cb_port_name.Text);
            }
        }

        /// <summary>
        /// wysyłanie wiadomości; otwarcie połaczenia-->wysłanie-->zamknięcie
        /// </summary>
        public void send_message()
        {
            string port = "";
            for (int i = 3; i < cb_port_name.Text.Length; i++)
            {
                port = port + cb_port_name.Text[i];
            }
            int baudRate = 9600;
            int timeout = 300;
            GsmCommMain comm = new GsmCommMain(Convert.ToInt16(port), baudRate, timeout);
            string smsc = string.Empty;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SmsSubmitPdu pdu;
                pdu = new SmsSubmitPdu(tb_text_message.Text, tb_phone_number.Text, smsc);
                comm.Open();
                comm.SendMessage(pdu);
                comm.Close();
                Output("Message sent to " + tb_phone_number.Text);
                Output("");
                tb_text_message.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            port_init();
        }

        private delegate void SetTextCallback(string text);

        private void Output(string text)
        {
            if (this.tb_communicates.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(Output);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                tb_communicates.AppendText(text);
                tb_communicates.AppendText("\r\n");
            }
        }

        private void Output(string text, params object[] args)
        {
            string msg = string.Format(text, args);
            Output(msg);
        }

        private void cb_port_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}