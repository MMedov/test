string[] array1 = new string[5] {"456", "85", "hello", "world", "yes"};
string[] array2 = new string[array1.Length];
void CutToThree(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CutToThree(array1, array2);
ShowArray(array2);