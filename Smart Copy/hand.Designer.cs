namespace Smart_Copy
{
    partial class hand
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
            this.hand_text = new System.Windows.Forms.TextBox();
            this.done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hand_text
            // 
            this.hand_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hand_text.Location = new System.Drawing.Point(25, 15);
            this.hand_text.Multiline = true;
            this.hand_text.Name = "hand_text";
            this.hand_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hand_text.Size = new System.Drawing.Size(1066, 399);
            this.hand_text.TabIndex = 0;
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.Location = new System.Drawing.Point(25, 468);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(162, 40);
            this.done.TabIndex = 2;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Use , for ";
            // 
            // hand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.done);
            this.Controls.Add(this.hand_text);
            this.Name = "hand";
            this.Size = new System.Drawing.Size(1116, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hand_text;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label label1;
    }
}
