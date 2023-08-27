using Model;

namespace EFCoreDemo
{
    public class Queries
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public void AddNewTour()
        {
            var newTour = new Tour() 
            { 
                Title = "NYALIBEACH", 
                Description = "kENYATTA BEACH", 
                Duration = "1 days", 
                Price = 40 
            };

            // Adding to the tables
            context.Tours.Add(newTour);

            context.SaveChanges();
        }
        public void fetchAll()
        {
            var tours = context.Tours.ToList();
            foreach (var tour in tours)
            {
                Console.WriteLine($"{tour.Id}- {tour.Title} - {tour.Description} - {tour.Duration}");
            }
        }
    }
}
