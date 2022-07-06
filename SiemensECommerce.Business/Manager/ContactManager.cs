using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Manager
{
    public class ContactManager
    {
        public Contact GetContactByID(int id)
        {
            SiemensECommerceContext db=new SiemensECommerceContext();   
            Contact contact=db.Contacts.Where (q=>q.IsDeleted==false).FirstOrDefault(c=>c.Id==id);
            return contact;
        }

        public List<Contact> GetContact()
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var contacts = db.Contacts.Where(x => x.IsDeleted == false).ToList();
            return contacts;
        }
        public static void Send(Contact contact)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            contact.AddDate = DateTime.Now;
            contact.IsDeleted = false;

            db.Contacts.Add(contact);
            db.SaveChanges();
        }
    }
}
