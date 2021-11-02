
namespace Magacin
{
    partial class Magacin
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
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.label_itemName = new System.Windows.Forms.Label();
            this.label_itemPrice = new System.Windows.Forms.Label();
            this.label_itemDiscount = new System.Windows.Forms.Label();
            this.textBox_itemName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_itemInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(28, 21);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(781, 199);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // label_itemName
            // 
            this.label_itemName.AutoSize = true;
            this.label_itemName.Location = new System.Drawing.Point(25, 260);
            this.label_itemName.Name = "label_itemName";
            this.label_itemName.Size = new System.Drawing.Size(64, 13);
            this.label_itemName.TabIndex = 1;
            this.label_itemName.Text = "Item Name:";
            // 
            // label_itemPrice
            // 
            this.label_itemPrice.AutoSize = true;
            this.label_itemPrice.Location = new System.Drawing.Point(28, 297);
            this.label_itemPrice.Name = "label_itemPrice";
            this.label_itemPrice.Size = new System.Drawing.Size(59, 13);
            this.label_itemPrice.TabIndex = 2;
            this.label_itemPrice.Text = "Item Price:";
            // 
            // label_itemDiscount
            // 
            this.label_itemDiscount.AutoSize = true;
            this.label_itemDiscount.Location = new System.Drawing.Point(31, 338);
            this.label_itemDiscount.Name = "label_itemDiscount";
            this.label_itemDiscount.Size = new System.Drawing.Size(81, 13);
            this.label_itemDiscount.TabIndex = 3;
            this.label_itemDiscount.Text = "Item Discount:";
            // 
            // textBox_itemName
            // 
            this.textBox_itemName.Location = new System.Drawing.Point(121, 260);
            this.textBox_itemName.Name = "textBox_itemName";
            this.textBox_itemName.Size = new System.Drawing.Size(184, 22);
            this.textBox_itemName.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 338);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 22);
            this.textBox3.TabIndex = 6;
            // 
            // button_itemInsert
            // 
            this.button_itemInsert.Location = new System.Drawing.Point(371, 260);
            this.button_itemInsert.Name = "button_itemInsert";
            this.button_itemInsert.Size = new System.Drawing.Size(163, 100);
            this.button_itemInsert.TabIndex = 7;
            this.button_itemInsert.Text = "INSERT";
            this.button_itemInsert.UseVisualStyleBackColor = true;
            // 
            // Magacin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(821, 473);
            this.Controls.Add(this.button_itemInsert);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_itemName);
            this.Controls.Add(this.label_itemDiscount);
            this.Controls.Add(this.label_itemPrice);
            this.Controls.Add(this.label_itemName);
            this.Controls.Add(this.listBoxItems);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Magacin";
            this.Text = "TZR \"Magacin\"";
            this.Load += new System.EventHandler(this.Magacin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Label label_itemName;
        private System.Windows.Forms.Label label_itemPrice;
        private System.Windows.Forms.Label label_itemDiscount;
        private System.Windows.Forms.TextBox textBox_itemName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_itemInsert;
    }
}

