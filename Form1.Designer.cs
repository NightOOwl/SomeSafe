namespace Safe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bStop = new System.Windows.Forms.Button();
            this.nudFieldSize = new System.Windows.Forms.NumericUpDown();
            this.bReset = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFieldSize)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.nudFieldSize);
            this.splitContainer1.Panel1.Controls.Add(this.bReset);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(50);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(50);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 862);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 0;
            // 
            // bStop
            // 
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.Location = new System.Drawing.Point(67, 831);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(138, 60);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // nudFieldSize
            // 
            this.nudFieldSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudFieldSize.Location = new System.Drawing.Point(67, 84);
            this.nudFieldSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFieldSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFieldSize.Name = "nudFieldSize";
            this.nudFieldSize.Size = new System.Drawing.Size(138, 47);
            this.nudFieldSize.TabIndex = 5;
            this.nudFieldSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFieldSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReset.Location = new System.Drawing.Point(67, 471);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(138, 60);
            this.bReset.TabIndex = 4;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(67, 151);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(138, 60);
            this.bStart.TabIndex = 3;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIELD SIZE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 862);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Try to open a safe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFieldSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.NumericUpDown nudFieldSize;
        private System.Windows.Forms.Button bStop;
    }
}

