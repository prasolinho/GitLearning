public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public DateTime EntryDate { get; set; }

    public string AddressStreet { get; set; }
    public string AddressHouseNumber { get; set; }
    public string AddressApartmentNumber { get; set; }
    public string AddressZipCode { get; set; }
    public string AddressCity { get; set; }
}
