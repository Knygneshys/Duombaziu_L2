namespace Trikotazo_Parduotuve.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public override string? ToString()
        {
            return $"{Id} {Name} {Contact} {Phone} {Email} {Address}";
        }
    }
}
