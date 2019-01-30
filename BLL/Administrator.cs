using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Administrator
    {
        public static DataTable GetAdminLoginDetails(string UserName, string Password)
        {
            return DAL.Administrator.GetAdminLoginDetails(UserName, Password);
        }
        public static DataTable GetAdminDetailsByEmail(string EmailID)
        {
            return DAL.Administrator.GetAdminDetailsByEmail(EmailID);
        }
        /// <summary>
        /// Get MenuDetails
        /// </summary>
        /// <param name="RoleName"></param>
        /// <returns></returns>
        public static String GetMenuDetails(String RoleName)
        {
            DataTable dt = new DataTable();
            dt = DAL.Administrator.GetMenuDetails(RoleName);
            StringBuilder sb_menu = new StringBuilder();
            sb_menu.Append("<div  class='navbar-collapse collapse navbar-left mid-nav'><ul  class='nav navbar-nav mb-top'>");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    sb_menu.Append("<li><a href='" + row["NavigateUrl"].ToString().Trim().ToLower() + "' >" + row["MenuName"].ToString() + "</a></li>");
                }
            }
            sb_menu.Append("</ul></div>");
            return sb_menu.ToString().Trim();
        }
        public static DataSet CountRecordsFromCompanyandTopic()
        {
            return DAL.Administrator.CountRecordsFromCompanyandTopic();
        }
        public static void AuditLog(String Action, String Message, String UserID, String RoleName, String IPAddress)
        {
            DAL.Administrator.AuditLog(Action, Message, UserID, RoleName, IPAddress);
        }
        public static void ResetPassword(String Password, String EmailID)
        {
            DAL.Administrator.ResetPassword(Password, EmailID);
        }
        public static void ForgotPasswordResetFunction(String NewPassword, String Role, String EmailID)
        {
            DAL.Administrator.ForgotPasswordResetFunction(NewPassword, Role, EmailID);
        }
        public static void UpdateLoginCountForEmployee(String EmailID)
        {
            DAL.Administrator.UpdateLoginCountForEmployee(EmailID);
        }
    }
}
