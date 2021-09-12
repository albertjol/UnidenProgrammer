
namespace UnidenProgrammer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_txtModel = new System.Windows.Forms.Label();
            this.cb_Ports = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_txtVersion = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.grd_Channels = new System.Windows.Forms.DataGridView();
            this.btn_Write = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.cb_Bank = new System.Windows.Forms.ComboBox();
            this.lbl_txtBank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Channels)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_txtModel
            // 
            this.lbl_txtModel.AutoSize = true;
            this.lbl_txtModel.Location = new System.Drawing.Point(12, 38);
            this.lbl_txtModel.Name = "lbl_txtModel";
            this.lbl_txtModel.Size = new System.Drawing.Size(41, 15);
            this.lbl_txtModel.TabIndex = 0;
            this.lbl_txtModel.Text = "Model";
            // 
            // cb_Ports
            // 
            this.cb_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ports.FormattingEnabled = true;
            this.cb_Ports.Location = new System.Drawing.Point(93, 12);
            this.cb_Ports.Name = "cb_Ports";
            this.cb_Ports.Size = new System.Drawing.Size(121, 23);
            this.cb_Ports.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(12, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(220, 11);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_txtVersion
            // 
            this.lbl_txtVersion.AutoSize = true;
            this.lbl_txtVersion.Location = new System.Drawing.Point(12, 53);
            this.lbl_txtVersion.Name = "lbl_txtVersion";
            this.lbl_txtVersion.Size = new System.Drawing.Size(45, 15);
            this.lbl_txtVersion.TabIndex = 4;
            this.lbl_txtVersion.Text = "Version";
            // 
            // lbl_model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Location = new System.Drawing.Point(93, 38);
            this.lbl_Model.Name = "lbl_model";
            this.lbl_Model.Size = new System.Drawing.Size(79, 15);
            this.lbl_Model.TabIndex = 5;
            this.lbl_Model.Text = "Disconnected";
            // 
            // lbl_version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(93, 53);
            this.lbl_Version.Name = "lbl_version";
            this.lbl_Version.Size = new System.Drawing.Size(0, 15);
            this.lbl_Version.TabIndex = 6;
            // 
            // grd_channels
            // 
            this.grd_Channels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_Channels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Channels.Location = new System.Drawing.Point(12, 71);
            this.grd_Channels.Name = "grd_channels";
            this.grd_Channels.RowTemplate.Height = 25;
            this.grd_Channels.Size = new System.Drawing.Size(652, 779);
            this.grd_Channels.TabIndex = 7;
            this.grd_Channels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grd_Channels_KeyDown);
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(589, 11);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(75, 23);
            this.btn_Write.TabIndex = 8;
            this.btn_Write.Text = "Write";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(508, 11);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(75, 23);
            this.btn_Read.TabIndex = 9;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // cb_bank
            // 
            this.cb_Bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Bank.FormattingEnabled = true;
            this.cb_Bank.Location = new System.Drawing.Point(393, 11);
            this.cb_Bank.Name = "cb_bank";
            this.cb_Bank.Size = new System.Drawing.Size(76, 23);
            this.cb_Bank.TabIndex = 10;
            // 
            // lbl_txtBank
            // 
            this.lbl_txtBank.AutoSize = true;
            this.lbl_txtBank.Location = new System.Drawing.Point(354, 15);
            this.lbl_txtBank.Name = "lbl_txtBank";
            this.lbl_txtBank.Size = new System.Drawing.Size(33, 15);
            this.lbl_txtBank.TabIndex = 11;
            this.lbl_txtBank.Text = "Bank";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 862);
            this.Controls.Add(this.lbl_txtBank);
            this.Controls.Add(this.cb_Bank);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.grd_Channels);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.lbl_txtVersion);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cb_Ports);
            this.Controls.Add(this.lbl_txtModel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uniden Bearcat Programmer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Channels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_txtModel;
        private System.Windows.Forms.ComboBox cb_Ports;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_txtVersion;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.DataGridView grd_Channels;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.ComboBox cb_Bank;
        private System.Windows.Forms.Label lbl_txtBank;
    }
}

