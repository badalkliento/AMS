using System;
using System.Data;
using System.Web.UI.WebControls;

namespace BLL
{
    public class Answer
    {
        /// <summary>
        /// Add Answer
        /// </summary>
        /// <param name="answer"></param>
        public static void AddAnswer(CBE.Answer answer)
        {
            DAL.Answer.AddAnswer(answer);
        }

        /// <summary>
        /// Get AnswerDetails By ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DataTable GetAnswerDetailsByID(Int32 ID)
        {
            return DAL.Answer.GetAnswerDetailsByID(ID);
        }

        /// <summary>
        /// Get Correct AnswerDetails By QuestionID
        /// </summary>
        /// <param name="QuestionID"></param>
        /// <returns></returns>
        public static DataTable GetCorrectAnswerDetailsByQuestionID(Int32 QuestionID)
        {
            return DAL.Answer.GetCorrectAnswerDetailsByQuestionID(QuestionID);
        }
    }
}
