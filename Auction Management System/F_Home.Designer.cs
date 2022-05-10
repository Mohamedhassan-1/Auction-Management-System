namespace Auction_Management_System
{
    partial class F_Home
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
            this.messagecontent = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // messagecontent
            // 
            this.messagecontent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagecontent.Location = new System.Drawing.Point(613, 60);
            this.messagecontent.Multiline = true;
            this.messagecontent.Name = "messagecontent";
            this.messagecontent.ReadOnly = true;
            this.messagecontent.Size = new System.Drawing.Size(251, 73);
            this.messagecontent.TabIndex = 9;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.DarkGray;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(554, 516);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(385, 59);
            this.logout.TabIndex = 8;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.DarkGray;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.Location = new System.Drawing.Point(554, 414);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(385, 59);
            this.help.TabIndex = 7;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.DarkGray;
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(554, 313);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(385, 59);
            this.product.TabIndex = 6;
            this.product.Text = "Buyer";
            this.product.UseVisualStyleBackColor = false;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(554, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "Seller";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(-2, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Home Page";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1333, 583);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 36);
            this.button4.TabIndex = 58;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1500, 28);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // F_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 630);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messagecontent);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.help);
            this.Controls.Add(this.product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Home";
            this.Load += new System.EventHandler(this.F_Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messagecontent;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
    }
}