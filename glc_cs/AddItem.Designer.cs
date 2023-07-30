﻿namespace glc_cs
{
	partial class AddItem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
			this.label1 = new System.Windows.Forms.Label();
			this.titleText = new System.Windows.Forms.TextBox();
			this.exePathText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.exePathButton = new System.Windows.Forms.Button();
			this.imgPathButton = new System.Windows.Forms.Button();
			this.imgPathText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.imgPictureBox = new System.Windows.Forms.PictureBox();
			this.runTimeResetButton = new System.Windows.Forms.Button();
			this.dconText = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.startCountResetButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.localIniCheck = new System.Windows.Forms.CheckBox();
			this.onlineCheck = new System.Windows.Forms.CheckBox();
			this.offlineCheck = new System.Windows.Forms.CheckBox();
			this.rateCheck = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.runTimeText = new System.Windows.Forms.NumericUpDown();
			this.startCountText = new System.Windows.Forms.NumericUpDown();
			this.dconImgText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.disCloseCheck = new System.Windows.Forms.CheckBox();
			this.bioText = new System.Windows.Forms.Label();
			this.executeCmdText = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.runTimeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.startCountText)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(167, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "タイトル";
			// 
			// titleText
			// 
			this.titleText.Location = new System.Drawing.Point(213, 82);
			this.titleText.MaxLength = 255;
			this.titleText.Name = "titleText";
			this.titleText.Size = new System.Drawing.Size(240, 19);
			this.titleText.TabIndex = 1;
			// 
			// exePathText
			// 
			this.exePathText.Location = new System.Drawing.Point(213, 110);
			this.exePathText.MaxLength = 500;
			this.exePathText.Name = "exePathText";
			this.exePathText.Size = new System.Drawing.Size(214, 19);
			this.exePathText.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(159, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "実行パス";
			// 
			// exePathButton
			// 
			this.exePathButton.Location = new System.Drawing.Point(433, 108);
			this.exePathButton.Name = "exePathButton";
			this.exePathButton.Size = new System.Drawing.Size(20, 23);
			this.exePathButton.TabIndex = 3;
			this.exePathButton.Text = "..";
			this.exePathButton.UseVisualStyleBackColor = true;
			this.exePathButton.Click += new System.EventHandler(this.exePathButton_Click);
			// 
			// imgPathButton
			// 
			this.imgPathButton.Location = new System.Drawing.Point(433, 158);
			this.imgPathButton.Name = "imgPathButton";
			this.imgPathButton.Size = new System.Drawing.Size(20, 23);
			this.imgPathButton.TabIndex = 6;
			this.imgPathButton.Text = "..";
			this.imgPathButton.UseVisualStyleBackColor = true;
			this.imgPathButton.Click += new System.EventHandler(this.imgPathButton_Click);
			// 
			// imgPathText
			// 
			this.imgPathText.Location = new System.Drawing.Point(213, 160);
			this.imgPathText.MaxLength = 500;
			this.imgPathText.Name = "imgPathText";
			this.imgPathText.Size = new System.Drawing.Size(214, 19);
			this.imgPathText.TabIndex = 5;
			this.imgPathText.TextChanged += new System.EventHandler(this.applyPictureBox);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(159, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "画像パス";
			// 
			// imgPictureBox
			// 
			this.imgPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.imgPictureBox.InitialImage = global::glc_cs.Properties.Resources.load;
			this.imgPictureBox.Location = new System.Drawing.Point(12, 12);
			this.imgPictureBox.Name = "imgPictureBox";
			this.imgPictureBox.Size = new System.Drawing.Size(100, 100);
			this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgPictureBox.TabIndex = 8;
			this.imgPictureBox.TabStop = false;
			this.imgPictureBox.WaitOnLoad = true;
			// 
			// runTimeResetButton
			// 
			this.runTimeResetButton.Location = new System.Drawing.Point(284, 244);
			this.runTimeResetButton.Name = "runTimeResetButton";
			this.runTimeResetButton.Size = new System.Drawing.Size(20, 19);
			this.runTimeResetButton.TabIndex = 10;
			this.runTimeResetButton.Text = "0";
			this.runTimeResetButton.UseVisualStyleBackColor = true;
			this.runTimeResetButton.Click += new System.EventHandler(this.runTimeResetButton_Click);
			// 
			// dconText
			// 
			this.dconText.Location = new System.Drawing.Point(213, 188);
			this.dconText.MaxLength = 50;
			this.dconText.Name = "dconText";
			this.dconText.Size = new System.Drawing.Size(240, 19);
			this.dconText.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(142, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 12);
			this.label5.TabIndex = 10;
			this.label5.Text = "dconテキスト";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(154, 246);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 12);
			this.label6.TabIndex = 13;
			this.label6.Text = "起動時間";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(320, 246);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 12);
			this.label7.TabIndex = 16;
			this.label7.Text = "起動回数";
			// 
			// startCountResetButton
			// 
			this.startCountResetButton.Location = new System.Drawing.Point(433, 244);
			this.startCountResetButton.Name = "startCountResetButton";
			this.startCountResetButton.Size = new System.Drawing.Size(20, 19);
			this.startCountResetButton.TabIndex = 12;
			this.startCountResetButton.Text = "0";
			this.startCountResetButton.UseVisualStyleBackColor = true;
			this.startCountResetButton.Click += new System.EventHandler(this.startCountResetButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(96, 306);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(122, 33);
			this.AddButton.TabIndex = 14;
			this.AddButton.Text = "追加";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.ApplyButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(250, 306);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(122, 33);
			this.CloseButton.TabIndex = 15;
			this.CloseButton.Text = "キャンセル";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// localIniCheck
			// 
			this.localIniCheck.AutoSize = true;
			this.localIniCheck.Enabled = false;
			this.localIniCheck.Location = new System.Drawing.Point(188, 12);
			this.localIniCheck.Name = "localIniCheck";
			this.localIniCheck.Size = new System.Drawing.Size(76, 16);
			this.localIniCheck.TabIndex = 22;
			this.localIniCheck.Text = "ローカルINI";
			this.localIniCheck.UseVisualStyleBackColor = true;
			// 
			// onlineCheck
			// 
			this.onlineCheck.AutoSize = true;
			this.onlineCheck.Enabled = false;
			this.onlineCheck.Location = new System.Drawing.Point(270, 12);
			this.onlineCheck.Name = "onlineCheck";
			this.onlineCheck.Size = new System.Drawing.Size(84, 16);
			this.onlineCheck.TabIndex = 23;
			this.onlineCheck.Text = "オンラインDB";
			this.onlineCheck.UseVisualStyleBackColor = true;
			// 
			// offlineCheck
			// 
			this.offlineCheck.AutoSize = true;
			this.offlineCheck.Enabled = false;
			this.offlineCheck.Location = new System.Drawing.Point(360, 12);
			this.offlineCheck.Name = "offlineCheck";
			this.offlineCheck.Size = new System.Drawing.Size(95, 16);
			this.offlineCheck.TabIndex = 24;
			this.offlineCheck.Text = "オフラインモード";
			this.offlineCheck.UseVisualStyleBackColor = true;
			// 
			// rateCheck
			// 
			this.rateCheck.AutoSize = true;
			this.rateCheck.Location = new System.Drawing.Point(213, 272);
			this.rateCheck.Name = "rateCheck";
			this.rateCheck.Size = new System.Drawing.Size(125, 16);
			this.rateCheck.TabIndex = 13;
			this.rateCheck.Text = "X-Rated（成人向け）";
			this.rateCheck.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(177, 273);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 12);
			this.label8.TabIndex = 27;
			this.label8.Text = "フラグ";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// runTimeText
			// 
			this.runTimeText.Location = new System.Drawing.Point(213, 244);
			this.runTimeText.Maximum = new decimal(new int[] {
            35791394,
            0,
            0,
            0});
			this.runTimeText.Name = "runTimeText";
			this.runTimeText.Size = new System.Drawing.Size(65, 19);
			this.runTimeText.TabIndex = 9;
			// 
			// startCountText
			// 
			this.startCountText.Location = new System.Drawing.Point(379, 244);
			this.startCountText.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.startCountText.Name = "startCountText";
			this.startCountText.Size = new System.Drawing.Size(48, 19);
			this.startCountText.TabIndex = 11;
			// 
			// dconImgText
			// 
			this.dconImgText.Location = new System.Drawing.Point(213, 216);
			this.dconImgText.MaxLength = 50;
			this.dconImgText.Name = "dconImgText";
			this.dconImgText.Size = new System.Drawing.Size(240, 19);
			this.dconImgText.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(130, 219);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 12);
			this.label4.TabIndex = 29;
			this.label4.Text = "dconイメージID";
			// 
			// disCloseCheck
			// 
			this.disCloseCheck.AutoSize = true;
			this.disCloseCheck.Location = new System.Drawing.Point(301, 350);
			this.disCloseCheck.Name = "disCloseCheck";
			this.disCloseCheck.Size = new System.Drawing.Size(162, 16);
			this.disCloseCheck.TabIndex = 30;
			this.disCloseCheck.Text = "追加後にウィンドウを閉じない";
			this.disCloseCheck.UseVisualStyleBackColor = true;
			// 
			// bioText
			// 
			this.bioText.AutoSize = true;
			this.bioText.Location = new System.Drawing.Point(137, 47);
			this.bioText.Name = "bioText";
			this.bioText.Size = new System.Drawing.Size(281, 12);
			this.bioText.TabIndex = 31;
			this.bioText.Text = "ランチャーにアイテムを追加します。D&&Dで自動補填します。";
			// 
			// executeCmdText
			// 
			this.executeCmdText.Location = new System.Drawing.Point(213, 135);
			this.executeCmdText.MaxLength = 255;
			this.executeCmdText.Name = "executeCmdText";
			this.executeCmdText.Size = new System.Drawing.Size(240, 19);
			this.executeCmdText.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(134, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 12);
			this.label9.TabIndex = 32;
			this.label9.Text = "実行パラメータ";
			// 
			// AddItem
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 373);
			this.Controls.Add(this.executeCmdText);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.bioText);
			this.Controls.Add(this.disCloseCheck);
			this.Controls.Add(this.dconImgText);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.startCountText);
			this.Controls.Add(this.runTimeText);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.rateCheck);
			this.Controls.Add(this.offlineCheck);
			this.Controls.Add(this.onlineCheck);
			this.Controls.Add(this.localIniCheck);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.startCountResetButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.runTimeResetButton);
			this.Controls.Add(this.dconText);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.imgPictureBox);
			this.Controls.Add(this.imgPathButton);
			this.Controls.Add(this.imgPathText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.exePathButton);
			this.Controls.Add(this.exePathText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.titleText);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddItem";
			this.Text = "AddItem";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddItem_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AddItem_DragEnter);
			((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.runTimeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.startCountText)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox titleText;
		private System.Windows.Forms.TextBox exePathText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button exePathButton;
		private System.Windows.Forms.Button imgPathButton;
		private System.Windows.Forms.TextBox imgPathText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox imgPictureBox;
		private System.Windows.Forms.Button runTimeResetButton;
		private System.Windows.Forms.TextBox dconText;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button startCountResetButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.CheckBox localIniCheck;
		private System.Windows.Forms.CheckBox onlineCheck;
		private System.Windows.Forms.CheckBox offlineCheck;
		private System.Windows.Forms.CheckBox rateCheck;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.NumericUpDown runTimeText;
		private System.Windows.Forms.NumericUpDown startCountText;
		private System.Windows.Forms.TextBox dconImgText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox disCloseCheck;
		private System.Windows.Forms.Label bioText;
		private System.Windows.Forms.TextBox executeCmdText;
		private System.Windows.Forms.Label label9;
	}
}