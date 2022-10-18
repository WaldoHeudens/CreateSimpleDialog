namespace Les_7_2
{
    partial class LoopDialog
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
            this.btNext = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btDoeAlles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(21, 37);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(156, 26);
            this.btNext.TabIndex = 0;
            this.btNext.Text = "Ga naar volgende stap";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(21, 66);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(156, 26);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop de loop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btDoeAlles
            // 
            this.btDoeAlles.Location = new System.Drawing.Point(21, 95);
            this.btDoeAlles.Name = "btDoeAlles";
            this.btDoeAlles.Size = new System.Drawing.Size(156, 26);
            this.btDoeAlles.TabIndex = 2;
            this.btDoeAlles.Text = "Verwerk hele loop";
            this.btDoeAlles.UseVisualStyleBackColor = true;
            this.btDoeAlles.Click += new System.EventHandler(this.btDoeAlles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hoe moet ik de loop verwerken?";
            // 
            // LoopDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 128);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDoeAlles);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoopDialog";
            this.Text = "Verwerk loop";
            this.Load += new System.EventHandler(this.LoopDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoopDialog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btNext;
        private Button btStop;
        private Button btDoeAlles;
        private Label label1;
    }
}