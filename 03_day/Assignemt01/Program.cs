
// int a = 10 , b = 20, c = 30;

// if(a>b && a>c){
//   Console.WriteLine("A is Largest");
// }
// else if(b>a && b>c){
//   Console.WriteLine("B is Largest");
// }
// else{
//   Console.WriteLine("C is Largest");
// }

// int num = 2;

// switch(num+1){
//   case 1: Console.WriteLine("One");
//   break;
//   case 2: Console.WriteLine("Two");
//   break;
//   case 3: Console.WriteLine("Three");
//   // break;
//   case 4: Console.WriteLine("Four");
//   break;

//   default: Console.WriteLine("Default");
  
  
// }

// int x = 0;
// if (x)
// Console.WriteLine("Hello");
// else
// Console.WriteLine("World");\

//  bool isTrue = false;
//   if (isTrue = true)
//   Console.WriteLine("Yes");
//   else
//   Console.WriteLine("No");


// int a = 5;
// if (a > 0)
// if (a < 10)
// Console.WriteLine("X");
// else if (a > 2)
// Console.WriteLine("Y");
// else
// Console.WriteLine("Z");

// int x = 5, y = 10;
// if (x++ > 5 && y++ < 10)
// Console.WriteLine(x,y);
// else
// Console.WriteLine(x,y);


// double x = 0.1 + 0.2;
// Console.WriteLine($"{x}");

// if (x == 0.3)
// Console.WriteLine("Equal");
// else
// Console.WriteLine("Not Equal");


  // decimal x = 0.1m + 0.2m;
  // Console.WriteLine($"{x}");
  
  // if (x == 0.3m)
  // Console.WriteLine("Equal");


// for (int i = 1; i <= 5; i++)
// {
// Console.Write(i + " ");
// }


// for(int i = 1; i <= 5; i++)
//   {
//   if (i == 3)
//   continue;
//   Console.Write(i + " ");
//   }


// for (int i = 1; i <= 5; i++)
// {
// if (i == 3)
// break;
// Console.Write(i + " ");
// }


// int i = 1;
// while (i <= 3)
// {
// Console.Write(i + " ");
// i++;
// }


// int i = 1;
// while (i > 0)
// {
// Console.Write(i + " ");
// if (i == 3) break;
// i++;
// }


// int i = 5;
// do
// {
// Console.Write(i + " ");
// } while (i < 3);


// for (int i = 1; i <= 3; i++)
// {
// for (int j = 1; j <= 2; j++)
// {
// Console.Write(i + "" + j + " ");
// }
// }


// for (int i = 2; i <= 10; i += 2)
// {
// Console.Write(i + " ");
// }



// int i = 1;
// while (i <= 10)
// {
// Console.Write(i + " ");
// i += 2;
// }


// int fact = 1;
//   for (int i = 1; i <= 4; i++)
//   {
//   fact *= i;
//   }
  // Console.Write(fact);



// int a = 0, b = 1, c;
//   Console.Write(a + " " + b + " ");
//   for (int i = 2; i < 5; i++)
//   {
//     c = a + b;
//     Console.Write(c + " ");
//     a = b;
//     b = c;
//   }


// int i = 1;
// while (i <= 3)
// Console.Write(i++ + " ");


int num = 123, sum = 0;
while (num > 0)
{
sum += num % 10;
num /= 10;
}
Console.Write(sum);