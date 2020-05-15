namespace UDP_Client
{
    partial class Client
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
            System.Windows.Forms.Label nameLbl;
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.field0 = new System.Windows.Forms.PictureBox();
            this.PlayfieldGrpBox = new System.Windows.Forms.GroupBox();
            this.field8 = new System.Windows.Forms.PictureBox();
            this.field7 = new System.Windows.Forms.PictureBox();
            this.field6 = new System.Windows.Forms.PictureBox();
            this.field5 = new System.Windows.Forms.PictureBox();
            this.field4 = new System.Windows.Forms.PictureBox();
            this.field3 = new System.Windows.Forms.PictureBox();
            this.field2 = new System.Windows.Forms.PictureBox();
            this.field1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            nameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.field0)).BeginInit();
            this.PlayfieldGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLbl.Location = new System.Drawing.Point(8, 9);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new System.Drawing.Size(126, 20);
            nameLbl.TabIndex = 1;
            nameLbl.Text = "Enter your name";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxtBox.Location = new System.Drawing.Point(12, 32);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(296, 26);
            this.NameTxtBox.TabIndex = 0;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectBtn.Location = new System.Drawing.Point(12, 64);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(296, 33);
            this.ConnectBtn.TabIndex = 2;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // field0
            // 
            this.field0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.field0.Location = new System.Drawing.Point(6, 11);
            this.field0.Name = "field0";
            this.field0.Size = new System.Drawing.Size(90, 90);
            this.field0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.field0.TabIndex = 3;
            this.field0.TabStop = false;
            this.field0.Click += new System.EventHandler(this.Field_Click);
            // 
            // PlayfieldGrpBox
            // 
            this.PlayfieldGrpBox.Controls.Add(this.field8);
            this.PlayfieldGrpBox.Controls.Add(this.field7);
            this.PlayfieldGrpBox.Controls.Add(this.field6);
            this.PlayfieldGrpBox.Controls.Add(this.field5);
            this.PlayfieldGrpBox.Controls.Add(this.field4);
            this.PlayfieldGrpBox.Controls.Add(this.field3);
            this.PlayfieldGrpBox.Controls.Add(this.field2);
            this.PlayfieldGrpBox.Controls.Add(this.field1);
            this.PlayfieldGrpBox.Controls.Add(this.field0);
            this.PlayfieldGrpBox.Enabled = false;
            this.PlayfieldGrpBox.Location = new System.Drawing.Point(12, 123);
            this.PlayfieldGrpBox.Name = "PlayfieldGrpBox";
            this.PlayfieldGrpBox.Size = new System.Drawing.Size(296, 300);
            this.PlayfieldGrpBox.TabIndex = 4;
            this.PlayfieldGrpBox.TabStop = false;
            // 
            // field8
            // 
            this.field8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.field8.Location = new System.Drawing.Point(198, 203);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(90, 90);
            this.field8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.field8.TabIndex = 11;
            this.field8.TabStop = false;
            this.field8.Click += new System.EventHandler(this.Field_Click);
            // 
            // field7
            // 
            this.field7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.field7.Location = new System.Drawing.Point(102, 204);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(90, 90);
            this.field7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.field7.TabIndex = 10;
            this.field7.TabStop = false;
            this.field7.Click += new System.EventHandler(this.Field_Click);
            // 
            // field6
            // 
            this.field6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.field6.Location = new System.Drawing.Point(6, 203);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(90, 90);
            this.field6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.field6.TabIndex = 9;
            this.field6.TabStop = false;
            this.field6.Click += new System.EventHandler(this.Field_Click);
            // 
            // field5
            // 
            this.field5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.field5.Location = new System.Drawing.Point(198, 107);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(90, 90);
            this.field5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.field5.TabIndex = 8;
            this.field5.TabStop = false;
            this.field5.Click += new System.EventHandler(this.Field_Click);
            // 
            // field4
            // 
            this.field4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.field4.Location = new System.Drawing.Point(102, 107);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(90, 90);
            this.field4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.field4.TabIndex = 7;
            this.field4.TabStop = false;
            this.field4.Click += new System.EventHandler(this.Field_Click);
            // 
            // field3
            // 
            this.field3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.field3.Location = new System.Drawing.Point(6, 107);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(90, 90);
            this.field3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.field3.TabIndex = 6;
            this.field3.TabStop = false;
            this.field3.Click += new System.EventHandler(this.Field_Click);
            // 
            // field2
            // 
            this.field2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.field2.Location = new System.Drawing.Point(198, 11);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(90, 90);
            this.field2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.field2.TabIndex = 5;
            this.field2.TabStop = false;
            this.field2.Click += new System.EventHandler(this.Field_Click);
            // 
            // field1
            // 
            this.field1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.field1.Location = new System.Drawing.Point(102, 11);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(90, 90);
            this.field1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.field1.TabIndex = 4;
            this.field1.TabStop = false;
            this.field1.Click += new System.EventHandler(this.Field_Click);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLbl.Location = new System.Drawing.Point(71, 100);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(107, 20);
            this.StatusLbl.TabIndex = 5;
            this.StatusLbl.Text = "Disconnected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.PlayfieldGrpBox);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(nameLbl);
            this.Controls.Add(this.NameTxtBox);
            this.Name = "Client";
            this.Text = "Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)(this.field0)).EndInit();
            this.PlayfieldGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.field8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.PictureBox field0;
        private System.Windows.Forms.GroupBox PlayfieldGrpBox;
        private System.Windows.Forms.PictureBox field8;
        private System.Windows.Forms.PictureBox field7;
        private System.Windows.Forms.PictureBox field6;
        private System.Windows.Forms.PictureBox field5;
        private System.Windows.Forms.PictureBox field4;
        private System.Windows.Forms.PictureBox field3;
        private System.Windows.Forms.PictureBox field2;
        private System.Windows.Forms.PictureBox field1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label label1;
    }
}

