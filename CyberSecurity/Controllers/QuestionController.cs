using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using System.Xml.XmlConfiguration;
using System.Xml.Serialization.Configuration;
using System.Xml.Serialization.Advanced;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Data;
using CyberSecurity.Models;

namespace CyberSecurity.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question
        public ActionResult MalwareQuestion()
        {
            MalwareQuestionsViewModel readXml = new MalwareQuestionsViewModel();

            var data = readXml.ReturnListOfQuestions();

            return View(data);
        }

        public ActionResult SecureConfigurationQuestion()
        {

            SecureConfigurationViewModel readXml = new SecureConfigurationViewModel();

            var data = readXml.ReturnListOfQuestions();

            return View(data);
        }

        public ActionResult PatchManagementQuestions()
        {

            PatchManagementViewModel readXml = new PatchManagementViewModel();

            var data = readXml.ReturnListOfQuestions();

            return View(data);
        }

    }
}