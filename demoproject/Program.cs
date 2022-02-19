// See https://aka.ms/new-console-template for more information
//base data type
//float pr, tm, rate,si;
//Console.WriteLine("Enter Principal");
//pr = Convert.ToSingle(Console.ReadLine());
//Console.WriteLine("Enter Rate");
//rate= Convert.ToSingle(Console.ReadLine());
//Console.WriteLine("Enter Time");
//tm = Convert.ToSingle(Console.ReadLine());
//si = (pr * tm * rate) / 100;
//Console.WriteLine($"The Simple Interest of  of {pr} and {rate} and {tm} is {si}");
//int amt;
//double netamt, rd;

//Console.WriteLine("Enter RD  Amount");
//amt = Convert.ToInt32(Console.ReadLine());
//netamt = amt / 5;
//rd = (netamt * 340.27) ;
//Console.WriteLine($"The RD  of {amt}  is {rd}");
// int hrs,newhrs, newhrs1,netpay = 0;

//Console.WriteLine("Enter Working  Hrs");
//hrs = Convert.ToInt32(Console.ReadLine());
//newhrs = hrs %8;
//if (newhrs == 0) { 

//    netpay = 250;
//}else if(newhrs <= 2) { 
//    netpay = 250+ (newhrs*75);
//}else if (newhrs >2 && newhrs <= 4) {
//    newhrs1 = newhrs - 2;
//    netpay = 250 + (2 * 75)+(newhrs1 * 100);
//}else if (newhrs > 4 && newhrs <= 6) {
//    newhrs1 = newhrs - 4;
//    netpay = 250 + (2 * 75) + (2 * 100) + (newhrs1 * 125);
//}

//Console.WriteLine($"The Total wage   of {hrs}  hrs is {netpay}");

//int sum = 0;
//int f = 1;
//for (int i = 1; i <= 5; i++)
//{
//    sum += i;
//    f *= i;
//    Console.Write($"{i}+");
//}
//Console.Write($"\b={sum}");
//Console.Write($"\n The factorial is {f}");

//int num,i;
//Console.WriteLine("Enter a  number");
//num = Convert.ToInt32(Console.ReadLine());

//for(i=2;i<num;i++)
//{
//    if (num % i == 0)
//        break;
//}
//if (i == num)
//    Console.WriteLine($"{num} is prime");
//else
//    Console.WriteLine($"{num} is not prime");

// 1 to 100 all primes nos
// 123 all possible combination 

//-------------------- while 

//int num, sum = 0, rev = 0;
//Console.WriteLine("Enter a  number");
//num = Convert.ToInt32(Console.ReadLine());
//while (num > 0)
//{
//    sum += num % 10;
//    rev = rev * 10 + num % 10;
//    num /= 10;

//}
//Console.Write($"The sum of digits {sum}");
//Console.WriteLine($"The Rev of digits {rev}");
//int a = 1, b = 0, c;
//do
//{
//    c = a + b;
//    Console.WriteLine(c);
//    a = b;
//    b = c;

//} while (c <= 100);


///*********enter a number print it in word   1234 => One Two Three Four***************/
//int n, num = 0;
//Console.WriteLine("Enter a  number");
//n = Convert.ToInt32(Console.ReadLine());
///* Store reverse of n in num */
//while (n != 0)
//{
//    num = (num * 10) + (n % 10);
//    n /= 10;
//}
//while (num != 0)
//{
//    switch (num % 10)
//    {
//        case 0:
//            Console.WriteLine("Zero");
//            break;
//        case 1:
//            Console.WriteLine("One ");
//            break;
//        case 2:
//            Console.WriteLine("Two ");
//            break;
//        case 3:
//            Console.WriteLine("Three ");
//            break;
//        case 4:
//            Console.WriteLine("Four ");
//            break;
//        case 5:
//            Console.WriteLine("Five ");
//            break;
//        case 6:
//            Console.WriteLine("Six ");
//            break;
//        case 7:
//            Console.WriteLine("Seven ");
//            break;
//        case 8:
//            Console.WriteLine("Eight ");
//            break;
//        case 9:
//            Console.WriteLine("Nine ");
//            break;
//    }

//    num = num / 10;
//}
/*********1 to 100 prime numbers***************/
/*int i, a = 1, count;

while (a <= 100)
{
    count = 0;
    i = 2;
    while (i <= a / 2)
    {
        if (a % i == 0)
        {
            count++;
            break;
        }
        i++;
    }
    if (count == 0 && a != 1)
    {
        Console.WriteLine($"{a}");
    }
    a++;
}
*/














/*
 testing
 1. 1+2+3+4+5+6+7+8+9+10=55
 2. enter a number print it in word   1234 => One Two Three Four
 */
