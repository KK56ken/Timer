namespace Timer
{
    partial class TimerClass
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new MyTime(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.swich = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.titlelabel = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeLabel.Location = new System.Drawing.Point(287, 127);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(31, 33);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "0";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // swich
            // 
            this.swich.Location = new System.Drawing.Point(555, 99);
            this.swich.Name = "swich";
            this.swich.Size = new System.Drawing.Size(145, 91);
            this.swich.TabIndex = 1;
            this.swich.Text = "切り替え";
            this.swich.UseVisualStyleBackColor = true;
            this.swich.Click += new System.EventHandler(this.swich_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(48, 288);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(145, 91);
            this.start.TabIndex = 2;
            this.start.Text = "スタート";
            this.start.UseVisualStyleBackColor = true;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(302, 288);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(145, 91);
            this.stop.TabIndex = 3;
            this.stop.Text = "ストップ";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titlelabel.Location = new System.Drawing.Point(44, 127);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(48, 24);
            this.titlelabel.TabIndex = 4;
            this.titlelabel.Text = "title";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(555, 288);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(144, 90);
            this.reset.TabIndex = 5;
            this.reset.Text = "リセット";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // TimerClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.swich);
            this.Controls.Add(this.TimeLabel);
            this.Name = "TimerClass";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Timer.MyTime timer1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button swich;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button reset;
    }
}

