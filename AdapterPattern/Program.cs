using AdapterPattern.Infrastructure.Persistence;

IPeopleRepository peopleRepository = new PeopleCsvAdapter("./people-information.csv");
var people = peopleRepository.ListPeople();

foreach (var person in people)
{
	Console.WriteLine(person);
}
