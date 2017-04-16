using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberSecurity.Models;

namespace CyberSecurity.Interfaces
{
    interface IQuestion
    {

        void DisplayQuestions(List<QuestionBusinessObject> setQuestions);
     
        void UpdateQuestions(List<QuestionBusinessObject> setQuestions);
     
        
    }
}
