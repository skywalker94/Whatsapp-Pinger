namespace Whatsapp_Pinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.textBox_to = new System.Windows.Forms.TextBox();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(9, 15);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(20, 13);
            this.lbl_to.TabIndex = 0;
            this.lbl_to.Text = "To";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(9, 64);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(50, 13);
            this.lbl_msg.TabIndex = 1;
            this.lbl_msg.Text = "Message";
            // 
            // textBox_to
            // 
            this.textBox_to.Location = new System.Drawing.Point(38, 12);
            this.textBox_to.Name = "textBox_to";
            this.textBox_to.Size = new System.Drawing.Size(184, 20);
            this.textBox_to.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox_to, "number with country code");
            // 
            // textBox_msg
            // 
            this.textBox_msg.Location = new System.Drawing.Point(12, 80);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(210, 77);
            this.textBox_msg.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox_msg, "your message text");
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Black;
            this.btn_send.Location = new System.Drawing.Point(66, 163);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(102, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.toolTip1.SetToolTip(this.btn_send, "send to above number");
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textBox_from
            // 
            this.textBox_from.Location = new System.Drawing.Point(38, 38);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(184, 20);
            this.textBox_from.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBox_from, "number with country code");
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(9, 41);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(30, 13);
            this.lbl_from.TabIndex = 5;
            this.lbl_from.Text = "From";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(234, 191);
            this.Controls.Add(this.textBox_from);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.textBox_to);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lbl_to);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(250, 230);
            this.MinimumSize = new System.Drawing.Size(250, 230);
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.Text = "Whatsapp Pinger v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.TextBox textBox_to;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.Label lbl_from;
    }
}

