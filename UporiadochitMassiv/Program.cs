int[] array = {1,22,31,4,5,64,7,8,4};
int n = array.Length;
int find = 4;

int index = 0;

while(index < n)
{
    if(array[index] ==find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
}
