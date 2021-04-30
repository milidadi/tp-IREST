using System.Windows.Forms;
namespace ClientAgence
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDateArrive = new System.Windows.Forms.Label();
            this.labelDateDepart = new System.Windows.Forms.Label();
            this.dateTimePickerArrivee = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDepart = new System.Windows.Forms.DateTimePicker();
            this.labelNbLits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDateArrive
            // 
            this.labelDateArrive.AutoSize = true;
            this.labelDateArrive.Location = new System.Drawing.Point(114, 86);
            this.labelDateArrive.Name = "labelDateArrive";
            this.labelDateArrive.Size = new System.Drawing.Size(87, 17);
            this.labelDateArrive.TabIndex = 0;
            this.labelDateArrive.Text = "Date Arrivée";
            // 
            // labelDateDepart
            // 
            this.labelDateDepart.AutoSize = true;
            this.labelDateDepart.Location = new System.Drawing.Point(114, 126);
            this.labelDateDepart.Name = "labelDateDepart";
            this.labelDateDepart.Size = new System.Drawing.Size(85, 17);
            this.labelDateDepart.TabIndex = 1;
            this.labelDateDepart.Text = "Date Depart";
            // 
            // dateTimePickerArrivee
            // 
            this.dateTimePickerArrivee.Location = new System.Drawing.Point(321, 86);
            this.dateTimePickerArrivee.Name = "dateTimePickerArrivee";
            this.dateTimePickerArrivee.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerArrivee.TabIndex = 2;
            // 
            // dateTimePickerDepart
            // 
            this.dateTimePickerDepart.Location = new System.Drawing.Point(321, 126);
            this.dateTimePickerDepart.Name = "dateTimePickerDepart";
            this.dateTimePickerDepart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDepart.TabIndex = 3;
            // 
            // labelNbLits
            // 
            this.labelNbLits.AutoSize = true;
            this.labelNbLits.Location = new System.Drawing.Point(114, 169);
            this.labelNbLits.Name = "labelNbLits";
            this.labelNbLits.Size = new System.Drawing.Size(99, 17);
            this.labelNbLits.TabIndex = 4;
            this.labelNbLits.Text = "Nombre de lits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenue dans notres Agence de rechrche de chambre dans des hotels partenaires";
            // 
            // buttonChercher
            // 
            this.buttonChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChercher.Location = new System.Drawing.Point(346, 295);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(295, 61);
            this.buttonChercher.TabIndex = 7;
            this.buttonChercher.Text = "Chercher";
            this.buttonChercher.UseVisualStyleBackColor = true;
            this.buttonChercher.Click += new System.EventHandler(this.buttonChercher_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(392, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 479);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonChercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNbLits);
            this.Controls.Add(this.dateTimePickerDepart);
            this.Controls.Add(this.dateTimePickerArrivee);
            this.Controls.Add(this.labelDateDepart);
            this.Controls.Add(this.labelDateArrive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDateArrive;
        private System.Windows.Forms.Label labelDateDepart;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivee;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepart;
        private System.Windows.Forms.Label labelNbLits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChercher;
        private ComboBox comboBox1;
    }

}

