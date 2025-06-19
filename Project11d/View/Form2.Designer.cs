namespace Project11d
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTypeId = new System.Windows.Forms.Label();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lstTypes = new System.Windows.Forms.ListBox();
            this.BtnAddType = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeId
            // 
            this.lblTypeId.AutoSize = true;
            this.lblTypeId.BackColor = System.Drawing.Color.YellowGreen;
            this.lblTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeId.Location = new System.Drawing.Point(12, 20);
            this.lblTypeId.Name = "lblTypeId";
            this.lblTypeId.Size = new System.Drawing.Size(30, 20);
            this.lblTypeId.TabIndex = 0;
            this.lblTypeId.Text = "Id:";
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.BackColor = System.Drawing.Color.YellowGreen;
            this.lblTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeName.Location = new System.Drawing.Point(12, 56);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(106, 20);
            this.lblTypeName.TabIndex = 1;
            this.lblTypeName.Text = "Type name:";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(130, 56);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(345, 22);
            this.txtTypeName.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(130, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(345, 22);
            this.txtId.TabIndex = 3;
            // 
            // lstTypes
            // 
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.ItemHeight = 16;
            this.lstTypes.Location = new System.Drawing.Point(12, 187);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(463, 148);
            this.lstTypes.TabIndex = 4;
            // 
            // BtnAddType
            // 
            this.BtnAddType.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddType.Location = new System.Drawing.Point(12, 90);
            this.BtnAddType.Name = "BtnAddType";
            this.BtnAddType.Size = new System.Drawing.Size(112, 91);
            this.BtnAddType.TabIndex = 5;
            this.BtnAddType.Text = "Add New Animal Type";
            this.BtnAddType.UseVisualStyleBackColor = false;
            this.BtnAddType.Click += new System.EventHandler(this.BtnAddType_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(244, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 91);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update Animal Type";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDeleteType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteType.Location = new System.Drawing.Point(130, 90);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(108, 91);
            this.btnDeleteType.TabIndex = 7;
            this.btnDeleteType.Text = "Delete Animal Type";
            this.btnDeleteType.UseVisualStyleBackColor = false;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // btnForm1
            // 
            this.btnForm1.BackColor = System.Drawing.Color.YellowGreen;
            this.btnForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm1.Location = new System.Drawing.Point(364, 90);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(111, 91);
            this.btnForm1.TabIndex = 8;
            this.btnForm1.Text = "Back to other form";
            this.btnForm1.UseVisualStyleBackColor = false;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project11d.Properties.Resources._5319163;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 352);
            this.Controls.Add(this.btnForm1);
            this.Controls.Add(this.btnDeleteType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAddType);
            this.Controls.Add(this.lstTypes);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.lblTypeId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Pet Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeId;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ListBox lstTypes;
        private System.Windows.Forms.Button BtnAddType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnForm1;
    }
}