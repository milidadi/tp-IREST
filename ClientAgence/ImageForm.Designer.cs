namespace ClientAgence
{
    partial class ImageForm
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
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.labelIdOffre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficher.Location = new System.Drawing.Point(330, 12);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(447, 59);
            this.buttonAfficher.TabIndex = 0;
            this.buttonAfficher.Text = "Afficher Image de la chambre";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // labelIdOffre
            // 
            this.labelIdOffre.Location = new System.Drawing.Point(0, 0);
            this.labelIdOffre.Name = "labelIdOffre";
            this.labelIdOffre.Size = new System.Drawing.Size(100, 23);
            this.labelIdOffre.TabIndex = 0;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 682);
            this.Controls.Add(this.labelIdOffre);
            this.Controls.Add(this.buttonAfficher);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.Load += new System.EventHandler(this.ImageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.Label labelIdOffre;
    }
}