namespace MyMVP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersList = new System.Windows.Forms.DataGridView();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ComboBoxFiltr = new System.Windows.Forms.ComboBox();
            this.Clear = new System.Windows.Forms.Button();
            this.NameFiltr = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersList
            // 
            this.UsersList.Location = new System.Drawing.Point(22, 12);
            this.UsersList.MultiSelect = false;
            this.UsersList.Name = "UsersList";
            this.UsersList.ReadOnly = true;
            this.UsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersList.Size = new System.Drawing.Size(648, 207);
            this.UsersList.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(22, 257);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // ComboBoxFiltr
            // 
            this.ComboBoxFiltr.FormattingEnabled = true;
            this.ComboBoxFiltr.Items.AddRange(new object[] {
            "Имя",
            "Логин"});
            this.ComboBoxFiltr.Location = new System.Drawing.Point(236, 257);
            this.ComboBoxFiltr.Name = "ComboBoxFiltr";
            this.ComboBoxFiltr.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxFiltr.TabIndex = 5;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(57, 296);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Сбросить";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // NameFiltr
            // 
            this.NameFiltr.Location = new System.Drawing.Point(193, 296);
            this.NameFiltr.Name = "NameFiltr";
            this.NameFiltr.Size = new System.Drawing.Size(100, 23);
            this.NameFiltr.TabIndex = 7;
            this.NameFiltr.Text = "Отфильтровать";
            this.NameFiltr.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(71, 338);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(206, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить пользователя";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.NameFiltr);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ComboBoxFiltr);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.UsersList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersList;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox ComboBoxFiltr;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button NameFiltr;
        private System.Windows.Forms.Button deleteButton;
   
    }
}

