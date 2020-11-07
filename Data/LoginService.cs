using System;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp.Data
{
    public class LoginService
    {
        private int loginstat;

        public LoginService(){
            this.loginstat=0;
        }
        public void setlogin(int login){
            this.loginstat=login;
        }
        public int getlogin(){
            return this.loginstat;
        }

        public Task<int> GetLoginAsync()
        {
            return Task.FromResult(getlogin());
        }

        public Task<MemberData> GetMemberInfo()
        {
            var rng = new Random();
            return Task.FromResult(new MemberData
            {
                Name = "Spencer",
                Order = "first order"
            });
        }

        
    }
}
