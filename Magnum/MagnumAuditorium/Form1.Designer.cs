namespace MagnumAuditorium
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
            this.sideMenu = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnPartners = new System.Windows.Forms.Button();
            this.btnResources = new System.Windows.Forms.Button();
            this.btnFacilities = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.sideMenu.Controls.Add(this.sidePanel);
            this.sideMenu.Controls.Add(this.btnPartners);
            this.sideMenu.Controls.Add(this.btnResources);
            this.sideMenu.Controls.Add(this.btnFacilities);
            this.sideMenu.Controls.Add(this.btnReservations);
            this.sideMenu.Controls.Add(this.panel1);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(200, 450);
            this.sideMenu.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(188)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 109);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 86);
            this.sidePanel.TabIndex = 1;
            // 
            // btnPartners
            // 
            this.btnPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnPartners.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartners.FlatAppearance.BorderSize = 0;
            this.btnPartners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartners.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartners.ForeColor = System.Drawing.Color.White;
            this.btnPartners.Location = new System.Drawing.Point(0, 367);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnPartners.Size = new System.Drawing.Size(200, 86);
            this.btnPartners.TabIndex = 4;
            this.btnPartners.Text = "Partners";
            this.btnPartners.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartners.UseVisualStyleBackColor = false;
            this.btnPartners.Click += new System.EventHandler(this.btnPartners_Click);
            // 
            // btnResources
            // 
            this.btnResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResources.FlatAppearance.BorderSize = 0;
            this.btnResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResources.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResources.ForeColor = System.Drawing.Color.White;
            this.btnResources.Location = new System.Drawing.Point(0, 281);
            this.btnResources.Name = "btnResources";
            this.btnResources.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnResources.Size = new System.Drawing.Size(200, 86);
            this.btnResources.TabIndex = 3;
            this.btnResources.Text = "Resources";
            this.btnResources.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResources.UseVisualStyleBackColor = false;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnFacilities
            // 
            this.btnFacilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnFacilities.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacilities.FlatAppearance.BorderSize = 0;
            this.btnFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilities.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacilities.ForeColor = System.Drawing.Color.White;
            this.btnFacilities.Location = new System.Drawing.Point(0, 195);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnFacilities.Size = new System.Drawing.Size(200, 86);
            this.btnFacilities.TabIndex = 2;
            this.btnFacilities.Text = "Facilities";
            this.btnFacilities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacilities.UseVisualStyleBackColor = false;
            this.btnFacilities.Click += new System.EventHandler(this.btnFacilities_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.Location = new System.Drawing.Point(0, 109);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnReservations.Size = new System.Drawing.Size(200, 86);
            this.btnReservations.TabIndex = 1;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMainTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 109);
            this.panel1.TabIndex = 0;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Mistral", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(188)))));
            this.lblMainTitle.Location = new System.Drawing.Point(12, 22);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(179, 64);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Magnum";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(600, 450);
            this.panelChildForm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 120F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 191);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magnum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(105, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 88);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auditorium";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.sideMenu);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPartners;
        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.Button btnFacilities;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label label2;
    }
}

