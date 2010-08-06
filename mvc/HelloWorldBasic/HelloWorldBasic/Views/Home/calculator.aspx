<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>calculator</title>
</head>
<body>
    <div>
        <h1>
            Welcome to the most advanced calculator in the world!</h1>
        <form action='/home/calculate' method='post'>
        First Number<input type='text' name='first' /><br />
        Second Number<input type='text' name='second' /><br />
        <input type='submit' value='Add' />
        </form>
    </div>
</body>
</html>
