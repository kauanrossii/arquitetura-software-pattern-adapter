namespace AdapterPattern.Domain.Entities
{
	public class Person
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public int Age { get; set; }
		
		public Person(string name, string email, int age)
		{
			Name = name;
			Email = email;
			Age = age;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Email: {Email}, Age: {Age}";
		}
	}
}
