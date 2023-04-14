




using IteratorDp;

PersonAggregate aggregate = new PersonAggregate();


aggregate.Add(new Person() { ID = 1, Name = "Huseyn", Surname = "Mammadov" });
aggregate.Add(new Person() { ID = 2, Name = "Rustam", Surname = "Mammadov" });
aggregate.Add(new Person() { ID = 3, Name = "Sarxan", Surname = "Tanri" });
aggregate.Add(new Person() { ID = 4, Name = "Islam", Surname = "Salam" });



IIterator iterator = aggregate.CreateIterator();


while (iterator.HasItem())
{
    Console.WriteLine($"Id : {iterator.Current().ID}  Name : {iterator.Current().Name}    Surname : {iterator.Current().Surname}");
    iterator.Next();
}

