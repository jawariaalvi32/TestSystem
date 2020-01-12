namespace concept
{
    partial class FRM_MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MAIN));
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_admin
            // 
            this.btn_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_admin.BackgroundImage")));
            this.btn_admin.ForeColor = System.Drawing.Color.Black;
            this.btn_admin.Location = new System.Drawing.Point(186, 267);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(117, 104);
            this.btn_admin.TabIndex = 0;
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_student
            // 
            this.btn_student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_student.BackgroundImage")));
            this.btn_student.ForeColor = System.Drawing.Color.Black;
            this.btn_student.Location = new System.Drawing.Point(63, 271);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(117, 100);
            this.btn_student.TabIndex = 1;
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "STUDENT\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_admin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.Black;
            this.lbl_admin.Location = new System.Drawing.Point(198, 374);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(70, 23);
            this.lbl_admin.TabIndex = 3;
            this.lbl_admin.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Image = global::concept.Properties.Resources.text3;
            this.label2.Location = new System.Drawing.Point(480, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 335);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Image = global::concept.Properties.Resources.welcome;
            this.label3.Location = new System.Drawing.Point(496, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 52);
            this.label3.TabIndex = 5;
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(891, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_admin);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRM_MAIN";
            this.Text = "::MainScreen::";
            this.Load += new System.EventHandler(this.FRM_MAIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

