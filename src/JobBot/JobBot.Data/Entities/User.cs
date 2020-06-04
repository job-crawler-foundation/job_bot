namespace JobBot.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        public long ChatId { get; set; }

        public bool SearchEnabled { get; set; }

        public string Preferences { get; set; }
    }
}
