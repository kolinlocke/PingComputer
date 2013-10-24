using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;

namespace PingComputer
{
    public partial class FrmMain : Form
    {
        #region _Variables

        Ping mPing = new Ping();
        String mAddress;
        Int32 mTimeout;
        const Int32 CnsTimeout = 5000;

        #endregion

        #region _Constructor

        public FrmMain()
        {
            InitializeComponent();

            this.Lbl_StatusMsg.Text = "Ready";
            this.Btn_Ping.Enabled = true;
            this.Btn_Cancel.Enabled = false;

            this.Txt_Timeout.Text = "5";

            this.Btn_Ping.Click += new EventHandler(Btn_Ping_Click);
            this.Btn_Cancel.Click += new EventHandler(Btn_Cancel_Click);
            this.Chk_Timeout.CheckedChanged += new EventHandler(Chk_Timeout_CheckedChanged);
            this.mPing.PingCompleted += new PingCompletedEventHandler(mPing_PingCompleted);
        }

        #endregion

        #region _EventHandlers

        void Btn_Ping_Click(object sender, EventArgs e)
        {
            this.StartPing();
        }

        void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.CancelPing();
        }

        void Chk_Timeout_CheckedChanged(object sender, EventArgs e)
        {
            this.Txt_Timeout.Enabled = this.Chk_Timeout.Checked;
        }

        void mPing_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(
                        "Pinging Cancelled"
                        , "Ping Cancelled"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
            }
            else if (e.Error != null)
            {
                MessageBox.Show(
                        "An Error Occurred, please check the IP Address or Host Name and try again."
                        , "Error Occurred"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
            }
            else if (e.Reply != null)
            {
                if (e.Reply.Status == IPStatus.Success)
                {
                    this.Notify.ShowBalloonTip(
                        5000
                        , "Ping Finished"
                        , "Pinging " + this.Txt_Target.Text + " Successful!"
                        , ToolTipIcon.Info);

                    this.Lbl_StatusMsg.Text = "Pinging " + this.Txt_Target.Text + " Successful!";
                }
                else
                {
                    if (!this.Chk_Timeout.Checked)
                    {
                        this.Ping();
                        return;
                    }
                    else
                    {
                        switch (e.Reply.Status)
                        {
                            case IPStatus.TimedOut:
                                this.Notify.ShowBalloonTip(
                                    5000
                                    , "Ping Timeout"
                                    , "Pinging " + this.Txt_Target.Text + " Failed due to timeout!"
                                    , ToolTipIcon.Warning);

                                this.Lbl_StatusMsg.Text = "Pinging " + this.Txt_Target.Text + " Failed due to timeout!";

                                break;
                            default:
                                this.Notify.ShowBalloonTip(
                                    5000
                                    , "Ping Failed"
                                    , "Pinging " + this.Txt_Target.Text + " Failed!"
                                    , ToolTipIcon.Warning);

                                this.Lbl_StatusMsg.Text = "Pinging " + this.Txt_Target.Text + " Failed!";

                                break;
                        }
                    }
                }
            }
            else
            { this.Lbl_StatusMsg.Text = "Unknown Event Occured. Please Try Again."; }

            //this.Lbl_StatusMsg.Text = "Ready";

            this.Btn_Ping.Enabled = true;
            this.Btn_Cancel.Enabled = false;
            this.Chk_Timeout.Enabled = true;
            this.Txt_Target.Enabled = true;
            this.Txt_Timeout.Enabled = true;
        }

        #endregion

        #region _Methods

        void StartPing()
        {
            this.mAddress = this.Txt_Target.Text;
            this.mTimeout = (Convert_Int32(this.Txt_Timeout.Text, 5) * 1000);
            if (this.mTimeout <= 0)
            {
                MessageBox.Show("Warning", "Timeout must be greater than zero!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.Btn_Ping.Enabled = false;
            this.Btn_Cancel.Enabled = true;
            this.Chk_Timeout.Enabled = false;
            this.Txt_Target.Enabled = false;
            this.Txt_Timeout.Enabled = false;

            this.Ping();

            this.Lbl_StatusMsg.Text = "Pinging...";
        }

        void CancelPing()
        {
            this.mPing.SendAsyncCancel();
        }

        void Ping()
        {
            try
            { this.mPing.SendAsync(this.mAddress, CnsTimeout, new Object()); }
            catch
            {
                MessageBox.Show(
                        "An Error Occurred, please check the IP Address or Host Name and try again."
                        , "Error Occurred"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
            }

        }

        public static object IsNull(object Obj_Input, object Obj_NullOutput)
        {
            if (Obj_Input == null || Object.Equals(DBNull.Value, Obj_Input))
            { return Obj_NullOutput; }
            else
            { return Obj_Input; }
        }

        public static Int32 Convert_Int32(Object Value)
        { return Convert_Int32(Value, 0); }

        public static Int32 Convert_Int32(Object Value, Int32 DefaultValue)
        {
            string ValueString = string.Empty;
            if (Value != null)
            {
                try { ValueString = Value.ToString(); }
                catch { }
            }

            Int32 ReturnValue;
            if (!Int32.TryParse(ValueString, out ReturnValue))
            { ReturnValue = DefaultValue; }
            return ReturnValue;
        }

        #endregion
    }
}
