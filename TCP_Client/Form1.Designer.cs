namespace TCP_Client
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
            this.adress = new System.Windows.Forms.TextBox();
            this.myPort = new System.Windows.Forms.NumericUpDown();
            this.info_about_connections = new System.Windows.Forms.ListBox();
            this.connect = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myPort)).BeginInit();
            this.SuspendLayout();
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(171, 90);
            this.adress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(263, 22);
            this.adress.TabIndex = 0;
            this.adress.Text = "adress";
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(683, 90);
            this.myPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.myPort.Name = "myPort";
            this.myPort.Size = new System.Drawing.Size(275, 22);
            this.myPort.TabIndex = 1;
            // 
            // info_about_connections
            // 
            this.info_about_connections.FormattingEnabled = true;
            this.info_about_connections.ItemHeight = 16;
            this.info_about_connections.Location = new System.Drawing.Point(171, 146);
            this.info_about_connections.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.info_about_connections.Name = "info_about_connections";
            this.info_about_connections.Size = new System.Drawing.Size(785, 308);
            this.info_about_connections.TabIndex = 2;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(751, 511);
            this.connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(207, 73);
            this.connect.TabIndex = 3;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainLabel.Location = new System.Drawing.Point(375, 11);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(258, 54);
            this.mainLabel.TabIndex = 4;
            this.mainLabel.Text = "TCP Client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 631);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.info_about_connections);
            this.Controls.Add(this.myPort);
            this.Controls.Add(this.adress);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.NumericUpDown myPort;
        private System.Windows.Forms.ListBox info_about_connections;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label mainLabel;
    }
}

