
namespace Autokereskedes
{
    partial class Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDoC = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblLicenseNumber = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbDoC = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbLicenseNumber = new System.Windows.Forms.TextBox();
            this.lblDatas = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(492, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Márka";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(492, 76);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 17);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Típus";
            // 
            // lblDoC
            // 
            this.lblDoC.AutoSize = true;
            this.lblDoC.Location = new System.Drawing.Point(492, 112);
            this.lblDoC.Name = "lblDoC";
            this.lblDoC.Size = new System.Drawing.Size(85, 17);
            this.lblDoC.TabIndex = 2;
            this.lblDoC.Text = "Gyártás éve";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(492, 149);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(35, 17);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Szín";
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.AutoSize = true;
            this.lblLicenseNumber.Location = new System.Drawing.Point(492, 187);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(75, 17);
            this.lblLicenseNumber.TabIndex = 4;
            this.lblLicenseNumber.Text = "Rendszám";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(351, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(122, 22);
            this.tbName.TabIndex = 5;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(351, 73);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(122, 22);
            this.tbType.TabIndex = 6;
            // 
            // tbDoC
            // 
            this.tbDoC.Location = new System.Drawing.Point(351, 109);
            this.tbDoC.Name = "tbDoC";
            this.tbDoC.Size = new System.Drawing.Size(122, 22);
            this.tbDoC.TabIndex = 7;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(351, 146);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(122, 22);
            this.tbColor.TabIndex = 8;
            // 
            // tbLicenseNumber
            // 
            this.tbLicenseNumber.Location = new System.Drawing.Point(351, 184);
            this.tbLicenseNumber.Name = "tbLicenseNumber";
            this.tbLicenseNumber.Size = new System.Drawing.Size(122, 22);
            this.tbLicenseNumber.TabIndex = 9;
            // 
            // lblDatas
            // 
            this.lblDatas.AutoSize = true;
            this.lblDatas.Location = new System.Drawing.Point(348, 10);
            this.lblDatas.Name = "lblDatas";
            this.lblDatas.Size = new System.Drawing.Size(52, 17);
            this.lblDatas.TabIndex = 10;
            this.lblDatas.Text = "Adatok";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(351, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Hozzáad";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(24, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 164);
            this.listBox1.TabIndex = 12;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(24, 232);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Töröl";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(105, 232);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(81, 23);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Módosít";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDatas);
            this.Controls.Add(this.tbLicenseNumber);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbDoC);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblLicenseNumber);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblDoC);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Name = "Control";
            this.Size = new System.Drawing.Size(610, 344);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDoC;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblLicenseNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbDoC;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbLicenseNumber;
        private System.Windows.Forms.Label lblDatas;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
    }
}
