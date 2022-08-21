int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//               0  1  2  3  4  5 6 7 8
int[] array = {111,12,23,45,56,78,1,0,10};
array[0] =112; // просто заменяем в уже имеющемся массиве элемент с индексом 0 т.е. 111 на 112

//можно функцию убрать во внутрь функции
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);
