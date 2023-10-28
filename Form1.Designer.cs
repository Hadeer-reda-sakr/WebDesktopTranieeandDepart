namespace WebDesktopTranieeandDepart
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
			dataGridView1 = new DataGridView();
			textName = new TextBox();
			textaddress = new TextBox();
			btnAdd = new Button();
			combDeparts = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 201);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(687, 237);
			dataGridView1.TabIndex = 0;
			// 
			// textName
			// 
			textName.Location = new Point(516, 21);
			textName.Name = "textName";
			textName.Size = new Size(121, 23);
			textName.TabIndex = 1;
			textName.TextChanged += textBox1_TextChanged;
			// 
			// textaddress
			// 
			textaddress.Location = new Point(516, 59);
			textaddress.Name = "textaddress";
			textaddress.Size = new Size(121, 23);
			textaddress.TabIndex = 3;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(516, 155);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(100, 30);
			btnAdd.TabIndex = 4;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// combDeparts
			// 
			combDeparts.FormattingEnabled = true;
			combDeparts.Location = new Point(516, 108);
			combDeparts.Name = "combDeparts";
			combDeparts.Size = new Size(121, 23);
			combDeparts.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(431, 21);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 6;
			label1.Text = "Name";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(431, 62);
			label2.Name = "label2";
			label2.Size = new Size(49, 15);
			label2.TabIndex = 7;
			label2.Text = "Address";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(416, 116);
			label3.Name = "label3";
			label3.Size = new Size(75, 15);
			label3.TabIndex = 8;
			label3.Text = "Departments";
			// 
			// button2
			// 
			button2.Location = new Point(78, 84);
			button2.Name = "button2";
			button2.Size = new Size(100, 30);
			button2.TabIndex = 14;
			button2.Text = "showDepartment";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(710, 429);
			Controls.Add(button2);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(combDeparts);
			Controls.Add(btnAdd);
			Controls.Add(textaddress);
			Controls.Add(textName);
			Controls.Add(dataGridView1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private TextBox textName;
		private TextBox textaddress;
		private Button btnAdd;
		private ComboBox combDeparts;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button2;
	}
}