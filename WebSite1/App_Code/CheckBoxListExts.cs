using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

public static class CheckBoxListExts
{
	public static List<string> SelectedValues(this CheckBoxList source)
	{
		return source.Items
			.OfType<ListItem>()
			.Where(item => item.Selected)
			.Select(item => item.Value)
			.ToList();
	}
}