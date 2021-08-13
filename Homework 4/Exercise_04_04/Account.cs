using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise_04_04
{
    public struct Account
    {
        string login;
        string pass;
        int authAttempts;
        public Account(string login, string pass)
        {
            this.login = login;
            this.pass = pass;
            authAttempts = 3;
        }
        string Login
        {
            set
            {
                login = value;
            }
            get
            {
                return login;
            }
        }
        string Pass
        {
            set
            {
                pass = value;
            }
        }
        public int AuthAttempts
        {
            set
            {
                authAttempts = value;
            }
        }
        string Path
        {
            get
            {
                return "loginpass.txt";
            }
        }
        /// <summary>
        /// Попытка авторизации, используя базу данных "array"
        /// </summary>
        public void AuthThroughArr()
        {
            bool result;
            do
            {
                Account user = UI_Auth.GetAuthFromConsole();
                login = user.login;
                pass = user.pass;
                result = CheckAuthFromArr();
                UI_Auth.SendAuthResult(result, authAttempts, login);
            } while (authAttempts > 0 && !result);
        }
        /// <summary>
        /// Попытка авторизации, используя базу данных "dictionary"
        /// </summary>
        public void AuthThroughDic()
        {
            bool result;
            do
            {
                Account user = UI_Auth.GetAuthFromConsole();
                login = user.login;
                pass = user.pass;
                result = CheckAuthFromDic();
                UI_Auth.SendAuthResult(result, authAttempts, login);
            } while (authAttempts > 0 && !result);
        }
        /// <summary>
        /// Считывает файл с логинами-паролями в массив массивов
        /// </summary>
        /// <returns>каждый массив массива это пара логин-пароль</returns>
        string[][] GetAccountDBToArr()
        {
            string[][] arr = new string[0][];
            try
            {
                StreamReader stream = new StreamReader(Path);
                while (!stream.EndOfStream)
                {
                    string[] temp = stream.ReadLine().Split(" ");
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = temp;
                }
                stream.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            return arr;
        }
        /// <summary>
        /// Считывает файл с логинами-паролями в словарь
        /// </summary>
        /// <returns>каждая пара ключ-значение это логин-пароль</returns>
        Dictionary<string, string> GetAccountDBToDic()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            try
            {
                StreamReader stream = new StreamReader(Path);
                while (!stream.EndOfStream)
                {
                    string[] temp = stream.ReadLine().Split(" ");
                    dic.Add(temp[0], temp[1]);
                }
                stream.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            return dic;
        }
        /// <summary>
        /// Проверка введенного логина-пароля с базой (массив массивов)
        /// </summary>
        /// <returns>true если успех</returns>
        public bool CheckAuthFromArr()
        {
            string[][] dataBase = GetAccountDBToArr();
            for (int i = 0; i < dataBase.Length; i++)
            {
                if (login == dataBase[i][0] && pass == dataBase[i][1])
                    return true;
            }
            authAttempts--;
            return false;
        }
        /// <summary>
        /// Проверка введенного логина-пароля с базой (словарь)
        /// </summary>
        /// <returns>true если успех</returns>
        public bool CheckAuthFromDic()
        {
            Dictionary<string, string> dataBase = GetAccountDBToDic();
            string temp;
            bool result = dataBase.TryGetValue(login, out temp) && temp == pass;
            if (!result) 
                authAttempts--;
            return result;
        }
        public void AddNewUser()
        {
            string tempLogin;
            string tempPass;
            bool result;
            do
            {
                tempLogin = UI_Auth.GetNewLogin();
                result = CheckNewLogin(tempLogin);
                UI_Auth.ShowNewLoginResult(result);
            } while (!result);
            login = tempLogin;
            do
            {
                tempPass = UI_Auth.GetNewPass();
                result = CheckNewPass(tempPass);
                UI_Auth.ShowNewPassResult(result);
            } while (!result);
            pass = tempPass;
            //...добавить логику записи нового пользователя в файл...
        }
        /// <summary>
        /// Осуществляет проверку логина на соответствие требованиям
        /// </summary>
        /// <param name="tempLogin">логин для проверки</param>
        /// <returns></returns>
        public bool CheckNewLogin(string tempLogin)
        {
            Regex rg = new Regex("^[a-zA-Z][a-zA-Z0-9]{1,9}$");
            return rg.IsMatch(tempLogin);
            #region Без использования регулярных выражений
            //bool result = false;
            //int charIndex = 0;
            //if (tempLogin.Length <= 10 && tempLogin.Length >= 2)
            //{
            //    if (!char.IsDigit(tempLogin[0]))
            //    {
            //        do
            //        {
            //            if (char.IsDigit(tempLogin[charIndex]) || 
            //                (tempLogin[charIndex] >= 65 && tempLogin[charIndex] <= 90) || 
            //                (tempLogin[charIndex] >= 97 && tempLogin[charIndex] <= 122))
            //            {
            //                result = true;
            //                charIndex++;
            //            }
            //            else
            //            {
            //                result = false;
            //            }
            //        } while (result && charIndex < tempLogin.Length);
            //    }
            //}
            //return result;
            #endregion
        }

        /// <summary>
        /// Осуществляет проверку пароля на соответствие требованиям
        /// </summary>
        /// <param name="tempPass">пароль для проверки</param>
        /// <returns></returns>
        public bool CheckNewPass(string tempPass)
        {
            Regex rg = new Regex("(?=.*[0-9])(?=.*[!?.,@#$%^&*':;`№/_+(){}\"|-])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!?.,@#$%^&*':;`№/_+(){}\"|-]{8,}");
            return rg.IsMatch(tempPass);
        }

    }
}
