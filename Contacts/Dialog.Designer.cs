namespace Contacts
{
    partial class Dialog
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dobTextBox = new TextBox();
            phoneTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dobTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(phoneTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(nameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(button2, 2, 3);
            tableLayoutPanel1.Controls.Add(button1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(448, 186);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dobTextBox
            // 
            dobTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(dobTextBox, 2);
            dobTextBox.Location = new Point(62, 103);
            dobTextBox.Margin = new Padding(4, 3, 4, 3);
            dobTextBox.Name = "dobTextBox";
            dobTextBox.PlaceholderText = "Date format: YYYY-MM-DD";
            dobTextBox.Size = new Size(382, 23);
            dobTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(phoneTextBox, 2);
            phoneTextBox.Location = new Point(62, 57);
            phoneTextBox.Margin = new Padding(4, 3, 4, 3);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.PlaceholderText = "Maximum of 50 characters";
            phoneTextBox.Size = new Size(382, 23);
            phoneTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(15, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 46);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(13, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 46);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(23, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 46);
            label3.TabIndex = 2;
            label3.Text = "DOB";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(nameTextBox, 2);
            nameTextBox.Location = new Point(62, 11);
            nameTextBox.Margin = new Padding(4, 3, 4, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Maximum of 100 characters";
            nameTextBox.Size = new Size(382, 23);
            nameTextBox.TabIndex = 5;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(257, 148);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(82, 27);
            button2.TabIndex = 4;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(167, 148);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(82, 27);
            button1.TabIndex = 3;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // Dialog
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(448, 186);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dialog";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox dobTextBox;
        private TextBox phoneTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox nameTextBox;
    }
}