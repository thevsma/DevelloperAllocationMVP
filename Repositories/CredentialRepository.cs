using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperAllocationMVP.Repositories
{
    internal class CredentialRepository
    {
        //authentication method that verifies if the password given is correct
        public static Boolean Authenticate(String email, String password)
        {
            Developer dev = DeveloperRepository.FindByEmail(email);

            if (dev != null)
            {
                if(dev.Credential.Active == true)
                {
                    String pwdBd = dev.Credential.Password;

                    if (pwdBd == Credential.ComputeSHA256(password, Credential.SALT))
                    {
                        Repository.LoggedDeveloper = dev;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("SENHA INCORRETA!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("ESTE USUÁRIO NÃO ESTÁ ATIVO!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("EMAIL NÃO EXISTENTE!");
                return false;
            }
        }
    }
}
