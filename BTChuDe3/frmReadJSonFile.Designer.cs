namespace BTChuDe3
{
    partial class frmReadJSonFile
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
            this.btnReadJSon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadJSon
            // 
            this.btnReadJSon.Location = new System.Drawing.Point(44, 48);
            this.btnReadJSon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadJSon.Name = "btnReadJSon";
            this.btnReadJSon.Size = new System.Drawing.Size(294, 114);
            this.btnReadJSon.TabIndex = 0;
            this.btnReadJSon.Text = "Đọc File JSon";
            this.btnReadJSon.UseVisualStyleBackColor = true;
            this.btnReadJSon.Click += new System.EventHandler(this.btnReadJSon_Click);
            // 
            // frmReadJSonFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 199);
            this.Controls.Add(this.btnReadJSon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReadJSonFile";
            this.Text = "frmReadJSonFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadJSon;
    }
}