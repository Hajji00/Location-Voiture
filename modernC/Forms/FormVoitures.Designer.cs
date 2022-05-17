namespace modernC.Forms
{
    partial class FormVoitures
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtMatriculation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.dgvVoitures = new System.Windows.Forms.DataGridView();
            this.panellm = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnSupperimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjoutter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoitures)).BeginInit();
            this.panellm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 24;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "List Voitures";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(129, 182);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(135, 22);
            this.txtKm.TabIndex = 22;
            this.txtKm.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(129, 130);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(135, 22);
            this.txtPrix.TabIndex = 21;
            this.txtPrix.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtMatriculation
            // 
            this.txtMatriculation.Location = new System.Drawing.Point(129, 26);
            this.txtMatriculation.Name = "txtMatriculation";
            this.txtMatriculation.Size = new System.Drawing.Size(135, 22);
            this.txtMatriculation.TabIndex = 20;
            this.txtMatriculation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prix";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Color";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Matriculation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Km";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Red",
            "Bleu",
            "Black",
            "White",
            "Yellow",
            "Grey",
            "Orange"});
            this.cmbColor.Location = new System.Drawing.Point(129, 78);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(135, 24);
            this.cmbColor.TabIndex = 29;
            // 
            // dgvVoitures
            // 
            this.dgvVoitures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVoitures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVoitures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoitures.Location = new System.Drawing.Point(345, 140);
            this.dgvVoitures.Name = "dgvVoitures";
            this.dgvVoitures.RowTemplate.Height = 24;
            this.dgvVoitures.Size = new System.Drawing.Size(574, 354);
            this.dgvVoitures.TabIndex = 31;
            // 
            // panellm
            // 
            this.panellm.Controls.Add(this.txtMatriculation);
            this.panellm.Controls.Add(this.label1);
            this.panellm.Controls.Add(this.label2);
            this.panellm.Controls.Add(this.cmbColor);
            this.panellm.Controls.Add(this.label3);
            this.panellm.Controls.Add(this.label6);
            this.panellm.Controls.Add(this.txtPrix);
            this.panellm.Controls.Add(this.txtKm);
            this.panellm.Location = new System.Drawing.Point(57, 62);
            this.panellm.Name = "panellm";
            this.panellm.Size = new System.Drawing.Size(276, 219);
            this.panellm.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(645, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 33;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercher.BackgroundImage = global::modernC.Properties.Resources.Find3;
            this.btnRechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRechercher.FlatAppearance.BorderSize = 0;
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Location = new System.Drawing.Point(860, 66);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(37, 32);
            this.btnRechercher.TabIndex = 34;
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnSupperimer
            // 
            this.btnSupperimer.BackgroundImage = global::modernC.Properties.Resources.Delete1;
            this.btnSupperimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupperimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupperimer.Location = new System.Drawing.Point(263, 312);
            this.btnSupperimer.Name = "btnSupperimer";
            this.btnSupperimer.Size = new System.Drawing.Size(70, 44);
            this.btnSupperimer.TabIndex = 30;
            this.btnSupperimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.BackgroundImage = global::modernC.Properties.Resources.Modify1;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Location = new System.Drawing.Point(159, 312);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(70, 44);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAjoutter
            // 
            this.btnAjoutter.BackgroundImage = global::modernC.Properties.Resources.Create;
            this.btnAjoutter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjoutter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutter.Location = new System.Drawing.Point(57, 312);
            this.btnAjoutter.Name = "btnAjoutter";
            this.btnAjoutter.Size = new System.Drawing.Size(70, 44);
            this.btnAjoutter.TabIndex = 14;
            this.btnAjoutter.UseVisualStyleBackColor = true;
            this.btnAjoutter.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVoitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 524);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panellm);
            this.Controls.Add(this.dgvVoitures);
            this.Controls.Add(this.btnSupperimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjoutter);
            this.Name = "FormVoitures";
            this.Text = "Voiture";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoitures)).EndInit();
            this.panellm.ResumeLayout(false);
            this.panellm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtMatriculation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjoutter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnSupperimer;
        private System.Windows.Forms.DataGridView dgvVoitures;
        private System.Windows.Forms.Panel panellm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRechercher;
    }
}