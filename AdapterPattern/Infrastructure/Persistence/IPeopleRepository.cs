using AdapterPattern.Domain.Entities;

namespace AdapterPattern.Infrastructure.Persistence
{
	public interface IPeopleRepository
	{
		List<Person> ListPeople();
	}
}
