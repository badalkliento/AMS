using System;
using System.Data;
using System.Web.UI.WebControls;

namespace BLL
{
    public class Company
    {
        public static DataSet GetCompanyEmployeeLoginDetails(string UserName, string Password)
        {
            return DAL.Company.GetCompanyEmployeeLoginDetails(UserName, Password);
        }
        public static DataTable GetCMSPage(String PageName)
        {
            return DAL.Company.GetCMSPage(PageName);
        }
        public static DataSet GetTNCByEmailID(String EmailID)
        {
            return DAL.Company.GetTNCByEmailID(EmailID);
        }
        public static void UpdateTNCbyEmailID(String EmailID, String RoleName)
        {
            DAL.Company.UpdateTNCbyEmailID(EmailID, RoleName);
        }
        /// <summary>
        /// Add Company
        /// </summary>
        /// <param name="company"></param>
        public static void AddCompany(CBE.Company company)
        {
            DAL.Company.AddCompany(company);
        }

        /// <summary>
        /// Get All Companies Pagewise
        /// </summary>
        /// <param name="txtKeyword"></param>
        /// <param name="pageIndex"></param>
        /// <param name="rp_CompanyList"></param>
        /// <param name="ddlPagination"></param>
        /// <param name="pageSize"></param>
        /// <param name="lbTotalRecords"></param>
        /// <param name="BindPagingDdl"></param>
        public static void GetAllCompaniesPagewise(ref TextBox txtKeyword, Int32 pageIndex, ref Repeater rp_CompanyList, ref DropDownList ddlPagination, Int32 pageSize, ref Label lbTotalRecords, String BindPagingDdl)
        {
            DAL.Company.GetAllCompaniesPagewise(ref txtKeyword, pageIndex, ref rp_CompanyList, ref ddlPagination, pageSize, ref lbTotalRecords, BindPagingDdl);
        }

        /// <summary>
        /// Update Company
        /// </summary>
        /// <param name="company"></param>
        public static void UpdateCompany(CBE.Company company)
        {
            DAL.Company.UpdateCompany(company);
        }

        /// <summary>
        /// Get CompanyDetails By ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CBE.Company GetCompanyDetailsByID(Int32 ID)
        {
            CBE.Company company = new CBE.Company();
            DataTable ldt = new DataTable();
            ldt = DAL.Company.GetCompanyDetailsByID(ID);
            if (ldt.Rows.Count > 0)
            {
                company.ID = ID;
                company.CompanyName = Convert.ToString(ldt.Rows[0]["CompanyName"]);
                company.Phone = Convert.ToString(ldt.Rows[0]["Phone"]);
                company.Fax = Convert.ToString(ldt.Rows[0]["Fax"]);
                company.Email = Common.Encrypter.Decrypt(Convert.ToString(ldt.Rows[0]["Email"]), true);
                company.StreetAddress1 = Convert.ToString(ldt.Rows[0]["StreetAddress1"]);
                company.StreetAddress2 = Convert.ToString(ldt.Rows[0]["StreetAddress2"]);
                company.CountryID = Convert.ToInt32(ldt.Rows[0]["CountryID"]);
                company.State = Convert.ToString(ldt.Rows[0]["State"]);
                company.City = Convert.ToString(ldt.Rows[0]["City"]);
                company.Zipcode = Convert.ToString(ldt.Rows[0]["Zipcode"]);
                company.CompanyLogo = Convert.ToString(ldt.Rows[0]["CompanyLogo"]);
                company.TotalPermittedEmployee = Convert.ToInt32(ldt.Rows[0]["TotalPermittedEmployee"]);
                company.IsActive = Convert.ToBoolean(ldt.Rows[0]["IsActive"]);
                company.IsApproved = Convert.ToBoolean(ldt.Rows[0]["IsApproved"]);
            }
            return company;
        }

        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="ID"></param>
        public static void DeleteCompany(Int32 ID)
        {
            DAL.Company.DeleteCompany(ID);
        }

