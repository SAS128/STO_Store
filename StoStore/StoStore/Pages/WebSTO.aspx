<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebSTO.aspx.cs"  Inherits="StoStore.Pages.WebSTO" MasterPageFile="~/Pages/Store.Master" %>
<%@ Import Namespace="System.Web.Routing" %>
<asp:Content ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">
      <asp:Repeater ItemType="StoStore.Models.Category" SelectMethod="GetCategory" runat="server">
          <ItemTemplate>
              <div class="item">
                  <h3><%# Item.Name %></h3>
                 
                  <button name="add" type="submit" value="<%# Item.CategoryId %>">
                      В корзину
                  </button>
              </div>
          </ItemTemplate>
      </asp:Repeater>
    </div>
    <div class="pager">
        <%
             for (int i = 1; i <= MaxPage; i++)
            {
                string selectedCategory = (string)Page.RouteData.Values["Name"] ?? Request.QueryString["Name"];
                string path = RouteTable.Routes.GetVirtualPath(null, null, new RouteValueDictionary() { { "Name", selectedCategory}, { "page", i} }).VirtualPath;
                Response.Write(String.Format("<a href='{0}' {1}>{2}</a>", path, i == CurrentPage ? "class='selected'" : "", i));
            }
        %>
    </div>
</asp:Content>