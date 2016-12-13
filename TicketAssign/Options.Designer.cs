namespace TicketAssign
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_minutes = new System.Windows.Forms.TextBox();
            this.txt_guests = new System.Windows.Forms.TextBox();
            this.txt_startTime = new System.Windows.Forms.TextBox();
            this.txt_endTime = new System.Windows.Forms.TextBox();
            this.txt_firstTicket = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guests per window:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "End time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "First ticket number:";
            // 
            // txt_minutes
            // 
            this.txt_minutes.Location = new System.Drawing.Point(219, 21);
            this.txt_minutes.Name = "txt_minutes";
            this.txt_minutes.Size = new System.Drawing.Size(100, 26);
            this.txt_minutes.TabIndex = 5;
            // 
            // txt_guests
            // 
            this.txt_guests.Location = new System.Drawing.Point(219, 73);
            this.txt_guests.Name = "txt_guests";
            this.txt_guests.Size = new System.Drawing.Size(100, 26);
            this.txt_guests.TabIndex = 6;
            // 
            // txt_startTime
            // 
            this.txt_startTime.Location = new System.Drawing.Point(219, 131);
            this.txt_startTime.Name = "txt_startTime";
            this.txt_startTime.Size = new System.Drawing.Size(100, 26);
            this.txt_startTime.TabIndex = 7;
            // 
            // txt_endTime
            // 
            this.txt_endTime.Location = new System.Drawing.Point(219, 182);
            this.txt_endTime.Name = "txt_endTime";
            this.txt_endTime.Size = new System.Drawing.Size(100, 26);
            this.txt_endTime.TabIndex = 8;
            // 
            // txt_firstTicket
            // 
            this.txt_firstTicket.Location = new System.Drawing.Point(219, 237);
            this.txt_firstTicket.Name = "txt_firstTicket";
            this.txt_firstTicket.Size = new System.Drawing.Size(100, 26);
            this.txt_firstTicket.TabIndex = 9;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(219, 297);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(100, 33);
            this.btn_confirm.TabIndex = 10;
            this.btn_confirm.Text = "OK";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 355);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_firstTicket);
            this.Controls.Add(this.txt_endTime);
            this.Controls.Add(this.txt_startTime);
            this.Controls.Add(this.txt_guests);
            this.Controls.Add(this.txt_minutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_minutes;
        private System.Windows.Forms.TextBox txt_guests;
        private System.Windows.Forms.TextBox txt_startTime;
        private System.Windows.Forms.TextBox txt_endTime;
        private System.Windows.Forms.TextBox txt_firstTicket;
        private System.Windows.Forms.Button btn_confirm;
    }
}