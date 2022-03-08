using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
	public int weightToValue;
	public int weight;
	public int value;
	public int id;
	public bool inOrOut;
	public Item()
	{
		weightToValue = 0;
		weight = 0;
		value = 0;
		id = 0;
		inOrOut = false;
	}
	public Item(int w, int v, int i)
    {
		weightToValue = w / v;
		weight = w;
		value = v;
		id = i;
		inOrOut = false;
    } //tostring przeciążone

	public override string ToString()
	{
		string s = "";
		if (inOrOut) s = " is in the bag ";
		else s = "is not in the bag ";
		return "Item no " + id + s + "\n";
	}
}
