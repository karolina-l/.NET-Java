using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
	public float valueToWeight;
	public int weight;
	public int value;
	public int id;
	public bool inOrOut;
	public Item()
	{
		valueToWeight = 0;
		weight = 0;
		value = 0;
		id = 0;
		inOrOut = false;
	}
	public Item(int w, int v, int i)
    {
		valueToWeight = (float)v / (float)w;
		weight = w;
		value = v;
		id = i;
		inOrOut = false;
    }

	public override string ToString()
	{
		string s = "";
		if (inOrOut) s = "is in the bag ";
		else s = "is not in the bag ";
		return "Item no " + id + ", weight: " + weight+ ", value: " + value + " "+ s + "\n";
	}
}
