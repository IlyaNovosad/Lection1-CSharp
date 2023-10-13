/*
Выполняем Example010 только в примере когда берется произвольный массив и заполняется случайными числами
*/
void FillArray(int[] collection){ //создаем метод, который будет заполнять, созданный ранее массив значениями
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().Next(1, 10); //обратиться к аргументу collection на позицию index и положить туда новое случайное число из диапазона от 1 до 10
        index++;
    }
}
void PrintArray(int[] col) {
    int count = col.Length;
    int position = 0;
    while (position < count) {
        Console.WriteLine(col[position]); //выводим на экран значение текущего элемента
        position++;
    }
} //Создаем метод, который будет печатать массив, заполненный случайными числами
int IndexOf(int[] collection, int find) //Создаем метод, который возвращает позицию index, значит тип этого метода определяется как int,
// в качестве аргумента будет приходить массив collection и какой-то элемент find
{
    int count = collection.Length; //определяем количество элементов count
    int index = 0;
    int position = 0;
    while (index < count) {
        if (collection[index] == find) {
            position = index;  
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; // создает новый массив длинной 10, весь массив изначально заполнен "0"

FillArray(array);
PrintArray(array);
Console.WriteLine(); //Печатаем пустую строчку, для того, чтобы быть увернным что не является частью вывода массива
int pos = IndexOf(array, 5); //определим переменную pos и в нее положим результат работы метода IndexOf в качестве аргумента передается массив и ищем 5
Console.WriteLine(pos); //Показываем на экране значение переменной pos после того, как отработает метод

/*
1. В начале мы определили массив из 10 элементов командой int[] array = new int[10];
2. Вызвали метод FillArray(array);, который заполнил массив произвольными значениями от 1 до 10
3. Вызвали метод PrintArray(array);, который распечатал нам данный массив в терминале
*/