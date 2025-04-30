using AdapterPattern.Domain.Entities;

namespace AdapterPattern.Infrastructure.Persistence
{
	public class PeopleCsvAdapter : IPeopleRepository
	{
		private readonly string _csvFilePath;

		public PeopleCsvAdapter(string csvFilePath)
		{
			_csvFilePath = csvFilePath;
		}

		public List<Person> ListPeople()
		{
			using var streamReader = new StreamReader(_csvFilePath);
			streamReader.ReadLine();

			var people = new List<Person>();

			while (!streamReader.EndOfStream)
			{
				var fileLine = streamReader.ReadLine();
				
				if (fileLine is not null)
				{
					var columnValues = fileLine.Split(",");
					var person = new Person(
						columnValues[0],
						columnValues[2],
						int.Parse(columnValues[1])
					);

					people.Add(person);
				}
			}

			return people;
		}
	}
}
