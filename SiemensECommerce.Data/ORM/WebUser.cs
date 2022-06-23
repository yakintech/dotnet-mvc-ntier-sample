namespace SiemensECommerce.Data.ORM;

public class WebUser : BaseEntity
{
    public int Id { get; set; }
    public string Namwe { get; set; }
    public string SurName { get; set; }
    public string Email {  get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }

}

