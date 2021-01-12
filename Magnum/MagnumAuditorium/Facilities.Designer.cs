namespace MagnumAuditorium
{
    partial class Facilities
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.facilitiesContainer = new System.Windows.Forms.Panel();
            this.FacilitiesView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFacilityAdd = new System.Windows.Forms.Button();
            this.txtFacilityType = new System.Windows.Forms.TextBox();
            this.txtFacilityName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFacilityID = new System.Windows.Forms.Label();
            this.btnFacilityDelete = new System.Windows.Forms.Button();
            this.btnFacilityEdit = new System.Windows.Forms.Button();
            this.txtFacilityTypeEdit = new System.Windows.Forms.TextBox();
            this.txtFacilityNameEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.facilitiesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 49);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Facilities";
            // 
            // facilitiesContainer
            // 
            this.facilitiesContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facilitiesContainer.Controls.Add(this.FacilitiesView);
            this.facilitiesContainer.Location = new System.Drawing.Point(28, 239);
            this.facilitiesContainer.Name = "facilitiesContainer";
            this.facilitiesContainer.Size = new System.Drawing.Size(529, 149);
            this.facilitiesContainer.TabIndex = 2;
            // 
            // FacilitiesView
            // 
            this.FacilitiesView.AllowUserToAddRows = false;
            this.FacilitiesView.AllowUserToDeleteRows = false;
            this.FacilitiesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacilitiesView.Location = new System.Drawing.Point(0, 3);
            this.FacilitiesView.Name = "FacilitiesView";
            this.FacilitiesView.ReadOnly = true;
            this.FacilitiesView.Size = new System.Drawing.Size(529, 143);
            this.FacilitiesView.TabIndex = 0;
            this.FacilitiesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacilitiesView_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnFacilityAdd);
            this.panel2.Controls.Add(this.txtFacilityType);
            this.panel2.Controls.Add(this.txtFacilityName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(28, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 164);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnFacilityAdd
            // 
            this.btnFacilityAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnFacilityAdd.ForeColor = System.Drawing.Color.White;
            this.btnFacilityAdd.Location = new System.Drawing.Point(143, 129);
            this.btnFacilityAdd.Name = "btnFacilityAdd";
            this.btnFacilityAdd.Size = new System.Drawing.Size(75, 30);
            this.btnFacilityAdd.TabIndex = 4;
            this.btnFacilityAdd.Text = "Add";
            this.btnFacilityAdd.UseVisualStyleBackColor = false;
            this.btnFacilityAdd.Click += new System.EventHandler(this.btnFacilityAdd_Click);
            // 
            // txtFacilityType
            // 
            this.txtFacilityType.Location = new System.Drawing.Point(118, 79);
            this.txtFacilityType.Name = "txtFacilityType";
            this.txtFacilityType.Size = new System.Drawing.Size(100, 20);
            this.txtFacilityType.TabIndex = 3;
            this.txtFacilityType.TextChanged += new System.EventHandler(this.txtFacilityType_TextChanged);
            // 
            // txtFacilityName
            // 
            this.txtFacilityName.Location = new System.Drawing.Point(118, 41);
            this.txtFacilityName.Name = "txtFacilityName";
            this.txtFacilityName.Size = new System.Drawing.Size(100, 20);
            this.txtFacilityName.TabIndex = 2;
            this.txtFacilityName.TextChanged += new System.EventHandler(this.txtFacilityName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Facility Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Facility Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Facility";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblFacilityID);
            this.panel3.Controls.Add(this.btnFacilityDelete);
            this.panel3.Controls.Add(this.btnFacilityEdit);
            this.panel3.Controls.Add(this.txtFacilityTypeEdit);
            this.panel3.Controls.Add(this.txtFacilityNameEdit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(296, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 164);
            this.panel3.TabIndex = 3;
            // 
            // lblFacilityID
            // 
            this.lblFacilityID.AutoSize = true;
            this.lblFacilityID.Location = new System.Drawing.Point(187, 22);
            this.lblFacilityID.Name = "lblFacilityID";
            this.lblFacilityID.Size = new System.Drawing.Size(18, 13);
            this.lblFacilityID.TabIndex = 6;
            this.lblFacilityID.Text = "ID";
            this.lblFacilityID.Click += new System.EventHandler(this.lblFacilityID_Click);
            // 
            // btnFacilityDelete
            // 
            this.btnFacilityDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnFacilityDelete.ForeColor = System.Drawing.Color.White;
            this.btnFacilityDelete.Location = new System.Drawing.Point(148, 129);
            this.btnFacilityDelete.Name = "btnFacilityDelete";
            this.btnFacilityDelete.Size = new System.Drawing.Size(75, 30);
            this.btnFacilityDelete.TabIndex = 5;
            this.btnFacilityDelete.Text = "Delete";
            this.btnFacilityDelete.UseVisualStyleBackColor = false;
            this.btnFacilityDelete.Click += new System.EventHandler(this.btnFacilityDelete_Click);
            // 
            // btnFacilityEdit
            // 
            this.btnFacilityEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnFacilityEdit.ForeColor = System.Drawing.Color.White;
            this.btnFacilityEdit.Location = new System.Drawing.Point(49, 129);
            this.btnFacilityEdit.Name = "btnFacilityEdit";
            this.btnFacilityEdit.Size = new System.Drawing.Size(75, 30);
            this.btnFacilityEdit.TabIndex = 4;
            this.btnFacilityEdit.Text = "Edit";
            this.btnFacilityEdit.UseVisualStyleBackColor = false;
            this.btnFacilityEdit.Click += new System.EventHandler(this.btnFacilityEdit_Click);
            // 
            // txtFacilityTypeEdit
            // 
            this.txtFacilityTypeEdit.Location = new System.Drawing.Point(123, 79);
            this.txtFacilityTypeEdit.Name = "txtFacilityTypeEdit";
            this.txtFacilityTypeEdit.Size = new System.Drawing.Size(100, 20);
            this.txtFacilityTypeEdit.TabIndex = 3;
            this.txtFacilityTypeEdit.TextChanged += new System.EventHandler(this.txtFacilityTypeEdit_TextChanged);
            // 
            // txtFacilityNameEdit
            // 
            this.txtFacilityNameEdit.Location = new System.Drawing.Point(123, 41);
            this.txtFacilityNameEdit.Name = "txtFacilityNameEdit";
            this.txtFacilityNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtFacilityNameEdit.TabIndex = 2;
            this.txtFacilityNameEdit.TextChanged += new System.EventHandler(this.txtFacilityNameEdit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update/ Delete Facility";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Facility Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Facility Type";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Facilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.facilitiesContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facilities";
            this.Text = "Facilities";
            this.Load += new System.EventHandler(this.Facilities_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.facilitiesContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel facilitiesContainer;
        private System.Windows.Forms.DataGridView FacilitiesView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFacilityAdd;
        private System.Windows.Forms.TextBox txtFacilityType;
        private System.Windows.Forms.TextBox txtFacilityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFacilityDelete;
        private System.Windows.Forms.Button btnFacilityEdit;
        private System.Windows.Forms.TextBox txtFacilityTypeEdit;
        private System.Windows.Forms.TextBox txtFacilityNameEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFacilityID;
    }
}