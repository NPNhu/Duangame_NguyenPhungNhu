namespace Stupid_Car
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IbIScore = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IbIScore
            // 
            this.IbIScore.AutoSize = true;
            this.IbIScore.BackColor = System.Drawing.Color.DarkKhaki;
            this.IbIScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.IbIScore.ForeColor = System.Drawing.Color.White;
            this.IbIScore.Location = new System.Drawing.Point(24, 680);
            this.IbIScore.Name = "IbIScore";
            this.IbIScore.Size = new System.Drawing.Size(94, 26);
            this.IbIScore.TabIndex = 2;
            this.IbIScore.Text = "Score:0";
            this.IbIScore.Click += new System.EventHandler(this.IbIScore_Click);
            // 
            // bird
            // 
            this.bird.Image = global::Stupid_Car.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(12, 12);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(70, 70);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 5;
            this.bird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Stupid_Car.Properties.Resources.pipetop;
            this.pipeTop.Location = new System.Drawing.Point(478, 470);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(163, 154);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 4;
            this.pipeTop.TabStop = false;
            this.pipeTop.Click += new System.EventHandler(this.pipeTop_Click);
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::Stupid_Car.Properties.Resources.pipedown;
            this.pipeDown.Location = new System.Drawing.Point(712, 0);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(163, 258);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Stupid_Car.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-12, 619);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1333, 129);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // car
            // 
            this.car.Image = global::Stupid_Car.Properties.Resources.car;
            this.car.Location = new System.Drawing.Point(336, 188);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(70, 70);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 0;
            this.car.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1192, 742);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.IbIScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.car);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stupid Car";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label IbIScore;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeDown;
    }
}

