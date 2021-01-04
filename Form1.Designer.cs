
namespace SpeechRecognitionWindowsForm
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
            this.BTNListen = new System.Windows.Forms.Button();
            this.BTNStopListening = new System.Windows.Forms.Button();
            this.BTNClear = new System.Windows.Forms.Button();
            this.TXTOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNListen
            // 
            this.BTNListen.Location = new System.Drawing.Point(13, 400);
            this.BTNListen.Name = "BTNListen";
            this.BTNListen.Size = new System.Drawing.Size(75, 23);
            this.BTNListen.TabIndex = 0;
            this.BTNListen.Text = "Listen";
            this.BTNListen.UseVisualStyleBackColor = true;
            this.BTNListen.Click += new System.EventHandler(this.BTNListen_Click);
            // 
            // BTNStopListening
            // 
            this.BTNStopListening.Location = new System.Drawing.Point(105, 400);
            this.BTNStopListening.Name = "BTNStopListening";
            this.BTNStopListening.Size = new System.Drawing.Size(75, 23);
            this.BTNStopListening.TabIndex = 1;
            this.BTNStopListening.Text = "Stop Listening";
            this.BTNStopListening.UseVisualStyleBackColor = true;
            this.BTNStopListening.Click += new System.EventHandler(this.BTNStopListening_Click);
            // 
            // BTNClear
            // 
            this.BTNClear.Location = new System.Drawing.Point(367, 387);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.Size = new System.Drawing.Size(75, 23);
            this.BTNClear.TabIndex = 2;
            this.BTNClear.Text = "Clear";
            this.BTNClear.UseVisualStyleBackColor = true;
            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // TXTOutput
            // 
            this.TXTOutput.Location = new System.Drawing.Point(13, 13);
            this.TXTOutput.Multiline = true;
            this.TXTOutput.Name = "TXTOutput";
            this.TXTOutput.Size = new System.Drawing.Size(775, 368);
            this.TXTOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTOutput);
            this.Controls.Add(this.BTNClear);
            this.Controls.Add(this.BTNStopListening);
            this.Controls.Add(this.BTNListen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNListen;
        private System.Windows.Forms.Button BTNStopListening;
        private System.Windows.Forms.Button BTNClear;
        private System.Windows.Forms.TextBox TXTOutput;
    }
}

