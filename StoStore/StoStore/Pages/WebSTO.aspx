<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebSTO.aspx.cs"  Inherits="StoStore.Pages.WebSTO" MasterPageFile="~/Pages/Store.Master" %>
<%@ Import Namespace="System.Web.Routing" %>
<asp:Content ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">
      <asp:Repeater ItemType="StoStore.Models.CLIENT" SelectMethod="GetCLIENT" runat="server">
          <ItemTemplate>
              <div class="item">
                  <h3><%# Item.STATUS %></h3>
                 
                  <button name="add" type="submit" value="<%# Item.CLIENT_ID %>">
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
                string selectedCategory = (string)Page.RouteData.Values["STATUS"] ?? Request.QueryString["STATUS"];
                string path = RouteTable.Routes.GetVirtualPath(null, null, new RouteValueDictionary() { { "STATUS", selectedCategory}, { "page", i} }).VirtualPath;
                Response.Write(String.Format("<a href='{0}' {1}>{2}</a>", path, i == CurrentPage ? "class='selected'" : "", i));
            }
        %>
    </div>
</asp:Content>