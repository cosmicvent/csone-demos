<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show</title>
</head>
<body>
    <%MvcForum.Question q = ( MvcForum.Question ) ViewData["question"]; %>
    <%if ( q == null ) { %>
    <h2>
        Question not found</h2>
    <%}
      else { %>
    <div>
        <h2>
            <%=q.Title%>
        </h2>
        <p>
            <%=q.Body%>
        </p>
        <p>
            <%=q.CreatedOn%>
        </p>
    </div>
    <a href='/questions/show/<%=q.Id -1 %>'>&lt;Prev</a> <a href='/questions/show/<%=q.Id +1 %>'>
        Next&gt;</a>
    <%} %>
</body>
</html>
