
namespace Supply_Chain_Management
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxRegCompany = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxCPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonSubmit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Register as a Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Confirm Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(267, 649);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Have already account?Login here";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxRegCompany
            // 
            this.textBoxRegCompany.Depth = 0;
            this.textBoxRegCompany.Hint = "";
            this.textBoxRegCompany.Location = new System.Drawing.Point(320, 145);
            this.textBoxRegCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxRegCompany.Name = "textBoxRegCompany";
            this.textBoxRegCompany.PasswordChar = '\0';
            this.textBoxRegCompany.SelectedText = "";
            this.textBoxRegCompany.SelectionLength = 0;
            this.textBoxRegCompany.SelectionStart = 0;
            this.textBoxRegCompany.Size = new System.Drawing.Size(418, 32);
            this.textBoxRegCompany.TabIndex = 18;
            this.textBoxRegCompany.UseSystemPasswordChar = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Depth = 0;
            this.textBoxEmail.Hint = "";
            this.textBoxEmail.Location = new System.Drawing.Point(320, 202);
            this.textBoxEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.SelectionLength = 0;
            this.textBoxEmail.SelectionStart = 0;
            this.textBoxEmail.Size = new System.Drawing.Size(418, 32);
            this.textBoxEmail.TabIndex = 19;
            this.textBoxEmail.UseSystemPasswordChar = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Depth = 0;
            this.textBoxName.Hint = "";
            this.textBoxName.Location = new System.Drawing.Point(320, 259);
            this.textBoxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.SelectedText = "";
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.Size = new System.Drawing.Size(418, 32);
            this.textBoxName.TabIndex = 20;
            this.textBoxName.UseSystemPasswordChar = false;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Depth = 0;
            this.textBoxNumber.Hint = "";
            this.textBoxNumber.Location = new System.Drawing.Point(320, 316);
            this.textBoxNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.PasswordChar = '\0';
            this.textBoxNumber.SelectedText = "";
            this.textBoxNumber.SelectionLength = 0;
            this.textBoxNumber.SelectionStart = 0;
            this.textBoxNumber.Size = new System.Drawing.Size(418, 32);
            this.textBoxNumber.TabIndex = 21;
            this.textBoxNumber.UseSystemPasswordChar = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Depth = 0;
            this.textBoxAddress.Hint = "";
            this.textBoxAddress.Location = new System.Drawing.Point(320, 374);
            this.textBoxAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.PasswordChar = '\0';
            this.textBoxAddress.SelectedText = "";
            this.textBoxAddress.SelectionLength = 0;
            this.textBoxAddress.SelectionStart = 0;
            this.textBoxAddress.Size = new System.Drawing.Size(418, 32);
            this.textBoxAddress.TabIndex = 22;
            this.textBoxAddress.UseSystemPasswordChar = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Hint = "";
            this.textBoxPassword.Location = new System.Drawing.Point(320, 441);
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(418, 32);
            this.textBoxPassword.TabIndex = 23;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxCPassword
            // 
            this.textBoxCPassword.Depth = 0;
            this.textBoxCPassword.Hint = "";
            this.textBoxCPassword.Location = new System.Drawing.Point(320, 491);
            this.textBoxCPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxCPassword.Name = "textBoxCPassword";
            this.textBoxCPassword.PasswordChar = '*';
            this.textBoxCPassword.SelectedText = "";
            this.textBoxCPassword.SelectionLength = 0;
            this.textBoxCPassword.SelectionStart = 0;
            this.textBoxCPassword.Size = new System.Drawing.Size(418, 32);
            this.textBoxCPassword.TabIndex = 24;
            this.textBoxCPassword.UseSystemPasswordChar = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Animated = true;
            this.buttonSubmit.AutoRoundedCorners = true;
            this.buttonSubmit.BorderRadius = 35;
            this.buttonSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSubmit.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(288, 563);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(193, 73);
            this.buttonSubmit.TabIndex = 26;
            this.buttonSubmit.Text = "Register";
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 738);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxCPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxRegCompany);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxRegCompany;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxCPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
        private Guna.UI2.WinForms.Guna2Button buttonSubmit;
    }
}