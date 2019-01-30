using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BLL
{
    public class Employee
    {
        public static CBE.Employee GetEmployeeDetailsByID(Int32 ID)
        {
            CBE.Employee employee = new CBE.Employee();
            DataTable ldt = new DataTable();
            ldt = DAL.Employee.GetEmployeeDetailsByID(ID);
            if (ldt.Rows.Count > 0)
            {
                employee.ID = ID;
                employee.Title = Convert.ToString(ldt.Rows[0]["Title"]);
                employee.FirstName = Convert.ToString(ldt.Rows[0]["FirstName"]);
                employee.LastName = Convert.ToString(ldt.Rows[0]["LastName"]);
                employee.Phone = Convert.ToString(ldt.Rows[0]["Phone"]);
                employee.Fax = Convert.ToString(ldt.Rows[0]["Fax"]);
                employee.Email = Common.Encrypter.Decrypt(Convert.ToString(ldt.Rows[0]["Email"]), true);
                employee.StreetAddress1 = Convert.ToString(ldt.Rows[0]["StreetAddress1"]);
                employee.StreetAddress2 = Convert.ToString(ldt.Rows[0]["StreetAddress2"]);
                employee.CountryID = Convert.ToInt32(ldt.Rows[0]["CountryID"]);
                employee.State = Convert.ToString(ldt.Rows[0]["State"]);
                employee.City = Convert.ToString(ldt.Rows[0]["City"]);
                employee.Zipcode = Convert.ToString(ldt.Rows[0]["Zipcode"]);
                employee.UserImage = Convert.ToString(ldt.Rows[0]["UserImage"]);
                employee.IsActive = Convert.ToBoolean(ldt.Rows[0]["IsActive"]);
                employee.Dob = Convert.ToDateTime(ldt.Rows[0]["DOB"]);
                employee.CompanyID = Convert.ToInt32(ldt.Rows[0]["CompanyID"]);
            }
            return employee;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public static void AddEmployee(CBE.Employee employee)
        {
            DAL.Employee.AddEmployee(employee);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public static void UpdateEmployee(CBE.Employee employee)
        {
            DAL.Employee.UpdateEmployee(employee);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtKeyword"></param>
        /// <param name="pageIndex"></param>
        /// <param name="rp_EmployeeList"></param>
        /// <param name="ddlPagination"></param>
        /// <param name="pageSize"></param>
        /// <param name="lbTotalRecords"></param>
        /// <param name="BindPagingDdl"></param>
        /// <param name="CompanyID"></param>
        public static void GetAllEmployeesPagewise(ref TextBox txtKeyword, Int32 pageIndex, ref Repeater rp_EmployeeList, ref DropDownList ddlPagination, Int32 pageSize, ref Label lbTotalRecords, String BindPagingDdl, Int32 CompanyID)
        {
            DAL.Employee.GetAllEmployeesPagewise(ref txtKeyword, pageIndex, ref rp_EmployeeList, ref ddlPagination, pageSize, ref lbTotalRecords, BindPagingDdl, CompanyID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        public static void DeleteEmployee(Int32 ID)
        {
            DAL.Employee.DeleteEmployee(ID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public static void AssignEmployeeToTopicByCompany(CBE.Employee employee)
        {
            DAL.Employee.AssignEmployeeToTopicByCompany(employee);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public static DataTable GetAssignedEmployeeByCompanyIDandTopicID(Int32 CompanyID, Int32 TopicID)
        {
            return DAL.Employee.GetAssignedEmployeeByCompanyIDandTopicID(CompanyID, TopicID);
        }
        public static void DeleteEmployeeAssignmentByID(Int32 ID)
        {
            DAL.Employee.DeleteEmployeeAssignmentByID(ID);
        }
        /// <summary>
        /// Get AllTopics Assign To EmployeePagewise
        /// </summary>
        /// <param name="txtKeyword"></param>
        /// <param name="pageIndex"></param>
        /// <param name="rpTopicList"></param>
        /// <param name="ddlPagination"></param>
        /// <param name="pageSize"></param>
        /// <param name="lbTotalRecords"></param>
        /// <param name="BindPagingDdl"></param>
        /// <param name="EmployeeID"></param>
        public static void GetAllTopicsAssignToEmployeePagewise(ref TextBox txtKeyword, Int32 pageIndex, ref Repeater rpTopicList, ref DropDownList ddlPagination, Int32 pageSize, ref Label lbTotalRecords, String BindPagingDdl, Int32 EmployeeID)
        {
            DAL.Employee.GetAllTopicsAssignToEmployeePagewise(ref txtKeyword, pageIndex, ref rpTopicList, ref ddlPagination, pageSize, ref lbTotalRecords, BindPagingDdl, EmployeeID);
        }

        /// <summary>
        /// Save Employee Topic Temp
        /// </summary>
        /// <param name="employeetopic"></param>
        /// <returns></returns>
        public static int SaveEmployeeTopicTemp(CBE.EmployeeTopic employeetopic)
        {
            return DAL.Employee.SaveEmployeeTopicTemp(employeetopic);
        }

        /// <summary>
        /// Save Employee Topic Answer Temp
        /// </summary>
        /// <param name="employeetopicanswer"></param>
        public static void SaveEmployeeTopicAnswerTemp(CBE.EmployeeTopicAnswer employeetopicanswer)
        {
            DAL.Employee.SaveEmployeeTopicAnswerTemp(employeetopicanswer);
        }

        /// <summary>
        /// Save Final Employee TopicAnswer
        /// </summary>
        /// <param name="employeetopic"></param>
        /// <returns></returns>
        public static int SaveFinalEmployeeTopic(CBE.EmployeeTopic employeetopic)
        {
            return DAL.Employee.SaveFinalEmployeeTopic(employeetopic);
        }

        /// <summary>
        /// Save Employee Topic Answer Temp
        /// </summary>
        /// <param name="employeetopicanswer"></param>
        public static int SaveFinalEmployeeTopicAnswer(CBE.EmployeeTopicAnswer employeetopicanswer)
        {
            return DAL.Employee.SaveFinalEmployeeTopicAnswer(employeetopicanswer);
        }

        /// <summary>
        /// Update Status And Marks Of EmployeeTopic
        /// </summary>
        /// <param name="employeetopic"></param>
        public static void UpdateStatusAndMarksOfEmployeeTopic(CBE.EmployeeTopic employeetopic)
        {
            DAL.Employee.UpdateStatusAndMarksOfEmployeeTopic(employeetopic);
        }

        /// <summary>
        /// Get EmployeeResult By EmployeeID And TopicID
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="TopicID"></param>
        /// <returns></returns>
        public static DataTable GetEmployeeResultByEmployeeIDAndTopicID(Int32 EmployeeID, Int32 TopicID)
        {
            return DAL.Employee.GetEmployeeResultByEmployeeIDAndTopicID(EmployeeID, TopicID);
        }

        /// <summary>
        /// Get EmployeeAnswers By EmployeeTopicID
        /// </summary>
        /// <param name="EmployeeTopicID"></param>
        /// <returns></returns>
        public static DataTable GetEmployeeAnswersByEmployeeTopicID(Int32 EmployeeTopicID)
        {
            return DAL.Employee.GetEmployeeAnswersByEmployeeTopicID(EmployeeTopicID);
        }

        /// <summary>
        /// Get EmployeeResult By EmployeeID
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public static DataTable GetEmployeeResultByEmployeeID(Int32 EmployeeID)
        {
            return DAL.Employee.GetEmployeeResultByEmployeeID(EmployeeID);
        }

        /// <summary>
        /// Get EmployeeTopicDetails By TopicID And EmployeeID
        /// </summary>
        /// <param name="TopicID"></param>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public static DataTable GetEmployeeTopicDetailsByTopicIDAndEmployeeID(Int32 TopicID, Int32 EmployeeID)
        {
            return DAL.Employee.GetEmployeeTopicDetailsByTopicIDAndEmployeeID(TopicID, EmployeeID);
        }

        /// <summary>
        /// Update AssignEmployee To Topic By ID
        /// </summary>
        /// <param name="employee"></param>
        public static void UpdateAssignEmployeeToTopicByID(CBE.Employee employee)
        {
            DAL.Employee.UpdateAssignEmployeeToTopicByID(employee);
        }

        /// <summary>
        /// Update AssignEmployee To Topic By TopicID
        /// </summary>
        /// <param name="employee"></param>
        public static void UpdateAssignEmployeeToTopicByTopicID(CBE.Employee employee)
        {
            DAL.Employee.UpdateAssignEmployeeToTopicByTopicID(employee);
        }
        public static DataTable GetEmployeeLoginDetails(string UserName, string Password)
        {
            return DAL.Employee.GetEmployeeLoginDetails(UserName, Password);
        }
        public static void ResetPassword(String Password, String EmailID)
        {
            DAL.Employee.ResetPassword(Password, EmailID);
        }
    }
}
