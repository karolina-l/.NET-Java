using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
	public int weight;
	public int value;
	public int id;
	//stosunek wv
	public Item()
	{
		weight = 0;
		value = 0;
		id = 0;
	}
	public Item(int w, int v, int i)
    {
		weight = w;
		value = v;
		id = i;
    } //tostring przeciążone
}
