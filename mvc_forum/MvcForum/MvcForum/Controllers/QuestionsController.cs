using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcForum.Models;

namespace MvcForum.Controllers {
    public class QuestionsController : Controller {

        MvcForumDataContext _dataContext;

        public QuestionsController() {
            _dataContext = new MvcForumDataContext();
        }

        public ActionResult Index() {
            ViewData["questions"] = _dataContext.Questions.ToList();
            return View();
        }

        public ActionResult Show( int id ) {
            Question question = _dataContext.Questions.FirstOrDefault( x => x.Id == id );
            ViewData["question"] = question;
            return View();
        }

        public ActionResult Create() {
            if ( User.Identity.IsAuthenticated ) {
                return View();
            }
            TempData["error"] = "Please login to ask a question";
            return Redirect( "/sessions/new" );
        }

        [HttpPost]
        public ActionResult Create( FormCollection form ) {
            if ( !User.Identity.IsAuthenticated ) {
                TempData["error"] = "Please login to ask a question";
                return Redirect( "/sessions/new" );
            }
            User user = _dataContext.Users.FirstOrDefault( x => x.UserName == User.Identity.Name );
            Question question = new Question();
            question.Title = form["title"];
            question.Body = form["body"];
            question.AuthorId = user.Id;
            question.CreatedOn = DateTime.Now;
            _dataContext.Questions.InsertOnSubmit( question );
            _dataContext.SubmitChanges();
            return View();
        }


        public ActionResult AddAnswer( FormCollection form ) {
            Answer answer = new Answer();
            int id = int.Parse( form["id"] );
            answer.QuestionId = id;
            answer.Body = form["body"];
            answer.CreatedOn = DateTime.Now;
            _dataContext.Answers.InsertOnSubmit( answer );
            _dataContext.SubmitChanges();
            return Redirect( "/questions/show/" + id );
        }

        public ActionResult Edit( int id ) {
            Question q = _dataContext.Questions.FirstOrDefault( x => x.Id == id );
            ViewData["question"] = q;
            return View();
        }

        [HttpPost]
        public ActionResult Edit( FormCollection form, int id ) {
            Question q = _dataContext.Questions.FirstOrDefault( x => x.Id == id );
            q.Title = form["title"];
            q.Body = form["body"];
            _dataContext.SubmitChanges();
            return Redirect( "/questions/show/" + id );
        }

        public ActionResult EditAnswer( int id ) {
            Answer a = _dataContext.Answers.FirstOrDefault( x => x.Id == id );
            ViewData["answer"] = a;
            return View();
        }

        [HttpPost]
        public ActionResult EditAnswer( FormCollection form, int id ) {
            Answer a = _dataContext.Answers.FirstOrDefault( x => x.Id == id );
            a.Body = form["body"];
            _dataContext.SubmitChanges();
            return Redirect( "/questions/show/" + a.Question.Id );
        }

        public ActionResult MarkAnswer( int id ) {
            Answer a = _dataContext.Answers.FirstOrDefault( x => x.Id == id );
            a.Question.CorrectAnswerId = a.Id;
            _dataContext.SubmitChanges();
            return Redirect( "/questions/show/" + a.QuestionId );
        }
    }
}