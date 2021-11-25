namespace BilgiSis
{
    partial class OE
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
            this.button_NotGir = new System.Windows.Forms.Button();
            this.button_DvmGir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_NotGir
            // 
            this.button_NotGir.Location = new System.Drawing.Point(78, 200);
            this.button_NotGir.Name = "button_NotGir";
            this.button_NotGir.Size = new System.Drawing.Size(136, 23);
            this.button_NotGir.TabIndex = 1;
            this.button_NotGir.Text = "Not Gir";
            this.button_NotGir.UseVisualStyleBackColor = true;
            this.button_NotGir.Click += new System.EventHandler(this.button_NotGir_Click);
            // 
            // button_DvmGir
            // 
            this.button_DvmGir.Location = new System.Drawing.Point(78, 152);
            this.button_DvmGir.Name = "button_DvmGir";
            this.button_DvmGir.Size = new System.Drawing.Size(136, 23);
            this.button_DvmGir.TabIndex = 2;
            this.button_DvmGir.Text = "Devamsızlık Gir";
            this.button_DvmGir.UseVisualStyleBackColor = true;
            this.button_DvmGir.Click += new System.EventHandler(this.button_DvmGir_Click);
            // 
            // OE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_DvmGir);
            this.Controls.Add(this.button_NotGir);
            this.Name = "OE";
            this.Text = "OE";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_NotGir;
        private System.Windows.Forms.Button button_DvmGir;
    }
}