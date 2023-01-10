using ServiceLayer.Exceptions;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        public string Register(string username, string password, string email)
        {
            var emails = GetEmails();
            try
            {
                if (emails.Contains(email))
                {
                    throw new EmailException(EmailResponseMsg.ErrorMessage);
                }
                return EmailResponseMsg.SuccesMessage;
            }
            catch (Exception ex)
            {
                return  ex.Message;
            }
        }

        private List<string> GetEmails()
        {
            List<string> emailList = new List<string>();
           
            emailList.Add("chinaraei@code.edu.az");
            emailList.Add("aqshin@code.edu.az");
            emailList.Add("konulsi@code.edu.az");
            emailList.Add("roya@code.edu.az");
            emailList.Add("ibrahimea@code.edu.az");
            return emailList;
        }
    }
}
