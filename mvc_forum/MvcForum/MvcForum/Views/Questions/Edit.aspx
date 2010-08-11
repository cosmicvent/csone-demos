<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit</title>
</head>
<body>
    <div>
        <%MvcForum.Question q = ( MvcForum.Question ) ViewData["question"]; %>
        <form method='post'>
        <input type='hidden' name='id' value='<%=q.Id %>' /><br />
        <input type='text' name='title' value='<%=q.Title %>' /><br />
        <textarea name='body'><%=q.Body %></textarea><br />
        <input type='submit' value='Update Question' />
        </form>
    </div>
</body>
</html>
