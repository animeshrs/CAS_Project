using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DbAccess;
using System.Web.Http.Cors;

namespace CAS_Project.Controllers
{
    [AllowAnonymous]
    public class ItemsController : ApiController
    {
        //public HttpResponseMessage Get()
        //{
        //    try
        //    {
        //        using (ItemEntities entities = new ItemEntities())
        //        {
        //            var entityList = entities.AldiStores.ToList();

        //            return Request.CreateResponse(HttpStatusCode.OK, entityList);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        //added comment for getting item by id
        public HttpResponseMessage Get(string name)
        {
            try
            {
                using (ItemEntities entities = new ItemEntities())
                {
                    var entity = entities.getComparison().Where(x => x.Product_Name.ToLower().Contains(name.ToLower())).ToList();                   

                    if (entity != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item with name = " + name + " is not found");
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        //creating post method
        public HttpResponseMessage Post([FromBody]AldiStore aldistore)
        {
            try
            {
                using (ItemEntities entities = new ItemEntities())
                {
                    entities.AldiStores.Add(aldistore);
                    entities.SaveChanges();

                    return Request.CreateResponse(HttpStatusCode.Created, aldistore);
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Put(int id, [FromBody]AldiStore aldistore)
        {
            try
            {
                using (ItemEntities entities = new ItemEntities())
                {
                    var entity = entities.AldiStores.FirstOrDefault(ent => ent.AldiID == id);

                    if (entity != null)
                    {
                        entity.ProductID = aldistore.ProductID;
                        entity.ProductPrice = aldistore.ProductPrice;

                        entities.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item with id = " + id + "not found to update");
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (ItemEntities entities = new ItemEntities())
                {
                    var entity = entities.AldiStores.FirstOrDefault(ent => ent.AldiID == id);

                    if (entity != null)
                    {
                        entities.AldiStores.Remove(entity);

                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item with id = " + id + " not found to delete");
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // GET api/Items/GetComparisonList

        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                using (ItemEntities entities = new ItemEntities())
                {
                    var entity = entities.getComparison().ToList();

                    if (entity != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                        //return entity;
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found to update");
                        //return null;
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
