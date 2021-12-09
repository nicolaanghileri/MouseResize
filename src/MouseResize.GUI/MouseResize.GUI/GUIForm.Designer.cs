
using System;

namespace MouseResize.GUI
{
    partial class GUIForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMouseMove = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMouseResize = new System.Windows.Forms.ComboBox();
            this.cbKeyMove = new System.Windows.Forms.ComboBox();
            this.cbKeyResize = new System.Windows.Forms.ComboBox();
            this.lbBlacklist = new System.Windows.Forms.ListBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMouseMove
            // 
            this.cbMouseMove.FormattingEnabled = true;
            this.cbMouseMove.Location = new System.Drawing.Point(498, 37);
            this.cbMouseMove.Name = "cbMouseMove";
            this.cbMouseMove.Size = new System.Drawing.Size(157, 23);
            this.cbMouseMove.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(147, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Move";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resize";
            // 
            // cbMouseResize
            // 
            this.cbMouseResize.FormattingEnabled = true;
            this.cbMouseResize.Location = new System.Drawing.Point(498, 72);
            this.cbMouseResize.Name = "cbMouseResize";
            this.cbMouseResize.Size = new System.Drawing.Size(157, 23);
            this.cbMouseResize.TabIndex = 10;
            // 
            // cbKeyMove
            // 
            this.cbKeyMove.FormattingEnabled = true;
            this.cbKeyMove.Location = new System.Drawing.Point(354, 36);
            this.cbKeyMove.Name = "cbKeyMove";
            this.cbKeyMove.Size = new System.Drawing.Size(77, 23);
            this.cbKeyMove.TabIndex = 11;
            // 
            // cbKeyResize
            // 
            this.cbKeyResize.FormattingEnabled = true;
            this.cbKeyResize.Location = new System.Drawing.Point(354, 75);
            this.cbKeyResize.Name = "cbKeyResize";
            this.cbKeyResize.Size = new System.Drawing.Size(77, 23);
            this.cbKeyResize.TabIndex = 12;
            // 
            // lbBlacklist
            // 
            this.lbBlacklist.FormattingEnabled = true;
            this.lbBlacklist.ItemHeight = 15;
            this.lbBlacklist.Location = new System.Drawing.Point(111, 144);
            this.lbBlacklist.Name = "lbBlacklist";
            this.lbBlacklist.Size = new System.Drawing.Size(583, 214);
            this.lbBlacklist.TabIndex = 13;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(618, 401);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 14;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(525, 401);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 23);
            this.bApply.TabIndex = 15;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(429, 401);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 16;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(665, 115);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(27, 23);
            this.bAdd.TabIndex = 17;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(632, 115);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(27, 23);
            this.bDelete.TabIndex = 18;
            this.bDelete.Text = "-";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lbBlacklist);
            this.Controls.Add(this.cbKeyResize);
            this.Controls.Add(this.cbKeyMove);
            this.Controls.Add(this.cbMouseResize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMouseMove);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(171)))), ((int)(((byte)(52)))));
            this.Name = "GUIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MouseResize";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ComboBox cbMouseMove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMouseResize;
        private System.Windows.Forms.ComboBox cbKeyMove;
        private System.Windows.Forms.ComboBox cbKeyResize;
        private System.Windows.Forms.ListBox lbBlacklist;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
    }
}

