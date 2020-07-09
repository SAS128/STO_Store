using StoStore.Models;
using StoStore.Models.Repository;
using StoStore.Pages.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoStore.Pages
{
    public partial class WebSTO : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        private int pageSize = 4;

        protected int MaxPage
        {
            get
            {
                int prodCount = FilterCLIENT().Count();
                return (int)Math.Ceiling((decimal)prodCount / pageSize);
            }
        }

        private int GetPageFromRequest()
        {
            int page;
            string reqValue = (string)RouteData.Values["page"] ?? Request.QueryString["page"];
            return reqValue != null && int.TryParse(reqValue, out page) ? page : 1;
        }
    
        protected int CurrentPage
        {
            get
            {
                int page;
                page = GetPageFromRequest();
                return page > MaxPage ? MaxPage : page;
            }
        }


        public IEnumerable<CLIENT> GetCLIENT()
        {
            return FilterCLIENT().
                OrderBy(g => g.CLIENT_ID).
                Skip((CurrentPage - 1) * pageSize).
                Take(pageSize);
        }

        //метод фильтрации по каттегории
        private IEnumerable<CLIENT> FilterCLIENT()
        {
            IEnumerable<CLIENT> CLIENT = repository.CLIENT;
            string currentCategory = (string)RouteData.Values["STATUS"] ??
                Request.QueryString["STATUS"];
            return currentCategory == null ? CLIENT :
                CLIENT.Where(p => p.STATUS == currentCategory);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int selectedDetailsId;
                if (int.TryParse(Request.Form["add"], out selectedDetailsId))
                {
                    CLIENT detailsGame = repository.CLIENT.Where(g => g.CLIENT_ID == selectedDetailsId).FirstOrDefault();
                    if (detailsGame != null)
                    {
                       
                        SessionHelper.Set(Session, SessionKey.RETURN_URL, Request.RawUrl);

                        Response.Redirect(RouteTable.Routes.GetVirtualPath(null, "cart", null).VirtualPath);
                    }
                }
            }

        }
    }
}