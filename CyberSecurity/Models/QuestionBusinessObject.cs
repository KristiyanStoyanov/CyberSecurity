using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CyberSecurity.Interfaces;

namespace CyberSecurity.Models
{
    [Serializable]
    [XmlRoot("Questions"), XmlType("Questions")]
    public class QuestionBusinessObject
    {
        public int QuestionID { get; set; }
        public string QuestionType { get; set; }
        public string QuestionContent { get; set; }
        public string QuestionPriority { get; set; }
        public bool QuestionCheckBox { get; set; }

    }

    public class MalwareQuestionsViewModel : QuestionBusinessObject
    {
        public List<MalwareQuestionsViewModel> ReturnListOfQuestions()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/MalwareQuestions.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(xmlData);
            var questions = new List<MalwareQuestionsViewModel>();
            questions = (from rows in ds.Tables[0].AsEnumerable()
                         select new MalwareQuestionsViewModel
                         {
                             QuestionID = Convert.ToInt32(rows[0].ToString()),
                             QuestionType = rows[1].ToString(),
                             QuestionContent = rows[2].ToString(),
                             QuestionPriority = rows[3].ToString(),
                             QuestionCheckBox = Convert.ToBoolean(rows[4]),
                         }).ToList();
                            return questions;
        }
    }
    public class SecureConfigurationViewModel : QuestionBusinessObject
    {
        public List<SecureConfigurationViewModel> ReturnListOfQuestions()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/SecureConfiguration.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(xmlData);
            var questions = new List<SecureConfigurationViewModel>();
            questions = (from rows in ds.Tables[0].AsEnumerable()
                         select new SecureConfigurationViewModel
                         {
                             QuestionID = Convert.ToInt32(rows[0].ToString()),
                             QuestionType = rows[1].ToString(),
                             QuestionContent = rows[2].ToString(),
                             QuestionPriority = rows[3].ToString(),
                             QuestionCheckBox = Convert.ToBoolean(rows[4]),
                         }).ToList();

                          return questions;
                         }
        }

    public class PatchManagementViewModel: QuestionBusinessObject
    {
        public List<PatchManagementViewModel> ReturnListOfQuestions()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/PatchManagementQuestions.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(xmlData);
            var questions = new List<PatchManagementViewModel>();
            questions = (from rows in ds.Tables[0].AsEnumerable()
                         select new PatchManagementViewModel
                         {
                             QuestionID = Convert.ToInt32(rows[0].ToString()),
                             QuestionType = rows[1].ToString(),
                             QuestionContent = rows[2].ToString(),
                             QuestionPriority = rows[3].ToString(),
                             QuestionCheckBox = Convert.ToBoolean(rows[4]),
                         }).ToList();
            return questions;
        }
    }


    }
