using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		//List<string> selectedValues = CheckBoxList1.Items
		//	.OfType<ListItem>()
		//	.Where(item => item.Selected)
		//	.Select(item => item.Value)
		//	.ToList();

		var selectedValues = CheckBoxList1.SelectedValues();

		// 顯示結果
		foreach (var value in selectedValues)
		{
			Response.Write(value + "<br />");
		}
	}
}