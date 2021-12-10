
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
            this.textBox_itemPrice = new System.Windows.Forms.TextBox();
            this.textBox_itemDiscount = new System.Windows.Forms.TextBox();
            this.button_itemInsert = new System.Windows.Forms.Button();
            this.label_insertConfirm = new System.Windows.Forms.Label();
            this.button_itemUpdate = new System.Windows.Forms.Button();
            this.button_itemDelete = new System.Windows.Forms.Button();
            this.textBox_itemId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(28, 21);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(767, 199);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            this.listBoxItems.DoubleClick += new System.EventHandler(this.listBoxItems_MouseDoubleClick);
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
            this.label_itemPrice.Location = new System.Drawing.Point(246, 260);
            this.label_itemPrice.Name = "label_itemPrice";
            this.label_itemPrice.Size = new System.Drawing.Size(59, 13);
            this.label_itemPrice.TabIndex = 2;
            this.label_itemPrice.Text = "Item Price:";
            // 
            // label_itemDiscount
            // 
            this.label_itemDiscount.AutoSize = true;
            this.label_itemDiscount.Location = new System.Drawing.Point(468, 260);
            this.label_itemDiscount.Name = "label_itemDiscount";
            this.label_itemDiscount.Size = new System.Drawing.Size(81, 13);
            this.label_itemDiscount.TabIndex = 3;
            this.label_itemDiscount.Text = "Item Discount:";
            // 
            // textBox_itemName
            // 
            this.textBox_itemName.Location = new System.Drawing.Point(28, 276);
            this.textBox_itemName.Name = "textBox_itemName";
            this.textBox_itemName.Size = new System.Drawing.Size(184, 22);
            this.textBox_itemName.TabIndex = 4;
            // 
            // textBox_itemPrice
            // 
            this.textBox_itemPrice.Location = new System.Drawing.Point(249, 276);
            this.textBox_itemPrice.Name = "textBox_itemPrice";
            this.textBox_itemPrice.Size = new System.Drawing.Size(184, 22);
            this.textBox_itemPrice.TabIndex = 5;
            // 
            // textBox_itemDiscount
            // 
            this.textBox_itemDiscount.Location = new System.Drawing.Point(471, 276);
            this.textBox_itemDiscount.Name = "textBox_itemDiscount";
            this.textBox_itemDiscount.Size = new System.Drawing.Size(184, 22);
            this.textBox_itemDiscount.TabIndex = 6;
            // 
            // button_itemInsert
            // 
            this.button_itemInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemInsert.Location = new System.Drawing.Point(28, 333);
            this.button_itemInsert.Name = "button_itemInsert";
            this.button_itemInsert.Size = new System.Drawing.Size(184, 100);
            this.button_itemInsert.TabIndex = 7;
            this.button_itemInsert.Text = "INSERT";
            this.button_itemInsert.UseVisualStyleBackColor = true;
            this.button_itemInsert.Click += new System.EventHandler(this.button_itemInsert_Click);
            // 
            // label_insertConfirm
            // 
            this.label_insertConfirm.AutoSize = true;
            this.label_insertConfirm.Location = new System.Drawing.Point(33, 444);
            this.label_insertConfirm.Name = "label_insertConfirm";
            this.label_insertConfirm.Size = new System.Drawing.Size(0, 13);
            this.label_insertConfirm.TabIndex = 8;
            // 
            // button_itemUpdate
            // 
            this.button_itemUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemUpdate.Location = new System.Drawing.Point(249, 333);
            this.button_itemUpdate.Name = "button_itemUpdate";
            this.button_itemUpdate.Size = new System.Drawing.Size(184, 100);
            this.button_itemUpdate.TabIndex = 9;
            this.button_itemUpdate.Text = "UPDATE";
            this.button_itemUpdate.UseVisualStyleBackColor = true;
            this.button_itemUpdate.Click += new System.EventHandler(this.button_itemUpdate_Click);
            // 
            // button_itemDelete
            // 
            this.button_itemDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemDelete.Location = new System.Drawing.Point(471, 333);
            this.button_itemDelete.Name = "button_itemDelete";
            this.button_itemDelete.Size = new System.Drawing.Size(184, 100);
            this.button_itemDelete.TabIndex = 10;
            this.button_itemDelete.Text = "DELETE";
            this.button_itemDelete.UseVisualStyleBackColor = true;
            this.button_itemDelete.Click += new System.EventHandler(this.button_itemDelete_Click);
            // 
            // textBox_itemId
            // 
            this.textBox_itemId.Enabled = false;
            this.textBox_itemId.Location = new System.Drawing.Point(681, 276);
            this.textBox_itemId.Name = "textBox_itemId";
            this.textBox_itemId.Size = new System.Drawing.Size(65, 22);
            this.textBox_itemId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(681, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id:";
            // 
            // Magacin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(821, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_itemId);
            this.Controls.Add(this.button_itemDelete);
            this.Controls.Add(this.button_itemUpdate);
            this.Controls.Add(this.label_insertConfirm);
            this.Controls.Add(this.button_itemInsert);
            this.Controls.Add(this.textBox_itemDiscount);
            this.Controls.Add(this.textBox_itemPrice);
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
        private System.Windows.Forms.TextBox textBox_itemPrice;
        private System.Windows.Forms.TextBox textBox_itemDiscount;
        private System.Windows.Forms.Button button_itemInsert;
        private System.Windows.Forms.Label label_insertConfirm;
        private System.Windows.Forms.Button button_itemUpdate;
        private System.Windows.Forms.Button button_itemDelete;
        private System.Windows.Forms.TextBox textBox_itemId;
        private System.Windows.Forms.Label label1;
    }
}

