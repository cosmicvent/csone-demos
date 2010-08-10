<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <%=TempData["error"] %>
    <div>
        <form method='post' action='/sessions/create'>
        User Name:
        <input type='text' name='username' /><br />
        Password:
        <input type='password' name='password' /><br />
        <input type='submit' value='Login' />
        </form>
    </div>
</body>
</html>
