namespace ArduinoUploader
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
            this.comboxComports = new System.Windows.Forms.ComboBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnEraseSAM = new System.Windows.Forms.Button();
            this.btnupload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboxComports
            // 
            this.comboxComports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxComports.FormattingEnabled = true;
            this.comboxComports.Location = new System.Drawing.Point(39, 35);
            this.comboxComports.Name = "comboxComports";
            this.comboxComports.Size = new System.Drawing.Size(159, 21);
            this.comboxComports.TabIndex = 3;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(228, 33);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(159, 23);
            this.btnrefresh.TabIndex = 2;
            this.btnrefresh.Text = "Refresh Port";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnEraseSAM
            // 
            this.btnEraseSAM.Location = new System.Drawing.Point(228, 85);
            this.btnEraseSAM.Name = "btnEraseSAM";
            this.btnEraseSAM.Size = new System.Drawing.Size(159, 23);
            this.btnEraseSAM.TabIndex = 4;
            this.btnEraseSAM.Text = "Erase Flash";
            this.btnEraseSAM.UseVisualStyleBackColor = true;
            this.btnEraseSAM.Click += new System.EventHandler(this.btnEraseSAM_Click);
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(39, 85);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(159, 23);
            this.btnupload.TabIndex = 54;
            this.btnupload.Text = "Upload";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 151);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.btnEraseSAM);
            this.Controls.Add(this.comboxComports);
            this.Controls.Add(this.btnrefresh);
            this.Name = "Form1";
            this.Text = "Arduino Uploader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxComports;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnEraseSAM;
        private System.Windows.Forms.Button btnupload;
    }
}

