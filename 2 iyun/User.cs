using System;
using System.Collections.Generic;
using System.Text;

namespace _2_iyun
{
    class User
    {
        private string _userName;
        private string _password; 

        public User(string UserName)
        {
            _userName = UserName;
          
        } 
        public string UserName
        {
            get
            {
                return _userName;
            } set
            {
                if (6<value.Length&&value.Length<25)
                {
                    _userName = value;
                }
            }
        } 
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (8<value.Length&&25>value.Length)
                { if (HasDigit(value)&& HasUpper(value)&&HasLower(value))
                    {
                        _password = value;
                    }
                    
                }
            }
        } 
        public bool HasDigit (string str)
        {
            
            bool check = false;
            for (int i = 0; i < str.Length; i++)

            { if (Char.IsDigit(str[i]))
                {
                    check = true;
                    break;
                } 

            } return check;

        } 
        public bool HasUpper (string upper)
        {
            bool check = false;
            for (int i = 0; i < upper.Length; i++)
            { if (Char.IsUpper(upper[i]))
                {
                    check = true;
                    break;
                }

            } return check;

        } 
        public bool HasLower (string lower)
        {
            bool check = false;
            for (int i = 0; i < lower.Length; i++)
            { if (Char.IsLower(lower[i]))
                {
                    check = true;
                    break;
                }

            } return check;
        }


    }
}
