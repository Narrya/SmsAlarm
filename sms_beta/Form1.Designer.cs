namespace sms_beta
{
    partial class SMS_beta
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
            this.components = new System.ComponentModel.Container();
            this.cb_port_name = new System.Windows.Forms.ComboBox();
            this.tb_text_message = new System.Windows.Forms.TextBox();
            this.bt_send_message = new System.Windows.Forms.Button();
            this.sp_connection = new System.IO.Ports.SerialPort(this.components);
            this.bt_refresh = new System.Windows.Forms.Button();
            this.tb_communicates = new System.Windows.Forms.TextBox();
            this.tb_phone_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_port_name
            // 
            this.cb_port_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_port_name.FormattingEnabled = true;
            this.cb_port_name.Location = new System.Drawing.Point(12, 12);
            this.cb_port_name.Name = "cb_port_name";
            this.cb_port_name.Size = new System.Drawing.Size(117, 21);
            this.cb_port_name.TabIndex = 0;
            this.cb_port_name.SelectedIndexChanged += new System.EventHandler(this.cb_port_name_SelectedIndexChanged);
            // 
            // tb_text_message
            // 
            this.tb_text_message.Location = new System.Drawing.Point(12, 137);
            this.tb_text_message.MaxLength = 160;
            this.tb_text_message.Multiline = true;
            this.tb_text_message.Name = "tb_text_message";
            this.tb_text_message.Size = new System.Drawing.Size(260, 113);
            this.tb_text_message.TabIndex = 2;
            // 
            // bt_send_message
            // 
            this.bt_send_message.Location = new System.Drawing.Point(209, 39);
            this.bt_send_message.Name = "bt_send_message";
            this.bt_send_message.Size = new System.Drawing.Size(63, 20);
            this.bt_send_message.TabIndex = 3;
            this.bt_send_message.Text = "Send";
            this.bt_send_message.UseVisualStyleBackColor = true;
            this.bt_send_message.Click += new System.EventHandler(this.bt_send_message_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(209, 13);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(63, 20);
            this.bt_refresh.TabIndex = 3;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // tb_communicates
            // 
            this.tb_communicates.BackColor = System.Drawing.SystemColors.Window;
            this.tb_communicates.Enabled = false;
            this.tb_communicates.Location = new System.Drawing.Point(12, 65);
            this.tb_communicates.Multiline = true;
            this.tb_communicates.Name = "tb_communicates";
            this.tb_communicates.Size = new System.Drawing.Size(260, 66);
            this.tb_communicates.TabIndex = 4;
            // 
            // tb_phone_number
            // 
            this.tb_phone_number.Location = new System.Drawing.Point(12, 39);
            this.tb_phone_number.MaxLength = 30;
            this.tb_phone_number.Name = "tb_phone_number";
            this.tb_phone_number.Size = new System.Drawing.Size(117, 20);
            this.tb_phone_number.TabIndex = 1;
            this.tb_phone_number.Text = "+48510804374";
            this.tb_phone_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SMS_beta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tb_communicates);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.bt_send_message);
            this.Controls.Add(this.tb_text_message);
            this.Controls.Add(this.tb_phone_number);
            this.Controls.Add(this.cb_port_name);
            this.Name = "SMS_beta";
            this.Text = "SMS_beta";
            this.Load += new System.EventHandler(this.SMS_beta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_port_name;
        private System.Windows.Forms.TextBox tb_text_message;
        private System.Windows.Forms.Button bt_send_message;
        private System.IO.Ports.SerialPort sp_connection;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.TextBox tb_communicates;
        private System.Windows.Forms.TextBox tb_phone_number;

    }
}

