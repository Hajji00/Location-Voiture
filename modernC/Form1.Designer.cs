namespace modernC
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.btnreporting = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitelBre = new System.Windows.Forms.Panel();
            this.btnmaximize = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitelBre.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnQuitter);
            this.panelMenu.Controls.Add(this.btnsetting);
            this.panelMenu.Controls.Add(this.btnreporting);
            this.panelMenu.Controls.Add(this.btncustomer);
            this.panelMenu.Controls.Add(this.btnorders);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 529);
            this.panelMenu.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Image = global::modernC.Properties.Resources.Exit;
            this.btnQuitter.Location = new System.Drawing.Point(0, 480);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(165, 49);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnsetting.Image = global::modernC.Properties.Resources.Delivery;
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.Location = new System.Drawing.Point(0, 261);
            this.btnsetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnsetting.Size = new System.Drawing.Size(165, 49);
            this.btnsetting.TabIndex = 6;
            this.btnsetting.Text = "   Model";
            this.btnsetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsetting.UseVisualStyleBackColor = true;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btnreporting
            // 
            this.btnreporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreporting.FlatAppearance.BorderSize = 0;
            this.btnreporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnreporting.Image = global::modernC.Properties.Resources.Zoom;
            this.btnreporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporting.Location = new System.Drawing.Point(0, 212);
            this.btnreporting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnreporting.Name = "btnreporting";
            this.btnreporting.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnreporting.Size = new System.Drawing.Size(165, 49);
            this.btnreporting.TabIndex = 4;
            this.btnreporting.Text = "   Carburant";
            this.btnreporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreporting.UseVisualStyleBackColor = true;
            this.btnreporting.Click += new System.EventHandler(this.btnreporting_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncustomer.FlatAppearance.BorderSize = 0;
            this.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btncustomer.Image = global::modernC.Properties.Resources.Taxi;
            this.btncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.Location = new System.Drawing.Point(0, 163);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btncustomer.Size = new System.Drawing.Size(165, 49);
            this.btncustomer.TabIndex = 3;
            this.btncustomer.Text = "   Voitures";
            this.btncustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnorders
            // 
            this.btnorders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnorders.FlatAppearance.BorderSize = 0;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnorders.Image = global::modernC.Properties.Resources.List;
            this.btnorders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.Location = new System.Drawing.Point(0, 114);
            this.btnorders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnorders.Name = "btnorders";
            this.btnorders.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnorders.Size = new System.Drawing.Size(165, 49);
            this.btnorders.TabIndex = 2;
            this.btnorders.Text = "   Contrat";
            this.btnorders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnorders.UseVisualStyleBackColor = true;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.Image = global::modernC.Properties.Resources.Male;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 65);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(165, 49);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "   Clients";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location Voiture";
            // 
            // panelTitelBre
            // 
            this.panelTitelBre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.panelTitelBre.Controls.Add(this.btnmaximize);
            this.panelTitelBre.Controls.Add(this.btnminimize);
            this.panelTitelBre.Controls.Add(this.btnCloseChildForm);
            this.panelTitelBre.Controls.Add(this.lblTitle);
            this.panelTitelBre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitelBre.Location = new System.Drawing.Point(165, 0);
            this.panelTitelBre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTitelBre.Name = "panelTitelBre";
            this.panelTitelBre.Size = new System.Drawing.Size(712, 65);
            this.panelTitelBre.TabIndex = 1;
            this.panelTitelBre.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitelBre_Paint);
            this.panelTitelBre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitelBre_MouseDown);
            // 
            // btnmaximize
            // 
            this.btnmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximize.FlatAppearance.BorderSize = 0;
            this.btnmaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaximize.ForeColor = System.Drawing.Color.White;
            this.btnmaximize.Location = new System.Drawing.Point(676, 2);
            this.btnmaximize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(27, 30);
            this.btnmaximize.TabIndex = 4;
            this.btnmaximize.Text = "O";
            this.btnmaximize.UseVisualStyleBackColor = true;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.Location = new System.Drawing.Point(644, 2);
            this.btnminimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(27, 28);
            this.btnminimize.TabIndex = 3;
            this.btnminimize.Text = "--";
            this.btnminimize.UseVisualStyleBackColor = true;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::modernC.Properties.Resources.Home;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(56, 65);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ACCUEI";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktopPane.Controls.Add(this.pictureBox2);
            this.panelDesktopPane.Controls.Add(this.label2);
            this.panelDesktopPane.Controls.Add(this.pictureBox1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(165, 65);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(712, 464);
            this.panelDesktopPane.TabIndex = 2;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::modernC.Properties.Resources.Blue_key;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(314, 299);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 38);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(198, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOCATION  VOITURE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::modernC.Properties.Resources._1652281011788;
            this.pictureBox1.Location = new System.Drawing.Point(150, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 529);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitelBre);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(716, 414);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitelBre.ResumeLayout(false);
            this.panelTitelBre.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button btnreporting;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitelBre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnmaximize;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

