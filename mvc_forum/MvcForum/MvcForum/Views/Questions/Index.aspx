<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%IList<MvcForum.Question> questions = ( IList<MvcForum.Question> ) ViewData["questions"]; %>
    <%foreach ( var question in questions ) {%>
    <a href='/questions/show/<%=question.Id %>'>
        <%=question.Title %>
    </a>
    <br />
    <%} %>
</asp:Content>
