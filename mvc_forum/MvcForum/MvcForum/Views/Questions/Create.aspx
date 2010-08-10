<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create</title>
</head>
<body>
    <div>
        <form method='post'>
        <input type='text' name='title' /><br />
        <textarea name='body'></textarea><br />
        <input type='submit' value='Ask Question' />
        </form>
    </div>
</body>
</html>
