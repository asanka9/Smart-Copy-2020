namespace Smart_Copy
{
    partial class csv
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
            this.url_label = new System.Windows.Forms.Label();
            this.open_dialog_file = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // url_label
            // 
            this.url_label.AutoSize = true;
            this.url_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_label.Location = new System.Drawing.Point(14, 72);
            this.url_label.Name = "url_label";
            this.url_label.Size = new System.Drawing.Size(26, 25);
            this.url_label.TabIndex = 0;
            this.url_label.Text = "--";
            // 
            // open_dialog_file
            // 
            this.open_dialog_file.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.open_dialog_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_dialog_file.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.open_dialog_file.Location = new System.Drawing.Point(19, 19);
            this.open_dialog_file.Name = "open_dialog_file";
            this.open_dialog_file.Size = new System.Drawing.Size(133, 40);
            this.open_dialog_file.TabIndex = 1;
            this.open_dialog_file.Text = "Open Dialog";
            this.open_dialog_file.UseVisualStyleBackColor = false;
            this.open_dialog_file.Click += new System.EventHandler(this.open_dialog_file_Click);
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.SystemColors.Highlight;
            this.done.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.done.Location = new System.Drawing.Point(894, 19);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(125, 40);
            this.done.TabIndex = 2;
            this.done.Text = "DONE";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(19, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1000, 363);
            this.textBox1.TabIndex = 3;
            // 
            // csv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.done);
            this.Controls.Add(this.open_dialog_file);
            this.Controls.Add(this.url_label);
            this.Name = "csv";
            this.Size = new System.Drawing.Size(1057, 644);
            this.Load += new System.EventHandler(this.csv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label url_label;
        private System.Windows.Forms.Button open_dialog_file;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.TextBox textBox1;
    }
}
