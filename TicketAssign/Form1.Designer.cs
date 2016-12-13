namespace TicketAssign
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_guestsAvail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_available = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_issueTicket = new System.Windows.Forms.Button();
            this.lst_nextTicket = new System.Windows.Forms.ListBox();
            this.btn_options = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_guestsAvail);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may now enter:";
            // 
            // lbl_guestsAvail
            // 
            this.lbl_guestsAvail.AutoSize = true;
            this.lbl_guestsAvail.Location = new System.Drawing.Point(23, 39);
            this.lbl_guestsAvail.Name = "lbl_guestsAvail";
            this.lbl_guestsAvail.Size = new System.Drawing.Size(0, 20);
            this.lbl_guestsAvail.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_available);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_issueTicket);
            this.groupBox2.Location = new System.Drawing.Point(13, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // lbl_available
            // 
            this.lbl_available.AutoSize = true;
            this.lbl_available.Location = new System.Drawing.Point(278, 90);
            this.lbl_available.Name = "lbl_available";
            this.lbl_available.Size = new System.Drawing.Size(0, 20);
            this.lbl_available.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Next available entry:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total tickets outstanding:";
            // 
            // btn_issueTicket
            // 
            this.btn_issueTicket.Location = new System.Drawing.Point(23, 131);
            this.btn_issueTicket.Name = "btn_issueTicket";
            this.btn_issueTicket.Size = new System.Drawing.Size(186, 35);
            this.btn_issueTicket.TabIndex = 0;
            this.btn_issueTicket.Text = "Issue Ticket";
            this.btn_issueTicket.UseVisualStyleBackColor = true;
            this.btn_issueTicket.Click += new System.EventHandler(this.btn_issueTicket_Click);
            // 
            // lst_nextTicket
            // 
            this.lst_nextTicket.FormattingEnabled = true;
            this.lst_nextTicket.ItemHeight = 20;
            this.lst_nextTicket.Location = new System.Drawing.Point(13, 315);
            this.lst_nextTicket.Name = "lst_nextTicket";
            this.lst_nextTicket.Size = new System.Drawing.Size(450, 224);
            this.lst_nextTicket.TabIndex = 2;
            // 
            // btn_options
            // 
            this.btn_options.Location = new System.Drawing.Point(13, 584);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(162, 43);
            this.btn_options.TabIndex = 3;
            this.btn_options.Text = "Options";
            this.btn_options.UseVisualStyleBackColor = true;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(295, 584);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(168, 43);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 652);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.lst_nextTicket);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_issueTicket;
        private System.Windows.Forms.ListBox lst_nextTicket;
        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_guestsAvail;
        private System.Windows.Forms.Label lbl_available;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
    }
}

