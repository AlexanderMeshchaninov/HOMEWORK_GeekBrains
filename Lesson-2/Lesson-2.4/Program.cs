using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача № 4:
            string bankName = "ПАО Сбербанк";
            string transactionDate = "ДАТА ОПЕРАЦИИ:  ";
            
            //разделитель решил "прогнать" через цикл, чтобы вручную не писать
            string divider = "";
            for (int i = 0; i < 50; i++)
            {
                divider += "-";
            }
            
            string date = DateTime.Now.ToString("dd/MM/yyyy");

            string documentNum = "НОМЕР ДОКУМЕНТА:  ";
            int docNumber = 876410;

            string sender = "ОТПРАВИТЕЛЬ:  ";
            string senderCard = "VISA GOLD:  ****";
            int senderCardNum = 4532;

            string recipient = "ПОЛУЧАТЕЛЬ:  ";
            string recipientCard = "№ КАРТЫ: ****";
            int recipientCardNum = 8454;

            string recipientTelNumber = "НОМЕР ТЕЛЕФОНА ПОЛУЧАТЕЛЯ:  ";
            string tel = "+7 (960) 111-13-13";

            string sumTransaction = "СУММА ОПЕРАЦИИ:  ";
            decimal sum = Convert.ToDecimal(15500.01);
            string currency = " РУБ.";

            string tax = "КОМИССИЯ:  ";
            decimal taxSum = Convert.ToDecimal(1.50);

            string authorizationCode = "КОД АВТОРИЗАЦИИ:  ";
            int authorizCode = 145897;

            string recipientName = "Ф.И.О:  ";
            string recipientNameSurname = "АНАСТАСИЯ ПЕТРОВНА К.";

            //статус операции: если правда, то выполнено
            string status = "";
            bool transactionStatus = true;
            if (transactionStatus == true)
            {
                status = "Операция выполнена";
            }
            else 
            {
                status = "Операция невыполнена";
            }

            Console.WriteLine($"" +
                $"\n{bankName}" +
                $"\n{divider}" +
                $"\n{transactionDate + date}" +
                $"\n{documentNum + docNumber}" +
                $"\n{sender + senderCard + senderCardNum}" +
                $"\n{recipient + recipientCard + recipientCardNum}" +
                $"\n{recipientTelNumber + tel}" +
                $"\n{sumTransaction + sum + currency}" +
                $"\n{tax + taxSum + currency}" +
                $"\n{authorizationCode + authorizCode}" +
                $"\n{recipientName + recipientNameSurname}" +
                $"\n{divider}" +
                $"\n{status}");
            Console.ReadKey();
        }
    }
}
