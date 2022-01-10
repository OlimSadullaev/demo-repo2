using System.Text.RegularExpressions;
using System.Runtime.ConstrainedExecution;
using System;
using System.Linq;

namespace ojpropblems
{
    public static class Solutions
    {
        public static void Problem1()
        {
           Console.WriteLine("222222");
           Console.WriteLine("2    2");
           Console.WriteLine("2    2");
           Console.WriteLine("222222");
        }

        public static void Problem2()
        {
            Console.WriteLine("  A");
            Console.WriteLine(" A A");
            Console.WriteLine("AAAAA");
        }

        public static void Problem3()
        {
            Console.WriteLine("\\    /\\");
            Console.WriteLine(" )  ( ')");
            Console.WriteLine("(  /  )");
            Console.WriteLine(" \\(__)|");

        }

        public static void Problem4()
        {
            Console.WriteLine("|\\_/|");
            Console.WriteLine("|qp| /}");
            Console.WriteLine("( 0 )\"\"\"\\");
            Console.WriteLine("|\"^\"` |");
            Console.WriteLine("||_/=\\\\__|");
        }

        public static void Problem5()
        {
            var numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();
            Console.WriteLine($"Birthday is {numbers[0]:D2}-{numbers[1]:D2}.");
        }

        public static void Problem6()
        {
            var s = int.Parse(Console.ReadLine());

            Console.WriteLine($"{s}{s}{s}{s}{s}{s}");
            Console.WriteLine($"{s}    {s}");
            Console.WriteLine($"{s}    {s}");
            Console.WriteLine($"{s}{s}{s}{s}{s}{s}");
        }

        public static void Problem7()
        {
            var k = int.Parse(Console.ReadLine());

            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            Console.Write($"{k,3}");
            
            k = k % 31 + 1;
            Console.Write($"{k,4}");

            k = k % 31 + 1;
            Console.Write($"{k,4}");
            
            k = k % 31 + 1;
            Console.Write($"{k,4}");
            
            k = k % 31 + 1;
            Console.Write($"{k,4}");
            
            k = k % 31 + 1;
            Console.Write($"{k,4}");

            k = k % 31 + 1;
            Console.WriteLine($"{k,4}");
        }

        public static void Problem8()
        {
            var s = int.Parse(Console.ReadLine());
            for(int a=1; a < 9; a++){
                Console.WriteLine($"{s}*{a}={s*a}");
            }
        }

        public static void Problem9()
        {   
            Console.WriteLine($"1!=1");
            Console.WriteLine($"2!=2");
            Console.WriteLine($"3!=6");
            Console.WriteLine($"4!=24");
            Console.WriteLine($"5!=120");
        }

        public static void Problem10()
        {
            var fib1 = 0;
            var fib2 = 1;
            var fib3 = fib1 + fib2;

            Console.Write($"{fib1} {fib2} {fib3} ");

            fib1 = fib2;
            fib2 = fib3;
            fib3 = fib1 + fib2;
            Console.Write($"{fib3} ");

            fib1 = fib2;
            fib2 = fib3;
            fib3 = fib1 + fib2;
            Console.Write($"{fib3} ");
            
            fib1 = fib2;
            fib2 = fib3;
            fib3 = fib1 + fib2;
            Console.Write($"{fib3} ");
            
            fib1 = fib2;
            fib2 = fib3;
            fib3 = fib1 + fib2;
            Console.Write($"{fib3} ");
            
            fib1 = fib2;
            fib2 = fib3;
            fib3 = fib1 + fib2;
            Console.Write($"{fib3} ");
            
            fib1 = fib2;
            fib2 = fib3;
            fib3 = fib1 + fib2;
            Console.Write($"{fib3} ");
            
            fib1 = fib2;
            fib2 = fib3;
            fib3 = fib1 + fib2;
            Console.Write($"{fib3} ");
        }

        public static void Problem11()
        {
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine($"{c}\n{(char)c}");
        }

        public static void Problem12()
        {
            var s = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

                Console.WriteLine($"Area is {s[0] * s[1]}.");
        }

        public static void Problem13()
        {
            var s = double.Parse(Console.ReadLine());
            var r = double.Parse(Console.ReadLine());
                

                Console.WriteLine($"Area is {r * s:F2}.");
        }

        public static void Problem14()
        {
            var s = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"{Math.Round(s)}");   
        }

        public static void Problem15()
        {
            Console.WriteLine($"{Console.ReadLine().ToUpper()}");
        }

