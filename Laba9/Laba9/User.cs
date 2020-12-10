using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    class User
    {
        public delegate void UserSolution(string message);
        public event UserSolution Move;
        public event UserSolution Compress;
    
      
        public User(int money)
        {
            Money = money;
        }
        public int Money { get; private set; }
        public void rankUp()
        {
            Money += 200;
            RankUp?.Invoke($"Сотрудник повышен. Новая ЗП: {Money}");
        }
        public void fine()
        {
            Money -= 100;
            Fine?.Invoke($"Сотрудник оштрафован. ЗП уменьшена и составляет: {Money}");
        }


        public void vvvod(string strrr)
        {
            if (strrr == null)
            {
                Vvod?.Invoke("Ввод пустой");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(strrr);
                Vvod?.Invoke($"Вы ввели: {strrr}");
            }

        }
    }

}
