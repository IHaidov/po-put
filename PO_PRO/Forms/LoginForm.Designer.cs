namespace PO_PRO
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
            this.Login_tab_control = new System.Windows.Forms.TabControl();
            this.Login_tab = new System.Windows.Forms.TabPage();
            this.Register_tab_control = new System.Windows.Forms.TabPage();
            this.Login_button = new System.Windows.Forms.Button();
            this.Login_email_textbox = new System.Windows.Forms.TextBox();
            this.Login_pass_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Login_tab_control.SuspendLayout();
            this.Login_tab.SuspendLayout();
            this.Register_tab_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_tab_control
            // 
            this.Login_tab_control.Controls.Add(this.Login_tab);
            this.Login_tab_control.Controls.Add(this.Register_tab_control);
            this.Login_tab_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_tab_control.Location = new System.Drawing.Point(0, 0);
            this.Login_tab_control.Name = "Login_tab_control";
            this.Login_tab_control.SelectedIndex = 0;
            this.Login_tab_control.Size = new System.Drawing.Size(330, 430);
            this.Login_tab_control.TabIndex = 0;
            // 
            // Login_tab
            // 
            this.Login_tab.Controls.Add(this.label2);
            this.Login_tab.Controls.Add(this.label1);
            this.Login_tab.Controls.Add(this.Login_pass_textbox);
            this.Login_tab.Controls.Add(this.Login_email_textbox);
            this.Login_tab.Controls.Add(this.Login_button);
            this.Login_tab.Location = new System.Drawing.Point(4, 29);
            this.Login_tab.Name = "Login_tab";
            this.Login_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Login_tab.Size = new System.Drawing.Size(322, 397);
            this.Login_tab.TabIndex = 0;
            this.Login_tab.Text = "Login";
            this.Login_tab.UseVisualStyleBackColor = true;
            this.Login_tab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Register_tab_control
            // 
            this.Register_tab_control.Controls.Add(this.label3);
            this.Register_tab_control.Controls.Add(this.label4);
            this.Register_tab_control.Controls.Add(this.textBox1);
            this.Register_tab_control.Controls.Add(this.textBox2);
            this.Register_tab_control.Controls.Add(this.button1);
            this.Register_tab_control.Location = new System.Drawing.Point(4, 29);
            this.Register_tab_control.Name = "Register_tab_control";
            this.Register_tab_control.Padding = new System.Windows.Forms.Padding(3);
            this.Register_tab_control.Size = new System.Drawing.Size(322, 397);
            this.Register_tab_control.TabIndex = 1;
            this.Register_tab_control.Text = "Register";
            this.Register_tab_control.UseVisualStyleBackColor = true;
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(40, 271);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(214, 54);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "Log in";
            this.Login_button.UseVisualStyleBackColor = true;
            // 
            // Login_email_textbox
            // 
            this.Login_email_textbox.Location = new System.Drawing.Point(40, 61);
            this.Login_email_textbox.Name = "Login_email_textbox";
            this.Login_email_textbox.Size = new System.Drawing.Size(214, 26);
            this.Login_email_textbox.TabIndex = 1;
            // 
            // Login_pass_textbox
            // 
            this.Login_pass_textbox.Location = new System.Drawing.Point(40, 127);
            this.Login_pass_textbox.Name = "Login_pass_textbox";
            this.Login_pass_textbox.Size = new System.Drawing.Size(214, 26);
            this.Login_pass_textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 26);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 430);
            this.Controls.Add(this.Login_tab_control);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Login_tab_control.ResumeLayout(false);
            this.Login_tab.ResumeLayout(false);
            this.Login_tab.PerformLayout();
            this.Register_tab_control.ResumeLayout(false);
            this.Register_tab_control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Login_tab_control;
        private System.Windows.Forms.TabPage Login_tab;
        private System.Windows.Forms.TabPage Register_tab_control;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login_pass_textbox;
        private System.Windows.Forms.TextBox Login_email_textbox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

