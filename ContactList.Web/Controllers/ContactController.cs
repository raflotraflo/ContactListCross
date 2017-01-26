using ContactList.Web.Database.Entities;
using ContactList.Web.Database.Repositories;
using ContactList.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactList.Web.Controllers
{
    public class ContactController : ApiController
    {
        IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        // GET: api/Contact
        public HttpResponseMessage Get()
        {
            var response = new ContactsResponse();

            try
            {
                response.Contacts = _contactRepository.GetAll();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }

           return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
        }

        public HttpResponseMessage Post(ContactEntity contact)
        {
            var response = new BaseResponse();

            try
            {
                _contactRepository.Add(contact);
                _contactRepository.Save();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }

            return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
        }

        public HttpResponseMessage Delete(int id)
        {
            var response = new BaseResponse();

            try
            {
                _contactRepository.Delete(id);
                _contactRepository.Save();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }

            return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
        }

    }
}
