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
                        DeveloperRepository.LoggedDeveloper = dev;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Este usuário não está ativo!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Email não existente!");
                return false;
            }
        }
    }
}