        /// <summary>
        /// Get CountryList
        /// </summary>
        /// <returns></returns>
        public static DataTable GetCountryList()
        {
            return DAL.Company.GetCountryList();
        }
        public static DataSet GetUserDetailByEmailID(String EmailID)
        {
            return DAL.Company.GetUserDetailByEmailID(EmailID);
        }

        /// <summary>
        /// Get CompanyList For Topic Assignment
        /// </summary>
        /// <param name="TopicID"></param>
        /// <returns></returns>
        public static DataTable GetCompanyListForTopicAssignment(Int32 TopicID)
        {
            return DAL.Company.GetCompanyListForTopicAssignment(TopicID);
        }

        /// <summary>
        /// Assign Topic To Company
        /// </summary>
        /// <param name="company"></param>
        public static void AssignTopicToCompany(CBE.Company company)
        {
            DAL.Company.AssignTopicToCompany(company);
        }
        /// <summary>
        /// Get AssignedCompany By TopicID
        /// </summary>
        /// <param name="TopicID"></param>
        /// <returns></returns>
        public static DataTable GetAssignedCompanyByTopicID(Int32 TopicID)
        {
            return DAL.Company.GetAssignedCompanyByTopicID(TopicID);
        }

        /// <summary>
        /// Delete CompanyAssignment By ID
        /// </summary>
        /// <param name="ID"></param>
        public static void DeleteCompanyAssignmentByID(Int32 ID)
        {
            DAL.Company.DeleteCompanyAssignmentByID(ID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EmailID"></param>
        /// <returns></returns>
        public static DataSet CheckEmailforEmployeeandCompany(String EmailID)
        {
            return DAL.Company.CheckEmailforEmployeeandCompany(EmailID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public static DataSet CountEmployeeandAssignedTopicsRecordsbyCompanyID(Int32 CompanyID)
        {
            return DAL.Company.CountEmployeeandAssignedTopicsRecordsbyCompanyID(CompanyID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CountryName"></param>
        /// <returns></returns>
        public static DataTable GetCountryIDByCountryName(String CountryName)
        {
            return DAL.Company.GetCountryIDByCountryName(CountryName);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public static DataTable GetTopicsByCompanyID(Int32 CompanyID)
        {
            return DAL.Company.GetTopicsByCompanyID(CompanyID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public static DataTable GetEmployeeListForAssessmentAssignmentByCompanyID(Int32 CompanyID, Int32 TopicID)
        {
            return DAL.Company.GetEmployeeListForAssessmentAssignmentByCompanyID(CompanyID, TopicID);
        }
        public static DataTable GetAllTopicReportByCompanyID(Int32 CompanyID)
        {
            return DAL.Company.GetAllTopicReportByCompanyID(CompanyID);
        }
        public static DataTable GetAllEmployeeReportByCompanyID(Int32 CompanyID)
        {
            return DAL.Company.GetAllEmployeeReportByCompanyID(CompanyID);
        }
        public static void UpdateApprovalStatus(Int32 ID)
        {
            DAL.Company.UpdateApprovalStatus(ID);
        }
        public static void GetAllTopicsPagewiseByCompanyID(ref TextBox txtKeyword, Int32 pageIndex, ref Repeater rp_TopicList, ref DropDownList ddlPagination, Int32 pageSize, ref Label lbTotalRecords, String BindPagingDdl, Int32 CompanyID)
        {
            DAL.Company.GetAllTopicsPagewiseByCompanyID(ref txtKeyword, pageIndex, ref rp_TopicList, ref ddlPagination, pageSize, ref lbTotalRecords, BindPagingDdl, CompanyID );
        }
        public static DataTable GetCompanyLoginDetails(string UserName, string Password)
        {
            return DAL.Company.GetCompanyLoginDetails(UserName, Password);
        }
        public static void ResetPassword(String Password, String EmailID)
        {
            DAL.Company.ResetPassword(Password, EmailID);
        }
    }
}
