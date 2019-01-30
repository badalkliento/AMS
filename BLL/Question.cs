using System;
using System.Data;
using System.Web.UI.WebControls;

namespace BLL
{
    public class Question
    {
        /// <summary>
        /// Add Question
        /// </summary>
        /// <param name="question"></param>
        public static int AddQuestion(CBE.Question question)
        {
            return DAL.Question.AddQuestion(question);
        }

        /// <summary>
        /// Get All Questions Pagewise
        /// </summary>
        /// <param name="TopicID"></param>
        /// <param name="txtKeyword"></param>
        /// <param name="pageIndex"></param>
        /// <param name="rp_QuestionList"></param>
        /// <param name="ddlPagination"></param>
        /// <param name="pageSize"></param>
        /// <param name="lbTotalRecords"></param>
        /// <param name="BindPagingDdl"></param>
        public static void GetAllQuestionsPagewise(Int32 TopicID, ref TextBox txtKeyword, Int32 pageIndex, ref Repeater rp_QuestionList, ref DropDownList ddlPagination, Int32 pageSize, ref Label lbTotalRecords, String BindPagingDdl)
        {
            DAL.Question.GetAllQuestionsPagewise(TopicID, ref txtKeyword, pageIndex, ref rp_QuestionList, ref ddlPagination, pageSize, ref lbTotalRecords, BindPagingDdl);
        }

        /// <summary>
        /// Update Question
        /// </summary>
        /// <param name="question"></param>
        public static void UpdateQuestion(CBE.Question question)
        {
            DAL.Question.UpdateQuestion(question);
        }

        /// <summary>
        /// Get QuestionDetails By ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CBE.Question GetQuestionDetailsByID(Int32 ID)
        {
            CBE.Question question = new CBE.Question();
            DataTable ldt = new DataTable();
            ldt = DAL.Question.GetQuestionDetailsByID(ID);
            if (ldt.Rows.Count > 0)
            {
                question.ID = ID;
                question.TopicID = Convert.ToInt32(ldt.Rows[0]["TopicID"]);
                question.Questions = Convert.ToString(ldt.Rows[0]["Question"]);
                question.NoOfAnswerOptions = Convert.ToInt32(ldt.Rows[0]["NoOfAnswerOptions"]);
                question.RightAnswerExplaination = Convert.ToString(ldt.Rows[0]["RightAnswerExplaination"]);
                question.IsActive = Convert.ToBoolean(ldt.Rows[0]["IsActive"]);
            }
            return question;
        }

        /// <summary>
        /// Delete Question
        /// </summary>
        /// <param name="ID"></param>
        public static void DeleteQuestion(Int32 ID)
        {
            DAL.Question.DeleteQuestion(ID);
        }

        /// <summary>
        /// Get Question By TopicID
        /// </summary>
        /// <param name="TopicID"></param>
        /// <returns></returns>
        public static DataTable GetQuestionByTopicID(Int32 TopicID)
        {
            return DAL.Question.GetQuestionByTopicID(TopicID);
        }

        /// <summary>
        /// Get Random Question By TopicID
        /// </summary>
        /// <param name="TopicID"></param>
        /// <returns></returns>
        public static DataTable GetRandomQuestionByTopicID(Int32 TopicID)
        {
            return DAL.Question.GetRandomQuestionByTopicID(TopicID);
        }

        /// <summary>
        /// Delete Question Data
        /// </summary>
        /// <param name="QuestionID"></param>
        public static void DeleteQuestionData(Int32 QuestionID)
        {
            DAL.Question.DeleteQuestionData(QuestionID);
        }
        public static DataTable GetQuestionByTopicIDforEmployee(Int32 TopicID)
        {
            return DAL.Question.GetQuestionByTopicIDforEmployee(TopicID);
        }
    }
}
