namespace Auction_Management_System
{
    partial class Home
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
            this.product = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.messagecontent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(251, 195);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(194, 52);
            this.product.TabIndex = 0;
            this.product.Text = "Product";
            this.product.UseVisualStyleBackColor = true;
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(251, 273);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(194, 52);
            this.help.TabIndex = 1;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(251, 353);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(194, 52);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // messagecontent
            // 
            this.messagecontent.Location = new System.Drawing.Point(161, 455);
            this.messagecontent.Multiline = true;
            this.messagecontent.Name = "messagecontent";
            this.messagecontent.ReadOnly = true;
            this.messagecontent.Size = new System.Drawing.Size(368, 168);
            this.messagecontent.TabIndex = 3;
            this.messagecontent.TextChanged += new System.EventHandler(this.messagebox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Auction_Management_System.Properties.Resources.homelogo;
            this.pictureBox1.Location = new System.Drawing.Point(215, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 203);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 663);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messagecontent);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.help);
            this.Controls.Add(this.product);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TextBox messagecontent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}