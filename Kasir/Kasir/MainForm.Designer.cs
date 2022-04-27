/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 25/04/2022
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kasir
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbKB = new System.Windows.Forms.TextBox();
			this.tbNB = new System.Windows.Forms.TextBox();
			this.tbHJ = new System.Windows.Forms.TextBox();
			this.tbHB = new System.Windows.Forms.TextBox();
			this.tbJB = new System.Windows.Forms.TextBox();
			this.tbSB = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(277, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "PT. SERBA-SERBI";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kode Barang";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Satuan Barang";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Jumlah Barang";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Harga Beli";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(24, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(121, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Harga Jual";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(24, 93);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Nama Barang";
			// 
			// tbKB
			// 
			this.tbKB.Location = new System.Drawing.Point(246, 61);
			this.tbKB.Name = "tbKB";
			this.tbKB.Size = new System.Drawing.Size(346, 22);
			this.tbKB.TabIndex = 7;
			// 
			// tbNB
			// 
			this.tbNB.Location = new System.Drawing.Point(246, 93);
			this.tbNB.Name = "tbNB";
			this.tbNB.Size = new System.Drawing.Size(346, 22);
			this.tbNB.TabIndex = 8;
			// 
			// tbHJ
			// 
			this.tbHJ.Location = new System.Drawing.Point(246, 125);
			this.tbHJ.Name = "tbHJ";
			this.tbHJ.Size = new System.Drawing.Size(346, 22);
			this.tbHJ.TabIndex = 9;
			// 
			// tbHB
			// 
			this.tbHB.Location = new System.Drawing.Point(246, 158);
			this.tbHB.Name = "tbHB";
			this.tbHB.Size = new System.Drawing.Size(346, 22);
			this.tbHB.TabIndex = 10;
			// 
			// tbJB
			// 
			this.tbJB.Location = new System.Drawing.Point(246, 192);
			this.tbJB.Name = "tbJB";
			this.tbJB.Size = new System.Drawing.Size(346, 22);
			this.tbJB.TabIndex = 11;
			// 
			// tbSB
			// 
			this.tbSB.Location = new System.Drawing.Point(246, 224);
			this.tbSB.Name = "tbSB";
			this.tbSB.Size = new System.Drawing.Size(346, 22);
			this.tbSB.TabIndex = 12;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(246, 335);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(92, 33);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(370, 335);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(92, 33);
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(498, 335);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(94, 33);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 385);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(878, 178);
			this.dataGridView1.TabIndex = 16;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(635, 290);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(255, 22);
			this.tbSearch.TabIndex = 17;
			this.tbSearch.TextChanged += new System.EventHandler(this.TbSearchTextChanged);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(635, 264);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(242, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Pencarian Kode/Nama Barang";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(902, 575);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.tbSB);
			this.Controls.Add(this.tbJB);
			this.Controls.Add(this.tbHB);
			this.Controls.Add(this.tbHJ);
			this.Controls.Add(this.tbNB);
			this.Controls.Add(this.tbKB);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Kasir";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox tbSB;
		private System.Windows.Forms.TextBox tbJB;
		private System.Windows.Forms.TextBox tbHB;
		private System.Windows.Forms.TextBox tbHJ;
		private System.Windows.Forms.TextBox tbNB;
		private System.Windows.Forms.TextBox tbKB;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
