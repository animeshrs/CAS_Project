﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DbAccess;

namespace CAS_Project.Controllers
{
    public class ItemsController : ApiController
    {
        public HttpResponseMessage Get()
        {
            try
            {
                using (ItemEntities entities = new ItemEntities())
                {
                    var entityList = entities.AldiStores.ToList();

                    return Request.CreateResponse(HttpStatusCode.OK, entityList);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Get(int id)
        {
            try
            {
                using (ItemEntities entities = new ItemEntities())
                {
                    var entity = entities.AldiStores.FirstOrDefault(x => x.AldiID == id);

                    if (entity != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item with id = " + id + " is not found");
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Post(AldiStore aldistore)
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
    }
}
