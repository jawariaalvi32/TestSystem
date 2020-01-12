namespace concept
{
    partial class QuestionsPanel
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
            this.gv_questions = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_dlt = new System.Windows.Forms.Button();
            this.cbm_option = new System.Windows.Forms.ComboBox();
            this.txt_question = new System.Windows.Forms.TextBox();
            this.txt_optm1 = new System.Windows.Forms.TextBox();
            this.txt_optn2 = new System.Windows.Forms.TextBox();
            this.txt_optn3 = new System.Windows.Forms.TextBox();
            this.txt_optn4 = new System.Windows.Forms.TextBox();
            this.cmb_subject = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.btn_cncl_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_questions)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_questions
            // 
            this.gv_questions.BackgroundColor = System.Drawing.Color.LightCoral;
            this.gv_questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_questions.Location = new System.Drawing.Point(65, 274);
            this.gv_questions.Name = "gv_questions";
            this.gv_questions.Size = new System.Drawing.Size(347, 263);
            this.gv_questions.TabIndex = 0;
            this.gv_questions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_questions_CellContentClick);
            this.gv_questions.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_questions_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::concept.Properties.Resources.btn1;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::concept.Properties.Resources.admin;
            this.button2.Location = new System.Drawing.Point(296, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 100);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.BackgroundImage = global::concept.Properties.Resources.btn2;
            this.btn_insert.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(595, 409);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(112, 39);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = global::concept.Properties.Resources.btn3;
            this.btn_update.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(478, 410);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(107, 36);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_dlt
            // 
            this.btn_dlt.BackgroundImage = global::concept.Properties.Resources.btn4;
            this.btn_dlt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dlt.Location = new System.Drawing.Point(713, 410);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(103, 36);
            this.btn_dlt.TabIndex = 5;
            this.btn_dlt.Text = "DELETE";
            this.btn_dlt.UseVisualStyleBackColor = true;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // cbm_option
            // 
            this.cbm_option.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_option.FormattingEnabled = true;
            this.cbm_option.Location = new System.Drawing.Point(567, 366);
            this.cbm_option.Name = "cbm_option";
            this.cbm_option.Size = new System.Drawing.Size(124, 25);
            this.cbm_option.TabIndex = 6;
            // 
            // txt_question
            // 
            this.txt_question.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_question.Location = new System.Drawing.Point(478, 184);
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(314, 24);
            this.txt_question.TabIndex = 8;
            // 
            // txt_optm1
            // 
            this.txt_optm1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_optm1.Location = new System.Drawing.Point(468, 265);
            this.txt_optm1.Name = "txt_optm1";
            this.txt_optm1.Size = new System.Drawing.Size(145, 24);
            this.txt_optm1.TabIndex = 9;
            // 
            // txt_optn2
            // 
            this.txt_optn2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_optn2.Location = new System.Drawing.Point(628, 265);
            this.txt_optn2.Name = "txt_optn2";
            this.txt_optn2.Size = new System.Drawing.Size(143, 24);
            this.txt_optn2.TabIndex = 10;
            // 
            // txt_optn3
            // 
            this.txt_optn3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_optn3.Location = new System.Drawing.Point(468, 307);
            this.txt_optn3.Name = "txt_optn3";
            this.txt_optn3.Size = new System.Drawing.Size(145, 24);
            this.txt_optn3.TabIndex = 11;
            // 
            // txt_optn4
            // 
            this.txt_optn4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_optn4.Location = new System.Drawing.Point(628, 307);
            this.txt_optn4.Name = "txt_optn4";
            this.txt_optn4.Size = new System.Drawing.Size(143, 24);
            this.txt_optn4.TabIndex = 12;
            // 
            // cmb_subject
            // 
            this.cmb_subject.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_subject.FormattingEnabled = true;
            this.cmb_subject.Location = new System.Drawing.Point(678, 127);
            this.cmb_subject.Name = "cmb_subject";
            this.cmb_subject.Size = new System.Drawing.Size(121, 25);
            this.cmb_subject.TabIndex = 13;
            this.cmb_subject.SelectedIndexChanged += new System.EventHandler(this.cmb_subject_SelectedIndexChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(36, 37);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Visible = false;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(97, 37);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(0, 13);
            this.lbl_question.TabIndex = 16;
            this.lbl_question.Visible = false;
            // 
            // btn_cncl_edit
            // 
            this.btn_cncl_edit.BackgroundImage = global::concept.Properties.Resources.btn2;
            this.btn_cncl_edit.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cncl_edit.Location = new System.Drawing.Point(588, 454);
            this.btn_cncl_edit.Name = "btn_cncl_edit";
            this.btn_cncl_edit.Size = new System.Drawing.Size(103, 50);
            this.btn_cncl_edit.TabIndex = 17;
            this.btn_cncl_edit.Text = "CANCEL EDIT";
            this.btn_cncl_edit.UseVisualStyleBackColor = true;
            this.btn_cncl_edit.Visible = false;
            this.btn_cncl_edit.Click += new System.EventHandler(this.btn_cncl_edit_Click);
            // 
            // QuestionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::concept.Properties.Resources.final21;
            this.ClientSize = new System.Drawing.Size(886, 600);
            this.Controls.Add(this.btn_cncl_edit);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cmb_subject);
            this.Controls.Add(this.txt_optn4);
            this.Controls.Add(this.txt_optn3);
            this.Controls.Add(this.txt_optn2);
            this.Controls.Add(this.txt_optm1);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.cbm_option);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gv_questions);
            this.Name = "QuestionsPanel";
            this.Text = "QuestionsPanel";
            this.Load += new System.EventHandler(this.QuestionsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_questions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_questions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_dlt;
        private System.Windows.Forms.ComboBox cbm_option;
        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.TextBox txt_optm1;
        private System.Windows.Forms.TextBox txt_optn2;
        private System.Windows.Forms.TextBox txt_optn3;
        private System.Windows.Forms.TextBox txt_optn4;
        private System.Windows.Forms.ComboBox cmb_subject;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Button btn_cncl_edit;
    }
}