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
    [Table("Credentials")]
    internal class Credential
    {
        public Int64 Id { get; set; }

        //constant to append with the password, ensuring more security
        public const String SALT = "mvp";

        [Index(IsUnique = true)]
        [StringLength(250)]
        public String Email { get; set; }

        private String _password;

        //verifies the password length, if it is higher than 8 and lower than 12, it encrypts it
        //if the password has exactly 64 characters, it is already encrypted, so it doesn't encrypt it again
        [StringLength(64)]
        public String Password
        {
            get 
            { 
                return _password;
            }
            set
            {
                if(value.Length >= 8 && value.Length <= 12)
                {
                    _password = ComputeSHA256(value, SALT);
                }
                else if(value.Length == 64)
                {
                    _password = value;
                }
                else
                {
                    throw new ArgumentException("A senha deve ter entre 8 e 12 caracteres");
                }
            }
        }

        public Boolean Active { get; set; }
        public Boolean Admin { get; set; }

        [Required]
        public Developer Developer { get; set; }

        public Credential()
        {

        }

        #region Hashing
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(salt + input));

                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }
            return hash;
        }
        #endregion
    }
}