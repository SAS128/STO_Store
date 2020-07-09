<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CategoryList.ascx.cs" Inherits="StoStore.Controls.CategoryList" %>

<%= CreateHomeLinkHtml() %>

<% 
    foreach (string item in GetCategories())
    {
        Response.Write(CreateLinkHtml(item));
    }
%>