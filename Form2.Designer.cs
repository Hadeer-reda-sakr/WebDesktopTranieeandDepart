namespace WebDesktopTranieeandDepart
{
	partial class Form2
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
			label2 = new Label();
			label1 = new Label();
			btnAdd = new Button();
			textName = new TextBox();
			dataGridView1 = new DataGridView();
			combtraniee = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(476, 66);
			label2.Name = "label2";
			label2.Size = new Size(44, 15);
			label2.TabIndex = 15;
			label2.Text = "Traniee";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(476, 17);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 14;
			label1.Text = "Name";
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(561, 138);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(100, 30);
			btnAdd.TabIndex = 12;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// textName
			// 
			textName.Location = new Point(561, 17);
			textName.Name = "textName";
			textName.Size = new Size(121, 23);
			textName.TabIndex = 10;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(57, 197);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(687, 237);
			dataGridView1.TabIndex = 9;
			// 
			// combtraniee
			// 
			combtraniee.FormattingEnabled = true;
			combtraniee.Location = new Point(561, 58);
			combtraniee.Name = "combtraniee";
			combtraniee.Size = new Size(121, 23);
			combtraniee.TabIndex = 18;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(combtraniee);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnAdd);
			Controls.Add(textName);
			Controls.Add(dataGridView1);
			Name = "Form2";
			Text = "Form2";
			Load += Form2_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
		private Label label2;
		private Label label1;
		private ComboBox combDeparts;
		private Button btnAdd;
		private TextBox textName;
		private DataGridView dataGridView1;
		private ComboBox comboBox1;
		private ComboBox combtraniee;
		private Label label4;
	}
}