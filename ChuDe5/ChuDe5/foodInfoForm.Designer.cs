namespace _ChuDe5
{
    partial class foodInfoForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFoodID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.cbbCatName = new System.Windows.Forms.ComboBox();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.nudPrice = new System.Windows.Forms.NumericUpDown();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.btnUpdateFood = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "FoodID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Unit";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "CategoryName";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(46, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Price";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(46, 274);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Notes";
			// 
			// txtFoodID
			// 
			this.txtFoodID.BackColor = System.Drawing.SystemColors.HighlightText;
			this.txtFoodID.Location = new System.Drawing.Point(133, 34);
			this.txtFoodID.Name = "txtFoodID";
			this.txtFoodID.ReadOnly = true;
			this.txtFoodID.Size = new System.Drawing.Size(169, 20);
			this.txtFoodID.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(133, 83);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(545, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(133, 124);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(545, 20);
			this.txtUnit.TabIndex = 1;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(133, 274);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(545, 20);
			this.txtNotes.TabIndex = 1;
			// 
			// cbbCatName
			// 
			this.cbbCatName.FormattingEnabled = true;
			this.cbbCatName.Location = new System.Drawing.Point(141, 170);
			this.cbbCatName.Name = "cbbCatName";
			this.cbbCatName.Size = new System.Drawing.Size(383, 21);
			this.cbbCatName.TabIndex = 2;
			// 
			// btnAddNew
			// 
			this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.btnAddNew.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAddNew.Location = new System.Drawing.Point(563, 163);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(106, 32);
			this.btnAddNew.TabIndex = 3;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// nudPrice
			// 
			this.nudPrice.Location = new System.Drawing.Point(139, 221);
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(530, 20);
			this.nudPrice.TabIndex = 4;
			// 
			// btnAddFood
			// 
			this.btnAddFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAddFood.Location = new System.Drawing.Point(170, 349);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(106, 32);
			this.btnAddFood.TabIndex = 3;
			this.btnAddFood.Text = "Add";
			this.btnAddFood.UseVisualStyleBackColor = false;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// btnUpdateFood
			// 
			this.btnUpdateFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnUpdateFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUpdateFood.Location = new System.Drawing.Point(350, 349);
			this.btnUpdateFood.Name = "btnUpdateFood";
			this.btnUpdateFood.Size = new System.Drawing.Size(106, 32);
			this.btnUpdateFood.TabIndex = 3;
			this.btnUpdateFood.Text = "Update";
			this.btnUpdateFood.UseVisualStyleBackColor = false;
			this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Location = new System.Drawing.Point(517, 349);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(106, 32);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// foodInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 428);
			this.Controls.Add(this.nudPrice);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdateFood);
			this.Controls.Add(this.btnAddFood);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.cbbCatName);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtFoodID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Name = "foodInfoForm";
			this.Text = "foodInfoForm";
			this.Load += new System.EventHandler(this.foodInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cbbCatName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnCancel;
    }
}