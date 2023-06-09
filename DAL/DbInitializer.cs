using Entities;

namespace DAL
{
    public static class DbInitializer
    {
        public static void Initialize(SithecDataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any human.
            if (context.Human.Any())
            {
                return;   // DB has been seeded
            }

            var humans = GetHumanListMock();

            foreach (Human s in humans)
            {
                context.Human.Add(s);
            }

            context.SaveChanges();
        }

        public static IEnumerable<Human> GetHumanListMock()
        {
            return new Human[]
           {
                new Human { Age = 23, Height = 2.2, Gender = Gender.Male, Name = "John Doe", Weight = 50.5 },
                new Human { Age = 29, Height = 1.4, Gender = Gender.Female, Name = "Joana d'arc", Weight = 57.3 },
                new Human { Age = 70, Height = 1.6, Gender = Gender.Male, Name = "J. Biden", Weight = 77.5 },
           };
        }
    }
}