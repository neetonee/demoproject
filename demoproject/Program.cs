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

            int num, sum = 0, rev = 0;
            Console.WriteLine("Enter a  number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                sum += num % 10;
                rev = rev * 10 + num % 10;
                num /= 10;

            }
            Console.Write($"The sum of digits {sum}");
            Console.WriteLine($"The Rev of digits {rev}");
            int a = 1, b = 0, c;
            do
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;

            } while (c <= 100);

            /*
             1. 1+2+3+4+5+6+7+8+9+10=55
             2. enter a number print it in word   1234 => One Two Three Four
             */
