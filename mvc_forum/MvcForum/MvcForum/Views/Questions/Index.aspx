<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mvc Forum</title>
</head>
<body>
    <div>
        Error:<%=TempData["error"] %></div>
    <div>
        Success:<%=TempData["success"] %></div>
    <div>
        Welcome
        <%=User.Identity.Name %>!</div>
    <div>
        <%IList<MvcForum.Question> questions = ( IList<MvcForum.Question> ) ViewData["questions"]; %>
        <%foreach ( var question in questions ) {%>
        <a href='/questions/show/<%=question.Id %>'>
            <%=question.Title %>
        </a>
        <br />
        <%} %>
    </div>
</body>
</html>
