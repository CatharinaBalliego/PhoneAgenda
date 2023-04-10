namespace PhoneAgenda
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
            name_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            phone_box = new TextBox();
            btn_save = new Button();
            contactListView = new DataGridView();
            searchLbl = new Label();
            searchBoxText = new TextBox();
            btnSearch = new Button();
            label3 = new Label();
            closeApp = new Label();
            ((System.ComponentModel.ISupportInitialize)contactListView).BeginInit();
            SuspendLayout();
            // 
            // name_box
            // 
            name_box.Location = new Point(102, 70);
            name_box.Name = "name_box";
            name_box.Size = new Size(154, 23);
            name_box.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 73);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = ":Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 73);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = ":Phone";
            // 
            // phone_box
            // 
            phone_box.Location = new Point(322, 71);
            phone_box.Name = "phone_box";
            phone_box.Size = new Size(154, 23);
            phone_box.TabIndex = 3;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(482, 70);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 24);
            btn_save.TabIndex = 5;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += button1_Click;
            // 
            // contactListView
            // 
            contactListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactListView.Location = new Point(53, 149);
            contactListView.Name = "contactListView";
            contactListView.RowTemplate.Height = 25;
            contactListView.Size = new Size(504, 237);
            contactListView.TabIndex = 6;
            // 
            // searchLbl
            // 
            searchLbl.AutoSize = true;
            searchLbl.Location = new Point(53, 121);
            searchLbl.Name = "searchLbl";
            searchLbl.Size = new Size(45, 15);
            searchLbl.TabIndex = 7;
            searchLbl.Text = ":Search";
            // 
            // searchBoxText
            // 
            searchBoxText.Location = new Point(102, 118);
            searchBoxText.Name = "searchBoxText";
            searchBoxText.Size = new Size(374, 23);
            searchBoxText.TabIndex = 8;
            searchBoxText.KeyUp += search;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(482, 117);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(244, 25);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 10;
            label3.Text = "Contact List";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeApp
            // 
            closeApp.AutoSize = true;
            closeApp.Location = new Point(582, 9);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(14, 15);
            closeApp.TabIndex = 11;
            closeApp.Text = "X";
            closeApp.Click += closeApp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(608, 422);
            Controls.Add(closeApp);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(searchBoxText);
            Controls.Add(searchLbl);
            Controls.Add(contactListView);
            Controls.Add(btn_save);
            Controls.Add(phone_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name_box);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhoneAgenda";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)contactListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name_box;
        private Label label1;
        private Label label2;
        private TextBox phone_box;
        private Button btn_save;
        private DataGridView contactListView;
        private Label searchLbl;
        private TextBox searchBoxText;
        private Button btnSearch;
        private Label label3;
        private Label closeApp;
    }
}