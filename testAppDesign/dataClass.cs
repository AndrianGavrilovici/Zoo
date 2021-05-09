using System;
using System.IO;
namespace testAppDesign
{
    class dataClass
    {
        private string[] animals = new string[0];
        private string[] sex = new string[2];
        private int[,] quantity = new int[0, 2];
        private int[] price = new int[0];
        public string[] Animals { get => animals; }
        public string[] Sex { get => sex; }
        public int[,] Quantity { get => quantity; }
        public int[] Price { get => price; set => price = value; }
        public dataClass()
        {
            readInFile();
            sort();
        }
        public void readInFile()
        {
            sort();
            sex[0] = "Male";
            sex[1] = "Female";
            using (StreamReader sr = File.OpenText(@"DummyFile.dll"))
            {
                int _lengthNum = Convert.ToInt32(sr.ReadLine());
                animals = new string[_lengthNum];
                quantity = new int[_lengthNum, 2];
                price = new int[_lengthNum];
                for (int i = 0; i < _lengthNum; i++)
                {
                    animals[i] = sr.ReadLine();
                    quantity[i, 0] = Convert.ToInt32(sr.ReadLine());
                    quantity[i, 1] = Convert.ToInt32(sr.ReadLine());
                    price[i] = Convert.ToInt32(sr.ReadLine());
                }
                sr.Close();
            }
        }
        private void saveInFile(int addNum = 0)
        {
            StreamWriter sr = new StreamWriter(@"DummyFile.dll");
            sr.WriteLine(animals.Length + addNum);
            for (int i = 0; i < animals.Length; i++)
                sr.Write(animals[i] + "\n" + quantity[i, 0] + "\n" + quantity[i, 1] + "\n" + price[i] + "\n");
            sr.Close();
        }
        private void sort()
        {
            for (int i = 0; i < price.Length - 1; i++)
                for (int j = 0; j < price.Length - i - 1; j++)
                    if (price[j] < price[j + 1])
                        sortTemp(j);
        }
        private void sortTemp(int j)
        {
            string animalsTemp = animals[j];
            animals[j] = animals[j + 1];
            animals[j + 1] = animalsTemp;
            int otherTemp = quantity[j, 0];
            quantity[j, 0] = quantity[j + 1, 0];
            quantity[j + 1, 0] = otherTemp;
            otherTemp = quantity[j, 1];
            quantity[j, 1] = quantity[j + 1, 1];
            quantity[j + 1, 1] = otherTemp;
            otherTemp = price[j];
            price[j] = price[j + 1];
            price[j + 1] = otherTemp;
        }
        public void addNewAnimal(string animalSpecify, int quantityMale, int quantityFemale, int priceAnimal, string pass = "return")
        {
            if (!pass.Equals("admin")) return;
            int num = animals.Length + 1;
            saveInFile(1);
            animals = new string[num];
            quantity = new int[num, 2];
            price = new int[num];
            readInFile();
            animals[animals.Length - 1] = animalSpecify;
            quantity[animals.Length - 1, 0] = quantityMale;
            quantity[animals.Length - 1, 1] = quantityFemale;
            price[animals.Length - 1] = priceAnimal;
            saveInFile();
            readInFile();
        }
        public void editAmount(int Male = 0, int Female = 0, int animalNum = 0, string func = "")
        {
            if (func.Equals("add"))
            {
                quantity[animalNum, 0] += Male;
                quantity[animalNum, 1] += Female;
            }
            else if (func.Equals("delete"))
            {
                quantity[animalNum, 0] -= Male;
                quantity[animalNum, 1] -= Female;
            }
            saveInFile();
            readInFile();
        }
        public void editPrice(int newPrice, int animalNum = 0, string pass = "return")
        {
            if (!pass.Equals("admin")) return;
            price[animalNum] = newPrice;
            saveInFile();
            readInFile();
        }
        public void deleteCategory(int _animalNum, int key, string pass = "return")
        {
            if (!pass.Equals("admin")) return;
            switch (key)
            {
                case 1:
                    quantity[_animalNum, 0] = 0;
                    saveInFile();
                    break;
                case 2:
                    quantity[_animalNum, 1] = 0;
                    saveInFile();
                    break;
                case 3:
                    TempAnimals(_animalNum);
                    saveInFile();
                    break;
            }
            readInFile();
        }
        private void TempAnimals(int _animalNum)
        {
            string[] _Animals = new string[animals.Length - 1];
            int[] _Price = new int[price.Length - 1];
            int[,] _Quantity = new int[animals.Length - 1, 2];
            int contour = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                if (i == _animalNum)
                {
                    i++;
                    if (i >= animals.Length) break;
                }
                _Animals[contour] = animals[i];
                _Quantity[contour, 0] = quantity[i, 0];
                _Quantity[contour, 1] = quantity[i, 1];
                _Price[contour] = price[i];
                contour++;
            }
            animals = new string[_Animals.Length];
            price = new int[_Price.Length];
            quantity = new int[_Animals.Length, 2];
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = _Animals[i];
                quantity[i, 0] = _Quantity[i, 0];
                quantity[i, 1] = _Quantity[i, 1];
                price[i] = _Price[i];
            }
        }
        public void deleteAllAnimals(string pass)
        {
            if (!pass.Equals("admin")) return;
            animals = new string[0];
            quantity = new int[0, 2];
            price = new int[0];
            saveInFile();
            readInFile();
        }
    }
    class userData : dataClass
    {
        public bool Verification(string _animal, ref int _animalNum)
        {
            bool _EXIST = true;
            for (int i = 0; i < Animals.Length; i++)
            {
                if (String.Equals(Animals[i], _animal))
                {
                    _animalNum = i;
                    _EXIST = true;
                    break;
                }
                else
                    _EXIST = false;
            }
            return _EXIST;
        }
    }
}