using DbAccess;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CAS_Project.Controllers
{
    public class AdminController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                // Retrieve storage account from connection string.
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                    ConfigurationManager.ConnectionStrings["StorageConnectionString"].ConnectionString);
                // Create the queue client.
                CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

                // Retrieve a reference to a queue.
                CloudQueue queue = queueClient.GetQueueReference("producttobedeleted");

                // Create the queue if it doesn't already exist.
                queue.CreateIfNotExists();

                CloudQueueMessage retrievedMessage = queue.GetMessage();
                var productId = Convert.ToInt32(retrievedMessage.AsString);

                using (ItemEntities entities = new ItemEntities())
                {
                    Product prodobj = entities.Products.FirstOrDefault(x => x.ProductID == productId);
                    
                    //prodobj.ProductID = productId;

                    AldiStore aldiobj = entities.AldiStores.FirstOrDefault(x => x.ProductID == productId);
                    //aldiobj.ProductID = productId;

                    TescoStore tescoobj = entities.TescoStores.FirstOrDefault(x => x.ProductID == productId);
                    //tescoobj.ProductID = productId;

                    CostCutterStore ccobj = entities.CostCutterStores.FirstOrDefault(x => x.ProductID == productId);
                    //ccobj.ProductID = productId;

                    LidlStore lidlobj = entities.LidlStores.FirstOrDefault(x => x.ProductID == productId);
                    //lidlobj.ProductID = productId;
                    entities.Entry(prodobj).State = System.Data.Entity.EntityState.Deleted;
                    entities.Entry(aldiobj).State = System.Data.Entity.EntityState.Deleted;
                    entities.Entry(tescoobj).State = System.Data.Entity.EntityState.Deleted;
                    entities.Entry(ccobj).State = System.Data.Entity.EntityState.Deleted;
                    entities.Entry(lidlobj).State = System.Data.Entity.EntityState.Deleted;

                    //entities.Products.Remove(prodobj);
                    //entities.AldiStores.Remove(aldiobj);
                    //entities.TescoStores.Remove(tescoobj);
                    //entities.CostCutterStores.Remove(ccobj);
                    //entities.LidlStores.Remove(lidlobj);
                    entities.SaveChanges();

                    queue.DeleteMessage(retrievedMessage);


                    //if (entity != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK);
                        //return entity;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
