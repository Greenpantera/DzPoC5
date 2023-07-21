// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double MaxCount(double[]array)
{
    double maxCount=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>maxCount)
        {
            maxCount=array[i];
        }
    }
return maxCount;
}

double MinCount(double[]array)
{
    double minCount=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]<minCount)
        {
           minCount=array[i];
        }
    }
return minCount;
}

double Rasnica(double minCount, double maxCount)
{
double result=maxCount-minCount;
return result;
}


double[] MakeNewArray(int size, int beginValue, int endValue)
{
    double[]array=new double[size];
    for(int i=0; i<size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue); //решила случайными числами заполнить, не поняла из задания так сделать или через Int32.Parse(Console.ReadLine())
        array[i] = array[i]/100;
     }
    return array;
}


double[]array=MakeNewArray(10,-10000,100000);
double max = MaxCount(array);
double min = MinCount(array);
double result = Rasnica(min, max);
Console.WriteLine($"В маcсиве [{string.Join("; ", array)}] максимальное число: {max}, минимальное число: {min}. Разница между ними: {result}");