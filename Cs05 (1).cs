// Chương trình C# để minh họa
// Khởi tạo một đối tượng
using System;

// Khai báo lớp
public class Dog {

	// Biến thể hiện
	String name;
	String breed;
	int age;
	String color;

	// Khai báo hàm tạo của lớp
	public Dog(String name, String breed,int age, String color)
	{
		this.name = name;
		this.breed = breed;
		this.age = age;
		this.color = color;
	}

	// Thuộc tính 1
	public String GetName()
	{
		return name;
	}

	// Thuộc tính 2
	public String GetBreed()
	{
		return breed;
	}

	// Thuộc tính 3
	public int GetAge()
	{
		return age;
	}

	// Thuộc tính 4
	public String GetColor()
	{
		return color;
	}

	// Cách 1
	public String ToString()
	{
		return ("Hi my name is " + this.GetName()
				+ ".\nMy breed, age and color are " + this.GetBreed()
				+ ", " + this.GetAge() + ", " + this.GetColor());
	}

// Phương thức chính
public static void Main(String[] args)
	{
		
		// Tạo đối tượng
		Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
		Console.WriteLine(tuffy.ToString());
	}
}
