namespace SiemensECommerce.Data.ORM;

public class WebUser : BaseEntity
{
    public string Name { get; set; }

    public string SurName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }

}

