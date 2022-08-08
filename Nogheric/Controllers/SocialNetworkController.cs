using Nogheric.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web;
using System.IO;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;

namespace Nogheric.Controllers
{
    
    public class SocialNetworkController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetSocial()
        {
            SocialNetWork socialNetWork = new SocialNetWork();
            try
            {
                socialNetWork.FaceBook = "www.facebook.com/nogheric";
                socialNetWork.Twitter = "www.twitter.com/nogheric";
                socialNetWork.YouTube = "";
                socialNetWork.Linkedin = "";
                socialNetWork.TikTok = "www.tiktok.com/@nogheric";
                socialNetWork.Instagram = "www.instagram.com/nogheric";
                socialNetWork.WebPage = "";
                socialNetWork.Other = "";

                return Ok(new { status = 200, message = "Exitoso.", response = socialNetWork });
            }
            catch (Exception e)
            {
                return Ok(new { status = 400, message = "Error de respuesta." });
            }

        }


    }
}
