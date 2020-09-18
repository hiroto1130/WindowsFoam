namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NudLevel = new System.Windows.Forms.NumericUpDown();
            this.NudExperience = new System.Windows.Forms.NumericUpDown();
            this.CmbTribe = new System.Windows.Forms.ComboBox();
            this.CmbPopPosition = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbtWind = new System.Windows.Forms.RadioButton();
            this.RbtSoil = new System.Windows.Forms.RadioButton();
            this.RbtThunder = new System.Windows.Forms.RadioButton();
            this.RbtWater = new System.Windows.Forms.RadioButton();
            this.RbtFire = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbAttackKindFirst = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NudPowerFirst = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.TextCommandFirst = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbAttackKindSecond = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NudPowerSecond = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.TextCommandSecond = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbAttackKindThird = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NudPowerThird = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.TextCommandThird = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CmbAttackKindFourth = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.NudPowerFourth = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TextCommandFourth = new System.Windows.Forms.TextBox();
            this.BtnComplete = new System.Windows.Forms.Button();
            this.TextMonsterName = new System.Windows.Forms.TextBox();
            this.BtnAppealPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudExperience)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPowerFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPowerSecond)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPowerThird)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPowerFourth)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // NudLevel
            // 
            this.NudLevel.Location = new System.Drawing.Point(25, 269);
            this.NudLevel.Name = "NudLevel";
            this.NudLevel.Size = new System.Drawing.Size(120, 23);
            this.NudLevel.TabIndex = 6;
            // 
            // NudExperience
            // 
            this.NudExperience.Location = new System.Drawing.Point(185, 269);
            this.NudExperience.Name = "NudExperience";
            this.NudExperience.Size = new System.Drawing.Size(120, 23);
            this.NudExperience.TabIndex = 7;
            // 
            // CmbTribe
            // 
            this.CmbTribe.FormattingEnabled = true;
            this.CmbTribe.Items.AddRange(new object[] {
            "スライム",
            "ドラゴン",
            "幽霊",
            "獣"});
            this.CmbTribe.Location = new System.Drawing.Point(24, 347);
            this.CmbTribe.Name = "CmbTribe";
            this.CmbTribe.Size = new System.Drawing.Size(121, 23);
            this.CmbTribe.TabIndex = 8;
            // 
            // CmbPopPosition
            // 
            this.CmbPopPosition.FormattingEnabled = true;
            this.CmbPopPosition.Items.AddRange(new object[] {
            "草原",
            "森",
            "洞窟"});
            this.CmbPopPosition.Location = new System.Drawing.Point(185, 347);
            this.CmbPopPosition.Name = "CmbPopPosition";
            this.CmbPopPosition.Size = new System.Drawing.Size(121, 23);
            this.CmbPopPosition.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbtWind);
            this.groupBox1.Controls.Add(this.RbtSoil);
            this.groupBox1.Controls.Add(this.RbtThunder);
            this.groupBox1.Controls.Add(this.RbtWater);
            this.groupBox1.Controls.Add(this.RbtFire);
            this.groupBox1.Location = new System.Drawing.Point(25, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 110);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性";
            // 
            // RbtWind
            // 
            this.RbtWind.AutoSize = true;
            this.RbtWind.Location = new System.Drawing.Point(107, 49);
            this.RbtWind.Name = "RbtWind";
            this.RbtWind.Size = new System.Drawing.Size(61, 19);
            this.RbtWind.TabIndex = 4;
            this.RbtWind.TabStop = true;
            this.RbtWind.Text = "風属性";
            this.RbtWind.UseVisualStyleBackColor = true;
            // 
            // RbtSoil
            // 
            this.RbtSoil.AutoSize = true;
            this.RbtSoil.Location = new System.Drawing.Point(107, 23);
            this.RbtSoil.Name = "RbtSoil";
            this.RbtSoil.Size = new System.Drawing.Size(61, 19);
            this.RbtSoil.TabIndex = 3;
            this.RbtSoil.TabStop = true;
            this.RbtSoil.Text = "土属性";
            this.RbtSoil.UseVisualStyleBackColor = true;
            // 
            // RbtThunder
            // 
            this.RbtThunder.AutoSize = true;
            this.RbtThunder.Location = new System.Drawing.Point(7, 75);
            this.RbtThunder.Name = "RbtThunder";
            this.RbtThunder.Size = new System.Drawing.Size(61, 19);
            this.RbtThunder.TabIndex = 2;
            this.RbtThunder.TabStop = true;
            this.RbtThunder.Text = "雷属性";
            this.RbtThunder.UseVisualStyleBackColor = true;
            // 
            // RbtWater
            // 
            this.RbtWater.AutoSize = true;
            this.RbtWater.Location = new System.Drawing.Point(7, 49);
            this.RbtWater.Name = "RbtWater";
            this.RbtWater.Size = new System.Drawing.Size(61, 19);
            this.RbtWater.TabIndex = 1;
            this.RbtWater.TabStop = true;
            this.RbtWater.Text = "水属性";
            this.RbtWater.UseVisualStyleBackColor = true;
            // 
            // RbtFire
            // 
            this.RbtFire.AutoSize = true;
            this.RbtFire.Location = new System.Drawing.Point(7, 23);
            this.RbtFire.Name = "RbtFire";
            this.RbtFire.Size = new System.Drawing.Size(61, 19);
            this.RbtFire.TabIndex = 0;
            this.RbtFire.TabStop = true;
            this.RbtFire.Text = "火属性";
            this.RbtFire.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "モンスター名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "レベル";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "経験値";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "種族";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "出現場所";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CmbAttackKindFirst);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.NudPowerFirst);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TextCommandFirst);
            this.groupBox2.Location = new System.Drawing.Point(403, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 81);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "コマンド１";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "種類";
            // 
            // CmbAttackKindFirst
            // 
            this.CmbAttackKindFirst.FormattingEnabled = true;
            this.CmbAttackKindFirst.Items.AddRange(new object[] {
            "魔法",
            "物理"});
            this.CmbAttackKindFirst.Location = new System.Drawing.Point(238, 43);
            this.CmbAttackKindFirst.Name = "CmbAttackKindFirst";
            this.CmbAttackKindFirst.Size = new System.Drawing.Size(121, 23);
            this.CmbAttackKindFirst.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "威力";
            // 
            // NudPowerFirst
            // 
            this.NudPowerFirst.Location = new System.Drawing.Point(112, 43);
            this.NudPowerFirst.Name = "NudPowerFirst";
            this.NudPowerFirst.Size = new System.Drawing.Size(120, 23);
            this.NudPowerFirst.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "コマンド名";
            // 
            // TextCommandFirst
            // 
            this.TextCommandFirst.Location = new System.Drawing.Point(6, 43);
            this.TextCommandFirst.Name = "TextCommandFirst";
            this.TextCommandFirst.Size = new System.Drawing.Size(100, 23);
            this.TextCommandFirst.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "種類";
            // 
            // CmbAttackKindSecond
            // 
            this.CmbAttackKindSecond.FormattingEnabled = true;
            this.CmbAttackKindSecond.Items.AddRange(new object[] {
            "魔法",
            "物理"});
            this.CmbAttackKindSecond.Location = new System.Drawing.Point(238, 43);
            this.CmbAttackKindSecond.Name = "CmbAttackKindSecond";
            this.CmbAttackKindSecond.Size = new System.Drawing.Size(121, 23);
            this.CmbAttackKindSecond.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "威力";
            // 
            // NudPowerSecond
            // 
            this.NudPowerSecond.Location = new System.Drawing.Point(112, 43);
            this.NudPowerSecond.Name = "NudPowerSecond";
            this.NudPowerSecond.Size = new System.Drawing.Size(120, 23);
            this.NudPowerSecond.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "コマンド名";
            // 
            // TextCommandSecond
            // 
            this.TextCommandSecond.Location = new System.Drawing.Point(6, 43);
            this.TextCommandSecond.Name = "TextCommandSecond";
            this.TextCommandSecond.Size = new System.Drawing.Size(100, 23);
            this.TextCommandSecond.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.CmbAttackKindSecond);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.NudPowerSecond);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TextCommandSecond);
            this.groupBox3.Location = new System.Drawing.Point(403, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 81);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "コマンド２";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "種類";
            // 
            // CmbAttackKindThird
            // 
            this.CmbAttackKindThird.FormattingEnabled = true;
            this.CmbAttackKindThird.Items.AddRange(new object[] {
            "魔法",
            "物理"});
            this.CmbAttackKindThird.Location = new System.Drawing.Point(238, 43);
            this.CmbAttackKindThird.Name = "CmbAttackKindThird";
            this.CmbAttackKindThird.Size = new System.Drawing.Size(121, 23);
            this.CmbAttackKindThird.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(112, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "威力";
            // 
            // NudPowerThird
            // 
            this.NudPowerThird.Location = new System.Drawing.Point(112, 43);
            this.NudPowerThird.Name = "NudPowerThird";
            this.NudPowerThird.Size = new System.Drawing.Size(120, 23);
            this.NudPowerThird.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "コマンド名";
            // 
            // TextCommandThird
            // 
            this.TextCommandThird.Location = new System.Drawing.Point(6, 43);
            this.TextCommandThird.Name = "TextCommandThird";
            this.TextCommandThird.Size = new System.Drawing.Size(100, 23);
            this.TextCommandThird.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.CmbAttackKindThird);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.NudPowerThird);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.TextCommandThird);
            this.groupBox4.Location = new System.Drawing.Point(403, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 81);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "コマンド３";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(238, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "種類";
            // 
            // CmbAttackKindFourth
            // 
            this.CmbAttackKindFourth.FormattingEnabled = true;
            this.CmbAttackKindFourth.Items.AddRange(new object[] {
            "魔法",
            "物理"});
            this.CmbAttackKindFourth.Location = new System.Drawing.Point(238, 43);
            this.CmbAttackKindFourth.Name = "CmbAttackKindFourth";
            this.CmbAttackKindFourth.Size = new System.Drawing.Size(121, 23);
            this.CmbAttackKindFourth.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(112, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "威力";
            // 
            // NudPowerFourth
            // 
            this.NudPowerFourth.Location = new System.Drawing.Point(112, 43);
            this.NudPowerFourth.Name = "NudPowerFourth";
            this.NudPowerFourth.Size = new System.Drawing.Size(120, 23);
            this.NudPowerFourth.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "コマンド名";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.CmbAttackKindFourth);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.NudPowerFourth);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.TextCommandFourth);
            this.groupBox5.Location = new System.Drawing.Point(403, 302);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(371, 81);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "コマンド４";
            // 
            // TextCommandFourth
            // 
            this.TextCommandFourth.Location = new System.Drawing.Point(6, 43);
            this.TextCommandFourth.Name = "TextCommandFourth";
            this.TextCommandFourth.Size = new System.Drawing.Size(100, 23);
            this.TextCommandFourth.TabIndex = 0;
            // 
            // BtnComplete
            // 
            this.BtnComplete.Location = new System.Drawing.Point(699, 406);
            this.BtnComplete.Name = "BtnComplete";
            this.BtnComplete.Size = new System.Drawing.Size(75, 23);
            this.BtnComplete.TabIndex = 17;
            this.BtnComplete.Text = "出力";
            this.BtnComplete.UseVisualStyleBackColor = true;
            this.BtnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // TextMonsterName
            // 
            this.TextMonsterName.Location = new System.Drawing.Point(32, 58);
            this.TextMonsterName.Name = "TextMonsterName";
            this.TextMonsterName.Size = new System.Drawing.Size(100, 23);
            this.TextMonsterName.TabIndex = 18;
            // 
            // BtnAppealPoint
            // 
            this.BtnAppealPoint.Location = new System.Drawing.Point(582, 406);
            this.BtnAppealPoint.Name = "BtnAppealPoint";
            this.BtnAppealPoint.Size = new System.Drawing.Size(90, 23);
            this.BtnAppealPoint.TabIndex = 6;
            this.BtnAppealPoint.Text = "アピールポイント";
            this.BtnAppealPoint.UseVisualStyleBackColor = true;
            this.BtnAppealPoint.Click += new System.EventHandler(this.BtnAppealPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAppealPoint);
            this.Controls.Add(this.TextMonsterName);
            this.Controls.Add(this.BtnComplete);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmbPopPosition);
            this.Controls.Add(this.CmbTribe);
            this.Controls.Add(this.NudExperience);
            this.Controls.Add(this.NudLevel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudExperience)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPowerFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPowerSecond)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPowerThird)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPowerFourth)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NudLevel;
        private System.Windows.Forms.NumericUpDown NudExperience;
        private System.Windows.Forms.ComboBox CmbTribe;
        private System.Windows.Forms.ComboBox CmbPopPosition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbtWind;
        private System.Windows.Forms.RadioButton RbtSoil;
        private System.Windows.Forms.RadioButton RbtThunder;
        private System.Windows.Forms.RadioButton RbtWater;
        private System.Windows.Forms.RadioButton RbtFire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbAttackKindFirst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NudPowerFirst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextCommandFirst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbAttackKindSecond;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NudPowerSecond;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextCommandSecond;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbAttackKindThird;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown NudPowerThird;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextCommandThird;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CmbAttackKindFourth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown NudPowerFourth;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TextCommandFourth;
        private System.Windows.Forms.Button BtnComplete;
        private System.Windows.Forms.TextBox TextMonsterName;
        private System.Windows.Forms.Button BtnAppealPoint;
    }
}

