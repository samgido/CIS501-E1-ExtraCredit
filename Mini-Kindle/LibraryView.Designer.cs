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
            listView1.Location = new Point(45, 34);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(614, 92);
            listView1.TabIndex = 0;
            listView1.TileSize = new Size(300, 300);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // OpenBookButton
            // 
            OpenBookButton.Location = new Point(48, 153);
            OpenBookButton.Margin = new Padding(3, 2, 3, 2);
            OpenBookButton.Name = "OpenBookButton";
            OpenBookButton.Size = new Size(82, 22);
            OpenBookButton.TabIndex = 1;
            OpenBookButton.Text = "Open Book";
            OpenBookButton.UseVisualStyleBackColor = true;
            OpenBookButton.Click += OpenBookClick;
            // 
            // SyncButton
            // 
            SyncButton.Location = new Point(458, 174);
            SyncButton.Margin = new Padding(3, 2, 3, 2);
            SyncButton.Name = "SyncButton";
            SyncButton.Size = new Size(82, 22);
            SyncButton.TabIndex = 2;
            SyncButton.Text = "Sync Library";
            SyncButton.UseVisualStyleBackColor = true;
            SyncButton.Click += SyncButtonClick;
            // 
            // LibraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(SyncButton);
            Controls.Add(OpenBookButton);
            Controls.Add(listView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LibraryView";
            Text = "Mini-Kindle";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
		private Button OpenBookButton;
		private Button SyncButton;
	}
}
