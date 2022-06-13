namespace SOLIDKavramı.Data
{
    public class Data
    {
        public static List<Movie> MovieList = new List<Movie>()
        {
             new Movie() {
                Id=1,
                Name="Inception",
                CategoryId=1, //Science-Fiction
                Year=new DateTime(2010)
                },
              new Movie() {
                Id=2,
                Name="The Shawshank Redemption",
                CategoryId=2, //Dram
                Year=new DateTime(1994)
                },
            new Movie() {
                Id=3,
                Name="The Prestige",
                CategoryId=1, //Science-Fiction
                Year=new DateTime(2006)
                },
              new Movie() {
                Id=4,
                Name="Forrest Gump",
                CategoryId=3, //Comedy
                Year=new DateTime(1994)
                },
               new Movie() {
                Id=5,
                Name="Ice Age",
                CategoryId=4, //Animation
                Year=new DateTime(2016)
                },
                  new Movie() {
                Id=6,
                Name="Soul",
                CategoryId=4, //Animation
                Year=new DateTime(2020)
                  }
        };
    }
}
