using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// PreventLink1 的摘要说明
    /// </summary>
    public class PreventLink1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            Uri lastUrl = context.Request.UrlReferrer;
            Uri currentUrl = context.Request.Url;
            if (lastUrl.Host != currentUrl.Host || lastUrl.Port != currentUrl.Port)
            {
                string errorImagePath = context.Request.PhysicalApplicationPath + "error.png";
                context.Response.WriteFile(errorImagePath);
            }
            else
            {
                context.Response.WriteFile(context.Request.PhysicalPath);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}