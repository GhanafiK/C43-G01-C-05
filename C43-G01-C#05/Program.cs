using System.Globalization;

namespace C43_G01_C_05
{
    internal class Program
    {
        ///public static void printShape(int count,string shape="/*\\")
        ///{
        ///    for (int i = 0; i < count; i++) {
        ///        Console.WriteLine(shape);
        ///    }
        ///}

        //public static void swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        ///public static int sumArray(int[] arr)
        ///{
        ///    int sum = 0;
        ///    arr[0] = 100;
        ///    for (int i = 0; i<arr.Length; i++)
        ///    {
        ///        sum += arr[i];
        ///    }
        ///    return sum;
        ///}
        ///public static int sumArray(ref int[] arr)
        ///{
        /// int sum = 0;
        /// arr[0] = 100;
        ///    for (int i = 0; i < arr.Length; i++)
        ///    {
        /// sum += arr[i];
        ///    }
        ///    return sum;
        ///}
        ///public static int sumArray2(ref int[] arr)
        ///{
        /// int sum = 0;
        /// arr = new int[] { 4, 5, 6 };
        ///    for (int i = 0; i < arr.Length; i++)
        ///    {
        /// sum += arr[i];
        ///    }
        ///    return sum;
        ///}

        //public static void SumAndMul(int x,int y,out int sum,out int mul)
        //{
        //    sum = x + y;
        //    mul = x * y;
        //}
        //public static void SumAndMul2(int x,int y,ref int sum,ref int mul)
        //{
        //    sum = x + y;
        //    mul = x * y;
        //}

        ///public static int sumMyArray(int x, params int[] arr)
        ///{
        ///    int sum = 0;
        ///    for (int i = 0; i < arr.Length; i++)
        ///    {
        ///        sum += arr[i];
        ///    }
        ///    return sum;
        ///}
        
        //public static void SumAndSub1(int x,int y,out int sum,out int sub)
        //{
        //    sum = x+y;
        //    sub = x-y;
        //}

