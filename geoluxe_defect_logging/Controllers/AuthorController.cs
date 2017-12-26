using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using geoluxe_defect_logging.Models;

namespace geoluxe_defect_logging.Controllers
{
    public class AuthorController : Controller
    {
        //
        // GET: /Author/

        public ActionResult Index()
        {
            var model = new Author();
            return View(model);
        }

        [HttpPost]
        public string Index(Author author)
        {
            var sb = new StringBuilder();
            try
            {
                sb.AppendFormat("Author : {0}", author.Name);
                sb.AppendLine("<br />");
                sb.AppendLine("--------------------------------");
                sb.AppendLine("<br />");
                foreach (var book in author.Books)
                {
                    sb.AppendFormat("Title : {0} | Published Date : {1}", book.Title, book.PublishedDate);
                    sb.AppendLine("<br />");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return sb.ToString();
        }
    }
}