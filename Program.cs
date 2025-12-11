/* Task 1 is done !
string input = Console.ReadLine();
int n = int.Parse(input);
int even = EvenCount(n);
Console.WriteLine($"Even : {even}");
int odd = OddCount(n);
System.Console.WriteLine($"Odd: {odd}");
int zero = ZeroCount(n);
System.Console.WriteLine($"Zeros : {zero}");
int digits = DigitsCount(n);
System.Console.WriteLine($"Digits : {digits}");
int min = MinCount(n);
System.Console.WriteLine($"Min : {min}");
int max = MaxCount(n);
System.Console.WriteLine($"Max : {max}");
int summ = SumDigit(n);
System.Console.WriteLine($"Sum of Digits : {summ}");


int EvenCount(int n)
{
    int count = 0;
    int i = n;
    while(i > 0)
    {
        int digit = i % 10;
        i /= 10;
        if(digit % 2 == 0)
        {
            count++;
        }
        
    }
    return count;
}


int OddCount(int n)
{
    int count = 0;
    int i = n;
    while(i > 0)
    {
        int digit = i % 10;
        i /= 10;
        if(digit % 2 != 0)
        {
          count++;  
        }
    }
    return count;
}

int ZeroCount(int n)
{
    int count = 0;
    int i = n;
    while(i > 0)
    {
        int digit = i % 10;
        i /= 10;
        if(digit == 0)
        {
            count++;
        }
    }
    return count;
}

int DigitsCount(int n)
{
    int count = 0;
    int i = n;
    while(i > 0)
    {
        int digit = i % 10;
        i /= 10;
        count ++;
    }
    return count;
}


int MinCount(int n)
{
    int min = 99;
    int i = n;
    while(i > 0)
    {
        int digit = i % 10;
        i /= 10;
      if(digit < min)
        {
            min = digit;
        }
    }
    return min;
}

int MaxCount(int n)
{
    int max = -99;
    int i = n;
    while(i > 0)
    {
        int digit = i % 10;
        i /= 10;
      if(digit > max)
        {
            max = digit;
        }
    }
    return max;
}

int SumDigit(int n)
{
    int sum = 0;
    int i = n;
    while(i > 0)
    {
        int digit = i % 10;
        i /= 10;
        sum += digit;
    }
    return sum;
}
*/


/* Task 2 is done !
int grade = int.Parse(Console.ReadLine());
char res = CheckGrade(grade);
System.Console.WriteLine(res);

char CheckGrade(int grade)
{
    if(grade >= 90 && grade <= 100)
    {
        return 'A';
    }
    else if(grade >= 80 && grade <= 89)
    {
        return 'B';
    }
    else if(grade >= 70 && grade <= 79)
    {
        return 'C';
    }    
    else if(grade >= 60 && grade <= 69)
    {
        return 'D';
    }
    else
    {
        return 'F';
    }    
}
*/

// int n = int.Parse(Console.ReadLine());
// int neg = 0;
// int pos = 0;
// int zero = 0;
// int even = 0;
// int odd = 0;
// int max = -99;
// int min = 99;
// int sum = 0;

// for(int i = 1; i <= n; i++)
// {
//     int nums = int.Parse(Console.ReadLine());
//     if(nums < 0) neg++;
//     if(nums > 0) pos++;
//     if(nums == 0) zero++;
//     if(nums % 2 == 0)even++;
//     if(nums % 2 == 0)odd++;
//     if(nums > max) max = nums;
//     if(nums < min) min = nums;
//     sum += nums;



// }
// System.Console.WriteLine($"Negative = {neg}");
// System.Console.WriteLine($"Postitve = {pos}");
// System.Console.WriteLine($"Zero = {zero}");
// System.Console.WriteLine($"Even = {even}");
// System.Console.WriteLine($"Odd = {odd}");
// System.Console.WriteLine($"Max = {max}");
// System.Console.WriteLine($"Min = {min}");
// System.Console.WriteLine($"Sum of Digits = {sum}");



/*Task 3 is done !
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

for(int i = 0; i <=arr.Length; i++)
{
    if(i % 2 == 0)
    {
        System.Console.WriteLine(arr[i]);
    }
}
*/
/* Task 4 is done !
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
int cnt = 0;
for(int i = 1; i < arr.Length; i++)
{
   if(i > i - 1)
    {
        cnt++;
    }
}
System.Console.WriteLine(cnt);
*/

/* Task 5 is done !
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
for(int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"{n1}x{i} = " + n1 * i );
    
}
System.Console.WriteLine("----------------------------------------");
for(int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"{n2}x{i} = " + n2 * i );
    
}
*/

/* Task 6 is done !
double n1 = double.Parse(Console.ReadLine());
char op = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());

if(op == '+')
{
    System.Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
}
else if(op == '-')
{
    System.Console.WriteLine($"{n1} - {n2} = {n1 - n2} ");
}
else if(op == '*')
{
    System.Console.WriteLine($"{n1} x {n2} = {n1 * n2} ");
}
else if(op == '/')
{
    System.Console.WriteLine($"{n1} / {n2} = {n1 / n2} ");
}
*/
