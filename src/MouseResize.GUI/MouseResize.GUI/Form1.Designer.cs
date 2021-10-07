
using System;

namespace MouseResize.GUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbProgram = new System.Windows.Forms.ListBox();
            this.cbKeyboard = new System.Windows.Forms.ComboBox();
            this.cbMouse = new System.Windows.Forms.ComboBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.tbProgramm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bAddProgram = new System.Windows.Forms.Button();
            this.lbCombination = new System.Windows.Forms.ListBox();
            this.tbCombination = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setup";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blacklist";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Insert Key";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(418, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Insert Mouse Key";
            // 
            // lbProgram
            // 
            this.lbProgram.FormattingEnabled = true;
            this.lbProgram.ItemHeight = 15;
            this.lbProgram.Location = new System.Drawing.Point(63, 216);
            this.lbProgram.Name = "lbProgram";
            this.lbProgram.Size = new System.Drawing.Size(52, 184);
            this.lbProgram.TabIndex = 6;
            this.lbProgram.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cbKeyboard
            // 
            this.cbKeyboard.FormattingEnabled = true;
            this.cbKeyboard.Location = new System.Drawing.Point(179, 79);
            this.cbKeyboard.Name = "cbKeyboard";
            this.cbKeyboard.Size = new System.Drawing.Size(157, 23);
            this.cbKeyboard.TabIndex = 7;
            this.cbKeyboard.SelectedIndexChanged += new System.EventHandler(this.cbKeyboard_SelectedIndexChanged);
            // 
            // cbMouse
            // 
            this.cbMouse.FormattingEnabled = true;
            this.cbMouse.Location = new System.Drawing.Point(578, 75);
            this.cbMouse.Name = "cbMouse";
            this.cbMouse.Size = new System.Drawing.Size(157, 23);
            this.cbMouse.TabIndex = 8;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(605, 295);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(130, 35);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Save Changes";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(605, 350);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(130, 35);
            this.bReset.TabIndex = 10;
            this.bReset.Text = "Reset Changes";
            this.bReset.UseVisualStyleBackColor = false;
            // 
            // tbProgramm
            // 
            this.tbProgramm.Location = new System.Drawing.Point(235, 250);
            this.tbProgramm.Name = "tbProgramm";
            this.tbProgramm.Size = new System.Drawing.Size(146, 23);
            this.tbProgramm.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(252, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Program Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(249, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Key Combination";
            // 
            // bAddProgram
            // 
            this.bAddProgram.Location = new System.Drawing.Point(265, 365);
            this.bAddProgram.Name = "bAddProgram";
            this.bAddProgram.Size = new System.Drawing.Size(89, 35);
            this.bAddProgram.TabIndex = 15;
            this.bAddProgram.Text = "Add Program";
            this.bAddProgram.UseVisualStyleBackColor = true;
            // 
            // lbCombination
            // 
            this.lbCombination.FormattingEnabled = true;
            this.lbCombination.ItemHeight = 15;
            this.lbCombination.Location = new System.Drawing.Point(149, 216);
            this.lbCombination.Name = "lbCombination";
            this.lbCombination.Size = new System.Drawing.Size(52, 184);
            this.lbCombination.TabIndex = 16;
            // 
            // tbCombination
            // 
            this.tbCombination.Location = new System.Drawing.Point(235, 326);
            this.tbCombination.Name = "tbCombination";
            this.tbCombination.Size = new System.Drawing.Size(146, 23);
            this.tbCombination.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCombination);
            this.Controls.Add(this.lbCombination);
            this.Controls.Add(this.bAddProgram);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbProgramm);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbMouse);
            this.Controls.Add(this.cbKeyboard);
            this.Controls.Add(this.lbProgram);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(171)))), ((int)(((byte)(52)))));
            this.Name = "Form1";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbProgram;
        private System.Windows.Forms.ComboBox cbKeyboard;
        private System.Windows.Forms.ComboBox cbMouse;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.TextBox tbProgramm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bAddProgram;
        private System.Windows.Forms.ListBox lbCombination;
        private System.Windows.Forms.TextBox tbCombination;
    }
}

