
namespace Compare
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbcode1 = new System.Windows.Forms.TextBox();
            this.tbcode2 = new System.Windows.Forms.TextBox();
            this.bt_compare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbcode1
            // 
            this.tbcode1.Location = new System.Drawing.Point(27, 20);
            this.tbcode1.Name = "tbcode1";
            this.tbcode1.Size = new System.Drawing.Size(231, 20);
            this.tbcode1.TabIndex = 0;
            this.tbcode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbcode1_KeyDown);
            // 
            // tbcode2
            // 
            this.tbcode2.Location = new System.Drawing.Point(27, 52);
            this.tbcode2.Name = "tbcode2";
            this.tbcode2.Size = new System.Drawing.Size(231, 20);
            this.tbcode2.TabIndex = 1;
            this.tbcode2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbcode2_KeyDown);
            // 
            // bt_compare
            // 
            this.bt_compare.FlatAppearance.BorderSize = 0;
            this.bt_compare.Location = new System.Drawing.Point(-9, 87);
            this.bt_compare.Margin = new System.Windows.Forms.Padding(0);
            this.bt_compare.Name = "bt_compare";
            this.bt_compare.Size = new System.Drawing.Size(302, 97);
            this.bt_compare.TabIndex = 2;
            this.bt_compare.Text = "Resultado";
            this.bt_compare.UseVisualStyleBackColor = true;
            this.bt_compare.Click += new System.EventHandler(this.bt_compare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 180);
            this.Controls.Add(this.bt_compare);
            this.Controls.Add(this.tbcode2);
            this.Controls.Add(this.tbcode1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CompareSN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcode1;
        private System.Windows.Forms.TextBox tbcode2;
        private System.Windows.Forms.Button bt_compare;
    }
}

