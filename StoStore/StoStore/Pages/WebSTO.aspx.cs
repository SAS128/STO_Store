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
                int prodCount = FilterCategory().Count();
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


        public IEnumerable<Category> GetCategory()
        {
            return FilterCategory().
                OrderBy(g => g.CategoryId).
                Skip((CurrentPage - 1) * pageSize).
                Take(pageSize);
        }

        //метод фильтрации по каттегории
        private IEnumerable<Category> FilterCategory()
        {
            IEnumerable<Category> Category = repository.Category;
            string currentCategory = (string)RouteData.Values["Name"] ??
                Request.QueryString["Name"];
            return currentCategory == null ? Category :
                Category.Where(p => p.Name == currentCategory);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int selectedDetailsId;
                if (int.TryParse(Request.Form["add"], out selectedDetailsId))
                {
                    Category detailsGame = repository.Category.Where(g => g.CategoryId == selectedDetailsId).FirstOrDefault();
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