<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EditAnswer</title>
</head>
<body>
    <%MvcForum.Answer answer = ( MvcForum.Answer ) ViewData["answer"]; %>
    <div>
        <form method='post' action='/questions/editanswer'>
        <input type='hidden' name='id' value='<%=answer.Id %>' />
        <textarea name='body'><%=answer.Body %></textarea><br />
        <input type='submit' value='Update Answer' />
        </form>
    </div>
</body>
</html>
