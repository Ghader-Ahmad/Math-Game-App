namespace Math_Game
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
            this.pbWelcome = new System.Windows.Forms.PictureBox();
            this.pPlayerDate = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.pbbtnClose = new System.Windows.Forms.Button();
            this.nupRounds = new System.Windows.Forms.NumericUpDown();
            this.cobOperator = new System.Windows.Forms.ComboBox();
            this.cobLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStrat = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).BeginInit();
            this.pPlayerDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWelcome
            // 
            this.pbWelcome.Image = global::Math_Game.Properties.Resources.Welcome1;
            this.pbWelcome.Location = new System.Drawing.Point(0, 38);
            this.pbWelcome.Name = "pbWelcome";
            this.pbWelcome.Size = new System.Drawing.Size(497, 152);
            this.pbWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWelcome.TabIndex = 0;
            this.pbWelcome.TabStop = false;
            // 
            // pPlayerDate
            // 
            this.pPlayerDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPlayerDate.Controls.Add(this.btnNext);
            this.pPlayerDate.Controls.Add(this.pbbtnClose);
            this.pPlayerDate.Controls.Add(this.nupRounds);
            this.pPlayerDate.Controls.Add(this.cobOperator);
            this.pPlayerDate.Controls.Add(this.cobLevel);
            this.pPlayerDate.Controls.Add(this.pbWelcome);
            this.pPlayerDate.Controls.Add(this.label3);
            this.pPlayerDate.Controls.Add(this.label2);
            this.pPlayerDate.Controls.Add(this.label1);
            this.pPlayerDate.Location = new System.Drawing.Point(265, 12);
            this.pPlayerDate.Name = "pPlayerDate";
            this.pPlayerDate.Size = new System.Drawing.Size(497, 539);
            this.pPlayerDate.TabIndex = 1;
            this.pPlayerDate.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Salmon;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.Location = new System.Drawing.Point(180, 450);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(119, 55);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pbbtnClose
            // 
            this.pbbtnClose.BackColor = System.Drawing.Color.White;
            this.pbbtnClose.BackgroundImage = global::Math_Game.Properties.Resources.Close;
            this.pbbtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbbtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.pbbtnClose.FlatAppearance.BorderSize = 2;
            this.pbbtnClose.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbbtnClose.ForeColor = System.Drawing.Color.White;
            this.pbbtnClose.Location = new System.Drawing.Point(447, 0);
            this.pbbtnClose.Name = "pbbtnClose";
            this.pbbtnClose.Size = new System.Drawing.Size(50, 40);
            this.pbbtnClose.TabIndex = 4;
            this.pbbtnClose.UseVisualStyleBackColor = false;
            this.pbbtnClose.Click += new System.EventHandler(this.pbbtnClose_Click);
            // 
            // nupRounds
            // 
            this.nupRounds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nupRounds.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupRounds.ForeColor = System.Drawing.Color.Lime;
            this.nupRounds.Location = new System.Drawing.Point(253, 379);
            this.nupRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupRounds.Name = "nupRounds";
            this.nupRounds.Size = new System.Drawing.Size(155, 30);
            this.nupRounds.TabIndex = 5;
            this.nupRounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cobOperator
            // 
            this.cobOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cobOperator.DisplayMember = "1";
            this.cobOperator.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobOperator.ForeColor = System.Drawing.Color.Lime;
            this.cobOperator.FormattingEnabled = true;
            this.cobOperator.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Mutiply",
            "Divide",
            "Mix"});
            this.cobOperator.Location = new System.Drawing.Point(253, 292);
            this.cobOperator.Name = "cobOperator";
            this.cobOperator.Size = new System.Drawing.Size(155, 30);
            this.cobOperator.TabIndex = 4;
            this.cobOperator.Tag = "1";
            this.cobOperator.Text = "Add";
            this.cobOperator.SelectedIndexChanged += new System.EventHandler(this.cobOperator_SelectedIndexChanged);
            // 
            // cobLevel
            // 
            this.cobLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cobLevel.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobLevel.ForeColor = System.Drawing.Color.Lime;
            this.cobLevel.FormattingEnabled = true;
            this.cobLevel.Items.AddRange(new object[] {
            "Easy ",
            "Meduim",
            "Hard",
            "Mix"});
            this.cobLevel.Location = new System.Drawing.Point(253, 211);
            this.cobLevel.Name = "cobLevel";
            this.cobLevel.Size = new System.Drawing.Size(155, 30);
            this.cobLevel.TabIndex = 3;
            this.cobLevel.Tag = "1";
            this.cobLevel.Text = "Easy ";
            this.cobLevel.SelectedIndexChanged += new System.EventHandler(this.cobLevel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(74, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rounds : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(74, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(74, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level : ";
            // 
            // btnStrat
            // 
            this.btnStrat.BackColor = System.Drawing.Color.Salmon;
            this.btnStrat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStrat.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnStrat.FlatAppearance.BorderSize = 2;
            this.btnStrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrat.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStrat.Location = new System.Drawing.Point(36, 496);
            this.btnStrat.Name = "btnStrat";
            this.btnStrat.Size = new System.Drawing.Size(119, 55);
            this.btnStrat.TabIndex = 2;
            this.btnStrat.Text = "START";
            this.btnStrat.UseVisualStyleBackColor = false;
            this.btnStrat.Click += new System.EventHandler(this.btnStrat_Click);
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.Salmon;
            this.btnExist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExist.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnExist.FlatAppearance.BorderSize = 2;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExist.Location = new System.Drawing.Point(852, 496);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(119, 55);
            this.btnExist.TabIndex = 3;
            this.btnExist.Text = "EXIST";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Math_Game.Properties.Resources.Math;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1009, 579);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnStrat);
            this.Controls.Add(this.pPlayerDate);
            this.Name = "Form1";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).EndInit();
            this.pPlayerDate.ResumeLayout(false);
            this.pPlayerDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupRounds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWelcome;
        private System.Windows.Forms.Panel pPlayerDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStrat;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button pbbtnClose;
        private System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.NumericUpDown nupRounds;
        public System.Windows.Forms.ComboBox cobOperator;
        public System.Windows.Forms.ComboBox cobLevel;
    }
}

