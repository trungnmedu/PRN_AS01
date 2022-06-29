namespace MyStoreWinApp
{
    partial class FormMemberManagement
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
            this.lableMemberId = new System.Windows.Forms.Label();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.labelMemberEmail = new System.Windows.Forms.Label();
            this.textBoxMemberEmail = new System.Windows.Forms.TextBox();
            this.labelMemberCity = new System.Windows.Forms.Label();
            this.textBoxMemberCity = new System.Windows.Forms.TextBox();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.labelMemberPassword = new System.Windows.Forms.Label();
            this.textBoxMemberPassword = new System.Windows.Forms.TextBox();
            this.labelMemberCountry = new System.Windows.Forms.Label();
            this.textBoxMemberCountry = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupSearchInput = new System.Windows.Forms.GroupBox();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelKeyword = new System.Windows.Forms.Label();
            this.textBoxSearchKeyword = new System.Windows.Forms.TextBox();
            this.groupBoxSearchBy = new System.Windows.Forms.GroupBox();
            this.radioButtonSearchByName = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchById = new System.Windows.Forms.RadioButton();
            this.groupBoxFilterByCountry = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterByCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterByCity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelFilterByCity = new System.Windows.Forms.Label();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.groupSearchInput.SuspendLayout();
            this.groupBoxSearchBy.SuspendLayout();
            this.groupBoxFilterByCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // lableMemberId
            // 
            this.lableMemberId.AutoSize = true;
            this.lableMemberId.Location = new System.Drawing.Point(20, 52);
            this.lableMemberId.Name = "lableMemberId";
            this.lableMemberId.Size = new System.Drawing.Size(84, 20);
            this.lableMemberId.TabIndex = 0;
            this.lableMemberId.Text = "Member ID";
            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.Location = new System.Drawing.Point(135, 45);
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.Size = new System.Drawing.Size(361, 27);
            this.textBoxMemberId.TabIndex = 1;
            // 
            // labelMemberEmail
            // 
            this.labelMemberEmail.AutoSize = true;
            this.labelMemberEmail.Location = new System.Drawing.Point(648, 52);
            this.labelMemberEmail.Name = "labelMemberEmail";
            this.labelMemberEmail.Size = new System.Drawing.Size(46, 20);
            this.labelMemberEmail.TabIndex = 0;
            this.labelMemberEmail.Text = "Email";
            // 
            // textBoxMemberEmail
            // 
            this.textBoxMemberEmail.Location = new System.Drawing.Point(753, 45);
            this.textBoxMemberEmail.Name = "textBoxMemberEmail";
            this.textBoxMemberEmail.Size = new System.Drawing.Size(361, 27);
            this.textBoxMemberEmail.TabIndex = 1;
            // 
            // labelMemberCity
            // 
            this.labelMemberCity.AutoSize = true;
            this.labelMemberCity.Location = new System.Drawing.Point(1201, 56);
            this.labelMemberCity.Name = "labelMemberCity";
            this.labelMemberCity.Size = new System.Drawing.Size(34, 20);
            this.labelMemberCity.TabIndex = 0;
            this.labelMemberCity.Text = "City";
            // 
            // textBoxMemberCity
            // 
            this.textBoxMemberCity.Location = new System.Drawing.Point(1306, 49);
            this.textBoxMemberCity.Name = "textBoxMemberCity";
            this.textBoxMemberCity.Size = new System.Drawing.Size(361, 27);
            this.textBoxMemberCity.TabIndex = 1;
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.Location = new System.Drawing.Point(20, 118);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(109, 20);
            this.labelMemberName.TabIndex = 0;
            this.labelMemberName.Text = "Member Name";
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(135, 111);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(361, 27);
            this.textBoxMemberName.TabIndex = 1;
            // 
            // labelMemberPassword
            // 
            this.labelMemberPassword.AutoSize = true;
            this.labelMemberPassword.Location = new System.Drawing.Point(648, 118);
            this.labelMemberPassword.Name = "labelMemberPassword";
            this.labelMemberPassword.Size = new System.Drawing.Size(70, 20);
            this.labelMemberPassword.TabIndex = 0;
            this.labelMemberPassword.Text = "Password";
            // 
            // textBoxMemberPassword
            // 
            this.textBoxMemberPassword.Location = new System.Drawing.Point(753, 111);
            this.textBoxMemberPassword.Name = "textBoxMemberPassword";
            this.textBoxMemberPassword.PasswordChar = '*';
            this.textBoxMemberPassword.Size = new System.Drawing.Size(361, 27);
            this.textBoxMemberPassword.TabIndex = 1;
            // 
            // labelMemberCountry
            // 
            this.labelMemberCountry.AutoSize = true;
            this.labelMemberCountry.Location = new System.Drawing.Point(1201, 122);
            this.labelMemberCountry.Name = "labelMemberCountry";
            this.labelMemberCountry.Size = new System.Drawing.Size(60, 20);
            this.labelMemberCountry.TabIndex = 0;
            this.labelMemberCountry.Text = "Country";
            // 
            // textBoxMemberCountry
            // 
            this.textBoxMemberCountry.Location = new System.Drawing.Point(1306, 115);
            this.textBoxMemberCountry.Name = "textBoxMemberCountry";
            this.textBoxMemberCountry.Size = new System.Drawing.Size(361, 27);
            this.textBoxMemberCountry.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(20, 393);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(94, 29);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(829, 393);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(94, 29);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1590, 393);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDelete_MouseClick);
            // 
            // groupSearchInput
            // 
            this.groupSearchInput.Controls.Add(this.buttonClearSearch);
            this.groupSearchInput.Controls.Add(this.buttonSearch);
            this.groupSearchInput.Controls.Add(this.labelKeyword);
            this.groupSearchInput.Controls.Add(this.textBoxSearchKeyword);
            this.groupSearchInput.Enabled = false;
            this.groupSearchInput.Location = new System.Drawing.Point(20, 182);
            this.groupSearchInput.Name = "groupSearchInput";
            this.groupSearchInput.Size = new System.Drawing.Size(493, 168);
            this.groupSearchInput.TabIndex = 3;
            this.groupSearchInput.TabStop = false;
            this.groupSearchInput.Text = "Search";
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Location = new System.Drawing.Point(372, 117);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonClearSearch.TabIndex = 4;
            this.buttonClearSearch.Text = "Clear";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(105, 117);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelKeyword
            // 
            this.labelKeyword.AutoSize = true;
            this.labelKeyword.Location = new System.Drawing.Point(6, 56);
            this.labelKeyword.Name = "labelKeyword";
            this.labelKeyword.Size = new System.Drawing.Size(67, 20);
            this.labelKeyword.TabIndex = 1;
            this.labelKeyword.Text = "Keyword";
            // 
            // textBoxSearchKeyword
            // 
            this.textBoxSearchKeyword.Location = new System.Drawing.Point(105, 49);
            this.textBoxSearchKeyword.Name = "textBoxSearchKeyword";
            this.textBoxSearchKeyword.PlaceholderText = "Enter search keyword ...";
            this.textBoxSearchKeyword.Size = new System.Drawing.Size(361, 27);
            this.textBoxSearchKeyword.TabIndex = 0;
            // 
            // groupBoxSearchBy
            // 
            this.groupBoxSearchBy.Controls.Add(this.radioButtonSearchByName);
            this.groupBoxSearchBy.Controls.Add(this.radioButtonSearchById);
            this.groupBoxSearchBy.Enabled = false;
            this.groupBoxSearchBy.Location = new System.Drawing.Point(648, 182);
            this.groupBoxSearchBy.Name = "groupBoxSearchBy";
            this.groupBoxSearchBy.Size = new System.Drawing.Size(483, 168);
            this.groupBoxSearchBy.TabIndex = 3;
            this.groupBoxSearchBy.TabStop = false;
            this.groupBoxSearchBy.Text = "Search By";
            // 
            // radioButtonSearchByName
            // 
            this.radioButtonSearchByName.AutoSize = true;
            this.radioButtonSearchByName.Checked = true;
            this.radioButtonSearchByName.Location = new System.Drawing.Point(18, 49);
            this.radioButtonSearchByName.Name = "radioButtonSearchByName";
            this.radioButtonSearchByName.Size = new System.Drawing.Size(150, 24);
            this.radioButtonSearchByName.TabIndex = 4;
            this.radioButtonSearchByName.TabStop = true;
            this.radioButtonSearchByName.Text = "By Member Name";
            this.radioButtonSearchByName.UseVisualStyleBackColor = true;
            // 
            // radioButtonSearchById
            // 
            this.radioButtonSearchById.AutoSize = true;
            this.radioButtonSearchById.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSearchById.Location = new System.Drawing.Point(18, 92);
            this.radioButtonSearchById.Name = "radioButtonSearchById";
            this.radioButtonSearchById.Size = new System.Drawing.Size(65, 24);
            this.radioButtonSearchById.TabIndex = 4;
            this.radioButtonSearchById.Text = "By ID";
            this.radioButtonSearchById.UseVisualStyleBackColor = true;
            // 
            // groupBoxFilterByCountry
            // 
            this.groupBoxFilterByCountry.Controls.Add(this.comboBoxFilterByCountry);
            this.groupBoxFilterByCountry.Controls.Add(this.comboBoxFilterByCity);
            this.groupBoxFilterByCountry.Controls.Add(this.label9);
            this.groupBoxFilterByCountry.Controls.Add(this.labelFilterByCity);
            this.groupBoxFilterByCountry.Enabled = false;
            this.groupBoxFilterByCountry.Location = new System.Drawing.Point(1201, 182);
            this.groupBoxFilterByCountry.Name = "groupBoxFilterByCountry";
            this.groupBoxFilterByCountry.Size = new System.Drawing.Size(483, 168);
            this.groupBoxFilterByCountry.TabIndex = 3;
            this.groupBoxFilterByCountry.TabStop = false;
            this.groupBoxFilterByCountry.Text = "Filter By";
            // 
            // comboBoxFilterByCountry
            // 
            this.comboBoxFilterByCountry.AllowDrop = true;
            this.comboBoxFilterByCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterByCountry.FormattingEnabled = true;
            this.comboBoxFilterByCountry.Location = new System.Drawing.Point(116, 45);
            this.comboBoxFilterByCountry.Name = "comboBoxFilterByCountry";
            this.comboBoxFilterByCountry.Size = new System.Drawing.Size(361, 28);
            this.comboBoxFilterByCountry.TabIndex = 1;
            this.comboBoxFilterByCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterByCountry_SelectedIndexChanged);
            // 
            // comboBoxFilterByCity
            // 
            this.comboBoxFilterByCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterByCity.FormattingEnabled = true;
            this.comboBoxFilterByCity.Location = new System.Drawing.Point(116, 88);
            this.comboBoxFilterByCity.Name = "comboBoxFilterByCity";
            this.comboBoxFilterByCity.Size = new System.Drawing.Size(361, 28);
            this.comboBoxFilterByCity.TabIndex = 0;
            this.comboBoxFilterByCity.TabStop = false;
            this.comboBoxFilterByCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterByCity_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Country";
            // 
            // labelFilterByCity
            // 
            this.labelFilterByCity.AutoSize = true;
            this.labelFilterByCity.Location = new System.Drawing.Point(30, 96);
            this.labelFilterByCity.Name = "labelFilterByCity";
            this.labelFilterByCity.Size = new System.Drawing.Size(34, 20);
            this.labelFilterByCity.TabIndex = 0;
            this.labelFilterByCity.Text = "City";
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(30, 452);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.RowHeadersWidth = 51;
            this.dataGridViewMembers.RowTemplate.Height = 29;
            this.dataGridViewMembers.Size = new System.Drawing.Size(1664, 386);
            this.dataGridViewMembers.TabIndex = 4;
            this.dataGridViewMembers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMembers_CellMouseDoubleClick);
            // 
            // FormMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 859);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.groupBoxFilterByCountry);
            this.Controls.Add(this.groupBoxSearchBy);
            this.Controls.Add(this.groupSearchInput);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxMemberCountry);
            this.Controls.Add(this.textBoxMemberCity);
            this.Controls.Add(this.labelMemberCountry);
            this.Controls.Add(this.labelMemberCity);
            this.Controls.Add(this.textBoxMemberPassword);
            this.Controls.Add(this.labelMemberPassword);
            this.Controls.Add(this.textBoxMemberEmail);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.labelMemberEmail);
            this.Controls.Add(this.labelMemberName);
            this.Controls.Add(this.textBoxMemberId);
            this.Controls.Add(this.lableMemberId);
            this.Name = "FormMemberManagement";
            this.Text = "FormMemberManagement";
            this.Load += new System.EventHandler(this.FormMemberManagement_Load);
            this.groupSearchInput.ResumeLayout(false);
            this.groupSearchInput.PerformLayout();
            this.groupBoxSearchBy.ResumeLayout(false);
            this.groupBoxSearchBy.PerformLayout();
            this.groupBoxFilterByCountry.ResumeLayout(false);
            this.groupBoxFilterByCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lableMemberId;
        private TextBox textBoxMemberId;
        private Label labelMemberEmail;
        private TextBox textBoxMemberEmail;
        private Label labelMemberCity;
        private TextBox textBoxMemberCity;
        private Label labelMemberName;
        private TextBox textBoxMemberName;
        private Label labelMemberPassword;
        private TextBox textBoxMemberPassword;
        private Label labelMemberCountry;
        private TextBox textBoxMemberCountry;
        private Button buttonLoad;
        private Button buttonNew;
        private Button buttonDelete;
        private GroupBox groupSearchInput;
        private TextBox textBoxSearchKeyword;
        private Label labelKeyword;
        private Button buttonSearch;
        private Button buttonClearSearch;
        private GroupBox groupBoxSearchBy;
        private RadioButton radioButtonSearchById;
        private GroupBox groupBoxFilterByCountry;
        private RadioButton radioButtonSearchByName;
        private ComboBox comboBoxFilterByCity;
        private Label label9;
        private Label labelFilterByCity;
        private DataGridView dataGridViewMembers;
        private ComboBox comboBoxFilterByCountry;
    }
}