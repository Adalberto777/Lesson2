// задается число, программа ищет его индекс в массиве, если оно та есть
int[] array = {1,2,9,4,9,6,7,8,9};

int n = array.Length;
int find = 9;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //обрывает цикл на первом найденном значении
    }
    index++;
}
