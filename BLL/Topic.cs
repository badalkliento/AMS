using System;
using System.Data;
using System.Web.UI.WebControls;

namespace BLL
{
    public class Topic
    {
        /// <summary>
        /// Add Topic
        /// </summary>
        /// <param name="topic"></param>
        public static void AddTopic(CBE.Topic topic)
        {
            DAL.Topic.AddTopic(topic);
        }

        /// <summary>
        /// Get All Topics Pagewise
        /// </summary>
        /// <param name="txtKeyword"></param>
        /// <param name="pageIndex"></param>
        /// <param name="rp_TopicList"></param>
        /// <param name="ddlPagination"></param>
        /// <param name="pageSize"></param>
        /// <param name="lbTotalRecords"></param>
        /// <param name="BindPagingDdl"></param>
        public static void GetAllTopicsPagewise(ref TextBox txtKeyword, Int32 pageIndex, ref Repeater rp_TopicList, ref DropDownList ddlPagination, Int32 pageSize, ref Label lbTotalRecords, String BindPagingDdl)
        {
            DAL.Topic.GetAllTopicsPagewise(ref txtKeyword, pageIndex, ref rp_TopicList, ref ddlPagination, pageSize, ref lbTotalRecords, BindPagingDdl);
        }

        /// <summary>
        /// Update Topic
        /// </summary>
        /// <param name="topic"></param>
        public static void UpdateTopic(CBE.Topic topic)
        {
            DAL.Topic.UpdateTopic(topic);
        }

        /// <summary>
        /// Get TopicDetails By ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CBE.Topic GetTopicDetailsByID(Int32 ID)
        {
            CBE.Topic topic = new CBE.Topic();
            DataTable ldt = new DataTable();
            ldt = DAL.Topic.GetTopicDetailsByID(ID);
            if (ldt.Rows.Count > 0)
            {
                topic.ID = ID;
                topic.TopicName = Convert.ToString(ldt.Rows[0]["TopicName"]);
                topic.NoOfQuestions = Convert.ToInt32(ldt.Rows[0]["NoOfQuestions"]);
                topic.MarksPerQuestion = Convert.ToInt32(ldt.Rows[0]["MarksPerQuestion"]);
                topic.PassingPercentage = Convert.ToInt32(ldt.Rows[0]["PassingPercentage"]);
                topic.IsRandom = Convert.ToBoolean(ldt.Rows[0]["IsRandom"]);
                topic.IsActive = Convert.ToBoolean(ldt.Rows[0]["IsActive"]);
            }
            return topic;
        }

        /// <summary>
        /// Delete Topic
        /// </summary>
        /// <param name="ID"></param>
        public static void DeleteTopic(Int32 ID)
        {
            DAL.Topic.DeleteTopic(ID);
        }

        /// <summary>
        /// Get AssignedTopic By CompanyID
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public static DataTable GetAssignedTopicByCompanyID(Int32 CompanyID)
        {
            return DAL.Topic.GetAssignedTopicByCompanyID(CompanyID);
        }

        /// <summary>
        /// Get TopicList For CompanyAssignment
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public static DataTable GetTopicListForCompanyAssignment(Int32 CompanyID)
        {
            return DAL.Topic.GetTopicListForCompanyAssignment(CompanyID);
        }

        public static DataTable GetTopicDetailsByTopicID(Int32 TopicID)
        {
            return DAL.Topic.GetTopicDetailsByID(TopicID);
        }
        public static DataTable GetEmployeeTopicDetailsByTopicID(Int32 TopicID)
        {
            return DAL.Topic.GetEmployeeTopicDetailsByTopicID(TopicID);
        }
        public static void DeleteTemporaryTableData(Int32 EmployeeID, Int32 TopicID)
        {
            DAL.Topic.DeleteTemporaryTableData(EmployeeID, TopicID);
        }
    }
}
