namespace PingComputer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Txt_Target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Chk_Timeout = new System.Windows.Forms.CheckBox();
            this.Btn_Ping = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.Lbl_StatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.Txt_Timeout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Target
            // 
            this.Txt_Target.Location = new System.Drawing.Point(12, 29);
            this.Txt_Target.Name = "Txt_Target";
            this.Txt_Target.Size = new System.Drawing.Size(200, 20);
            this.Txt_Target.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target Computer IP/HostName";
            // 
            // Chk_Timeout
            // 
            this.Chk_Timeout.AutoSize = true;
            this.Chk_Timeout.Location = new System.Drawing.Point(16, 55);
            this.Chk_Timeout.Name = "Chk_Timeout";
            this.Chk_Timeout.Size = new System.Drawing.Size(92, 17);
            this.Chk_Timeout.TabIndex = 2;
            this.Chk_Timeout.Text = "Has Timeout?";
            this.Chk_Timeout.UseVisualStyleBackColor = true;
            // 
            // Btn_Ping
            // 
            this.Btn_Ping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ping.Location = new System.Drawing.Point(12, 78);
            this.Btn_Ping.Name = "Btn_Ping";
            this.Btn_Ping.Size = new System.Drawing.Size(80, 25);
            this.Btn_Ping.TabIndex = 3;
            this.Btn_Ping.Text = "PING!";
            this.Btn_Ping.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_StatusMsg});
            this.Status.Location = new System.Drawing.Point(0, 140);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(284, 22);
            this.Status.TabIndex = 4;
            this.Status.Text = "statusStrip1";
            // 
            // Lbl_StatusMsg
            // 
            this.Lbl_StatusMsg.Name = "Lbl_StatusMsg";
            this.Lbl_StatusMsg.Size = new System.Drawing.Size(62, 17);
            this.Lbl_StatusMsg.Text = "StatusMsg";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(98, 78);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 25);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "Cancel Ping!";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "Ping Computer!";
            this.Notify.Visible = true;
            // 
            // Txt_Timeout
            // 
            this.Txt_Timeout.Location = new System.Drawing.Point(114, 53);
            this.Txt_Timeout.Name = "Txt_Timeout";
            this.Txt_Timeout.Size = new System.Drawing.Size(98, 20);
            this.Txt_Timeout.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "secs.";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Timeout);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Btn_Ping);
            this.Controls.Add(this.Chk_Timeout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Target);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Computer!";
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Chk_Timeout;
        private System.Windows.Forms.Button Btn_Ping;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_StatusMsg;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.TextBox Txt_Timeout;
        private System.Windows.Forms.Label label2;
    }
}