        public static void Problem16()
        {
            Console.WriteLine($"{Console.ReadLine().ToLower()}");
        }

        public static void Problem17()
        {
            var s = int.Parse(Console.ReadLine());

            Console.Write($"{s / 10000}!");
            Console.Write($"{s / 1000 % 10}!");
            Console.Write($"{s / 100 % 10}!");
            Console.Write($"{s / 10 % 10}!");
            Console.WriteLine($"{s  % 10}!");
        }

        public static void Problem18()
        {
            var sec = int.Parse(Console.ReadLine());
            Console.WriteLine($"{sec /3600:D2}:{sec % 3600 /60:D2}:{sec % 60:D2}");
        }

        public static void Problem19()
        {
            var son = int.Parse(Console.ReadLine());

            Console.WriteLine($"{son / 100 % 10}");
        }

        public static void Problem20()
        {
            var pay = int.Parse(Console.ReadLine());
            pay = (int)(Math.Round(pay /1000.0) *1000);
            System.Console.WriteLine($"{pay}");
        }

        public static void Problem21()
        {
            var N = float.Parse(Console.ReadLine());

            var PI = 3.14;

            var radius = N / (2 * PI);
            var S = PI * radius * radius;
            Console.WriteLine(Math.Round(S));
             
        }

        public static void Problem22()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine( N >= 20 && N <= 30 ? "1" :"0");
        }

        public static void Problem23()
        {
            var N = char.Parse(Console.ReadLine());
            if( N >= 'A' && N <= 'Z' || N >= 'a' && N <= 'z')
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }

        public static void Problem24()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine(N % 2 == 0 ? "even" : "odd");
        }

        public static void Problem25()
        {
            var A = Console.ReadLine().Split().Select(int.Parse).ToList();
            var N = A[0];
            var M = A[1];

            if(N > M)
            {
                System.Console.WriteLine(N);
            }
            else
            {
                System.Console.WriteLine(M);
            }        
        }

        public static void Problem26()
        {
            var B = Console.ReadLine().Split().Select(int.Parse).ToList();

            var X = B[0];
            var Y = B[1];

            if(X > Y)
            {
                System.Console.WriteLine(X / Y);
                System.Console.WriteLine(X % Y);
            }
            else
            {
                System.Console.WriteLine(X / Y);
                System.Console.WriteLine(X % Y);
            }
        }

        public static void Problem27()
        {
            var A = Console.ReadLine().Split().Select(int.Parse).ToList();

            var S = A[0]; var M = A[1];
            if(S == 0)
            {
                S = 24;
            }

            var N = S * 60 + M - 45;
            System.Console.WriteLine($"{N / 60} {N % 60}");
        }

        public static void Problem28()
        {
            var N = int.Parse(Console.ReadLine());
            if(N < 0 && N > 39)
            {
                System.Console.WriteLine("tashqarida o'yna");
            }
            else
            {
                System.Console.WriteLine("ichkarida o'yna");
            }
        }

        public static void Problem29()
        {
            var A = Console.ReadLine().Split().Select(int.Parse).ToList();

            var X = A[0];
            var Y = A[1];
            
            if(X * X == Y)
            {
                System.Console.WriteLine($"{X} * {X} = {Y}");
            }
            else if(Y * Y == X)
            {
                System.Console.WriteLine($"{Y} * {Y} = {X}");
            }
            else
            {
                System.Console.WriteLine("none");
            }
        }

        public static void Problem30()
        {
            var A = Console.ReadLine().Split().Select(int.Parse).ToList();

            var a = A[0];
            var b = A[1];
            var c = A[2];

            if(a > c && a >b)
            {
                Console.WriteLine(a);
            }
            else if(b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else if(c > a && c > b)
            {
                Console.WriteLine(c);
            }
        }

        public static void Problem31()
        {
            var A = int.Parse(Console.ReadLine());
            
            if(A % 2 == 0 && A % 3 == 0 && A % 5 == 0)
            {
                System.Console.WriteLine("A");
            }
            else if(A % 2 == 0 && A % 3 == 0)
            {
                System.Console.WriteLine("B");
            }
            else if(A % 2 == 0 && A % 5 == 0)
            {
                System.Console.WriteLine("C");
            }
            else if(A % 3 == 0 && A % 5 == 0)
            {
                System.Console.WriteLine("D");
            }
            else if(A % 2 == 0 || A % 3 == 0 || A % 5 == 0)
            {
                System.Console.WriteLine("E");
            }
            else
            {
                System.Console.WriteLine("N");
            }
        }

        public static void Problem32()
        {
            var N = int.Parse(Console.ReadLine());

            if(DateTime.IsLeapYear(N))
            {
                System.Console.WriteLine("1");
            }
            else
            {
                System.Console.WriteLine("0");
            }
        }

        public static void Problem33()
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());

            if(M == N)
            {
                System.Console.WriteLine("YORVORDIZ");
            }
            else
            {
                if(N < M)
                {
                    System.Console.WriteLine("PASTGA");
                }
                else
                {
                    System.Console.WriteLine("TEPAGA");
                }

                M = int.Parse(Console.ReadLine());

                if(M == N)
                {
                    System.Console.WriteLine("YORVORDIZ");
                }
                else if(M < N)
                {
                    System.Console.WriteLine("TEPAGA");
                }
                else
                {
                    System.Console.WriteLine("PASTGA");
                }
            }
        }

        public static void Problem34()
        {
            var A = char.Parse(Console.ReadLine());

            if(char.IsLower(A))
            {
                System.Console.WriteLine(char.ToUpper(A));
            }
            else if(char.IsUpper(A))
            {
                System.Console.WriteLine(char.ToLower(A));
            }
            else
            {
                System.Console.WriteLine("none");
            }
        }

        public static void Problem35()
        {
            int strike = 0, ball = 0;
            var a = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var b = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if(b[0] == a[0])
            {
                strike++;
            }
            else if(b[0] == a[1] || b[0] == b[2])
            {
                ball++;
            }
            if(b[1] == a[1])
            {
                strike++;
            }
            else if(b[1] == a[0] || b[1] == a[2])
            {
                ball++;
            }
            if(b[2] == a[2])
            {
                strike++;
            }
            else if(b[2] == a[0] || b[2] == a[1])
            {
                ball++;
            }
            System.Console.WriteLine($"{strike}S{ball}B");
        }    
    
        public static void Problem36()
        {
            var number = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            if(number[1] == "+")
            {
                System.Console.WriteLine($"{int.Parse(number[0]) + int.Parse(number[2])}");
            }
            else
            {
                System.Console.WriteLine($"{int.Parse(number[0]) - int.Parse(number[2])}");
            }
        }

        public static void Problem37()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            switch(n){
                case 1: System.Console.WriteLine($"Americano \n{(m - 500) / 500} {(m - 500) % 500 / 100}"); break;
                case 2: System.Console.WriteLine($"Caffe Latte \n{(m - 400) / 500} {(m - 400) % 500 / 100}"); break;
                case 3: System.Console.WriteLine($"Lemon Tea\n {(m - 300) / 500} {(m - 300) % 500 / 100}"); break;
            }
        }

        public static void Problem38()
        {
            var nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string res = new string ("false");
            for(int i = 0; i < 1; i++)
            {
                if(Math.Pow(nums[i], 2) + Math.Pow(nums[i+1], 2) == Math.Pow(nums[i + 2], 2))
                {
                    res = "true";
                }
                else if(Math.Pow(nums[i], 2) + Math.Pow(nums[i + 2], 2) == Math.Pow(nums[i +1], 2))
                {
                    res = "true";
                }
                else if(Math.Pow(nums[i + 1], 2) + Math.Pow(nums[i+2], 2) == Math.Pow(nums[i], 2))
                {
                    res = "true";
                }

                System.Console.WriteLine(res);
            }
        }

        public static void Problem39()
        {
            int n = int.Parse(Console.ReadLine()), sum = 0;
            var nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach(var num in nums)
            {
                sum += (int)Math.Pow(num, 3);
            }
            System.Console.WriteLine(sum);

        }
       
        public static void Problem40()
        {
            long n = long.Parse(Console.ReadLine());

        for (int i = 1; ; i++)
        {
            if (n % i == 0)
            {
                n /= i;
            }
            else
            {
                break;
            }
        }
        if (n == 1)
        {
            System.Console.WriteLine("true");
        }
        else
        {
            System.Console.WriteLine("false");
        }
        }
        
        public static void Problem41()
        {
            long n = long.Parse(Console.ReadLine());
            for(long i=n; ; i++){
                bool tubmi = true;
                for(long j=2; j <= Math.Sqrt(i); j++){
                    if(i % j==0){
                        tubmi = false;
                        break;
                    }
                }

                if(tubmi == true){
                    System.Console.WriteLine(i);
                    break;
                }
            }
        }
        public static void Problem42()
        {
             int x = 0, y = 0; 
            var N = int.Parse(Console.ReadLine()); 
            var steps = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
 
            for(int i = 0; i < N; i++) 
            { 
                switch(i % 4) 
                { 
                    case 0: y += steps[i]; break; 
                    case 1: x += steps[i]; break; 
                    case 2: y -= steps[i]; break; 
                    case 3: x -= steps[i]; break; 
                }  
            } 
             
            Console.WriteLine($"{x} {y}"); 
 
        }

        public static void Problem44()
        {
            long n = long.Parse(Console.ReadLine());
            long f1 = 0, f2 = 1, f3 = f1 + f2;

            for(int i = 2; i < n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            System.Console.WriteLine(f3);
        }
        public static void Problem49()
        {
            int n = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 1; i <= n; i++) 
            { 
                for (int j = 1; j <= (n - i); j++)  
                {     
                Console.Write(" ");   
                } 
                for (int k = 1; k < i * 2; k++)   
                {     
                Console.Write("*");    
                } 
                Console.WriteLine();
            }  
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= (n - i); j++)     
                {
                Console.Write(" ");    
                }     
                for (int k = 1; k < i * 2; k++)  
                {    
                Console.Write("*"); 
                } 
                Console.WriteLine(); 
            } 
            Console.WriteLine();  
        }

        public static void Problem50()
        {
        int n = int.Parse(Console.ReadLine()), count = 0;

        for (int i = 1; i <= n; i++)
        {
            int temp = i;
            while (temp != 0)
            {
                if (temp % 10 == 3)
                {
                    count++;
                }
                temp /= 10;
            }
        }
            System.Console.WriteLine(count);
        }

        public static void Problem51()
        {
            int n = int.Parse(Console.ReadLine()), count = 1;
            for(int i =1; i<=n; i++)
            {
                int space = n - 1;
                while(space-- > 0)
                {
                    System.Console.Write(" ");
                }
                for(int j = 1; j<=i; j++)
                {
                System.Console.Write($"{count++ % 10} ");
                }
                System.Console.WriteLine();
            }
        }

        public static void Problem52()
        {
            int n = int.Parse(Console.ReadLine()), sum = 0;
            while(true)
            {
                sum = 0;
                while(n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                if(sum < 10)
                {
                    System.Console.WriteLine(sum);
                    break;
                }
                n = sum;
            }
        }

        private static int GetNewN(int n)
        {
            int sum = 0, orgN = n;
            while(n != 0){
                sum += n % 10;
                n /= 10;
            }
            int NewN = orgN % 10 * 10 + sum % 10;
            return NewN;
        }
        
        public static void Problem53()
        {
           int n = int.Parse(Console.ReadLine()), count = 0;
           for(int Newn = 0, copyN = n; true; copyN = Newn)
           {
               Newn = GetNewN(copyN);
               count++;
               if(n == Newn)
               {
                   System.Console.WriteLine(count);
                   break;
               }
           }
        }
        
        public static void Problem54()
        {

        }
        
        public static int reverse(int n)
        {
        string str = new string(n.ToString().Reverse().ToArray());

        int rev = int.Parse(str);
        return rev;
        }
        public static void Problem55()
        {
            int n = int.Parse(Console.ReadLine()), count = 0;
            string str = new string(n.ToString().Reverse().ToArray());

            int rev = int.Parse(str);

            while (rev != n)
            {
                count++;
                n += rev;
                rev = reverse(n);
            }
            System.Console.WriteLine($"{count} {rev}");
        }

        public static void Problem61()
        {
            int n = int.Parse(Console.ReadLine());
            string c = Console.ReadLine();
            char[] Arr = c.ToCharArray();
            int z = 0;
            for (int a = 0; a < c.Length; a++)
            {
                if (Arr[a] == 'c' && Arr[a + 1] == 'a' && Arr[a + 2] == 't')
                {
                    z++;
                }
            }
            System.Console.WriteLine(z);
        }

        public static void Problem64()
        {

                var a = char.Parse(Console.ReadLine());
            switch(a)
            {
                case 'a':
                case 'i':
                case 'o':
                case 'u':
                case 'e':
                case 'A':
                case 'I':
                case 'O':
                case 'U':
                case 'E': 
                    System.Console.WriteLine("unli");
                    break;
                default:
                    System.Console.WriteLine("undosh");
                    break;
            }
        }


        
    }
}   
