<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SignUp</title>
</head>
<body>
    <div>
        <form method='post'>
        User Name<input type='text' name='username' /><br />
        Password
        <input type='password' name='password' /><br />
        Confirm Password
        <input type='password' name='confirmation' /><br />
        <input type='submit' value='Sign Up' />
        </form>
    </div>
</body>
</html>
