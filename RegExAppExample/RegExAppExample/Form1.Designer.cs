
namespace RegExAppExample
{
    partial class Form_RegExApp
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_ZIP = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_ZIP = new System.Windows.Forms.TextBox();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(58, 47);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(298, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Validate User Details";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(64, 150);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(55, 21);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name:";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Surname.Location = new System.Drawing.Point(43, 194);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(76, 21);
            this.label_Surname.TabIndex = 2;
            this.label_Surname.Text = "Surname:";
            this.label_Surname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.Location = new System.Drawing.Point(50, 238);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(69, 21);
            this.label_Address.TabIndex = 3;
            this.label_Address.Text = "Address:";
            this.label_Address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_City.Location = new System.Drawing.Point(78, 284);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(40, 21);
            this.label_City.TabIndex = 4;
            this.label_City.Text = "City:";
            this.label_City.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ZIP
            // 
            this.label_ZIP.AutoSize = true;
            this.label_ZIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ZIP.Location = new System.Drawing.Point(43, 327);
            this.label_ZIP.Name = "label_ZIP";
            this.label_ZIP.Size = new System.Drawing.Size(75, 21);
            this.label_ZIP.TabIndex = 5;
            this.label_ZIP.Text = "ZIP Code:";
            this.label_ZIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Country.Location = new System.Drawing.Point(49, 368);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(69, 21);
            this.label_Country.TabIndex = 6;
            this.label_Country.Text = "Country:";
            this.label_Country.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Phone.Location = new System.Drawing.Point(61, 417);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(57, 21);
            this.label_Phone.TabIndex = 7;
            this.label_Phone.Text = "Phone:";
            this.label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(126, 150);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(164, 20);
            this.textBox_Name.TabIndex = 8;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(124, 194);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(166, 20);
            this.textBox_Surname.TabIndex = 9;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(126, 238);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(164, 20);
            this.textBox_Address.TabIndex = 10;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(124, 284);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(164, 20);
            this.textBox_City.TabIndex = 11;
            // 
            // textBox_ZIP
            // 
            this.textBox_ZIP.Location = new System.Drawing.Point(124, 327);
            this.textBox_ZIP.Name = "textBox_ZIP";
            this.textBox_ZIP.Size = new System.Drawing.Size(164, 20);
            this.textBox_ZIP.TabIndex = 12;
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(124, 368);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(164, 20);
            this.textBox_Country.TabIndex = 13;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(124, 417);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(164, 20);
            this.textBox_Phone.TabIndex = 14;
            // 
            // button_Register
            // 
            this.button_Register.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Location = new System.Drawing.Point(12, 467);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(370, 64);
            this.button_Register.TabIndex = 15;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // Form_RegExApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 563);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.textBox_ZIP);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.label_ZIP);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Title);
            this.Name = "Form_RegExApp";
            this.Text = "RegEx App Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_ZIP;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_ZIP;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Button button_Register;
    }
}

