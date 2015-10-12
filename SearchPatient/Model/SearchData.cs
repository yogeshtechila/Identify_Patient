using System;
using Xamarin.Forms;

namespace SearchPatient
{
	public class SearchData
	{
		public SearchData(string Name, string Address, string contacts,string GetDriections)
		{
			this.name=Name;
			this.address = Address;
			this.contact = contacts;
			this.ButtonTitle = GetDriections;
		}
		public string name {get; set;}
		public string address {get; set;}
		public string contact{get; set;}
		public string ButtonTitle{ get; set;}
	}

}

//
//public President (string name, int position, string image)
//{
//	this.Name = name;
//	this.Position = position;
//	this.Image = image;
//}
//
//public string Name { private set; get; }
//
//public int Position { private set; get; }
//
//public string Image { private set; get; }
