using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestExample.Abstractions;
using UnitTestExample.Entities;
using UnitTestExample.Services;

namespace UnitTestExample.Controllers
{
    public class AccountController
    {        
        public IAccountManager AccountManager { get; set; }

        public AccountController()
        {
            AccountManager = new AccountManager();
        }


        //a függvény csak az email címeket veti alá vizsgálatnak valamiért
        //jelszónak mindent elfogad

        //első hiba: a második validateemailben password a helyes paraméter
        //második hiba talán: a második az validatepassword és nem email
        //ez segített, de még nem jó a teszt
        //minden létrehozott accountnak ugyanaz az ID-ja
        //adtam az új accountnak új guididt, de nem segített
        //az előbb rosszul a adtm a nw Guid-ot, mostmár jó ,az volt a probléma
        public Account Register(string email, string password)
        {
            if(!ValidateEmail(email))
                throw new ValidationException(
                    "A megadott e-mail cím nem megfelelő!");
            if(!ValidatePassword(password))
                throw new ValidationException(
                    "A megadottt jelszó nem megfelelő!\n" +
                    "A jelszó legalább 8 karakter hosszú kell legyen, csak az angol ABC betűiből és számokból állhat, és tartalmaznia kell legalább egy kisbetűt, egy nagybetűt és egy számot.");

            var account = new Account()
            {
                ID = Guid.NewGuid(),
                Email = email,
                Password = password
            };

            var newAccount = AccountManager.CreateAccount(account);

            return newAccount;
        }

        public bool ValidateEmail(string email)
        {            
            return Regex.IsMatch(
                email, 
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(
                password,
                @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?!=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
        }
    }
}
