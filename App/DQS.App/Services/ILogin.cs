using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQS.App.Services
{
    public interface ILogin
    {
        void verificationLogintxt(string userCode, out string codeError, string password, out string pwdError);
        void Logintxt(string userCode, out string codeError, string password, out string pwdError);
        List<SYSConnection> getConnList(out string cboText);
        bool isVisible(out string EnterpriseName);
        void SaveConfiguration(string connection);
    }
}
