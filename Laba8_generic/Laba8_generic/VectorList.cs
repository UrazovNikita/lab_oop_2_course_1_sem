using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laba8_generic
{
    class VectorList<T> : IGeneric<T> where T : Vector
    {
        public string name { get; private set; }

        public VectorList(string inputName)
        {
            name = inputName;
        }

        private List<T> list = new List<T>();
        public void Add(T obj)
        {
            list.Add(obj);
        }

        public void Delete(T obj)
        {
            list.Remove(obj);
        }
        public void Show()
        {

            foreach (Vector i in list)
            {
                i.PrintVector();

            }
            Console.WriteLine();
            Console.WriteLine();


        }

        public void fileWrite(string path)
        {
            // запись в файл
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                string text;

                foreach (Vector i in list)
                {
                    text = Convert.ToString(i.x) + " " + Convert.ToString(i.y)+"ƒ";


                    // преобразуем строку в байты
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    
                    fstream.Write(array, 0, array.Length);
                   
                }
            }
        }

        public void fileRead(string path)
        {
            // чтение из файла
            using (FileStream fstream = File.OpenRead(path))
            {



                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                int i=0;
                int x = 0;
                while (i < list.Count) {
                    while (x < textFromFile.Length)
                    {
                        if ((Convert.ToString(textFromFile[x])) == "ƒ")
                        {
                            string sym = Convert.ToString(textFromFile[x-3]);
                            list[i].x = Convert.ToInt32(sym);
                            sym = Convert.ToString(textFromFile[x - 1]);
                            list[i].y = Convert.ToInt32(sym);
                            i++;
                        }
                        x++;
                    }
                }
                
                




                  
            }
        }

    }
}
