namespace karanlık_ve_aydınlık_mod__96
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
            this.rbDark = new System.Windows.Forms.RadioButton();
            this.rbLight = new System.Windows.Forms.RadioButton();
            this.btnUygula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbDark
            // 
            this.rbDark.AutoSize = true;
            this.rbDark.Location = new System.Drawing.Point(100, 82);
            this.rbDark.Name = "rbDark";
            this.rbDark.Size = new System.Drawing.Size(78, 17);
            this.rbDark.TabIndex = 0;
            this.rbDark.TabStop = true;
            this.rbDark.Text = "Dark Mode";
            this.rbDark.UseVisualStyleBackColor = true;
            // 
            // rbLight
            // 
            this.rbLight.AutoSize = true;
            this.rbLight.Location = new System.Drawing.Point(100, 114);
            this.rbLight.Name = "rbLight";
            this.rbLight.Size = new System.Drawing.Size(78, 17);
            this.rbLight.TabIndex = 1;
            this.rbLight.TabStop = true;
            this.rbLight.Text = "Light Mode";
            this.rbLight.UseVisualStyleBackColor = true;
            // 
            // btnUygula
            // 
            this.btnUygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUygula.Location = new System.Drawing.Point(56, 184);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(185, 42);
            this.btnUygula.TabIndex = 2;
            this.btnUygula.Text = "UYGULA";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 298);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.rbLight);
            this.Controls.Add(this.rbDark);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDark;
        private System.Windows.Forms.RadioButton rbLight;
        private System.Windows.Forms.Button btnUygula;
    }
}

