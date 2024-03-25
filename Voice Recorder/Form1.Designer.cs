namespace Voice_Recorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRecord = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.lbl_Recorder = new System.Windows.Forms.Label();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnRecord.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(12, 136);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(154, 45);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(183, 136);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(154, 45);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.Location = new System.Drawing.Point(357, 136);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(154, 45);
            this.BtnPlay.TabIndex = 2;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // lbl_Recorder
            // 
            this.lbl_Recorder.AutoSize = true;
            this.lbl_Recorder.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Recorder.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recorder.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Recorder.Location = new System.Drawing.Point(12, 25);
            this.lbl_Recorder.Name = "lbl_Recorder";
            this.lbl_Recorder.Size = new System.Drawing.Size(185, 41);
            this.lbl_Recorder.TabIndex = 3;
            this.lbl_Recorder.Text = "Voice Recorder ";
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.AutoSize = true;
            this.lbl_Timer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Timer.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Timer.Location = new System.Drawing.Point(241, 25);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(246, 41);
            this.lbl_Timer.TabIndex = 4;
            this.lbl_Timer.Text = "Duration : 00 : 00 : 00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voice_Recorder.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(520, 193);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.lbl_Recorder);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice Recorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Label lbl_Recorder;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
    }
}

