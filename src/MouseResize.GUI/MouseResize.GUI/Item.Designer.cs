
namespace MouseResize.GUI
{
    partial class Item
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
            this.bAdd = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.tbProgram = new System.Windows.Forms.TextBox();
            this.cbMouse = new System.Windows.Forms.ComboBox();
            this.cbKey = new System.Windows.Forms.ComboBox();
            this.lPrgramName = new System.Windows.Forms.Label();
            this.lCombi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(182, 177);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(271, 177);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // tbProgram
            // 
            this.tbProgram.Location = new System.Drawing.Point(155, 32);
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.Size = new System.Drawing.Size(191, 23);
            this.tbProgram.TabIndex = 2;
            // 
            // cbMouse
            // 
            this.cbMouse.FormattingEnabled = true;
            this.cbMouse.Location = new System.Drawing.Point(260, 79);
            this.cbMouse.Name = "cbMouse";
            this.cbMouse.Size = new System.Drawing.Size(86, 23);
            this.cbMouse.TabIndex = 3;
            // 
            // cbKey
            // 
            this.cbKey.FormattingEnabled = true;
            this.cbKey.Location = new System.Drawing.Point(155, 79);
            this.cbKey.Name = "cbKey";
            this.cbKey.Size = new System.Drawing.Size(86, 23);
            this.cbKey.TabIndex = 4;
            // 
            // lPrgramName
            // 
            this.lPrgramName.AutoSize = true;
            this.lPrgramName.Location = new System.Drawing.Point(28, 32);
            this.lPrgramName.Name = "lPrgramName";
            this.lPrgramName.Size = new System.Drawing.Size(88, 15);
            this.lPrgramName.TabIndex = 5;
            this.lPrgramName.Text = "Program Name";
            // 
            // lCombi
            // 
            this.lCombi.AutoSize = true;
            this.lCombi.Location = new System.Drawing.Point(28, 82);
            this.lCombi.Name = "lCombi";
            this.lCombi.Size = new System.Drawing.Size(77, 15);
            this.lCombi.TabIndex = 6;
            this.lCombi.Text = "Combination";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(374, 228);
            this.Controls.Add(this.lCombi);
            this.Controls.Add(this.lPrgramName);
            this.Controls.Add(this.cbKey);
            this.Controls.Add(this.cbMouse);
            this.Controls.Add(this.tbProgram);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAdd);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(171)))), ((int)(((byte)(52)))));
            this.Name = "Item";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.TextBox tbProgram;
        private System.Windows.Forms.ComboBox cbMouse;
        private System.Windows.Forms.ComboBox cbKey;
        private System.Windows.Forms.Label lPrgramName;
        private System.Windows.Forms.Label lCombi;
    }
}