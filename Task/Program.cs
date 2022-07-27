/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

string[] array = new string[]  {};

int n = InputNumbers("Введите количество элементов массива: ");
array = new string[n];
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"Введите {i+1} элемент: ");
  array[i] = Console.ReadLine();
}

int maxLength = 3;

int numberOfElements = CheckArray(array, maxLength);

string[] newArray = new string[numberOfElements];

FillNewArray(array, newArray, maxLength);

Console.Write($"{PrintArray(array)} -> {PrintArray(newArray)}");


int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int CheckArray(string[] array, int maxLength)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= maxLength) result++;
  }
  return result;
}

void FillNewArray(string[] array, string[] newArray, int maxLength)
{
  int temp = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= maxLength)
    {
      newArray[temp] = array[i];
      temp++;
    }
  }
}

string PrintArray(string[] array)
{ 
  string result = string.Empty;
  result = "[";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],1}";
    if (i < array.Length - 1) result += ", ";
  }
  result += "]";
  return result;
}
