namespace MediaTekDocuments.view
{
    partial class Authentification
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
            this.loginAuthentification = new System.Windows.Forms.Label();
            this.passwordAuthentification = new System.Windows.Forms.Label();
            this.titreAuthentification = new System.Windows.Forms.Label();
            this.textBoxLoginAuthentification = new System.Windows.Forms.TextBox();
            this.textBoxPasswordAuthentification = new System.Windows.Forms.TextBox();
            this.validerAuthentification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginAuthentification
            // 
            this.loginAuthentification.AutoSize = true;
            this.loginAuthentification.Location = new System.Drawing.Point(22, 78);
            this.loginAuthentification.Name = "loginAuthentification";
            this.loginAuthentification.Size = new System.Drawing.Size(33, 13);
            this.loginAuthentification.TabIndex = 0;
            this.loginAuthentification.Text = "Login";
            // 
            // passwordAuthentification
            // 
            this.passwordAuthentification.AutoSize = true;
            this.passwordAuthentification.Location = new System.Drawing.Point(22, 131);
            this.passwordAuthentification.Name = "passwordAuthentification";
            this.passwordAuthentification.Size = new System.Drawing.Size(53, 13);
            this.passwordAuthentification.TabIndex = 1;
            this.passwordAuthentification.Text = "Password";
            // 
            // titreAuthentification
            // 
            this.titreAuthentification.AutoSize = true;
            this.titreAuthentification.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreAuthentification.Location = new System.Drawing.Point(60, 9);
            this.titreAuthentification.Name = "titreAuthentification";
            this.titreAuthentification.Size = new System.Drawing.Size(202, 20);
            this.titreAuthentification.TabIndex = 2;
            this.titreAuthentification.Text = "MEDIATEKDOCUMENT";
            // 
            // textBoxLoginAuthentification
            // 
            this.textBoxLoginAuthentification.Location = new System.Drawing.Point(64, 78);
            this.textBoxLoginAuthentification.Name = "textBoxLoginAuthentification";
            this.textBoxLoginAuthentification.Size = new System.Drawing.Size(244, 20);
            this.textBoxLoginAuthentification.TabIndex = 3;
            // 
            // textBoxPasswordAuthentification
            // 
            this.textBoxPasswordAuthentification.Location = new System.Drawing.Point(81, 128);
            this.textBoxPasswordAuthentification.Name = "textBoxPasswordAuthentification";
            this.textBoxPasswordAuthentification.Size = new System.Drawing.Size(227, 20);
            this.textBoxPasswordAuthentification.TabIndex = 4;
            // 
            // validerAuthentification
            // 
            this.validerAuthentification.Location = new System.Drawing.Point(121, 180);
            this.validerAuthentification.Name = "validerAuthentification";
            this.validerAuthentification.Size = new System.Drawing.Size(75, 23);
            this.validerAuthentification.TabIndex = 5;
            this.validerAuthentification.Text = "Valider";
            this.validerAuthentification.UseVisualStyleBackColor = true;
            this.validerAuthentification.Click += new System.EventHandler(this.validerAuthentification_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 237);
            this.Controls.Add(this.validerAuthentification);
            this.Controls.Add(this.textBoxPasswordAuthentification);
            this.Controls.Add(this.textBoxLoginAuthentification);
            this.Controls.Add(this.titreAuthentification);
            this.Controls.Add(this.passwordAuthentification);
            this.Controls.Add(this.loginAuthentification);
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginAuthentification;
        private System.Windows.Forms.Label passwordAuthentification;
        private System.Windows.Forms.Label titreAuthentification;
        private System.Windows.Forms.TextBox textBoxLoginAuthentification;
        private System.Windows.Forms.TextBox textBoxPasswordAuthentification;
        private System.Windows.Forms.Button validerAuthentification;
    }
}