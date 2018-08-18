public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public DateTime EntryDate { get; set; }

    public string AddressStreet { get; set; }
    public string AddressHouseNumber { get; set; }
    public string AddressApartmentNumber { get; set; }
    public string AddressZipCode { get; set; }
    public string AddressCity { get; set; }
    public DateTime LastLoginDate { get; set; }
}