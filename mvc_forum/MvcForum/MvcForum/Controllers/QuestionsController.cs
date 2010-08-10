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
            return View();
        }

        [HttpPost]
        public ActionResult Create( FormCollection form ) {
            Question question = new Question();
            question.Title = form["title"];
            question.Body = form["body"];
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

    }
}