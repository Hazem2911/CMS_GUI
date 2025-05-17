namespace CMS_gui
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Instructor_button = new System.Windows.Forms.Button();
            this.Student_button = new System.Windows.Forms.Button();
            this.cMSDataSet = new CMS_gui.CMSDataSet();
            this.eXPERTISEAREABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTISE_AREATableAdapter = new CMS_gui.CMSDataSetTableAdapters.EXPERTISE_AREATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTISEAREABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Role";
            // 
            // Instructor_button
            // 
            this.Instructor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructor_button.Location = new System.Drawing.Point(77, 144);
            this.Instructor_button.Name = "Instructor_button";
            this.Instructor_button.Size = new System.Drawing.Size(253, 141);
            this.Instructor_button.TabIndex = 1;
            this.Instructor_button.Text = "Instructor";
            this.Instructor_button.UseVisualStyleBackColor = true;
            this.Instructor_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_button
            // 
            this.Student_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_button.Location = new System.Drawing.Point(467, 144);
            this.Student_button.Name = "Student_button";
            this.Student_button.Size = new System.Drawing.Size(253, 141);
            this.Student_button.TabIndex = 2;
            this.Student_button.Text = "Student";
            this.Student_button.UseVisualStyleBackColor = true;
            this.Student_button.Click += new System.EventHandler(this.Student_button_Click);
            // 
            // cMSDataSet
            // 
            this.cMSDataSet.DataSetName = "CMSDataSet";
            this.cMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPERTISEAREABindingSource
            // 
            this.eXPERTISEAREABindingSource.DataMember = "EXPERTISE_AREA";
            this.eXPERTISEAREABindingSource.DataSource = this.cMSDataSet;
            // 
            // eXPERTISE_AREATableAdapter
            // 
            this.eXPERTISE_AREATableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Student_button);
            this.Controls.Add(this.Instructor_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTISEAREABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Instructor_button;
        private System.Windows.Forms.Button Student_button;
        private CMSDataSet cMSDataSet;
        private System.Windows.Forms.BindingSource eXPERTISEAREABindingSource;
        private CMSDataSetTableAdapters.EXPERTISE_AREATableAdapter eXPERTISE_AREATableAdapter;
    }
}

