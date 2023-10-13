/*
Поиск позиции нужного нам элемента
*/
int[] array = { 100, 29, 33, 42, 55, 16, 71, 18, 42 }; //определяем массив
int n = array.Length; //обявляется переменная n равная количеству элементов массива
int find = 42;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++; //index = index + 1
}