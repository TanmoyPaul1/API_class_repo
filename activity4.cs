// create a console app with a class that has an interface and push it to a git repo! Send me the link to the repository when done. 
// your class should have at least one interface and three different types of properties.
// the interface (and therefore, your class) should have at least three out of these four things:
// instance methods, properties, events, indexers.
// Make sure you have an instance of this class in main!

// Tanmoy Paul
// CSCI 39537
// 02/10/2023

using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Collections;

interface IConsole 
{
	string storeName { get; set; }
	float returnPrice(); 
	int availableStock(); 
	void availableColors(); 
}

class Switch : IConsole 
{
	public string storeName 
	{ 
		get { return _storeName; }; 
		set { _storeName = value; }; 
	}
	private string _storeName;

	public readonly int stock = 2500;
	public readonly float price = 349.99;
	public string[] colors = {"red", "blue", "white"};

	public string this[string color]
	{
		get { return colors.Find(color); }
	}

	public float returnPrice() 
	{
		return price;
	}

	public int availableStock()
	{
		return stock;
	}

	public void availableColors()
	{
		Console.WriteLine("The color options  are ");
		for (int i = 0; i < colors.Length; i++)
		{
			Console.WriteLine(colors[i]);
		}
	}
}

class Program 
{
	static void Main(string[] args) 
	{
		Switch mySwitch = new Switch(); 
		Switch.storeName = "Best Buy";
		Switch.WriteLine($"The price is {mySwitch.returnPrice()}");
		Switch.WriteLine($"The amount of Switch Switchs left is  + {mySwitch.availableStock()}");
		mySwitch.availableColors();
	}
}