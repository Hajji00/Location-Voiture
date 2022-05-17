namespace modernC.Forms
{
    partial class FormClients
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.Cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtDateNaissance = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelcnmdte = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSupperimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnAjoutter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.panelcnmdte.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prenom";
            // 
            // txtCin
            // 
            this.txtCin.Location = new System.Drawing.Point(157, 22);
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(136, 22);
            this.txtCin.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(157, 62);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(136, 22);
            this.txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(157, 103);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(136, 22);
            this.txtPrenom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "List Clients";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 10;
            // 
            // dgvClients
            // 
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cin,
            this.Nom,
            this.Prenom,
            this.DateNaissance,
            this.Telephone,
            this.Email});
            this.dgvClients.Location = new System.Drawing.Point(397, 128);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(503, 378);
            this.dgvClients.TabIndex = 13;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // Cin
            // 
            this.Cin.HeaderText = "Cin";
            this.Cin.Name = "Cin";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // DateNaissance
            // 
            this.DateNaissance.HeaderText = "Date Naissance";
            this.DateNaissance.Name = "DateNaissance";
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 216);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // mtxtDateNaissance
            // 
            this.mtxtDateNaissance.Location = new System.Drawing.Point(157, 140);
            this.mtxtDateNaissance.Mask = "00/00/0000";
            this.mtxtDateNaissance.Name = "mtxtDateNaissance";
            this.mtxtDateNaissance.Size = new System.Drawing.Size(136, 22);
            this.mtxtDateNaissance.TabIndex = 15;
            this.mtxtDateNaissance.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtTelephone
            // 
            this.mtxtTelephone.Location = new System.Drawing.Point(157, 179);
            this.mtxtTelephone.Mask = "+2120 00 00 00 00 ";
            this.mtxtTelephone.Name = "mtxtTelephone";
            this.mtxtTelephone.Size = new System.Drawing.Size(136, 22);
            this.mtxtTelephone.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date Naissance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telephone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email";
            // 
            // panelcnmdte
            // 
            this.panelcnmdte.Controls.Add(this.txtCin);
            this.panelcnmdte.Controls.Add(this.label1);
            this.panelcnmdte.Controls.Add(this.label8);
            this.panelcnmdte.Controls.Add(this.label2);
            this.panelcnmdte.Controls.Add(this.label7);
            this.panelcnmdte.Controls.Add(this.label3);
            this.panelcnmdte.Controls.Add(this.label6);
            this.panelcnmdte.Controls.Add(this.txtNom);
            this.panelcnmdte.Controls.Add(this.mtxtTelephone);
            this.panelcnmdte.Controls.Add(this.txtPrenom);
            this.panelcnmdte.Controls.Add(this.mtxtDateNaissance);
            this.panelcnmdte.Controls.Add(this.txtEmail);
            this.panelcnmdte.Location = new System.Drawing.Point(60, 45);
            this.panelcnmdte.Name = "panelcnmdte";
            this.panelcnmdte.Size = new System.Drawing.Size(306, 254);
            this.panelcnmdte.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(626, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 22;
            // 
            // btnSupperimer
            // 
            this.btnSupperimer.BackgroundImage = global::modernC.Properties.Resources.Delete;
            this.btnSupperimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupperimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupperimer.Location = new System.Drawing.Point(294, 318);
            this.btnSupperimer.Name = "btnSupperimer";
            this.btnSupperimer.Size = new System.Drawing.Size(72, 51);
            this.btnSupperimer.TabIndex = 20;
            this.btnSupperimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.BackgroundImage = global::modernC.Properties.Resources.Modify;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Location = new System.Drawing.Point(181, 318);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(72, 51);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercher.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRechercher.BackgroundImage = global::modernC.Properties.Resources.Find2;
            this.btnRechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRechercher.FlatAppearance.BorderSize = 0;
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Location = new System.Drawing.Point(841, 29);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(37, 32);
            this.btnRechercher.TabIndex = 1;
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnAjoutter
            // 
            this.btnAjoutter.BackgroundImage = global::modernC.Properties.Resources.Create;
            this.btnAjoutter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjoutter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutter.Location = new System.Drawing.Point(60, 318);
            this.btnAjoutter.Name = "btnAjoutter";
            this.btnAjoutter.Size = new System.Drawing.Size(72, 51);
            this.btnAjoutter.TabIndex = 0;
            this.btnAjoutter.UseVisualStyleBackColor = true;
            this.btnAjoutter.Click += new System.EventHandler(this.btnAjoutter_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 524);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelcnmdte);
            this.Controls.Add(this.btnSupperimer);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnAjoutter);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormClients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.panelcnmdte.ResumeLayout(false);
            this.panelcnmdte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutter;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCin;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtDateNaissance;
        private System.Windows.Forms.MaskedTextBox mtxtTelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSupperimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Panel panelcnmdte;
        private System.Windows.Forms.TextBox textBox1;
    }
}