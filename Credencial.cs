using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperAllocationMVP
{
    [Table("Credenciais")]
    internal class Credencial
    {
        public Int64 Id { get; set; }

        //constant to append with the password, ensuring more security
        public const String SALT = "mvp";

        [Index(IsUnique = true)]
        [StringLength(250)]
        public String Email { get; set; }

        private String _senha;

        //verifies the password length, if it is higher than 8 and lower than 12, it encrypts it
        //if the password has exactly 64 characters, it is already encrypted, so it doesn't encrypt it again
        public String Senha
        {
            get 
            { 
                return _senha;
            }
            set
            {
                if(value.Length >= 8 && value.Length <= 12)
                {
                    _senha = ComputeSHA256(value, SALT);
                }
                else if(value.Length == 64)
                {
                    _senha = value;
                }
                else
                {
                    throw new ArgumentException("Senha inválida!");
                }
            }
        }

        public Boolean Ativo { get; set; }
        public Boolean Admin { get; set; }

        [Required]
        public Desenvolvedor Desenvolvedor { get; set; }

        public Credencial()
        {

        }

        #region Hashing
        //public static String ComputeSHA256(String input)
        //{
        //    return ComputeSHA256(input, null);
        //}

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(salt + input));

                foreach (byte b in hashValue)
                {
                    hash = $"{b:X2}";
                }
            }
            return hash;
        }
        #endregion

        //authentication method that verifies if the password given is correct
        public static Boolean Autenticar(String email, String senha)
        {
            Desenvolvedor dev = DevRepos.EncontrarEmail(email);

            if(dev != null)
            {
                String senhaBd = dev.Credencial.Senha;

                if (senhaBd == ComputeSHA256(senha, SALT)) return true;
                else
                {
                    MessageBox.Show("SENHA INCORRETA!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("EMAIL NÃO EXISTENTE!");
                return false;
            }
        }

        public override string ToString()
        {
            return String.Format("Email: {0} \nSenha: {1}", Email, Senha);
        }
    }
}