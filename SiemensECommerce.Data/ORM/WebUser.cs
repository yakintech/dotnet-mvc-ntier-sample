using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Data.ORM;

public class WebUser : BaseEntity
{
    public string Namwe { get; set; }
    public string SurName { get; set; }
    public string Email {  get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }

}

