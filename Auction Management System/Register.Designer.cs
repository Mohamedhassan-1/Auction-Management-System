namespace Auction_Management_System
{
    partial class Register
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_Gender = new Auction_Management_System.RJTextBox();
            this.txt_Name = new Auction_Management_System.RJTextBox();
            this.txt_Email = new Auction_Management_System.RJTextBox();
            this.txt_Pass = new Auction_Management_System.RJTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 68);
            this.button1.TabIndex = 13;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_name.Location = new System.Drawing.Point(290, -52);
            this.text_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(482, 30);
            this.text_name.TabIndex = 6;
            // 
            // Name_txt
            // 
            this.Name_txt.AutoSize = true;
            this.Name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.Location = new System.Drawing.Point(31, -45);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(64, 25);
            this.Name_txt.TabIndex = 5;
            this.Name_txt.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_Gender
            // 
            this.txt_Gender.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Gender.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txt_Gender.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Gender.BorderSize = 2;
            this.txt_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Gender.Location = new System.Drawing.Point(327, 363);
            this.txt_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Gender.Multiline = false;
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Gender.PasswordChar = false;
            this.txt_Gender.Size = new System.Drawing.Size(482, 35);
            this.txt_Gender.TabIndex = 14;
            this.txt_Gender.Texts = "";
            this.txt_Gender.UnderlinedStyle = false;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Name.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txt_Name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Name.BorderSize = 2;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Name.Location = new System.Drawing.Point(327, 39);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Multiline = false;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Name.PasswordChar = false;
            this.txt_Name.Size = new System.Drawing.Size(482, 35);
            this.txt_Name.TabIndex = 14;
            this.txt_Name.Texts = "";
            this.txt_Name.UnderlinedStyle = false;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Email.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txt_Email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Email.BorderSize = 2;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Email.Location = new System.Drawing.Point(327, 134);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Multiline = false;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Email.PasswordChar = false;
            this.txt_Email.Size = new System.Drawing.Size(482, 35);
            this.txt_Email.TabIndex = 14;
            this.txt_Email.Texts = "";
            this.txt_Email.UnderlinedStyle = false;
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Pass.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txt_Pass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Pass.BorderSize = 2;
            this.txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Pass.Location = new System.Drawing.Point(327, 249);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pass.Multiline = false;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Pass.PasswordChar = true;
            this.txt_Pass.Size = new System.Drawing.Size(482, 35);
            this.txt_Pass.TabIndex = 14;
            this.txt_Pass.Texts = "";
            this.txt_Pass.UnderlinedStyle = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 706);
            this.Controls.Add(this.txt_Gender);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.Name_txt);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label Name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RJTextBox txt_Pass;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private RJTextBox txt_Gender;
        private RJTextBox txt_Email;
        private RJTextBox txt_Name;
    }
}