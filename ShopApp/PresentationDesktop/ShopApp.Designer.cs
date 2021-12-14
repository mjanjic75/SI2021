
namespace PresentationDesktop
{
    partial class ShopApp
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
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dateTimePickerProduct = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInsertProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(33, 228);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(315, 173);
            this.listBoxProducts.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(73, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(253, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(73, 55);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(253, 20);
            this.textBoxDescription.TabIndex = 4;
            // 
            // dateTimePickerProduct
            // 
            this.dateTimePickerProduct.Location = new System.Drawing.Point(73, 91);
            this.dateTimePickerProduct.Name = "dateTimePickerProduct";
            this.dateTimePickerProduct.Size = new System.Drawing.Size(253, 20);
            this.dateTimePickerProduct.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rok:";
            // 
            // buttonInsertProduct
            // 
            this.buttonInsertProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertProduct.Location = new System.Drawing.Point(33, 145);
            this.buttonInsertProduct.Name = "buttonInsertProduct";
            this.buttonInsertProduct.Size = new System.Drawing.Size(315, 50);
            this.buttonInsertProduct.TabIndex = 7;
            this.buttonInsertProduct.Text = "DODAJ";
            this.buttonInsertProduct.UseVisualStyleBackColor = true;
            this.buttonInsertProduct.Click += new System.EventHandler(this.buttonInsertProduct_Click);
            // 
            // ShopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 427);
            this.Controls.Add(this.buttonInsertProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerProduct);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "ShopApp";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.ShopApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInsertProduct;
    }
}

