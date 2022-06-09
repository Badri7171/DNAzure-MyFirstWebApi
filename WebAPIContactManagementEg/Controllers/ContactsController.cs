using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIContactManagementEg.Models;

namespace WebAPIContactMangement.Controllers
{
    public class ContactsController : ApiController
    {
        Model1 model1 = new Model1();

        // GET: api/Contacts
        public IEnumerable<Contact> Get()
        {
            return model1.Contacts;
        }

        // GET: api/Contacts/5
        public Contact Get(int id)
        {
            var contact = model1.Contacts.Find(id);

            return contact;
        }

        // POST: api/Contacts
        public void Post([FromBody] Contact contact)
        {
            model1.Contacts.Add(contact);
            model1.SaveChanges();
        }


        // PUT: api/Contacts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Contacts/5
        public void Delete(int id)
        {
        }
    }
}
