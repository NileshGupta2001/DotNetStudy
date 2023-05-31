// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int CheckBlank(int[] arr)
{
    int j = 0,count=0;
    int[] countarr = new int[arr.Length];
    for( int i=0; i < arr.Length; i++ )
    {
        if (arr[i] ==0)
        {
            count++;
        }
        else
        {
            countarr[j] = count;
            j=j+1;
            count = 0;
        }
    }

    int max = countarr[0];
    for( int i=0; i < countarr.Length; i++ )
    {
        if (max < countarr[i])
        {
            max = countarr[i];
        }
    }
    return max;
}

int n;
//Console.WriteLine("Enter number of arrays: ");
n= int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    int size;
    //Console.WriteLine("Enter size of array "+i+": ");
    size = int.Parse(Console.ReadLine());
    int[] arr=new int[size];
    for(int j = 0; j < size; j++)
    {
        int val;
        //Console.WriteLine("Enter value: ");
        val= int.Parse(Console.ReadLine());
       //val=Console.Read();
        arr[j] = val;
    }
    int res = CheckBlank(arr);

    Console.WriteLine("Largest Blank Space: "+res);
}