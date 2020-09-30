namespace Smart_Copy
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
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.text1 = new Smart_Copy.text();
            this.hand1 = new Smart_Copy.hand();
            this.csv1 = new Smart_Copy.csv();
            this.api1 = new Smart_Copy.api();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select input type : ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add data with writing",
            "Connect with API",
            "Combined with .csv file",
            "Combined with .txt fle"});
            this.comboBox1.Location = new System.Drawing.Point(24, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(411, 33);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 96);
            this.panel1.TabIndex = 11;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.text1.Location = new System.Drawing.Point(12, 115);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(1104, 520);
            this.text1.TabIndex = 17;
            // 
            // hand1
            // 
            this.hand1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hand1.Location = new System.Drawing.Point(12, 114);
            this.hand1.Name = "hand1";
            this.hand1.Size = new System.Drawing.Size(1104, 521);
            this.hand1.TabIndex = 16;
            // 
            // csv1
            // 
            this.csv1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.csv1.Location = new System.Drawing.Point(12, 114);
            this.csv1.Name = "csv1";
            this.csv1.Size = new System.Drawing.Size(1104, 521);
            this.csv1.TabIndex = 15;
            // 
            // api1
            // 
            this.api1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.api1.Location = new System.Drawing.Point(12, 114);
            this.api1.Name = "api1";
            this.api1.Size = new System.Drawing.Size(1104, 521);
            this.api1.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1128, 647);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.hand1);
            this.Controls.Add(this.csv1);
            this.Controls.Add(this.api1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private api api1;
        private csv csv1;
        private hand hand1;
        private text text1;
    }
}