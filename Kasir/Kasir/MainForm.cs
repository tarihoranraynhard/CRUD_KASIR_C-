/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 25/04/2022
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kasir
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = kasir; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from tbl_barang";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"tbl_barang") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_barang";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void SearchBarang(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from tbl_barang where KodeBarang like '%" + tbSearch.Text +"%' or NamaBarang like '%" + tbSearch.Text +"%' ";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"tbl_barang") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_barang";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void ResetData(){
			tbKB.Text="";
			tbNB.Text="";
			tbHJ.Text="";
			tbHB.Text="";
			tbJB.Text="";
			tbSB.Text="";
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ReadData();
			ResetData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			if(tbKB.Text.Trim() == "" || tbNB.Text.Trim() == "" || tbHJ.Text.Trim() == "" || tbHB.Text.Trim() == "" || tbJB.Text.Trim() == "" || tbSB.Text.Trim() == ""){
				MessageBox.Show("Isi Setiap Kolom yang Tersedia Terlebih Dahulu");
			}
			else{			
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "INSERT INTO  tbl_barang VALUES ('"+tbKB.Text+"','"+tbNB.Text+"','"+tbHJ.Text+"','"+tbHB.Text+"','"+tbJB.Text+"','"+tbSB.Text+"')";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "tbl_barang")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_barang";
				}
				MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		}
		
		
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			if(tbKB.Text.Trim() == "" || tbNB.Text.Trim() == ""|| tbHJ.Text.Trim() == ""|| tbHB.Text.Trim() == ""|| tbJB.Text.Trim() == ""|| tbSB.Text.Trim() == ""){
				MessageBox.Show("Isi Setiap Kolom yang Tersedia Terlebih Dahulu");
			}
			else{
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "UPDATE tbl_barang SET KodeBarang='"+tbKB.Text+"',NamaBarang='"+tbNB.Text+"',HargaJual='"+tbHJ.Text+"',HargaBeli='"+tbHB.Text+"',JumlahBarang='"+tbJB.Text+"',SatuanBarang='"+tbSB.Text+"' WHERE KodeBarang ='"+tbKB.Text+"'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "tbl_barang")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_barang";
				}
				MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		}
		
		
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Yakin ingin menghapus "+tbKB.Text+ "?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "DELETE FROM tbl_barang WHERE KodeBarang='"+tbKB.Text+"'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "tbl_barang")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_barang";
				}
				MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
			}
		}
		
		
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
			DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
			tbKB.Text = row.Cells["KodeBarang"].Value.ToString();
			tbNB.Text = row.Cells["NamaBarang"].Value.ToString();
			tbHJ.Text = row.Cells["HargaJual"].Value.ToString();
			tbHB.Text = row.Cells["HargaBeli"].Value.ToString();
			tbJB.Text = row.Cells["JumlahBarang"].Value.ToString();
			tbSB.Text = row.Cells["SatuanBarang"].Value.ToString();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		void TbSearchTextChanged(object sender, EventArgs e)
		{
			SearchBarang();
		}
	}
}
