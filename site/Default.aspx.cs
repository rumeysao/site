using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace site
{
	public partial class Default1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void bekle_Click(object sender, EventArgs e)
        {
            bosalt();
        }
        void bosalt()
        {
            GridView1.SelectedIndex = -1;//seçimi iptal etti
            hdfBirimId.Value = "";
            hdfMalzemeId.Value = "";
            txtdt.Text = "";
            txtkdv.Text = "";
            txtot.Text = "";
           
            cbaktif.Checked = false;
            ddlad.Focus();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex > -1)
            doldur();
        }
        void doldur()
        {
            hdfBirimId.Value = GridView1.SelectedRow.Cells[7].Text;
            hdfMalzemeId.Value = GridView1.SelectedRow.Cells[1].Text;
            txtdt.Text = GridView1.SelectedRow.Cells[9].Text;
            txtkdv.Text = GridView1.SelectedRow.Cells[6].Text;
            txtot.Text = GridView1.SelectedRow.Cells[8].Text;
            ddlad.DataBind();
            ddlad.SelectedValue = GridView1.SelectedRow.Cells[4].Text;
            ddlkod.DataBind();
            ddlkod.SelectedValue = GridView1.SelectedRow.Cells[3].Text;
            ddlozelkod.DataBind();
            ddlozelkod.SelectedValue = GridView1.SelectedRow.Cells[5].Text;
            cbaktif.Checked = (GridView1.SelectedRow.Cells[2].Controls[0] as CheckBox).Checked;
        }

        protected void bsil_Click(object sender, EventArgs e)
        {

            if (MalzemeDB.Delete() > 0)
            {
                lblmesaj.Text = "Malzeme başarıyla silinfi";
                bosalt();
            }
        }

        protected void bguncelle_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex > -1)//seçili kayıt var,güncelleme yap
            {
                if (MalzemeDB.Update() > 0)
                {
                    lblmesaj.Text = "Malzeme başarıyla güncellendi";
                    bosalt();
                }
            }
            else
            {
                if (MalzemeDB.Insert() > 0)
                {
                    lblmesaj.Text = "Malzeme başarıyla eklendi";
                    bosalt();
                }
            }
        }
    }
}