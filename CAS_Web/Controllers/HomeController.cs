using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAS_Web.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }

        public ActionResult Delete()
        {
            ViewBag.Title = "Delete Product";

            return View();
        }

        [HttpPost]
        public ActionResult Delete(int productId)
        {
            try
            {
                // Retrieve storage account from connection string.
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                    System.Configuration.ConfigurationManager.
        ConnectionStrings["StorageConnectionString"].ConnectionString);


                // Create the queue client.
                CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

                // Retrieve a reference to a container.
                CloudQueue queue = queueClient.GetQueueReference("tobedeletedproduct");

                // Create the queue if it doesn't already exist
                queue.CreateIfNotExists();


                CloudQueueMessage message = new CloudQueueMessage(productId.ToString());
                queue.AddMessage(message);


                ViewBag.Title = "Delete Product";
            }
            catch (Exception ex)
            {
                string exxx = ex.InnerException.ToString();

            }


            return Json(new {result="OK" });
        }
    }
}