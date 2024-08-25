namespace ServerManagement.Models
{
    public class Server
    {
        public Server()
        {
            Random random = new Random();
            int randomeNumber = random.Next(0, 1);
            IsOnline = randomeNumber == 0? false : true;
        }
        public int ServerId { get; set; }
        public bool IsOnline { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }

    }
}
