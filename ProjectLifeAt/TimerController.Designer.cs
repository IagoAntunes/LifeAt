
namespace ProjectLifeAt
{
    partial class TimerController
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.lblTempoCrono = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            this.btnPomodoro = new Guna.UI2.WinForms.Guna2Button();
            this.btnShort = new Guna.UI2.WinForms.Guna2Button();
            this.btnLong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnLong);
            this.guna2Panel1.Controls.Add(this.btnShort);
            this.guna2Panel1.Controls.Add(this.btnPomodoro);
            this.guna2Panel1.Controls.Add(this.btnStart);
            this.guna2Panel1.Controls.Add(this.lblTempoCrono);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 33);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(397, 139);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BorderColor = System.Drawing.Color.White;
            this.btnStart.BorderRadius = 10;
            this.btnStart.BorderThickness = 1;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.DisabledState.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(250, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(105, 42);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblTempoCrono
            // 
            this.lblTempoCrono.BackColor = System.Drawing.Color.Transparent;
            this.lblTempoCrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoCrono.ForeColor = System.Drawing.Color.White;
            this.lblTempoCrono.Location = new System.Drawing.Point(13, 18);
            this.lblTempoCrono.Name = "lblTempoCrono";
            this.lblTempoCrono.Size = new System.Drawing.Size(165, 75);
            this.lblTempoCrono.TabIndex = 0;
            this.lblTempoCrono.Text = "00:00";
            // 
            // timerCronometro
            // 
            this.timerCronometro.Interval = 1000;
            this.timerCronometro.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.CheckedState.Parent = this.btnPomodoro;
            this.btnPomodoro.CustomImages.Parent = this.btnPomodoro;
            this.btnPomodoro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPomodoro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPomodoro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPomodoro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPomodoro.DisabledState.Parent = this.btnPomodoro;
            this.btnPomodoro.FillColor = System.Drawing.Color.Transparent;
            this.btnPomodoro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomodoro.ForeColor = System.Drawing.Color.White;
            this.btnPomodoro.HoverState.Parent = this.btnPomodoro;
            this.btnPomodoro.Location = new System.Drawing.Point(13, 111);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.ShadowDecoration.Parent = this.btnPomodoro;
            this.btnPomodoro.Size = new System.Drawing.Size(100, 25);
            this.btnPomodoro.TabIndex = 5;
            this.btnPomodoro.Text = "Pomodoro";
            this.btnPomodoro.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // btnShort
            // 
            this.btnShort.CheckedState.Parent = this.btnShort;
            this.btnShort.CustomImages.Parent = this.btnShort;
            this.btnShort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShort.DisabledState.Parent = this.btnShort;
            this.btnShort.FillColor = System.Drawing.Color.Transparent;
            this.btnShort.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShort.ForeColor = System.Drawing.Color.White;
            this.btnShort.HoverState.Parent = this.btnShort;
            this.btnShort.Location = new System.Drawing.Point(143, 111);
            this.btnShort.Name = "btnShort";
            this.btnShort.ShadowDecoration.Parent = this.btnShort;
            this.btnShort.Size = new System.Drawing.Size(107, 25);
            this.btnShort.TabIndex = 6;
            this.btnShort.Text = "ShortBreak";
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnLong
            // 
            this.btnLong.CheckedState.Parent = this.btnLong;
            this.btnLong.CustomImages.Parent = this.btnLong;
            this.btnLong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLong.DisabledState.Parent = this.btnLong;
            this.btnLong.FillColor = System.Drawing.Color.Transparent;
            this.btnLong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLong.ForeColor = System.Drawing.Color.White;
            this.btnLong.HoverState.Parent = this.btnLong;
            this.btnLong.Location = new System.Drawing.Point(291, 111);
            this.btnLong.Name = "btnLong";
            this.btnLong.ShadowDecoration.Parent = this.btnLong;
            this.btnLong.Size = new System.Drawing.Size(100, 25);
            this.btnLong.TabIndex = 7;
            this.btnLong.Text = "LongBreak";
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // TimerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.guna2Panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "TimerController";
            this.Size = new System.Drawing.Size(397, 172);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTempoCrono;
        private System.Windows.Forms.Timer timerCronometro;
        private Guna.UI2.WinForms.Guna2Button btnLong;
        private Guna.UI2.WinForms.Guna2Button btnShort;
        private Guna.UI2.WinForms.Guna2Button btnPomodoro;
    }
}
