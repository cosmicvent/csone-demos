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
    <%if ( q.User.UserName == User.Identity.Name ) { %>
    <a href='/questions/edit/<%=q.Id %>'>Edit</a>
    <%} %>
    <div>
        <h3>
            Answers (<%=q.Answers.Count %>)</h3>
        <% foreach ( var answer in q.Answers ) { %>
        <%if ( q.CorrectAnswerId.HasValue && answer.Id == q.CorrectAnswerId.Value ) { %>
        (Correct Answer)
        <%} %>
        <p>
            <%=answer.Body %>
        </p>
        <p>
            <%=answer.CreatedOn %></p>
        <%if ( answer.User.UserName == User.Identity.Name ) { %>
        <a href='/questions/editanswer/<%=answer.Id %>'>Edit</a>
        <%} %>
        <%if ( q.User.UserName == User.Identity.Name && q.CorrectAnswerId == null ) { %>
        <a href='/questions/markanswer/<%=answer.Id %>'>Mark as Correct Answer</a>
        <%} %>
        <%} %>
    </div>
    <form method='post' action='/questions/addanswer'>
    <input type='hidden' name='id' value='<%=q.Id %>' />
    <textarea name='body'></textarea><br />
    <input type='submit' value='Post Answer' />
    </form>
    <a href='/questions/show/<%=q.Id -1 %>'>&lt;Prev</a> <a href='/questions/show/<%=q.Id +1 %>'>
        Next&gt;</a>
    <%} %>
</body>
</html>
