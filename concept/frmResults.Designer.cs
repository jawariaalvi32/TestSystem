namespace concept
{
    partial class frmResults
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_qualification = new System.Windows.Forms.Label();
            this.lbl_moile = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_obtainedmarks = new System.Windows.Forms.Label();
            this.lbl_totalmarks = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_percentage = new System.Windows.Forms.Label();
            this.lbl_correct_answer = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(609, 103);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(56, 23);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(609, 138);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(56, 23);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "label2";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject.Location = new System.Drawing.Point(609, 174);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(56, 23);
            this.lbl_subject.TabIndex = 2;
            this.lbl_subject.Text = "label3";
            // 
            // lbl_qualification
            // 
            this.lbl_qualification.AutoSize = true;
            this.lbl_qualification.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qualification.Location = new System.Drawing.Point(609, 208);
            this.lbl_qualification.Name = "lbl_qualification";
            this.lbl_qualification.Size = new System.Drawing.Size(56, 23);
            this.lbl_qualification.TabIndex = 3;
            this.lbl_qualification.Text = "label4";
            // 
            // lbl_moile
            // 
            this.lbl_moile.AutoSize = true;
            this.lbl_moile.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moile.Location = new System.Drawing.Point(609, 248);
            this.lbl_moile.Name = "lbl_moile";
            this.lbl_moile.Size = new System.Drawing.Size(56, 23);
            this.lbl_moile.TabIndex = 4;
            this.lbl_moile.Text = "label5";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(609, 288);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(56, 23);
            this.lbl_age.TabIndex = 5;
            this.lbl_age.Text = "label6";
            this.lbl_age.Click += new System.EventHandler(this.lbl_age_Click);
            // 
            // lbl_obtainedmarks
            // 
            this.lbl_obtainedmarks.AutoSize = true;
            this.lbl_obtainedmarks.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obtainedmarks.Location = new System.Drawing.Point(609, 321);
            this.lbl_obtainedmarks.Name = "lbl_obtainedmarks";
            this.lbl_obtainedmarks.Size = new System.Drawing.Size(56, 23);
            this.lbl_obtainedmarks.TabIndex = 6;
            this.lbl_obtainedmarks.Text = "label6";
            // 
            // lbl_totalmarks
            // 
            this.lbl_totalmarks.AutoSize = true;
            this.lbl_totalmarks.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalmarks.Location = new System.Drawing.Point(609, 353);
            this.lbl_totalmarks.Name = "lbl_totalmarks";
            this.lbl_totalmarks.Size = new System.Drawing.Size(56, 23);
            this.lbl_totalmarks.TabIndex = 7;
            this.lbl_totalmarks.Text = "label6";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::concept.Properties.Resources.btn;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(585, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "OPEN AND DOWNLOAD RESULT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_percentage
            // 
            this.lbl_percentage.AutoSize = true;
            this.lbl_percentage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percentage.Location = new System.Drawing.Point(609, 389);
            this.lbl_percentage.Name = "lbl_percentage";
            this.lbl_percentage.Size = new System.Drawing.Size(56, 23);
            this.lbl_percentage.TabIndex = 9;
            this.lbl_percentage.Text = "label1";
            // 
            // lbl_correct_answer
            // 
            this.lbl_correct_answer.AutoSize = true;
            this.lbl_correct_answer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correct_answer.Location = new System.Drawing.Point(609, 419);
            this.lbl_correct_answer.Name = "lbl_correct_answer";
            this.lbl_correct_answer.Size = new System.Drawing.Size(56, 23);
            this.lbl_correct_answer.TabIndex = 10;
            this.lbl_correct_answer.Text = "label2";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::concept.Properties.Resources.btn;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(152, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 76);
            this.button2.TabIndex = 11;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::concept.Properties.Resources.final22;
            this.ClientSize = new System.Drawing.Size(882, 598);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_correct_answer);
            this.Controls.Add(this.lbl_percentage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_totalmarks);
            this.Controls.Add(this.lbl_obtainedmarks);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_moile);
            this.Controls.Add(this.lbl_qualification);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.Name = "frmResults";
            this.Text = "::ResultScreen::";
            this.Load += new System.EventHandler(this.frmResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_qualification;
        private System.Windows.Forms.Label lbl_moile;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_obtainedmarks;
        private System.Windows.Forms.Label lbl_totalmarks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_percentage;
        private System.Windows.Forms.Label lbl_correct_answer;
        private System.Windows.Forms.Button button2;

    }
}