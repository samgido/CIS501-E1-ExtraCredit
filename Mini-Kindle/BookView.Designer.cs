namespace Mini_Kindle
{
    partial class BookView
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
			PageTextLabel = new Label();
			FlipBackwardsButton = new Button();
			FlipForwardButton = new Button();
			PageNumberNumericUpDown = new NumericUpDown();
			GoToPageButton = new Button();
			CloseBookButton = new Button();
			BookmarkLabel = new Label();
			BookmarkPageButton = new Button();
			((System.ComponentModel.ISupportInitialize)PageNumberNumericUpDown).BeginInit();
			SuspendLayout();
			// 
			// PageTextLabel
			// 
			PageTextLabel.AutoSize = true;
			PageTextLabel.Location = new Point(323, 74);
			PageTextLabel.Name = "PageTextLabel";
			PageTextLabel.Size = new Size(0, 20);
			PageTextLabel.TabIndex = 0;
			// 
			// FlipBackwardsButton
			// 
			FlipBackwardsButton.Location = new Point(26, 304);
			FlipBackwardsButton.Name = "FlipBackwardsButton";
			FlipBackwardsButton.Size = new Size(154, 29);
			FlipBackwardsButton.TabIndex = 1;
			FlipBackwardsButton.Text = "Flip Backwards";
			FlipBackwardsButton.UseVisualStyleBackColor = true;
			FlipBackwardsButton.Click += FlipBackwardsButton_Click;
			// 
			// FlipForwardButton
			// 
			FlipForwardButton.Location = new Point(618, 304);
			FlipForwardButton.Name = "FlipForwardButton";
			FlipForwardButton.Size = new Size(154, 29);
			FlipForwardButton.TabIndex = 2;
			FlipForwardButton.Text = "Flip Forwards";
			FlipForwardButton.UseVisualStyleBackColor = true;
			FlipForwardButton.Click += FlipForwardButton_Click;
			// 
			// PageNumberNumericUpDown
			// 
			PageNumberNumericUpDown.Location = new Point(301, 348);
			PageNumberNumericUpDown.Name = "PageNumberNumericUpDown";
			PageNumberNumericUpDown.Size = new Size(150, 27);
			PageNumberNumericUpDown.TabIndex = 3;
			// 
			// GoToPageButton
			// 
			GoToPageButton.Location = new Point(324, 395);
			GoToPageButton.Name = "GoToPageButton";
			GoToPageButton.Size = new Size(94, 29);
			GoToPageButton.TabIndex = 4;
			GoToPageButton.Text = "Go To Page";
			GoToPageButton.UseVisualStyleBackColor = true;
			GoToPageButton.Click += GoToPageButton_Click;
			// 
			// CloseBookButton
			// 
			CloseBookButton.Location = new Point(666, 402);
			CloseBookButton.Name = "CloseBookButton";
			CloseBookButton.Size = new Size(94, 29);
			CloseBookButton.TabIndex = 5;
			CloseBookButton.Text = "Close Book";
			CloseBookButton.UseVisualStyleBackColor = true;
			CloseBookButton.Click += CloseBookButton_Click;
			// 
			// BookmarkLabel
			// 
			BookmarkLabel.AutoSize = true;
			BookmarkLabel.Font = new Font("Segoe UI", 15F);
			BookmarkLabel.Location = new Point(641, 89);
			BookmarkLabel.Name = "BookmarkLabel";
			BookmarkLabel.Size = new Size(0, 35);
			BookmarkLabel.TabIndex = 6;
			// 
			// BookmarkPageButton
			// 
			BookmarkPageButton.Location = new Point(38, 375);
			BookmarkPageButton.Name = "BookmarkPageButton";
			BookmarkPageButton.Size = new Size(169, 29);
			BookmarkPageButton.TabIndex = 7;
			BookmarkPageButton.Text = "Bookmark Page";
			BookmarkPageButton.UseVisualStyleBackColor = true;
			BookmarkPageButton.Click += BookmarkPageButton_Click;
			// 
			// BookView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(BookmarkPageButton);
			Controls.Add(BookmarkLabel);
			Controls.Add(CloseBookButton);
			Controls.Add(GoToPageButton);
			Controls.Add(PageNumberNumericUpDown);
			Controls.Add(FlipForwardButton);
			Controls.Add(FlipBackwardsButton);
			Controls.Add(PageTextLabel);
			Name = "BookView";
			Text = "BookView";
			((System.ComponentModel.ISupportInitialize)PageNumberNumericUpDown).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label PageTextLabel;
		private Button FlipBackwardsButton;
		private Button FlipForwardButton;
		private NumericUpDown PageNumberNumericUpDown;
		private Button GoToPageButton;
		private Button CloseBookButton;
		private Label BookmarkLabel;
		private Button BookmarkPageButton;
	}
}