namespace Mini_Kindle
{
    partial class LibraryView
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
			listView1 = new ListView();
			OpenBookButton = new Button();
			SyncButton = new Button();
			SuspendLayout();
			// 
			// listView1
			// 
			listView1.Location = new Point(51, 46);
			listView1.Name = "listView1";
			listView1.Size = new Size(701, 121);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
			// 
			// OpenBookButton
			// 
			OpenBookButton.Location = new Point(55, 204);
			OpenBookButton.Name = "OpenBookButton";
			OpenBookButton.Size = new Size(94, 29);
			OpenBookButton.TabIndex = 1;
			OpenBookButton.Text = "Open Book";
			OpenBookButton.UseVisualStyleBackColor = true;
			OpenBookButton.Click += OpenBookClick;
			// 
			// SyncButton
			// 
			SyncButton.Location = new Point(524, 232);
			SyncButton.Name = "SyncButton";
			SyncButton.Size = new Size(94, 29);
			SyncButton.TabIndex = 2;
			SyncButton.Text = "Sync Library";
			SyncButton.UseVisualStyleBackColor = true;
			SyncButton.Click += SyncButtonClick;
			// 
			// LibraryView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(SyncButton);
			Controls.Add(OpenBookButton);
			Controls.Add(listView1);
			Name = "LibraryView";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private ListView listView1;
		private Button OpenBookButton;
		private Button SyncButton;
	}
}
