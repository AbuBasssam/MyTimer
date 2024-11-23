namespace MyTimer
{
    partial class frmChooseLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseLanguage));
            this.btnArabic = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArabic
            // 
            this.btnArabic.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArabic.Image = ((System.Drawing.Image)(resources.GetObject("btnArabic.Image")));
            this.btnArabic.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArabic.Location = new System.Drawing.Point(409, 114);
            this.btnArabic.Name = "btnArabic";
            this.btnArabic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnArabic.Size = new System.Drawing.Size(189, 58);
            this.btnArabic.TabIndex = 1;
            this.btnArabic.Text = "Arabic";
            this.btnArabic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArabic.UseVisualStyleBackColor = true;
            this.btnArabic.Click += new System.EventHandler(this.btnArabic_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.Image = ((System.Drawing.Image)(resources.GetObject("btnEnglish.Image")));
            this.btnEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnglish.Location = new System.Drawing.Point(12, 114);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(189, 58);
            this.btnEnglish.TabIndex = 2;
            this.btnEnglish.Text = "English";
            this.btnEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // ChooseLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 222);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnArabic);
            this.Name = "ChooseLanguage";
            this.Text = "Choose Language";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnArabic;
        private System.Windows.Forms.Button btnEnglish;
    }
}