        static void Main(string[] args)
        {
            #region Demo
            #region Casting (Boxing - UnBoxing)

            #region Boxing [Safe Casting]
            //object obj = new object();
            //int x = 1;
            //obj = x;// Boxing casting ==> convert from value type to reference type 
            #endregion

            #region unBoxing [unsafe casting]
            //object obj2=new object();
            //obj2 = 10;
            //int y = (int)obj2;// unBoxing casting ==> convert from reference type to value type
            #endregion


            #endregion

            #region Nullable (value type - reference type)

            #region nullable value type
            ////value type does n't accept null
            //int x = 22;// only accept int numbers
            //int? xx = null;// accept int numbers & null
            //int y;
            //if (xx != null)
            //{
            //    y = (int)xx;// casting
            //}
            //else
            //{
            //    y = 0;
            //}

            ////or
            ////we use second method because it does n't has casting

            //if (xx.HasValue)
            //{
            //    y = xx.Value;
            //}
            //else
            //{
            //    y = 0;
            //}
            #endregion

            #region nullable reference type
            ////reference type accept null but we use nullable with it to remove warning
            //string name = null;//has ==> warning that name can be null
            //string? name1 = null;//nullable ==> no warning ==> use it
            //string name3 = null!;// null forgiveness operator (!) ==> no warning
            #endregion

            #endregion

            #region null propagation operator
            //int [] numbers = null;
            //for (int i = 0; i < numbers?.Length; i++) {//if numbers has elements it will return nummber of elements
            //           // if not it retun null and didn't cause null referenece exception
            //    Console.WriteLine(numbers[i]);
            //}

            //int? x = numbers?.Length;// it can return null so we make x i a nullable type
            ////or using null coalescing operator
            //int y = numbers?.Length ?? 22;//if it return nullit will put 22 in y

            //Employee emp=new Employee();
            //emp.department = new Department();
            //if (emp != null)
            //{
            //    if (emp.department != null)
            //    {
            //        Console.WriteLine(emp.department.name);
            //    }
            //}

            ////OR

            //Console.WriteLine(emp?.department?.name??"Not Found");

            #endregion

            #region Function
            //printShape(15,"<*><*>");//passing by order
            //printShape(15);//pasing by default
            //printShape(shape:"*&*",count:10);//passing by name

            #endregion

            #region value type parameters
            #region passing by value
            //int a = 9;
            //int b = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //swap(a,b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region passing by reference
            //int a = 9;
            //int b = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            #endregion

            #region reference type parameters
            #region passing by value
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(sumArray(numbers));//105
            //Console.WriteLine(numbers[0]);/100
            #endregion

            #region passing by reference
            ///int[] numbers = { 1, 2, 3 };
            ///Console.WriteLine(sumArray(numbers));//105
            ///Console.WriteLine(numbers[0]);100

            //EX02
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(sumArray2(ref numbers));//15
            //Console.WriteLine(numbers[0]);//4
            #endregion
            #endregion

            #region passing by out
            //int summ, mull;
            //SumAndMul(5, 10, out summ, out mull);
            //Console.WriteLine(summ+" "+mull);

            //// we can use passsing by reference in this case
            //int summ2 =0, mull2=0;//we must give initial value to it
            //SumAndMul2(5, 10, ref summ2, ref mull2);
            //Console.WriteLine(summ+" "+mull);


            #endregion

            #region Function - params
            //Console.WriteLine(sumMyArray(10,1,2,3,4,5,6,7,8,9,10));
            #endregion
            #endregion

            #region Assignment

            #region Q1 - value type parameters

            #region passing by value
            //int a = 10, b = 4;
            //Console.WriteLine($"a: {a} , b: {b}");
            //swap(a, b);
            //Console.WriteLine($"a: {a} , b: {b}");
            /*
                when code run it create to each function stack frame which contain parameters of function and 
                local variable inside it , so i create a stack frame to main contain a = 10,b = 4,
                then it call swap function and pass parameters by value so it create a swap stack frame contain x,y,temp,
                function swap make it's process so it temp = 10,x = 4,y = 10 , so it make the swap inside swap stack frame,
                after function finish it process it delete this stake frame and it didn't affected a , b values so a still = 10
                and b still = 4.    
            */


            #endregion

            #region passing by reference
            //int a = 10, b = 4;
            //Console.WriteLine($"a: {a} , b: {b}");
            //swap(ref a,ref b);
            //Console.WriteLine($"a: {a} , b: {b}");

            /*
                when code run it create to each function stack frame which contain parameters of function and 
                local variable inside it , so i create a stack frame to main contain a = 10,b = 4,
                then it call swap function and passing parameters by reference so i pass variable and it's value ,so any change will be
                applied to this variable,so it create a swap stack frame contain temp,and while function make its process
                it rename a to be x and b to be y.function swap make it's process so it temp = 10,x = 4,y = 10 , 
                it make the swap inside main stack frame,after function finish it's process it return a to it's name with new swap value
                so a = 4 and b=10 . 
            */
            #endregion

            #endregion

            #region Q2 - Reference type parameters
            #region passing by value
            //int[] numbers = { 1, 2, 3 }; // it create a reference in stack look at {1,2,3}
            //Console.WriteLine(sumArray(numbers));
            //Console.WriteLine(NumberStyles[0]);//100

            /*
                when code run it create a main stack frame to store local variable (numbers) so it store 4 bytes (numbers) in stack
                to store the address in heap that carry obj {1,2,3} so numbers look at obj {1,2,3},when function sumArray call it 
                store another 4 bytes in stack (arr) to store the address of the same object that (numbers) store so arr and numbers 
                are lokking to the same object {1,2,3} so if any one of (arr) or (numbers)so  when we change in one of them 
                the other one will affected by changes ,so when we make arr[0]=100 , numbers affected by this change and 
                numbers[0] become = 100;
            */
            #endregion

            #region passing by reference
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(sumArray(ref numbers));
            //Console.WriteLine(numbers[0]);

            /*
                when passing value by reference while function making it process it rename array to be arr instead of numbers
                and make changes on it , after it finish it returned to name array to be numbers with new changes so in 
                this case numbers[0] will = 100;
            */

            //ex02
            //Console.WriteLine(sumArray2(ref numbers));
            //Console.WriteLine(numbers[0]);

            /*
                when this code run it create a main stack frame and store local variable (numbers) by store 4 bytes in stack and make it
                looking on obj {1,2,3} , then when passing parameter by reference it change name of numbers to be arr but 
                u make this arr locking to another obj {4,5,6} so after function end its process and return array to its name(numbers)
                numbers will be looking at new obj {4,5,6} and the old object will be unreachable object
            */

            #endregion
            #endregion

            #region Q3
            //int num1, num2;
            //bool flag1, flag2;
            //do {
            //    Console.Write("Enter first number: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out num1);
            //}while (!flag1);
            //do {
            //    Console.Write("Enter second number: ");
            //    flag2= int.TryParse(Console.ReadLine(), out num2);
            //}while (!flag2);
            //Console.Write("give name to be summation name: ");
            //string SumName=Console.ReadLine();
            //Console.Write("give name to be subtraction name: ");
            //string SubName=Console.ReadLine();

            //int summition, subtraction;
            //SumAndSub1(num1, num2, out summition, out subtraction);

            //Console.Clear();
            //Console.WriteLine($"{SumName} = {summition}");
            //Console.WriteLine($"{SubName} = {subtraction}");
            #endregion

            #endregion
        }
    }
}
 