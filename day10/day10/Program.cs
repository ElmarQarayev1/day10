namespace day10;

class Program
{
    static void Main(string[] args)
    {
        // Verilmiş 3 ədədin cəmini tapan method(həm int, həm double ədədlər üçün)
        Console.WriteLine(Sum(4.5,12,34));
        //Verilmiş ədədlər siyahısındaki bütün ədədlərin cəmini tapan method(həm int, həm double ədədlər üçün)
         Console.WriteLine(SumArr(new double[] {5.6,2,3,4}));
        // Verilmiş yazıda veirlmiş charın yerləşdiyi ilk indexi tapan method(yoxdursa - 1 qaytarı)
        Console.WriteLine(FindFirstIndex("elmarmmm",'m'));
        Console.WriteLine(FindLastIndex("elmarqarayev",'e'));
        // Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan method
       Console.WriteLine(FindBiggestDigitInArray(new int[] {91,2,3,4,90}));
       // //Verilmiş ədədin müsbət və cüt olub olmadığını tapan method
        Console.WriteLine(EvenAndPositive(10));
       // //Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərin sayını tapan method
         Console.WriteLine(EvenAndPostiveCountInArray(new int[] {1,2,3,4,5,6,7,8}));

       // //Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərdən ibarət yeni bir array düzəldən method.
        
        int[] arr = new int[] { 1, 2, 3,6,8,12,24 };

        for (int i = 0; i < EvenAndPositiveArray(arr).Length; i++)
        {

            Console.WriteLine(EvenAndPositiveArray(arr)[i]);
        }
        // //Verilmiş ədədlər siyahısından tərsinə düzülmüz yeni bir
        // //array qaytaran method. (misalçün verilən arra { 10,20,30}
        // //olarsa methoddan return olunan array { 30,20,10}
        // //olacaq.

        for (int i = 0; i < ReverseArray(arr).Length; i++)
        {
            Console.WriteLine(ReverseArray(arr)[i]);

        }
         //Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən method
         Console.WriteLine(DeleteSpaceInBegin("      elmarqarayev"));
         //Verilmiş yazıdan sonundaki boşluqlar silinmiş yeni string düzəldən method
         Console.Write(DeleteSpaceInFinal("     elmar qarayev             "));

        Console.ReadLine();

    }
    static int Sum(int a,int b,int c)
    {
        int cem = a + b + c;
        return cem;
    }
    static double Sum(double a, double b, double c)
    {
        double cem = a + b + c;
        return cem;
    }
    static int SumArr(int[] arr)
    {
        int sum=0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

        }
        return sum;
    }
    static double SumArr(double[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

        }
        return sum;
    }
    static int FindFirstIndex(string str,char c)
    {
        for (int i = 0; i <str.Length; i++)
        {
            if (str[i] == c)
            {
                return i;
            }

        }
        return -1;
    }
    static int FindLastIndex(string str, char c)
    {
        for (int i = str.Length-1; i >=0; i--)
        {
            if (str[i] == c)
            {
                return i;
            }

        }
        return -1;
    }
    static int FindBiggestDigitInArray(int[] arr)
    {
        int big = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > big)
            {
                big = arr[i];
            }
        }
        return big;
    }
    static bool EvenAndPositive(int n)
    {
        if(n>0 && n % 2 == 0)
        {
            return true;
        }
        return false;
    }
    static  int EvenAndPostiveCountInArray(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]>0 && arr[i] % 2 == 0)
            {
                count++;
            }   
        }
        return count;
    }
    static int[] EvenAndPositiveArray(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0 && arr[i] % 2 == 0)
            {
                count++;
            }

        }
        int[] arr2 = new int[count];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0 && arr[i] % 2 == 0)
            {
                arr2[index] = arr[i];
                index++;
            }
        }
        return arr2;

    }
    static int[] ReverseArray(int[] arr)
    {
        int say = arr.Length;

        int[] arr2 = new int[say];
        int index = 0;
        for (int i = arr.Length-1; i >=0; i--)
        {
            arr2[index] = arr[i];
            index++;
        }
        return arr2;

    }
    static string  DeleteSpaceInBegin(string str)
    {
        string newArr = "";
        int startIndex = FindStartIndex(str);
        if (startIndex == -1)
        {
            return str; 
        }
        for (int i = startIndex; i < str.Length; i++)
        {
            newArr += str[i];
        }

        return newArr;

    }
    static int FindStartIndex(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
            {
                return i;
            }

        }
        return -1;
    }
    static string DeleteSpaceInFinal(string str)
    {
        string newArr = "";
        int finalIndex = FindFinalIndex(str);
        if (finalIndex == -1)
        {
            return str;
        }
        for (int i = 0; i <=finalIndex; i++)
        {
            newArr += str[i];
        }

        return newArr;

    }
    static int FindFinalIndex(string str)
    {
        for (int i = str.Length-1; i >=0; i--)
        {
            if (str[i] != ' ')
            {
                return i;
            }
        }
        return -1;
    }

}

