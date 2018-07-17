namespace setRTC
{
    partial class Form1
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
            this.SetRTCTime = new System.Windows.Forms.Button();
            this.LabelSysTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxSystemTime = new System.Windows.Forms.GroupBox();
            this.groupBoxRTCTime = new System.Windows.Forms.GroupBox();
            this.labelRTCTime = new System.Windows.Forms.Label();
            this.ComboBoxPorts = new System.Windows.Forms.ComboBox();
            this.groupBoxPorts = new System.Windows.Forms.GroupBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxSystemTime.SuspendLayout();
            this.groupBoxRTCTime.SuspendLayout();
            this.groupBoxPorts.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetRTCTime
            // 
            this.SetRTCTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetRTCTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SetRTCTime.Location = new System.Drawing.Point(100, 225);
            this.SetRTCTime.Name = "SetRTCTime";
            this.SetRTCTime.Size = new System.Drawing.Size(75, 25);
            this.SetRTCTime.TabIndex = 0;
            this.SetRTCTime.Text = "Sync Time";
            this.SetRTCTime.UseVisualStyleBackColor = true;
            this.SetRTCTime.Click += new System.EventHandler(this.SetRTCTime_Click);
            // 
            // LabelSysTime
            // 
            this.LabelSysTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelSysTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LabelSysTime.Location = new System.Drawing.Point(3, 17);
            this.LabelSysTime.Name = "LabelSysTime";
            this.LabelSysTime.Size = new System.Drawing.Size(281, 47);
            this.LabelSysTime.TabIndex = 1;
            this.LabelSysTime.Text = "SystemTime";
            this.LabelSysTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxSystemTime
            // 
            this.groupBoxSystemTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSystemTime.AutoSize = true;
            this.groupBoxSystemTime.Controls.Add(this.LabelSysTime);
            this.groupBoxSystemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBoxSystemTime.Location = new System.Drawing.Point(0, 5);
            this.groupBoxSystemTime.Name = "groupBoxSystemTime";
            this.groupBoxSystemTime.Size = new System.Drawing.Size(287, 67);
            this.groupBoxSystemTime.TabIndex = 2;
            this.groupBoxSystemTime.TabStop = false;
            this.groupBoxSystemTime.Text = "SystemTime";
            // 
            // groupBoxRTCTime
            // 
            this.groupBoxRTCTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRTCTime.AutoSize = true;
            this.groupBoxRTCTime.Controls.Add(this.labelRTCTime);
            this.groupBoxRTCTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBoxRTCTime.Location = new System.Drawing.Point(0, 78);
            this.groupBoxRTCTime.Name = "groupBoxRTCTime";
            this.groupBoxRTCTime.Size = new System.Drawing.Size(287, 67);
            this.groupBoxRTCTime.TabIndex = 2;
            this.groupBoxRTCTime.TabStop = false;
            this.groupBoxRTCTime.Text = "RTCTime";
            // 
            // labelRTCTime
            // 
            this.labelRTCTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRTCTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelRTCTime.Location = new System.Drawing.Point(3, 17);
            this.labelRTCTime.Name = "labelRTCTime";
            this.labelRTCTime.Size = new System.Drawing.Size(281, 47);
            this.labelRTCTime.TabIndex = 0;
            this.labelRTCTime.Text = "RTCTime";
            this.labelRTCTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ComboBoxPorts
            // 
            this.ComboBoxPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPorts.FormattingEnabled = true;
            this.ComboBoxPorts.Items.AddRange(new object[] {
            "Disconnect"});
            this.ComboBoxPorts.Location = new System.Drawing.Point(12, 28);
            this.ComboBoxPorts.Name = "ComboBoxPorts";
            this.ComboBoxPorts.Size = new System.Drawing.Size(259, 23);
            this.ComboBoxPorts.TabIndex = 3;
            this.ComboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPorts_SelectedIndexChanged);
            this.ComboBoxPorts.Click += new System.EventHandler(this.ComboBoxPorts_Click);
            // 
            // groupBoxPorts
            // 
            this.groupBoxPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPorts.Controls.Add(this.ComboBoxPorts);
            this.groupBoxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBoxPorts.Location = new System.Drawing.Point(0, 151);
            this.groupBoxPorts.Name = "groupBoxPorts";
            this.groupBoxPorts.Size = new System.Drawing.Size(287, 67);
            this.groupBoxPorts.TabIndex = 4;
            this.groupBoxPorts.TabStop = false;
            this.groupBoxPorts.Text = "Ports";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusStrip.AutoSize = false;
            this.StatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 260);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(287, 22);
            this.StatusStrip.TabIndex = 5;
            // 
            // StripStatusLabel
            // 
            this.StripStatusLabel.Name = "StripStatusLabel";
            this.StripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.SetRTCTime);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.groupBoxPorts);
            this.Controls.Add(this.groupBoxRTCTime);
            this.Controls.Add(this.groupBoxSystemTime);
            this.MinimumSize = new System.Drawing.Size(300, 320);
            this.Name = "Form1";
            this.Text = "SetRTC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSystemTime.ResumeLayout(false);
            this.groupBoxRTCTime.ResumeLayout(false);
            this.groupBoxPorts.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetRTCTime;
        private System.Windows.Forms.Label LabelSysTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxSystemTime;
        private System.Windows.Forms.GroupBox groupBoxRTCTime;
        private System.Windows.Forms.Label labelRTCTime;
        private System.Windows.Forms.ComboBox ComboBoxPorts;
        private System.Windows.Forms.GroupBox groupBoxPorts;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel;
    }
}

