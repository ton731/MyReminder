namespace MyReminder
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Remove1Button = new System.Windows.Forms.Button();
            this.Add1Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Remove2Button = new System.Windows.Forms.Button();
            this.Add2Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NewItem1Panel = new System.Windows.Forms.Panel();
            this.NewItemCancel1Button = new System.Windows.Forms.Button();
            this.NewItemOk1Button = new System.Windows.Forms.Button();
            this.NewItem1TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewItem2Panel = new System.Windows.Forms.Panel();
            this.NewItemCancel2Button = new System.Windows.Forms.Button();
            this.NewItemOk2Button = new System.Windows.Forms.Button();
            this.NewItem2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Remove1Panel = new System.Windows.Forms.Panel();
            this.Remove1ComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveCancel1Button = new System.Windows.Forms.Button();
            this.RemoveOk1Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Remove2Panel = new System.Windows.Forms.Panel();
            this.Remove2ComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveCancel2Button = new System.Windows.Forms.Button();
            this.RemoveOk2Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MoveDownPanel = new System.Windows.Forms.Panel();
            this.MoveDownComboBox = new System.Windows.Forms.ComboBox();
            this.MoveDownCancelButton = new System.Windows.Forms.Button();
            this.MoveDownOkButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MoveUpPanel = new System.Windows.Forms.Panel();
            this.MoveUpComboBox = new System.Windows.Forms.ComboBox();
            this.MoveUpCancelButton = new System.Windows.Forms.Button();
            this.MoveUpOkButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.NewItem1Panel.SuspendLayout();
            this.NewItem2Panel.SuspendLayout();
            this.Remove1Panel.SuspendLayout();
            this.Remove2Panel.SuspendLayout();
            this.MoveDownPanel.SuspendLayout();
            this.MoveUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MoveDownButton);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.Remove1Button);
            this.panel1.Controls.Add(this.Add1Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 300);
            this.panel1.TabIndex = 0;
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.BackColor = System.Drawing.Color.Wheat;
            this.MoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDownButton.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveDownButton.Location = new System.Drawing.Point(383, 108);
            this.MoveDownButton.Margin = new System.Windows.Forms.Padding(4);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(51, 40);
            this.MoveDownButton.TabIndex = 4;
            this.MoveDownButton.Text = "▼";
            this.MoveDownButton.UseVisualStyleBackColor = false;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Wheat;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 42);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(357, 234);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Remove1Button
            // 
            this.Remove1Button.BackColor = System.Drawing.Color.Wheat;
            this.Remove1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove1Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove1Button.Location = new System.Drawing.Point(383, 14);
            this.Remove1Button.Margin = new System.Windows.Forms.Padding(4);
            this.Remove1Button.Name = "Remove1Button";
            this.Remove1Button.Size = new System.Drawing.Size(51, 40);
            this.Remove1Button.TabIndex = 2;
            this.Remove1Button.Text = "✔";
            this.Remove1Button.UseVisualStyleBackColor = false;
            this.Remove1Button.Click += new System.EventHandler(this.Remove1Button_Click);
            // 
            // Add1Button
            // 
            this.Add1Button.BackColor = System.Drawing.Color.Wheat;
            this.Add1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add1Button.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Add1Button.Location = new System.Drawing.Point(383, 61);
            this.Add1Button.Margin = new System.Windows.Forms.Padding(4);
            this.Add1Button.Name = "Add1Button";
            this.Add1Button.Size = new System.Drawing.Size(51, 40);
            this.Add1Button.TabIndex = 1;
            this.Add1Button.Text = "➕";
            this.Add1Button.UseVisualStyleBackColor = false;
            this.Add1Button.Click += new System.EventHandler(this.Add1Button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Important";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.MoveUpButton);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.Remove2Button);
            this.panel2.Controls.Add(this.Add2Button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 308);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 300);
            this.panel2.TabIndex = 1;
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.BackColor = System.Drawing.Color.Wheat;
            this.MoveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveUpButton.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveUpButton.Location = new System.Drawing.Point(383, 110);
            this.MoveUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(51, 40);
            this.MoveUpButton.TabIndex = 6;
            this.MoveUpButton.Text = "▲";
            this.MoveUpButton.UseVisualStyleBackColor = false;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Wheat;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox2.Location = new System.Drawing.Point(13, 42);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(357, 234);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // Remove2Button
            // 
            this.Remove2Button.BackColor = System.Drawing.Color.Wheat;
            this.Remove2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove2Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove2Button.Location = new System.Drawing.Point(383, 15);
            this.Remove2Button.Margin = new System.Windows.Forms.Padding(4);
            this.Remove2Button.Name = "Remove2Button";
            this.Remove2Button.Size = new System.Drawing.Size(51, 40);
            this.Remove2Button.TabIndex = 4;
            this.Remove2Button.Text = "✔";
            this.Remove2Button.UseVisualStyleBackColor = false;
            this.Remove2Button.Click += new System.EventHandler(this.Remove2Button_Click);
            // 
            // Add2Button
            // 
            this.Add2Button.BackColor = System.Drawing.Color.Wheat;
            this.Add2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add2Button.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Add2Button.Location = new System.Drawing.Point(383, 62);
            this.Add2Button.Margin = new System.Windows.Forms.Padding(4);
            this.Add2Button.Name = "Add2Button";
            this.Add2Button.Size = new System.Drawing.Size(51, 40);
            this.Add2Button.TabIndex = 3;
            this.Add2Button.Text = "➕";
            this.Add2Button.UseVisualStyleBackColor = false;
            this.Add2Button.Click += new System.EventHandler(this.Add2Button_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "If I have time...";
            // 
            // NewItem1Panel
            // 
            this.NewItem1Panel.BackColor = System.Drawing.SystemColors.Control;
            this.NewItem1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewItem1Panel.Controls.Add(this.NewItemCancel1Button);
            this.NewItem1Panel.Controls.Add(this.NewItemOk1Button);
            this.NewItem1Panel.Controls.Add(this.NewItem1TextBox);
            this.NewItem1Panel.Controls.Add(this.label3);
            this.NewItem1Panel.Location = new System.Drawing.Point(499, 29);
            this.NewItem1Panel.Margin = new System.Windows.Forms.Padding(4);
            this.NewItem1Panel.Name = "NewItem1Panel";
            this.NewItem1Panel.Size = new System.Drawing.Size(310, 180);
            this.NewItem1Panel.TabIndex = 2;
            this.NewItem1Panel.Visible = false;
            // 
            // NewItemCancel1Button
            // 
            this.NewItemCancel1Button.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewItemCancel1Button.Location = new System.Drawing.Point(160, 128);
            this.NewItemCancel1Button.Margin = new System.Windows.Forms.Padding(4);
            this.NewItemCancel1Button.Name = "NewItemCancel1Button";
            this.NewItemCancel1Button.Size = new System.Drawing.Size(100, 29);
            this.NewItemCancel1Button.TabIndex = 3;
            this.NewItemCancel1Button.Text = "取消";
            this.NewItemCancel1Button.UseVisualStyleBackColor = true;
            this.NewItemCancel1Button.Click += new System.EventHandler(this.NewItemCancel1Button_Click);
            // 
            // NewItemOk1Button
            // 
            this.NewItemOk1Button.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewItemOk1Button.Location = new System.Drawing.Point(39, 128);
            this.NewItemOk1Button.Margin = new System.Windows.Forms.Padding(4);
            this.NewItemOk1Button.Name = "NewItemOk1Button";
            this.NewItemOk1Button.Size = new System.Drawing.Size(100, 29);
            this.NewItemOk1Button.TabIndex = 2;
            this.NewItemOk1Button.Text = "確認";
            this.NewItemOk1Button.UseVisualStyleBackColor = true;
            this.NewItemOk1Button.Click += new System.EventHandler(this.NewItemOk1Button_Click);
            // 
            // NewItem1TextBox
            // 
            this.NewItem1TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewItem1TextBox.Location = new System.Drawing.Point(40, 72);
            this.NewItem1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NewItem1TextBox.Name = "NewItem1TextBox";
            this.NewItem1TextBox.Size = new System.Drawing.Size(219, 34);
            this.NewItem1TextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(43, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "請輸入新增事項：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewItem2Panel
            // 
            this.NewItem2Panel.BackColor = System.Drawing.SystemColors.Control;
            this.NewItem2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewItem2Panel.Controls.Add(this.NewItemCancel2Button);
            this.NewItem2Panel.Controls.Add(this.NewItemOk2Button);
            this.NewItem2Panel.Controls.Add(this.NewItem2TextBox);
            this.NewItem2Panel.Controls.Add(this.label4);
            this.NewItem2Panel.Location = new System.Drawing.Point(499, 242);
            this.NewItem2Panel.Margin = new System.Windows.Forms.Padding(4);
            this.NewItem2Panel.Name = "NewItem2Panel";
            this.NewItem2Panel.Size = new System.Drawing.Size(310, 180);
            this.NewItem2Panel.TabIndex = 3;
            this.NewItem2Panel.Visible = false;
            // 
            // NewItemCancel2Button
            // 
            this.NewItemCancel2Button.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewItemCancel2Button.Location = new System.Drawing.Point(160, 128);
            this.NewItemCancel2Button.Margin = new System.Windows.Forms.Padding(4);
            this.NewItemCancel2Button.Name = "NewItemCancel2Button";
            this.NewItemCancel2Button.Size = new System.Drawing.Size(100, 29);
            this.NewItemCancel2Button.TabIndex = 3;
            this.NewItemCancel2Button.Text = "取消";
            this.NewItemCancel2Button.UseVisualStyleBackColor = true;
            this.NewItemCancel2Button.Click += new System.EventHandler(this.NewItemCancel2Button_Click);
            // 
            // NewItemOk2Button
            // 
            this.NewItemOk2Button.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewItemOk2Button.Location = new System.Drawing.Point(39, 128);
            this.NewItemOk2Button.Margin = new System.Windows.Forms.Padding(4);
            this.NewItemOk2Button.Name = "NewItemOk2Button";
            this.NewItemOk2Button.Size = new System.Drawing.Size(100, 29);
            this.NewItemOk2Button.TabIndex = 2;
            this.NewItemOk2Button.Text = "確認";
            this.NewItemOk2Button.UseVisualStyleBackColor = true;
            this.NewItemOk2Button.Click += new System.EventHandler(this.NewItemOk2Button_Click);
            // 
            // NewItem2TextBox
            // 
            this.NewItem2TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewItem2TextBox.Location = new System.Drawing.Point(40, 72);
            this.NewItem2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NewItem2TextBox.Name = "NewItem2TextBox";
            this.NewItem2TextBox.Size = new System.Drawing.Size(219, 34);
            this.NewItem2TextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(43, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "請輸入新增事項：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Remove1Panel
            // 
            this.Remove1Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Remove1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Remove1Panel.Controls.Add(this.Remove1ComboBox);
            this.Remove1Panel.Controls.Add(this.RemoveCancel1Button);
            this.Remove1Panel.Controls.Add(this.RemoveOk1Button);
            this.Remove1Panel.Controls.Add(this.label5);
            this.Remove1Panel.Location = new System.Drawing.Point(889, 29);
            this.Remove1Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Remove1Panel.Name = "Remove1Panel";
            this.Remove1Panel.Size = new System.Drawing.Size(310, 180);
            this.Remove1Panel.TabIndex = 4;
            this.Remove1Panel.Visible = false;
            // 
            // Remove1ComboBox
            // 
            this.Remove1ComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Remove1ComboBox.Location = new System.Drawing.Point(39, 72);
            this.Remove1ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Remove1ComboBox.Name = "Remove1ComboBox";
            this.Remove1ComboBox.Size = new System.Drawing.Size(220, 33);
            this.Remove1ComboBox.TabIndex = 4;
            // 
            // RemoveCancel1Button
            // 
            this.RemoveCancel1Button.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RemoveCancel1Button.Location = new System.Drawing.Point(160, 128);
            this.RemoveCancel1Button.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveCancel1Button.Name = "RemoveCancel1Button";
            this.RemoveCancel1Button.Size = new System.Drawing.Size(100, 29);
            this.RemoveCancel1Button.TabIndex = 3;
            this.RemoveCancel1Button.Text = "取消";
            this.RemoveCancel1Button.UseVisualStyleBackColor = true;
            this.RemoveCancel1Button.Click += new System.EventHandler(this.RemoveCancel1Button_Click);
            // 
            // RemoveOk1Button
            // 
            this.RemoveOk1Button.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RemoveOk1Button.Location = new System.Drawing.Point(39, 128);
            this.RemoveOk1Button.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveOk1Button.Name = "RemoveOk1Button";
            this.RemoveOk1Button.Size = new System.Drawing.Size(100, 29);
            this.RemoveOk1Button.TabIndex = 2;
            this.RemoveOk1Button.Text = "確認";
            this.RemoveOk1Button.UseVisualStyleBackColor = true;
            this.RemoveOk1Button.Click += new System.EventHandler(this.RemoveOk1Button_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(20, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "請選擇完成的事項：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Remove2Panel
            // 
            this.Remove2Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Remove2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Remove2Panel.Controls.Add(this.Remove2ComboBox);
            this.Remove2Panel.Controls.Add(this.RemoveCancel2Button);
            this.Remove2Panel.Controls.Add(this.RemoveOk2Button);
            this.Remove2Panel.Controls.Add(this.label6);
            this.Remove2Panel.Location = new System.Drawing.Point(889, 242);
            this.Remove2Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Remove2Panel.Name = "Remove2Panel";
            this.Remove2Panel.Size = new System.Drawing.Size(310, 180);
            this.Remove2Panel.TabIndex = 5;
            this.Remove2Panel.Visible = false;
            // 
            // Remove2ComboBox
            // 
            this.Remove2ComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Remove2ComboBox.Location = new System.Drawing.Point(39, 72);
            this.Remove2ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Remove2ComboBox.Name = "Remove2ComboBox";
            this.Remove2ComboBox.Size = new System.Drawing.Size(220, 33);
            this.Remove2ComboBox.TabIndex = 4;
            // 
            // RemoveCancel2Button
            // 
            this.RemoveCancel2Button.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RemoveCancel2Button.Location = new System.Drawing.Point(160, 128);
            this.RemoveCancel2Button.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveCancel2Button.Name = "RemoveCancel2Button";
            this.RemoveCancel2Button.Size = new System.Drawing.Size(100, 29);
            this.RemoveCancel2Button.TabIndex = 3;
            this.RemoveCancel2Button.Text = "取消";
            this.RemoveCancel2Button.UseVisualStyleBackColor = true;
            this.RemoveCancel2Button.Click += new System.EventHandler(this.RemoveCancel2Button_Click);
            // 
            // RemoveOk2Button
            // 
            this.RemoveOk2Button.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RemoveOk2Button.Location = new System.Drawing.Point(39, 128);
            this.RemoveOk2Button.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveOk2Button.Name = "RemoveOk2Button";
            this.RemoveOk2Button.Size = new System.Drawing.Size(100, 29);
            this.RemoveOk2Button.TabIndex = 2;
            this.RemoveOk2Button.Text = "確認";
            this.RemoveOk2Button.UseVisualStyleBackColor = true;
            this.RemoveOk2Button.Click += new System.EventHandler(this.RemoveOk2Button_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(20, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "請選擇完成的事項：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoveDownPanel
            // 
            this.MoveDownPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MoveDownPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoveDownPanel.Controls.Add(this.MoveDownComboBox);
            this.MoveDownPanel.Controls.Add(this.MoveDownCancelButton);
            this.MoveDownPanel.Controls.Add(this.MoveDownOkButton);
            this.MoveDownPanel.Controls.Add(this.label7);
            this.MoveDownPanel.Location = new System.Drawing.Point(499, 466);
            this.MoveDownPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MoveDownPanel.Name = "MoveDownPanel";
            this.MoveDownPanel.Size = new System.Drawing.Size(310, 180);
            this.MoveDownPanel.TabIndex = 6;
            this.MoveDownPanel.Visible = false;
            // 
            // MoveDownComboBox
            // 
            this.MoveDownComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveDownComboBox.Location = new System.Drawing.Point(39, 72);
            this.MoveDownComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoveDownComboBox.Name = "MoveDownComboBox";
            this.MoveDownComboBox.Size = new System.Drawing.Size(220, 33);
            this.MoveDownComboBox.TabIndex = 4;
            // 
            // MoveDownCancelButton
            // 
            this.MoveDownCancelButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveDownCancelButton.Location = new System.Drawing.Point(160, 128);
            this.MoveDownCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.MoveDownCancelButton.Name = "MoveDownCancelButton";
            this.MoveDownCancelButton.Size = new System.Drawing.Size(100, 29);
            this.MoveDownCancelButton.TabIndex = 3;
            this.MoveDownCancelButton.Text = "取消";
            this.MoveDownCancelButton.UseVisualStyleBackColor = true;
            this.MoveDownCancelButton.Click += new System.EventHandler(this.MoveDownCancelButton_Click);
            // 
            // MoveDownOkButton
            // 
            this.MoveDownOkButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveDownOkButton.Location = new System.Drawing.Point(39, 128);
            this.MoveDownOkButton.Margin = new System.Windows.Forms.Padding(4);
            this.MoveDownOkButton.Name = "MoveDownOkButton";
            this.MoveDownOkButton.Size = new System.Drawing.Size(100, 29);
            this.MoveDownOkButton.TabIndex = 2;
            this.MoveDownOkButton.Text = "確認";
            this.MoveDownOkButton.UseVisualStyleBackColor = true;
            this.MoveDownOkButton.Click += new System.EventHandler(this.MoveDownOkButton_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(20, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "請選要下移的事項：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoveUpPanel
            // 
            this.MoveUpPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MoveUpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoveUpPanel.Controls.Add(this.MoveUpComboBox);
            this.MoveUpPanel.Controls.Add(this.MoveUpCancelButton);
            this.MoveUpPanel.Controls.Add(this.MoveUpOkButton);
            this.MoveUpPanel.Controls.Add(this.label8);
            this.MoveUpPanel.Location = new System.Drawing.Point(889, 466);
            this.MoveUpPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MoveUpPanel.Name = "MoveUpPanel";
            this.MoveUpPanel.Size = new System.Drawing.Size(310, 180);
            this.MoveUpPanel.TabIndex = 7;
            this.MoveUpPanel.Visible = false;
            // 
            // MoveUpComboBox
            // 
            this.MoveUpComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveUpComboBox.Location = new System.Drawing.Point(39, 72);
            this.MoveUpComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoveUpComboBox.Name = "MoveUpComboBox";
            this.MoveUpComboBox.Size = new System.Drawing.Size(220, 33);
            this.MoveUpComboBox.TabIndex = 4;
            // 
            // MoveUpCancelButton
            // 
            this.MoveUpCancelButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveUpCancelButton.Location = new System.Drawing.Point(160, 128);
            this.MoveUpCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.MoveUpCancelButton.Name = "MoveUpCancelButton";
            this.MoveUpCancelButton.Size = new System.Drawing.Size(100, 29);
            this.MoveUpCancelButton.TabIndex = 3;
            this.MoveUpCancelButton.Text = "取消";
            this.MoveUpCancelButton.UseVisualStyleBackColor = true;
            this.MoveUpCancelButton.Click += new System.EventHandler(this.MoveUpCancelButton_Click);
            // 
            // MoveUpOkButton
            // 
            this.MoveUpOkButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoveUpOkButton.Location = new System.Drawing.Point(39, 128);
            this.MoveUpOkButton.Margin = new System.Windows.Forms.Padding(4);
            this.MoveUpOkButton.Name = "MoveUpOkButton";
            this.MoveUpOkButton.Size = new System.Drawing.Size(100, 29);
            this.MoveUpOkButton.TabIndex = 2;
            this.MoveUpOkButton.Text = "確認";
            this.MoveUpOkButton.UseVisualStyleBackColor = true;
            this.MoveUpOkButton.Click += new System.EventHandler(this.MoveUpOkButton_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(20, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 39);
            this.label8.TabIndex = 0;
            this.label8.Text = "請選要上移的事項：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1264, 799);
            this.Controls.Add(this.MoveUpPanel);
            this.Controls.Add(this.MoveDownPanel);
            this.Controls.Add(this.Remove2Panel);
            this.Controls.Add(this.Remove1Panel);
            this.Controls.Add(this.NewItem2Panel);
            this.Controls.Add(this.NewItem1Panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.NewItem1Panel.ResumeLayout(false);
            this.NewItem1Panel.PerformLayout();
            this.NewItem2Panel.ResumeLayout(false);
            this.NewItem2Panel.PerformLayout();
            this.Remove1Panel.ResumeLayout(false);
            this.Remove2Panel.ResumeLayout(false);
            this.MoveDownPanel.ResumeLayout(false);
            this.MoveUpPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add1Button;
        private System.Windows.Forms.Button Remove1Button;
        private System.Windows.Forms.Button Remove2Button;
        private System.Windows.Forms.Button Add2Button;
        private System.Windows.Forms.Panel NewItem1Panel;
        private System.Windows.Forms.Button NewItemCancel1Button;
        private System.Windows.Forms.Button NewItemOk1Button;
        private System.Windows.Forms.TextBox NewItem1TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel NewItem2Panel;
        private System.Windows.Forms.Button NewItemCancel2Button;
        private System.Windows.Forms.Button NewItemOk2Button;
        private System.Windows.Forms.TextBox NewItem2TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel Remove1Panel;
        private System.Windows.Forms.Button RemoveCancel1Button;
        private System.Windows.Forms.Button RemoveOk1Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Remove1ComboBox;
        private System.Windows.Forms.Panel Remove2Panel;
        private System.Windows.Forms.ComboBox Remove2ComboBox;
        private System.Windows.Forms.Button RemoveCancel2Button;
        private System.Windows.Forms.Button RemoveOk2Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.Panel MoveDownPanel;
        private System.Windows.Forms.ComboBox MoveDownComboBox;
        private System.Windows.Forms.Button MoveDownCancelButton;
        private System.Windows.Forms.Button MoveDownOkButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel MoveUpPanel;
        private System.Windows.Forms.ComboBox MoveUpComboBox;
        private System.Windows.Forms.Button MoveUpCancelButton;
        private System.Windows.Forms.Button MoveUpOkButton;
        private System.Windows.Forms.Label label8;
    }
}

