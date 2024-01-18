namespace WindowsFormsApp1
{
    partial class PhoneBook
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
            this.newButton = new System.Windows.Forms.Button();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phoneDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(677, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(111, 20);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(105, 12);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(565, 20);
            this.firstNameText.TabIndex = 1;
            this.firstNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(40, 16);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(59, 20);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "FirstName:";
            this.firstName.Click += new System.EventHandler(this.firstName_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(677, 39);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(111, 20);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(677, 64);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 20);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(677, 90);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 20);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(105, 39);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(565, 20);
            this.lastNameText.TabIndex = 6;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(105, 65);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(565, 20);
            this.phoneText.TabIndex = 7;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(105, 90);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(565, 20);
            this.emailText.TabIndex = 8;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(40, 42);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(59, 20);
            this.lastName.TabIndex = 9;
            this.lastName.Text = "LastName:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(40, 68);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(59, 20);
            this.phone.TabIndex = 10;
            this.phone.Text = "Phone:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(40, 93);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(59, 20);
            this.email.TabIndex = 11;
            this.email.Text = "Email:";
            // 
            // phoneDataGrid
            // 
            this.phoneDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phoneDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneDataGrid.Location = new System.Drawing.Point(43, 127);
            this.phoneDataGrid.Name = "phoneDataGrid";
            this.phoneDataGrid.Size = new System.Drawing.Size(745, 165);
            this.phoneDataGrid.TabIndex = 12;
            this.phoneDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.phoneDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.phoneDataGrid_CellMouseDoubleClick);
            // 
            // PhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.phoneDataGrid);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.newButton);
            this.Name = "PhoneBook";
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.DataGridView phoneDataGrid;
    }
}

