
////////////////////////////////////////////////////////////////////////////////////////////////////////
// Start the C# Basic Fundamentals 
////////////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("Data types in C#");
//Console.WriteLine("Hello, World!");
// string name = Console.ReadLine();
//Console.WriteLine("Your name is {0}", name);
//Console.WriteLine("Built in data types in The C#");
//there are diffrent data type that are built in in the type script 
//s= signed we stor the negative and positive values in this
//Console.WriteLine(int.MinValue);
//Console.WriteLine(int.MaxValue);


////////////////// boolean data types ////////////////////////
// store only the true or false
//int a = 23, b = 56;
//bool c = a > b;
//Console.WriteLine(c);

//float double 
//float f = 23.345f;
//double d = 567.78906655;
//Console.WriteLine(f);
//decimal s = 23.456789098665322344556677m ;

//  string char 
//string a = "Ali hassan";
//char b = '1';
//Console.WriteLine("{0}{1}",a,b);
//Console.WriteLine( a, b);

// escape sequence
// string c = "\"Ali Hassan\"";
// Console.WriteLine(c);

// string d = "\'Ali Hassan\'";
// Console.WriteLine(d);

// verbatim literal
// string x = "D:\\adil\\toturial\\Csharp";
// string x1 = @"D:\adil\toturial\Csharp";
// Console.WriteLine(x1);

// data types conversions 
// implicit
// int a = 23;
// float b = a;
////Console.WriteLine(a);


// explicit
// float d = 23.123f;

//Console.WriteLine(d);
// int f = (int)a;
// Console.WriteLine(f);

// int e = Convert.ToInt16(d);
// Console.WriteLine(e);

// string s = "12";
// int ds = int.Parse(s);
// Console.WriteLine(ds);

// string str = "23ali";
// int num;

//if (int.TryParse(str, out num))
//{
//Console.WriteLine(num); // Output: 23
//}
//else
//{
//Console.WriteLine("Unable to convert string to integer.");
//}

//int Add(int a, int b)
//{
//return a + b;
//}

//int num1 = 10;
//int num2 = 20;
//int sum = Add(num1, num2);
//Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
//const string sunrise1= "Ali hassan";
//Console.WriteLine(sunrise1);

//  Constants in c#
//const double PI = 3.24;
//Console.WriteLine("Pi Value:", PI);
//PI = 2.34; this is error 


/////////////////// Date and Time formate specifiers ////////////////////////

// DateTime dt = DateTime.Now;
// Console.WriteLine(dt);
// Console.WriteLine("{0:d}", dt);// short date 
// Console.WriteLine("Long Date {0:D}", dt);
// Console.WriteLine("short time {0:f}", dt);
// Console.WriteLine("long time {0:F}", dt);
// Console.WriteLine("{0:g}", dt);
// Console.WriteLine("{0:d} {1:D}", dt,dt);
//Console.WriteLine("{0:G}", dt);
//Console.WriteLine("{0:m}", dt);
//Console.WriteLine("{0:y}", dt);
//Console.WriteLine("{0:ddd}", dt);
//Console.WriteLine("{0:dddd}", dt);
//Console.WriteLine("{0:ff}", dt);
//Console.WriteLine("{0:hh}", dt);
//Console.WriteLine("{0:HH}", dt);
//Console.WriteLine("{0:ss}", dt);

////////////////////////// operators /////////////////
// Arithmetic → Calculate
//    Comparison → Compare
//    Logical → Combine conditions
// Assignment → Assign/Update
//    ++ / -- → Add/Subtract 1
// Ternary → Short if-else
// statement expresions and operators
//int a = 4;  //statement
//int b = a; //statemnt
//Console.WriteLine(b + 3);  //expression is simple single calculated value
//Console.WriteLine(a > b); // expresions are true and false


//////////////////////// Selection statements =decitions making ////////////////////////////////////////////////
// if else | if else if | nested if | switch case nested switch case
//// if else
//int a = 23, b=45;
//if (a > b)
//{
//Console.WriteLine("a is greater then B");
//}
//else
//{
//Console.WriteLine("B is greater then A");
//}

// Else if 
// if (a < 45)
// {
// Console.WriteLine("A is alpha student");
//}
//else if (a < 66 && a>50)
//{
//Console.WriteLine("A is Super student");

//}
//else if (a >66 && a< 90)
//{
//Console.WriteLine("A is A+ student");

//}
//else
//{
//Console.WriteLine("A is not our Student");
//}

//// Nested if construct

//int age = 22;
//if (age > 18)
//{
//int vote = 18;
//if (age >= age)
//{
//    Console.WriteLine("You are eligible to vote00");
//    bool license = age > 25 && vote >= 18;
//    if (license)
//    {
//        Console.WriteLine("congratulations you have driving licence");

//    }
//    else
//    {
//        Console.WriteLine("you waite 3 more years to get driving licence");

//    }
//}
//}
//*/


//////////////////////// Switch case constructors  ////////////////////////////////////////////////

//int a = 2;
//switch (a)
//{
//case 1:
//    Console.WriteLine("you are happy");
//    break;
//case 2:
//    Console.WriteLine("you are happy2");
//    break;
//case 3:
//    Console.WriteLine("you are happy3");
//    break;
//case 4:
//    Console.WriteLine("you are happy4");
//    break;
//default:
//    Console.WriteLine("please enter right number");
//    break;
//}

////// difficult case


//int totalMarks = 1100;
//int obtainedMarks = 600;
//double average = 0.0;

//switch (totalMarks)
//{
//case 1000:
//    average = (double)obtainedMarks / totalMarks * 100;
//    Console.WriteLine("Average percentage: {0}%", average);
//    break;
//case 1100:
//    average = (double)obtainedMarks / totalMarks * 100;
//    Console.WriteLine("Average percentage: {0}%", average);
//    break;
//case 1200:
//    average = (double)obtainedMarks / totalMarks * 100;
//    Console.WriteLine("Average percentage: {0}%", average);
//    break;
//default:
//    Console.WriteLine("Invalid total marks entered.");
//    break;
//}


//// multiple selectors

//int age = 18;
//switch (age)
//{
//case 15:
//case 16:
//case 17:
//    Console.WriteLine("You are not eligiba to Vote");
//    break;
//case 18:
//case 19:
//case 21:
//    Console.WriteLine("You are are elligible to vote");
//    break;
//case 22:
//case 23:
//case 24:
//    Console.WriteLine("You are on peak time to Vote");
//    break;
//}

//// Nested switch cases
//string pizzaType = "Pepperoni";
//string vegetableType = "Onion";

//switch (pizzaType)
//{
//case "Margherita":
//    Console.WriteLine("You ordered a Margherita pizza.");
//    break;
//case "Pepperoni":
//    Console.WriteLine("You ordered a Pepperoni pizza.");
//    break;
//case "Vegetable":
//    switch (vegetableType)
//    {
//        case "Onion":
//            Console.WriteLine("You ordered a Vegetable pizza with Onion.");
//            break;
//        case "Mushroom":
//            Console.WriteLine("You ordered a Vegetable pizza with Mushroom.");
//            break;
//        case "Tomato":
//            Console.WriteLine("You ordered a Vegetable pizza with Tomato.");
//            break;
//        default:
//            Console.WriteLine("Invalid vegetable type entered.");
//            break;
//    }
//    break;
//default:
//    Console.WriteLine("Invalid pizza type entered.");
//    break;
//}

//////////////////////////// simple marks sheet in the c#  ////////////////////////////////////////////////

//Console.WriteLine("Enter You Name");
//string name=Console.ReadLine();

//Console.WriteLine("Enter Your RollNo");
//string rollno = Console.ReadLine();
//Console.WriteLine("Enter You class");
//string className = Console.ReadLine();
//Console.WriteLine("Enter You gender from male,female,other");
//string gender = Console.ReadLine();
//string selectedgender = gender == "male" ? "Mr" : "Mis" ;
//Console.WriteLine("Wellcome"+ selectedgender+ " "+ name+" "+ "in our LMs");
//Console.WriteLine("We recognized your class is : "+" "+className+" "+ "and your rollNo is : "+rollno+ "if you are "+name+ "enter 'Yes' to quite programe ");
//string option = Console.ReadLine();
//if(option== "yes")
//{
//Console.WriteLine("Wellcome "+ selectedgender + " " + name + "please enter required data to check you result ");
//Console.WriteLine("Enter you physics marks:?");
//int mark1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter you chemistry marks:?");
//int mark12 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter you Math marks:?");
//int mark3 = int.Parse(Console.ReadLine());
//double total_m = 300;
//double percentage = ((mark1 + mark12 + mark3)/total_m)*100;
//Console.WriteLine(percentage);

//float average = (mark1 + mark12 + mark3) / 3;
//char grade='A';
//if(average>50 && average < 60)
//{
//    grade = 'D';

//};
//if (average > 60 && average < 70)
//{
//    grade = 'C';

//};
//if (average > 70 && average < 80)
//{
//    grade = 'B';

//};
//if (average > 80 && average < 90)
//{
//    grade = 'A';

//};

//Console.WriteLine("This is Your Result table");
//Console.WriteLine("Book"+ " | "+ "Total"+ " | "+ "Obtained"+ " | "+ "Average"+ " | "+ "Percentage"+" | "+"Grade");
//Console.WriteLine("physics"+ " | "+ "100"+ " | "+ mark1 + " | "+ "--"+ " | "+ "--"+ " | "+ "--");
//Console.WriteLine("chemistry"+ " | " + "100"+ " | " + mark12+ " | " + "--"+ " | " + "--"+ " | " + "--");
//Console.WriteLine("math"+ " | " + "100"+ " | " + mark3+ " | " + "--"+ " | " + "--"+ " | " + "--");
//Console.WriteLine("All"+ " | " + "300"+ " | " + (mark1+mark12+mark3)+ " | " + average+ " | " + percentage+ " | " + grade);
//}

////////////////////////////////////////     Loops in  C-Sharp ////////////////////////////////////////////////
////// fout types of loops for while do while foreach loop

////// for loop
//Console.WriteLine("Please enter a number to print his table");
//int num = 2;

//for(int i=1; i<=10; i++)
//{
//Console.WriteLine(num+" X " +i+" = "+ num*i);
//}

////second example
////reverse Table
//Console.WriteLine("Reverse Table ");
//for(int i=10; i >= 1; i--)
//{
//Console.WriteLine(num + " X " + i + " = " + num * i);
//}

///// diffrent cases
//for (int i = 0; i < 10;)
//{
//Console.WriteLine("i = {0}", i);
//i += 2; // incrementing i by 2 in the body of the for loop
//}

////// while loop
//int num = 2;
//int i = 1;
//while (i <= 10)
//{
//Console.WriteLine(num + " X " + i + " = " + num * i);
//i++;
//}

////// reverse while loop
//int i1 = 10;
//while (i1 >= 1)
//{
//Console.WriteLine(num + " X " + i1 + " = " + num * i1);
//i1--;
//}*/

////do-While  Loop
//int num = 2;
//int i = 1; // counter variable
//do
//{
//Console.WriteLine(num + " X " + i + " = " + num * i);

//i++;
//} while (i <= 10);

//////////// jump statements = breake ; continue

////// break statements

//for (int i=1; i < 15; i++)
//{
//    if (i >= 12)
//    {
//        Console.WriteLine("Your fees is pending so stuch of");
//        break;
//    }
//    if (i == 4)
//    {
//        Console.WriteLine("Fees not paid");
//        continue;
//    }
//    if (i == 10)
//    {
//        goto complete;
//    }
//    Console.WriteLine(" complet semester is: " +" "+ i+"/15");
//}

//complete:
//Console.WriteLine("You are one step far to complete you graduation");
//Console.WriteLine("The Programe is completed");

//// start program on input
//string confirm;
//do
//{
//    Console.WriteLine("Enter 1st number");
//    int num1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Enter 2nd number");
//    int num2 = int.Parse(Console.ReadLine());
//    double sum = num1 + num2;
//    Console.WriteLine("Sum is = " + sum);
//    Console.WriteLine("would you like to quite program y/n");
//    confirm = Console.ReadLine().ToLower();
//} while (confirm != "y");
//Console.WriteLine("Programe is over");

//////////////////////////////////////// Arrays in c-Sharp ////////////////////////////////////////
//int[] myArr = new int[5];
//myArr[0] = 11;
//myArr[2] = 23;
//myArr[1] = 65;
//myArr[4] = 2345678;//"Ai";// Error
//myArr[3] = 2345;
//Console.WriteLine(myArr[2]);

////// second method of array declaration
//string[] arr = new string[] { "Ali", "Hassan", "Husnain", "Asim", "Abubakar" };
//string[] friends = { "Ahsan", "Waqas", "Mehmood-Ayaz", };
//Console.WriteLine(friends[2]);
//Console.WriteLine(friends[0]);
//Console.WriteLine(friends[1]);
//Console.WriteLine("Arr-------------------------");
//Console.WriteLine(arr[2]);
//arr[2] = "Aslam shehzad bhatti";
//Console.WriteLine(arr[2]);
//Console.WriteLine(arr[0]);*/
//Console.WriteLine(arr.Length);

////// for loop used to print values
//for(int i=0; i<arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

////// forEach loop
//Console.WriteLine("ForEach loop in C#");

//foreach(string s in friends)
//{
//  Console.WriteLine(s);
//}

////// types of arrays
// single dimentions  | multidimentionals arrays
//int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//Console.WriteLine(nums[2]);

////// multi di 2d
////// Rectangular array
//int[,] mdarr = new int[3, 4]
//{
//    {12,13,14,15 },
//    { 23,34,56,78,},
//    {23,54,76,98 }
//};

// int[,] md_arr =
// {
//    {1,2,3,4,5,6 },
//    {2,3,4,5,6,7 },
//    {8,6,5,4,3,2 },
// };
// Console.WriteLine(md_arr.GetLength(0));//rows
// Console.WriteLine(md_arr.GetLength(1));//colums
// Console.WriteLine(md_arr.Rank);

////// for loop at nested arrays
//for (int i = 0; i < md_arr.GetLength(0); i++)
//{
//    Console.WriteLine("Outer iteration " + i);
//    for (int j=0; j<md_arr.GetLength(1); j++)
//    {
//        Console.WriteLine("inner iteration " +j);
//        Console.WriteLine(md_arr[i,j]);
//    }
//}
//Console.WriteLine(md_arr[1,3]);

////// Array Types in c# (b)


//int[,] md_arr =
//{
//    {1,2,3,4,5,6 },
//    {2,3,4,5,6,7 },
//    {8,6,5,4,3,2 },
//};
//foreach(int item in md_arr)
//{
//    Console.WriteLine(item);
//}


////Jagged arrays

//int[][] myArr = new int[3][];
//myArr[0] = new[] {11,22,33,44,55,66,77,67,4567890 };
//myArr[1] = new[] { 90,78,56,45,34,23,12,23,67,890,56,56};
//myArr[2] = new[] { 56, 43,89,23,1234,5678,4556 };
//Console.WriteLine(myArr[0][2]);
//Console.WriteLine(myArr[1][5]);
//Console.WriteLine(myArr[2][4]);



//////////////////////////////////////////  Methods is  C#  //////////////////////////////////////////////////////////////


//int sum(int a, int b)
//{
//    int result = a + b;
//    return result;
//}
//int a = 12, b = 34;
//int sum1 = sum(a, b);
//Console.WriteLine("The sum of {0} and {1} is : {2}", a, b, sum1);

//void message()
//{
//    Console.WriteLine("In new version of c# we can" +
//        " declaire methods" +
//        " and variable with out the class 🤩😍😘🥰 ");
//}
//message();


//////parametrized methods

//int data(int a, int b , int c, int d)
//{
//    return a + b + c + d + 2;
//}

//int s=data(12, 23, 45, 67);
//Console.WriteLine(s);
//string dat(string a, string b)
//{
//    return a +" "+ b;
//}

// string s1 = dat("Ali","Hassan");
// Console.WriteLine(s1);

// (int, double) GetValues()
//{
//    int intValue = 42;
//    double doubleValue = 3.14159;

//    return (intValue, doubleValue);
//}
//var result = GetValues();
//Console.WriteLine(result);

//// defualt parameters

//int df(int age = 22)
//{
//    Console.WriteLine(age );
//    return age
//;
//}
//df();

//void show_name_Age()
//{
//    int age=23;
//    Console.WriteLine("Your age is {0}", age);
//    Console.WriteLine("Your age is =: Ali hassan");
//}
//show_name_Age();


////// names arguments in c#

//int show_name_Age1(string name, int age, string section) // parameters
//{
//    Console.WriteLine("Your age is {0}", age);
//    Console.WriteLine("Your age is =: Ali hassan",name);
//    return age;
//}

////show_name_Age1(age:12,name:"Ali Hassan",section:"BSSE-A");// arguments
//////May or may not return 
//int sum22()
//{
//    return 23;     
//}
//int ad = sum22();


//// Calculator app in c#
//bool quit = false;
//double result = 0.0;

//while (!quit)
//{
//    Console.Write("Enter a math operation (+, -, *, /, clear, quit): ");
//    string op = Console.ReadLine().ToLower();

//    switch (op)
//    {
//        case "+":
//            Console.Write("Enter a number: ");
//            double addend = double.Parse(Console.ReadLine());
//            result += addend;
//            Console.WriteLine("Result: {0}", result);
//            break;

//        case "-":
//            Console.Write("Enter a number: ");
//            double subtrahend = double.Parse(Console.ReadLine());
//            result -= subtrahend;
//            Console.WriteLine("Result: {0}", result);
//            break;

//        case "*":
//            Console.Write("Enter a number: ");
//            double factor = double.Parse(Console.ReadLine());
//            result *= factor;
//            Console.WriteLine("Result: {0}", result);
//            break;

//        case "/":
//            Console.Write("Enter a number: ");
//            double divisor = double.Parse(Console.ReadLine());
//            if (divisor == 0.0)
//            {
//                Console.WriteLine("Error: division by zero");
//            }
//            else
//            {
//                result /= divisor;
//                Console.WriteLine("Result: {0}", result);
//            }
//            break;

//        case "clear":
//            result = 0.0;
//            Console.WriteLine("Result cleared.");
//            break;

//        case "quit":
//            quit = true;
//            break;

//        default:
//            Console.WriteLine("Error: invalid operation");
//            break;
//    }
//}


////// Value types and Reference Types
////  struct = vlau type = stack
////  class = reference type = heap

//struct Employ
//{
//    public int Age { get; set; }
//    public int Salary { get; set; }
//}

//class Program1
//{
//    static void Main(string[] args)
//    {
//        Employ emp1 = new Employ { Age = 25, Salary = 50000 };
//        Employ emp2 = emp1;
//        Employ emp3 = emp1;

//        emp1.Age = 30;

//        Console.WriteLine("Employee 1 Age: {0}", emp1.Age);
//        Console.WriteLine("Employee 2 Age: {0}", emp2.Age);
//        Console.WriteLine("Employee 3 Age: {0}", emp3.Age);
//    }
//}

////////////////////////////////////////// pass by value pass by reference  ////////////////////////////////////////////////
//void passByValue(int a)
//{
//    a = a + 10;
//    Console.WriteLine(a);
//}
//int value = 5;
//passByValue(value);
//Console.WriteLine(value);

//void passByRef(ref int a)
//{
//    a = a + 10;
//    Console.WriteLine(a);
//}
//int value1 = 5;
//passByRef(ref value1);
//Console.WriteLine(value1);

////// passbyout

//void passByout(out int a)
//{
//    a = 10;
//    Console.WriteLine(a);
//}
//int value2=5 ;
//passByout(out value2);
//Console.WriteLine(value2);

////// var and dynamic keywords in c#
////var b = "Ali Hassan";
////Console.WriteLine(b);
////Console.WriteLine(b.ToLower());
////Console.WriteLine(b.GetType());

////////dynamic keywords
//////dynamic a = "Anil Sidhu";
//////Console.WriteLine(a);
//////Console.WriteLine("Ali");
//////a = 23;
//////Console.WriteLine(a);


//////////////////////////////////////////////////////////////////////////////////////
///////  OBject oriented programing in c#
///////  ////////////////////////////////////////////////////////////////////////////

////////////////////////////// Classes and objects //////////////////////////////////////////
//     class Program
//    {
//        // classes has 2 things 
//        //properties | methods called behaviors
//        // Properties 
//        int rollno;
//        string name;
//        int age;
//        int standard;

//        // constructors in c# 
//        public void setall(string name,int age,int standard,int roll)
//        {
//            this.name = name;
//            this.age = age;
//            this.standard =standard ;
//            this.rollno = roll;

//        }
//        public void getall()
//        {
//            Console.WriteLine("Your name is: {0}",this.name);
//            Console.WriteLine("Your age is: {0}", this.age);

//            Console.WriteLine("Your class is: {0}", this.rollno);

//            Console.WriteLine("Your rollNo is: {0}", this.standard);
//        }


//        static void Main(string[] args)
//        {


//            Console.WriteLine("Inshallah i became " +
//                "a programing master");
//            // make object 
//            Program ali = new Program();

//            ali.setall(name:"Ali hassan",age:20,roll:5063,standard:11);
//            ali.getall();
//            // second object
//            Program ali1 = new Program();

//            ali1.setall(name: "Danish Riaz", age: 23, roll: 5061, standard: 12);
//            ali1.getall();

//        }
//    }

//////////////////////////////////  C#   constructors  ////////////////////////////////////////////////////////////
//        class Program
//        {
//            // classes has 2 things 
//            //properties | methods called behaviors
//            // Properties 
//            int rollno;
//            string name;
//            int age;
//            int standard;

//            // constructors in c# 
//            // constructor creation 
//            Program(string name, int age, int standard, int roll)
//            {
//                this.name = name;
//                this.age = age;
//                this.standard = standard;
//                this.rollno = roll;
//                Console.WriteLine("Constructor is called automatically");
//            }

//////////// Constructor Overloading
//            // when we have one or  ore constructors in a class
//            Program(int a,int b)
//            {
//                Console.WriteLine("The sum of {0} and {1} is :",a,b,a+b);
//            }
//            Program()
//            {
//                Console.WriteLine("This is defulat constructor" );

//            }
//            // change  type of parameters
//            Program(string b, int a)
//            {
//                Console.WriteLine("The sum of {0} and {1} is :", a, b, a + b);
//            }

//            public void getall()
//            {
//                Console.WriteLine("Your name is: {0}", this.name);
//                Console.WriteLine("Your age is: {0}", this.age);

//                Console.WriteLine("Your class is: {0}", this.rollno);

//                Console.WriteLine("Your rollNo is: {0}", this.standard);
//            }


//            static void Main(string[] args)
//            {
//                Console.WriteLine("Inshallah i became " +
//                    "a programing master");
//                // make object 
//                Program ali = new Program(name: "Ali hassan", age: 20, roll: 5063, standard: 11);
//                ali.getall();
//                // second object
//                Program danish = new Program();  // run defualt constructor
//                Program ahsan = new Program(12,45);
//                Program adeel = new Program("Adeel",23);
//            }



///////////////////////////////////////////////////////  Static and instance methods variables  ///////////////////////////////////////////////////

//     class Student
//     {
//       public  int name;
//        public double reg_No;
//       public  double cgpa;
//         public int age = 23;
//         // static variable 
//         public static int number;
//         public static int number1;

//         public static string school = "London school of bussiness";
//        public Student(double reg, int age )
//         {
//             this.age = age;
//             this.reg_No = reg
// ;        }        
//        // static Student()
//        // {
//            // number = 12;
//            // number1 = 234567;
//            // Console.WriteLine("The static constructor is called");

//         //}
//         // copy constructor
//         public Student(Student ali)
//         {
//             this.reg_No = ali.cgpa;
//             this.age = ali.age;

//         }

//         // instance methods
//         public void printAge()
//         {
//             Console.WriteLine("You age is {0}", age);
//         }
//         // static methods
//         public static int num()
//         {
//             // we can only used the static variables in c# static methods
//             Console.WriteLine("your school is :{0}",Student.school);
//             return 23456;
//         }
//     }
//     class Program
//     {
//         // instance variables
//         int rollno;
//         string name;
//          int age=123;
//         int standard;
//          //instance  methods
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Inshallah i became " +
//                 "a programing master");
//             // make object 
//             Student ali = new Student(23.4,25);
//             ali.cgpa = 1222.34;
//             Console.WriteLine(ali.cgpa);
//             // second obj
//             Student danish = new Student(ali);
//             // call the instrance method by objectname
//             danish.printAge();
//             // static variable is same for all object
//             // we create form class

//             Console.WriteLine(Student.school) ;
//             string school = Student.school;
//             Console.WriteLine(school);
//             school =Student.school = "Alhamra center";
//             Console.WriteLine(school);
//             Console.WriteLine(Student.school);
//             // static methods
//             int num = Student.num();
//             Console.WriteLine(num);

//             // make new obj and used the previouse obj values through copy constructor

//             Student obj = new Student(ali);
//             Console.WriteLine("New age is"+obj.age);
//         }
//     }


/////////////////////////////////////////////////  Static class in c#   /////////////////////////////////////////// 
////   No object no inherited and only static memebers 

//        static class Friend
//        {
//            public static int age;
//            public static int age1;
//            public static int age3;
//            public static int age2;
//            static Friend()
//            {
//            age= 123;
//                age2 = 345;
//                age3 = 45678;
//                age1 = 4567890;
//            }
//            public static void getAges()
//            {
//                Console.WriteLine("The age 1 is : {0}",age);
//                Console.WriteLine("The age 1 is : {0}", age1);
//                Console.WriteLine("The age 1 is : {0}", age2);
//                Console.WriteLine("The age 1 is : {0}", age3);
//            }
//        }
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("runing successfully");

//                // call the methods of static class
//                Friend.getAges();
//            }
//        }
//    }


///////  # Destructures in c# 
////    ///  // same class name memory dealocations | not overloaded | not inherited | no parameters
//    public class MyClass
//    {
//        private int _value;

//        public int Value
//        {
//            get { return _value; }
//            set { _value = value; }
//        }
//        ~MyClass()
//        {
//            Console.WriteLine("Memory cleared.");
//        }
//    }

//    public class Friend
//    {
//        public  int age;
//        public  int salry;
//         public Friend(int age, int salary)
//        {
//            this.age=age;
//            this.salry = salary;
//        }
//        public void get()
//        {
//            Console.WriteLine("Your age is: {0}",this.age);
//            Console.WriteLine("Your salary is : ",this.salry);
//        }
//        ~Friend()
//        {
//            Console.WriteLine("contruct running all meory is free now");
//        }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("runing successfully");
//            // call the methods of static class
//            Friend pi = new Friend(23,2500);
//            pi.get();
//            MyClass myObj = new MyClass();
//            myObj.Value = 10;
//        }
//    }
//}

/////////////////////////////////////////////////    This Keyword   /////////////////////////////////////
// class Student
// {
//     public string Name;
//     public int Age;
//
//     public void Display()
//     {
//         Console.WriteLine(this.Name);
//         Console.WriteLine(this.Age);
//     }
//     public void Display()
//     {
//        this.ShowName();
//      }
// }

// Student student = new Student();
// student.Name = "Ali";
// student.Age = 25;
// student.Display();


///////////////////////////////////////////////////////////////////////////////////// Inheritance in c#    //////////////////////////////////////////

//    public class Employs
//    {
//        public int EmplId;
//        public string EmpName;
//        public int EmpAge;
//        public int EmpContact;
//        public void show()
//        {
//            Console.WriteLine("This is method of employs class");
//        }
//    }

//    public class Visiting_Employs : Employs
//    {
//        public int visitingSalry;
//        public int workHourse;
//    }

//    public class Permanent_Employs: Employs
//    {
//        public int perSalry;
//        public int workHourse;
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Inheritance is start");
//            // Making object of the Permanent Emloyees
//            Permanent_Employs ali = new Permanent_Employs();
//            ali.EmplId = 12;
//            ali.workHourse = 9;
//            Console.WriteLine(ali.EmplId) ;
//            Visiting_Employs asim = new Visiting_Employs();
//            asim.EmplId = 45;
//            asim.workHourse = 10;
//            Console.WriteLine(asim.EmplId);
//            asim.show(); 
//        }
//    }


////////////////////////////////////////////////
////// Types of Inheritance
////// 4 types of inheritance in  c#     Single | heirarical | multi level | Multiple
////// single inheritance: One class derives from one base class.

//    public class Employs
//    {
//        public int EmplId;
//        public string EmpName;
//        public int EmpAge;
//        public int EmpContact;
//        public void show()
//        {
//            Console.WriteLine("This is method of employs class");
//        }
//    }
//    public class Visiting_Employs : Employs
//    {
//        public int visitingSalry;
//        public int workHourse;
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Inhritance is start Ali You Win Inshallah");
//            // Making object of the Permanent Emloyees
//            Visiting_Employs asim = new Visiting_Employs();
//            asim.EmplId = 45;
//            asim.workHourse = 10;
//            Console.WriteLine(asim.EmplId);
//            asim.show();
//        }
//    }


/////////////////////////////////////////
/////// Heirarical Inheritance : Multiple classes derive from a single base class.

//   public class Employs
//   {
//       public int EmplId;
//   public string EmpName;
//   public int EmpAge;
//   public int EmpContact;
//   public void show()
//   {
//       Console.WriteLine("This is method of employs class");
//   }
//}

//   public class Permanent_Employs : Employs
//   {
//       public int Salry;
//       public int workHourse;
//   }

//   public class Visiting_Employs : Employs
//{
//   public int visitingSalry;
//   public int workHourse;
//}
//   public class M2_Employs : Employs
//   {
//       public int Salry;
//       public int workHourse;
//   }

//   class Program
//{
//   static void Main(string[] args)
//   {
//       Console.WriteLine("Inhritance is start Ali");
//       // Making object of the Permanent Emloyees
//       Visiting_Employs asim = new Visiting_Employs();
//       asim.EmplId = 45;
//       asim.workHourse = 10;
//       Console.WriteLine(asim.EmplId);
//       asim.show();
//   }
//}

/////////////////////////////////////////////////
/////// Multilevel inheritance: A class derives from another derived class.

//        public class Employs
//        {
//            public int EmplId;
//            public string EmpName;
//            public int EmpAge;
//            public int EmpContact;
//            public int s1;
//            public void show()
//            {
//                Console.WriteLine("This is method of employs class");
//            }
//        }

//        public class Permanent_Employs : Employs
//        {
//            public int Salry;
//            public int workHourse;
//            public int s3;
//        }
//        public class Visiting_Employs : Permanent_Employs
//        {
//            public int visitingSalry;
//            public int workHourse;
//        }

//        public class M2_Employs : Visiting_Employs    {
//            public int Salry;
//            public int workHourse;
//        }

//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("Inhritance is start Ali You Win Inshallah");
//                // Making object of the Permanent Emloyees
//                Visiting_Employs asim = new Visiting_Employs();
//                asim.EmplId = 45;
//                asim.workHourse = 10;
//                Console.WriteLine(asim.EmplId);
//                asim.show();
//                Secondclass m34 = new Secondclass();
//                M2_Employs m1 = new M2_Employs();
//                m1.s3 = 1234;
//                Console.WriteLine(m1.s3);
//                m34.secondClassVar = "Yes Ali its posible";
//                Console.WriteLine(m34.secondClassVar);
//            }
//        }

/////////////////////////////////////  Multiple inheritance using interfaces
// Please note that C# does not support multiple inheritance with classes. In C#, we can achieve multiple inheritance
// only through Interfaces. 

//    class person
//    {
//        public void show()
//        {
//            Console.WriteLine("This is the person classs methods");
//        }
//    }
//    interface Teacher
//    {
//        void show();
//    }
//    class student : person, Teacher  // this is error ic case of two base class
//    {
//        void Teacher.show()
//        {
//            Console.WriteLine("This is the explanation of interface methods");
//        }
//    }

//    class Program2
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Ali Never giv up one day success is knock on your door");
//            student n = new student();
//            n.show();
//            Teacher e = new student();
//            e.show();
//        }
//}


///////////////////////////////////////////////////
///////// constructors in inheritance
//      class Baseclass
//      {
//          public Baseclass(string mesg)
//          {
//              Console.WriteLine("This is constructor of Base Class {0}",mesg);
//          }
//      }
//      class DeriveClass: Baseclass
//      {
//       public DeriveClass() :base("Hello Ali How are You")
//          {
//              Console.WriteLine("This is constructor of Derive class");
//          }
//      }
//      class Program
//      {
//          static void Main(string[] args)
//          {
//              //constructors in Inheritance
//              DeriveClass m1 = new DeriveClass();
//          }
//      }

////    ///////////////////////////////////////////////
////    ///// Access Specifiers
//   public private protected internal specifiers
//   Public =  acceess every where in the project
//   private = bydefualt = not access outside the class

//    class ParentClass
//    {
//        public int publicVar = 1;
//        protected int protectedVar = 2;
//    }

//    class DerivedClass : ParentClass
//    {
//        public int Age { get; set; }
//        public int PublicVar { get; set; }
//        public int ProtectedVar { get; set; }

//        public DerivedClass()
//        {
//            PublicVar = base.publicVar;
//            ProtectedVar = base.protectedVar;
//        }
//    }

//   public class Baseclass
//    {
//        public int a=345;
//        public int b;
//        protected int c;
//        public void metho()
//        {
//            Console.WriteLine("This is public method of the base class");
//        }

//        public Baseclass(string mesg)
//        {
//            Console.WriteLine("This is constructor of Base Class {0}", mesg);
//        }
//        protected void SomeMethod()
//        {
//            Console.WriteLine("This is a method of the base class.");
//        }
//    }
//    public class Deiveclass : Baseclass
//    {
//        public int s;
//        public Deiveclass() : base("Hello Ali How are You")
//        {
//            Console.WriteLine("This is constructor of Derive class");
//            s = base.a;//
//        }
//    }

//    class Program2
//    {
//        static void Main(string[] args)
//        {
//            //consructors in Inheritancey
//            Deiveclass m1 = new Deiveclass();
//            DerivedClass instance = new DerivedClass();
//            instance.Age = 30;
//            Console.WriteLine($"Age: {instance.Age}, PublicVar: {instance.PublicVar}, ProtectedVar: {instance.ProtectedVar}");
//        }
//    }


///////////////////////////////////////////////////////////////  Encapsulation    //////////////////////////////////////////////
////// Encapsulations: wrape data | set data | get data   "Hide the internal data and provide controlled access to it."

//    class Person
//    {
//        // Encapsolation
//        //make all them private
//       private  string name;
//        private int age;
//        // methods to set data
//        public void setData(string name, int age)
//        {
//            if (string.IsNullOrEmpty(name) && age>0)
//            {
//                Console.WriteLine("The name is required age must be positive");
//            }
//            else
//            {
//                this.name = name;
//                this.age = age;
//            }
//         // we make methds reads only and write only
//        }
//        public void getData()
//        {
//            Console.WriteLine("You name is : {0}", this.name);
//            Console.WriteLine("your age is {0}",this.age);
//        }
//    }

//     class Program3
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("All About the Encapsolations");
//            // make object
//            Person p1 = new Person();
//            // p1.name = "Ali Hassan";
//            // p1.age = 12;// not eccapsolation
//            p1.setData("Ali Hassan", 21);
//            p1.getData();
//        }
//    }

///////////////////////////////////////// #Properties with get and set
//    class Person
//    {
//        // Properties 
//        // set and get  
//        private string _name;
//        private int _age;
//        private string gender = "Male";
//        public string lastName { get; set; }
//        public string l1 { private get; set; }
//        public string l2 { get; private set; }
//        // static propert
//        private static string uniName;
//        private static string depName;
//        public static string UniProperty
//        {
//            set
//            {
//                uniName = value;
//            }
//            get
//            {
//                return uniName;
//            }
//        }
//        public static string DepProperty { get; set; }
//        public Person()
//        {
//            l2 = "Amjad Sabri";
//        }


//        public string Name
//        {
//            set
//            {
//                if (string.IsNullOrEmpty(value))
//                {
//                    Console.WriteLine("Enter something in name");
//                }
//                else
//                {
//                    this._name = value;
//                }
//            }
//            get
//            {
//                return this._name;
//            }
//        }

     // write only properties
//        public int Age
//        {
//            set
//            {
//                if (value < 0)
//                {
//                    Console.WriteLine("Enter positive value");
//                }
//                else
//                {
//                    this._age = value;
//                }
//            }
//        }

////// read only
//        public string Gender
//        {
//            get
//            {
//                return this.gender;
//            }
//        }
//        //auto implemented
//        // we make methods reads only and write only
//    }

//    class Program3
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("All About the Encapsolations properties");
//            // make object
//            Person p1 = new Person();
//            p1.Name = "Ali Hassan";
//            Console.WriteLine(p1.Name);
//            p1.Age = 21;
//            //  Console.WriteLine(p1.Age);=error
//            // p1.Gender = "Male";// read only not set
//            Console.WriteLine(p1.Gender);
//            p1.lastName = "Hassan";
//            Console.WriteLine(p1.lastName);
//            Console.WriteLine(p1.l2);
//            // static property
//            Person.UniProperty = "University of Okara";
//            Console.WriteLine(Person.UniProperty);
//        }
//    }


////////////////////////////////////////////////////   Polymorphism  //////////////////////////////////////////////
// it means the same method or interface can behave differently depending on the object using it
//namespace Polimorphism
//{
//    // static polymorphism | Compile time Polymorphism
//    // operator overloading | method overloading
//    // many functions with same names
//    class Person
//    {
//        public string str;
//        public int num;
//        // method for operator overloading
//        public static Person operator + (Person obj1,Person obj2)
//        {
//            Person obj3 = new Person();
//            obj3.str = obj1.str +" "+ obj2.str;
//            obj3.num = obj1.num  + obj2.num;
//            return obj3;
//        }
//    }
//    class MyClass
//    {
//        public int value;
//        public MyClass(int val)
//        {
//            value = val;
//        }

//        // Overload the + operator
//        public static MyClass operator +(MyClass obj1, MyClass obj2)
//        {
//            int sum = obj1.value + obj2.value;
//            return new MyClass(sum);
//        }
//    }

//    class Program4
//    {
//     functions overloading
//        public void add()
//        {
//            int a = 20;
//            int b = 34;
//            int c = a + b;
//            Console.WriteLine("The sum is:{0}", c);
//        }
//    //public void add(int a)
//   {
//       int b = 34;
//      int c = a + b;
//   Console.WriteLine("The sum is:{0}", c);
//    }
//    //public void add(string a)
//   {
//      string  c = a;
//      Console.WriteLine("The sum is:{0}", c);
//    }
//    //static void Main(string[] args)
//    //{
//    //    Console.WriteLine("All about Polimorphism");
//    Program4 pi = new Program4();
//    pi.add();
//    pi.add(12);
//    pi.add("Ali Hassan");
//    operator overloading
//    Person obj1 = new Person();
//    obj1.str = "Ali";
//    obj1.num = 23;
//    Person obj2 = new Person();
//    obj2.str = "hassan";
//    obj2.num = 25;
//    Person obj3 = obj1 + obj2;
//    Console.WriteLine(obj3.str+ obj3.num);
//    //MyClass obj1 = new MyClass(10);
//    //MyClass obj2 = new MyClass(20);
//    //MyClass obj3 = obj1 + obj2;
//    //Console.WriteLine("obj3.value = {0}", obj3.value);
//}
//}

///////////       Method Hiding  Method hiding means a child class creates a method with the same name as a method in the parent class,
// and the child method hides the parent method.

//     class MyClass
//  {
//    public void show()
//     {
//         Console.WriteLine("this is parent class method");
//     }
//    }
//     class MyClass1: MyClass
//   {
//     public new void show()
//     {
//         base.show();
//         Console.WriteLine("this is child class method");
//     }
//   }

// class Program4
// {
//     static void Main(string[] args)
//     {
//          MyClass1 obj1 = new MyClass1();
//         obj1.show();
//         MyClass p = new MyClass1();// run parent method

//         ((MyClass)obj1).show();
//         p.show();
//         // Output: obj3.value = 30
//     }
// }

//////// Another example of method hiding
//     class Employ
//     {
//         public void show()
//         {
//             Console.WriteLine("this is Employ class method");
//         }
//     }

//     class PartTimeEmploy : Employ
//     {
//         public new void show()
//         {
//             // if we want to call parent class method
//             base.show();
//            // Console.WriteLine("this is PartTimeEmploy class method");
//         }
//     }
//     class FullTimeEmploy : Employ
//     {
//         public new void show()
//         {
//             Console.WriteLine("this is FullTimeEmploy class method");
//         }
//     }


//     class Program4
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Ali try try again");
//             PartTimeEmploy PTE = new PartTimeEmploy();
//             PTE.show();

//         }
//     }


/////////////// Runtime Polymorphism (Method Overriding)
     // Runtime polymorphism (dynamic polymorphism) in C# is achieved through method overriding. It occurs when a derived class provides a specific implementation of a method already defined in the base class, using the same method name, parameters, and return type.
     // This allows the derived class to modify or extend the behavior of the inherited method.
     //     Key Points:
     // Virtual Method: The base class method must be declared as virtual to allow overriding.
     //     Override Keyword: The derived class method must use the override keyword to provide a new implementation.

//   class Employ
//   {
//       public  virtual void show()
//       {
//           Console.WriteLine("this is Employ class method");
//       }
//   }
//  class PartTimeEmploy : Employ
//   {
//      public  void show()
//      {
//         // if we want to call parent class method
//         base.show();
//        // Console.WriteLine("this is PartTimeEmploy class method");
//     }
//   }
//   class FullTimeEmploy : Employ
//   {
//       public override  void show()
//       {
//           Console.WriteLine("this is FullTimeEmploy class method");
//       }
//   }


//   class Program4
//   {
//       static void Main(string[] args)
//       {
//           Console.WriteLine("Ali try try again");
//          Employ p = new FullTimeEmploy();
//           p.show();
//       } 
//   }

////////////////////////////// Sealed Class in c#
////    /// prevent inheritance | no child classes
///////// Sealed methods
//    class Employ
//    {
//        public virtual void show()
//        {
//            Console.WriteLine("this is Employ class method");
//        }
//    }

//    class FullTimeEmploy : Employ
//    {
//        public override void show()
//        {
//            Console.WriteLine("this is FullTimeEmploy class method");
//        } 
//    }
//    class PartEmploy : FullTimeEmploy
//    {
//        public sealed override void show() // then method is never ovverrde again
//        {
//            Console.WriteLine("this is PartTimeEmploy class method");
//        }
//    }


//    class Program4
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("All about Sealed class in C#");
//            PartEmploy p = new PartEmploy();
//            p.show();
//        }
//    }

///////////////////////////////  Indexers in c#

//    class Employ
//    {
//        private int[] Ages = new int[4];
//        public int a = 12;
//        public int this[int index]
//        {
//            set
//            {
//                if (index >= 0 && index < Ages.Length)
//                {
//                    if (value > 0)
//                    {
//                        Ages[index] = value;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Please enter positive value");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Invalid Index !!");
//                }
//            }
//            get
//            { /* return the specified index here */
//                return Ages[index];
//            }
//        }
//    }
     
// class Program4
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("All about indexers in C#");
//            Employ p = new Employ();
//            p[0] = 3;
//            Console.WriteLine(p[0]);
//            p[1] = -3;
//            p[4] = 5;
//            Console.WriteLine(p.a);
//        }
//    }



////////////////////////////// Delegates: A delegate is a type-safe reference to a method.

//namespace Delegates
//{
//    // Delegates in C#
//    // Delegates are hold reference of methods
//    // we can call a method by its Reference
//    // reference type delegates are

//    public delegate void Calc(int a, int b);
//    // single casr delegate
//    public delegate void Singledel();
//    public class Program5
//        {
//            public static void single()
//            {
//                Console.WriteLine("This function is called by single delegate");
//            } 
//            public static void addition(int a, int b)
//            {
//                Console.WriteLine("The A is : {0} and b is :{1}",a,b);
//            }
//            // subtraction
//            public static void sub(int a, int b)
//            {
//                Console.WriteLine("The A is : {0} and b is :{1}", a, b);

//            }
//            // mul
//            public static void mul(int a, int b)
//            {
//                Console.WriteLine("The A is : {0} and b is :{1}", a, b);

//            }
//            static void Main(string[] args)
//            {
//                Console.WriteLine("Ali Delegates Finish Today ");
//                Calc obj = new Calc(Program5.addition);
//                obj.Invoke(12, 34);
//                obj = sub;
//                obj(12, 56);
//                obj = mul;
//                obj(90, 78);
//                // its called only the single functions
//                Singledel p = new Singledel(Program5.single);
//                p();       }
//        }*/
//    /////////////////////////////////////////////////
//    ///  Types of Delegates     

//    //  multiple delegates

//    public delegate void Calc(int a, int b);
//    public delegate void def();
//    // multicast delegates
//    public delegate void Mcasr(int a, int b);

//    public class Program5
//    {
//        public static void single()
//        {
//            Console.WriteLine("This function is called by single delegate");
//        }
//        // 3 parameter func
//        public static void add(int a, int b, string c)
//        {
//            Console.WriteLine("The A is : {0} and b is :{1}={2}", a, b, c);
//        }
//        public static void addition(int a, int b)
//        {
//            int c = a + b;
//            Console.WriteLine("The sum is :{0} ", c);

//        }
//        // subtraction
//        public static void sub(int a, int b)
//        {
//            int c = a - b;
//            Console.WriteLine("The sub is :{0} ", c);
//        }
//        // mul
//        public static void mul(int a, int b)
//        {
//            int c = a * b;
//            Console.WriteLine("The Mul is :{0} ", c);


//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Ali Delegates Finish Today ");
//            //Calc obj = new Calc(Program5.addition);
//            //obj(45, 78);
//            // without parameter function delegate

//            //def p = new def(single);
//            //p();

//            // multicast delegates objects
//            Calc obj = new Calc(Program5.addition);
//            obj += sub;
//            obj += mul;
//            obj(45, 67);
//        }
//    }
//}


/////////////////////////////////////// Anonymous Function in C#

//namespace AnounimouseFunction
//{
//        public delegate void Calc(int a, int b);
//        public delegate int Recalc(int a, int b);
//        public class Program6
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("All about Anounimouse Functions");
//                Calc obj = delegate (int a, int b)
//                {
//                    a = a + b;
//                    Console.WriteLine("The sum is : {0}", a);
//                };
//                obj(12, 45);
//                Recalc p = delegate (int a, int b)
//                {
//                    a = a + b;
//                    Console.WriteLine("The sum is : {0}", a);
//                    return a;
//                };
//                Console.WriteLine("Return is : {0} ", p(12, 45));
//            }
//        }
// 
////    ///////////////////////////////////////////////    //////////////
//    ///    Lambda expressions

//    public delegate void Calc(int a, int b);
//    public delegate int Cal(int a, int b);
//    public class Program6
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("All about Anounimouse Functions");
//            Calc obj = delegate (int a, int b)
//            {
//                a = a + b;
//                Console.WriteLine("The sum is : {0}", a);
//            };
//            obj(12, 45);
//            //   lambda 
//            Calc lambda = (int a, int b) =>
//            {
//                a = a + b;
//                Console.WriteLine("The lambda functions is ", a);
//            };
//            lambda(12, 45);
//            // expresion lambda
//            Cal explambda = (a, b) => a = a + b;
//            Console.WriteLine(explambda(12, 34));
//        }
//    }
//}

//////////////////////////////////////////// Abstarction in c#   /////////////////////////////////////////////////

///// abstactions = characteristics and behaviors of an object while hiding unnecessary details. 
//namespace _07Abstraction
//{

//        class Employ
//        {
//            public int EmpId;
//            public string EmpName;
//            public double grosPay;
//            public double tex = 0.1;
//            double netsalary;

//            public Employ(int id, string name, double payl)
//            {
//                this.EmpId = id;
//                this.EmpName = name;
//                this.grosPay = payl;
//            }

//             void calculate()
//            {
//                if( grosPay>= 30000)
//                {
//                    netsalary = grosPay-300 ;
//                    Console.WriteLine("You salary is {0}",netsalary);

//                }
//                else
//                {

//                    Console.WriteLine("You salary is {0}", netsalary);

//                }



//            }

//            public void showDetails()
//            {
//                this.calculate();

//            }






//        }
//        public class Program7 
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("Abstractions");
//                Employ ali = new Employ(12,"Ali Hassan",45000);
//                ali.showDetails();

//            }
//        }
//    /////////////////////////////////////////////
//    /// Abstract clas and abstract methods
//    /// no instance   <summary>
//    /// Abstract clas and abstract methods
//    /// </summary>
//    /* abstract class Person
//     {
//          public int age;
//         public string name;
//         public long phone;
//         // abstract Properties
//       //  public abstract int Id { get; set; }
//         public abstract string Name { get; set; }
//         public abstract void show_Detals();
//     }
//     class student: Person
//     {
//         public int roll;
//         public int fees;
//         public override  void show_Detals()
//         {
//             Console.WriteLine("This is the Student class{0}",this.name);
//         }
//         // overide the abstract clas properties 
//         public override string Name {
//             set
//             {
//                 this.name = value;
//             }
//             get
//             {
//                 return this.name;
//             }
//              }
//     }
//     class teacher:Person
//     {
//         public string qualification;
//         public int salery;
//         public override  void show_Detals()
//         {
//             Console.WriteLine("This is the teacher class{0}",this.name);
//         }
//         // override the abstract properties
//         public override string Name
//         {
//             set
//             {
//                 this.name = value;
//             }
//             get
//             {
//                 return this.name;
//             }
//         }
//     }
//     public class Program7
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Abstractions");
//             student ali = new student();
//             ali.name = "Ali Hassan";
//             ali.age = 21;
//             ali.roll = 5063;
//             ali.phone = 03133324617;
//             ali.show_Detals();
//             // teacher class 
//             teacher aslam = new teacher();
//             aslam.name = "Aslam Shehzad";
//             aslam.show_Detals();
//             aslam.Name = "Ali Hassan";
//             Console.WriteLine(aslam.Name); 
//         }
//    }

////    //////////////////////////////////////////
////    /// interfaces  
////    ///  contract b/t interfaces and class 
////    ///  all the properties are abstracted and implemented in child class 
////    //interfaces inheritance

//           interface Employ

//        {
//            void show();
//        }
//        interface  Employ2

//        {
//            void show1();
//        }
//        interface Employ3:Employ,Employ2

//        {
//            void show2();
//        }
//        class InheritedEmploys : Employ3
//        {
//            public void show()
//            {
//                Console.WriteLine("This is the 1  method of Interface");
//            }
//            public void show1()
//            {
//                Console.WriteLine("This is the 2  method of Interface");
//            }
//            public void show2()
//            {
//                Console.WriteLine("This is the  3 method of Interface");
//            }
//        }

//        public class Program7
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("Abstractions");
//                // partime employs class
//                InheritedEmploys p = new InheritedEmploys();
//                p.show();
//                p.show1();
//                p.show2();
//                // we also do that
//                Employ3 p1 = new InheritedEmploys();
//                p1.show1();
//            }
//        }

//    /// Explicit interface types inplementation
//    interface Employ
//    {
//        void show();
//    }
//    interface Employ2

//    {
//        void show();
//    }
//    interface Employ3
//    {
//        void show();
//    }


//    class InheritedEmploys : Employ3, Employ2, Employ
//    {
//        void Employ.show()
//        {
//            Console.WriteLine("This is the Employ1  method of Interface");
//        }
//        void Employ2.show()
//        {
//            Console.WriteLine("This is the Employ2  method of Interface");
//        }
//        void Employ3.show()
//        {
//            Console.WriteLine("This is the Employ3  method of Interface");
//        }
//    }

//    public class Program7
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Abstractions");
//            // partime employs class
//            InheritedEmploys p = new InheritedEmploys();
//            ((Employ)p).show();
//            ((Employ3)p).show();
//            ((Employ2)p).show();
//        }
//    }
//}



///////////////////////////////////////////////// Generics and Generics methods 
//namespace _08_Generics
//{
//    /// Generics are used to make functions class which accept all kinds of data
//    /*class Example
//       {
//         public static void show<T>( T[] arr)
//           {
//               for(int i=0; i<arr.Length; i++)
//               {
//                   Console.WriteLine(arr[i]);
//               }
//           }
//           // overloading avoide by generics
//           public static bool calculate<T>( T a, T b)
//           {
//               bool c = a.Equals(b);
//               return c;
//           }

//       }



//       class Program
//       {
//           static void Main(string[] args)
//           {
//               Console.WriteLine("All About Generics");
//               int[] nums = { 12, 34, 56, 78, 90 };
//               dynamic[] diff = { "Ali", 12, "Amjad Sabri", "Aslam", 12.56 }
//               ;
//               Example.show(nums);
//               string[] names = {  "Ali ","Hassan","Mahindra","Sachil","Grabing","Sundarta" };


//               Example.show(names);
//               Example.show(diff);
//               Console.WriteLine(Example.calculate("Ali", "Ahsan"));
//               Console.WriteLine(Example.calculate(10,10));

//           }
//       }


///////////////////////////////////////////////////////////////////////    Generics in classes

//    /// Generics are used to make functions class which accept
//    /// all kinds of data
//    /* class Example<T>
//     {
//         T box;
//         T age;

//         public  Example(T a)
//         {
//             this.box = a;
//         }
//         public T getBox()
//         {
//             return this.box;
//         }
//         // Generics properties
//         public T Age
//         {
//             set
//             {
//                 this.age = value;
//             }
//             get
//             {
//                 return this.age ;
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Example<int> e = new Example<int>(20);
//             Console.WriteLine(e.getBox());
//             Example<string> e1 = new Example<string>("Ali Hassan");
//             Console.WriteLine(e1.getBox());
//             e.Age = 21;
//             Console.WriteLine(e.Age);
//         }
//     }

///////////////////////////////////////////////////////// Collections in c#
//    // Generics and non Generics

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Collections in C#");
//            int[] arr = new int[4];
//            arr[1] = 17;
//            arr[2] = 11;
//            arr[3] = 14;
//            arr[0] = 189;
//            Array.Resize(ref arr, 8);
//            arr[6] = 112;
//            arr[5] = 124;
//            arr[4] = 1289;
//            Console.WriteLine(arr[6]);

//        }
//    }
//}


/////////////////////////////////////////////////////////     Non-Generic Collections 

//namespace _09_Non_Generics_collections
//{
//    // arraylist collections
//    public class Program
//      {
//          static void Main(string[] args)
//          {
//              ArrayList list = new ArrayList();
//              list.Add(10);
//              list.Add("Ali hassan");
//              list.Add("Amjad Sabri");
//              list.Add(102);
//              list.Add("Ali hassan1");
//              list.Add("Amjad Sabri123");

//              Console.WriteLine("All About Non-Generics Collection");

//              list.Insert(3, "aslam shehzad bhatti");
//              // remove 
//              list.Remove("Ali hassan");
//              foreach (object obj in list)
//              {
//                  Console.WriteLine(obj + " ");

//              }



//          }
//      } 

//    /// <summary>
//    ///   //////////////////////////////////////////////////////
//    /// </summary>
//    //  Hash Table collection in c# 
//    // store data in key values Pairs

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("All About Non-Generics Collection");
//            Hashtable ht = new Hashtable();
//            ht.Add("Id", 121);
//            ht.Add("phone", 03133324617);
//            ht.Add("salery", "25k");
//            ht.Add("name", "Ali Hassan");
//            ht.Add("IsMarried", false);
//            Console.WriteLine(ht["name"]);
//            // second methods
//            Hashtable ht1 = new Hashtable()
//            {
//                {12,"chack No" },
//                 {"name","Ali Hassan" },
//                  {false,"yes its false" },
//                   {"roll",5063 },
//            };
//            Console.WriteLine(ht1[12<5]);
//            Console.WriteLine(ht1[14-2]);
//            // methods of HashTable
//            // ADD | Remove 
//            foreach(object key in ht1.Keys)
//            {
//                Console.WriteLine(key);
//            }
//            foreach (object key in ht1.Values)
//            {
//                Console.WriteLine(key);
//            }
//            foreach (object key in ht1.Keys)
//            {
//                Console.WriteLine(key + ":  " + ht1[key]);
//            }
//            // Remove 
//            ht1.Remove(12);
//            Console.WriteLine("after remove");
//            foreach (object key in ht1.Keys)
//            {
//                Console.WriteLine(key + ":  " + ht1[key]);
//            }
//            // cleare
//            //ht1.Clear(); it clear all the things
//            // contians key 
//            Console.WriteLine (ht1.Contains("name1"));
//            Console.WriteLine(ht1.ContainsValue(5063));
//            // hashcode
//            Console.WriteLine(ht1.Count);
//        }
//    }


/////////////////////////////////////////////////    stack non generic collections 
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("All About Non-Generics Collection");
//            Stack s = new Stack();
//            s.Push("Ali");
//            s.Push("Aslam");
//            s.Push(12);
//            Console.WriteLine(s.Count);
//            Console.WriteLine(s.Peek);
//            Console.WriteLine(s.Contains("Ali"));
//            // s.Clear();//clear all data from stack
//            foreach (object x in s)
//            {
//                Console.WriteLine(x);

//            }  


//        }
//    }


/////////////////////////////////////////////////    Que non generic collections 
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("All About Non-Generics Collection");
//                Queue q = new Queue();
//                q.Enqueue("Ali Hassan");
//                q.Enqueue("Sabar");
//                q.Enqueue(123);
//                Console.WriteLine(q.Dequeue());
//                Console.WriteLine(q.Count);
//                Console.WriteLine(q.Peek);
//                foreach (object item in q)
//                {
//                    Console.WriteLine(item);
//                }
//        }
//    }

/////////////////////////////////////////////// Diffrence betweeen Generics and non Generics
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("All About Non-Generics Collection");
//            int[] arr = new int[4];
//            arr[0] = 2;
//        }
//    }

//}
/////////////////////////////////////////////////////////////////////////////////////////////
///// Generics collections 
///// //////////////////////////////////////////////////////////////////////////////////////
//namespace _10_Gereric_Collections
//{
//    // Generics collection
//    // List Stack , Que ; Dictionary
//    /// <List>
//    /// ///////////////////////////////////////////////////
//    /// used to assign any data type once you give the int then its accept only int
//    /// 
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("All about Generics collections ");
//            /*///////////////////////////////////
//            List<int> li = new List<int>();

//            li.Add(13456);
//            li.Add(12456);
//            li.Add(12);
//            li.Add(1345632190);
//            li.Sort();
//            foreach (int item in li)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine("--------------------------------");
//            List<string> l1 = new List<string>();
//            l1.Add("Ahsan");
//            l1.Add("Adeel ");
//            l1.Add("Ali");
//            l1.Add("Ahmad hassan");
//            Console.WriteLine(l1[1]);
//            // we also give the duplicate values in the list
//            List<string> l2 = new List<string>();
//            l2.Add("Ali hassan");
//            l2.Add("Ali Hassan");
//            l2.Add("Ali Hassan");
//            l2.Add("Ali Hassan");
//            l2.Add("nulain hasan jameel");
//           // l2.Add(null);//

//            l2.Add("Zain ul abdain");
//            l2.Add("halal hassan");
//            l2.Add("bazam hassan");
//          //  l2.AddRange(l2);
//            l2.Sort();
//            l2.Insert(3, "Aslam Ghori");
//            l2.InsertRange(4, l2);
//            Console.WriteLine("--------------------h1");
//            Console.WriteLine(l2[3]);
//            l2.Remove("bazam hassan");
//            l2.RemoveAt(2);
//            l2.RemoveAll(emp => emp == "Ali Hassan");
//          bool c=  l2.Contains("halal hassan");
//            Console.WriteLine(c);
//            bool d = l2.Exists(emp => emp.StartsWith("l"));
//            Console.WriteLine(d);
//            l2.Reverse();
//            l2.IndexOf("Ali Hassan");
//            l2.IndexOf("Ali Hassan",2);
//            l2.LastIndexOf("Ali Hassan");
//            //l2.Clear();
//            string c2=l2.Find(em => em == "halal hassa");
//            Console.WriteLine("Hello "  +c2);
//            string c22 = l2.FindLast(em => em == "halal hassan");
//            Console.WriteLine("Hello " + c22);
//            Console.WriteLine( l2.FindIndex(e => e == "Ali Hassan"));






//            //  l2.RemoveRange(5, 4);// start from index 5 and remove 5 items
//            //  


//            // foreach (string item in l2)
//            //{
//            //    Console.WriteLine(item);
//            */
//            /////////////////////////////////////////////////////
//            ///  Dictionary 
//            Dictionary<string, string> dic = new Dictionary<string, string>();
//            dic.Add("name", "Ali hassan");
//            dic.Add("class", "BSSE-A-Evening");
//            dic.Add("roll", "BSSE-19-5063");
//            Console.WriteLine(dic["name"]);
//            foreach (KeyValuePair<string, string> item in dic)
//            {
//                Console.WriteLine(item.Key);
//            }
//            //
//            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
//            myDictionary.Add("apple", 1);
//            myDictionary.Add("banana", 2);
//            myDictionary.Add("cherry", 3);
//            foreach (KeyValuePair<string, int> kvp in myDictionary)
//            {
//                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
//            }
//            dic.Remove("roll");
//            dic.ContainsKey("name");
//            dic.ContainsValue("BSSE-A-Evening");
//            //dic.Clear()
//            string value;
//            dic.TryGetValue("name", out value);
//            Console.WriteLine(value);
//            dic.Add("wife", null);
//            //dic.Add("name", "Ali hassan"); error exceptions
//        }
//    }
//}
////////////////////////////////////////////////////////////////////////////////////////////////////////
///// Exception Handling in c#
///// /////////////////////////////////////////////////////////////////////////////////////////////////
//namespace _11_Exceptional_Handling
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            /*
//            Console.WriteLine("Exceptional Handling in  c#");
//            Console.WriteLine("Enter number 1");
//            int num1=int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter number 2");
//            int num2 = int.Parse(Console.ReadLine());
//            //////////////////////////
//            /// dive by zeor
//            try
//            {
//                int div = num1 / num2;
//                Console.WriteLine("Divition is :{0}", div);
//            }catch(DivideByZeroException ex)
//            {
//                Console.WriteLine("We can not divide" +
//                    " a number by zero");
//                Console.WriteLine(ex.Message);
//            }
//{ }     

//            Console.WriteLine("lest expressions");
//            Console.WriteLine("lest expressions");
//            Console.WriteLine("lest expressions");
//            Console.WriteLine("lest expressions");
//            ///////////////////////////////////////////
//            /// index out of range
//            int[] arr = new int[3];
//            try
//            {
//                arr[0] = 12;
//                arr[1] = 13;
//                arr[2] = 14;
//                arr[3] = 15;
//                arr[4] = 16; // exeptiones line

//            }
//            catch(IndexOutOfRangeException ex)
//            {
//                Console.WriteLine(ex.Message);
//                Console.WriteLine("Array is out of range ");

//            }

//            // nul reference Expresions
//            string name = "Ali hassan";
//            try
//            {
//                Console.WriteLine(name.Length);
//            }catch(NullReferenceException ex)
//            {
//                Console.WriteLine("Your variable is null ");
//                Console.WriteLine(ex.Message);
//            }
//            // formate exceptions
//            string number = Console.ReadLine();
//            try
//            {
//                int num = int.Parse(number);
//                Console.WriteLine("nymber is {0}", num);
//            }catch(FormatException ex)
//            {
//                Console.WriteLine(ex.Message);
//                Console.WriteLine("string formate is invalid ");
//            }
//            */
//            // Exception class in  
//            /*
//            try
//            {
//                string a = null;
//                Console.WriteLine(a.Length);
//                int c = 12, b = 0;
//                int d = c / b;



//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            catch (NullReferenceException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            catch (IndexOutOfRangeException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            catch (FormatException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            */
//            // try catch with finaly block
//            try
//            {
//                int[] arr = new int[3];
//                arr[3] = 12;
//            }
//            catch (IndexOutOfRangeException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("We done all Work");
//            }

//            // ways  of exceptions
//            // our throw and default catch
//            //Console.WriteLine("Enter your age ");
//            //int age = int.Parse(Console.ReadLine());
//            //if (age > 18)
//            //{
//            //    Console.WriteLine("You eligible to cast vote");
//            //}
//            //else
//            //{
//            //    throw new Exception("you are not eligible to vote");
//            //}
//            // our throw and our catch
//            try
//            {
//                Console.WriteLine("Enter your age ");
//                int age = int.Parse(Console.ReadLine());
//                if (age > 18)
//                {
//                    Console.WriteLine("You eligible to cast vote");
//                }
//                else
//                {
//                    throw new Exception("you are not eligible to vote");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////
///  Partial classes 
///  ////////////////////////////////////////////////////////////////////////////////////////
///   this is the program class in an directory 
//       class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Partial Class in c#");
//        studentPartial obj = new studentPartial();
//        obj.FirstName = "Ali";
//        obj.lastName = "Hassan";
//        obj.getCompleteName();


//    }
//}

////   These are the two classes which on the diffrent directory or in else in the namespace 
////// we create the parcial methods in this class of program class and used this 
///// 
//using System.Text;
///  Partial classes 
///  ////////////////////////////////////////////////////////////////////////////////////////
///   this is the program class in an directory 
/// In C#, partial classes allow you to split the definition of a 
/// //class into multiple files. This can be useful when working with
/// large classes or when different developers are working on different
/// parts of a class simultaneously. 
/// 
// namespace _12_Parial_Classes
// {
//     public partial class studentPartial
//     {
//         private string _firstName;
//         private string _lastName;
//         public string FirstName
//         {
//             set
//             {
//                 this._firstName = value;

//             }
//             get
//             {
//                 return this._firstName;
//             }
//         }
//         public string lastName
//         {
//             set
//             {
//                 this._lastName = value;

//             }
//             get
//             {
//                 return this._lastName;
//             }
//         }

//     }
// }
// // partial class for the student
// namespace _12_Parial_Classes
// {
//     public partial class studentPartial
//     {
//         public void getCompleteName()
//         {
//             Console.WriteLine("The full name is :  {0} {1}", this._firstName, this._lastName);
//         }
//     }
// }
////// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// Params in c#
/// //////////////////////////////////////////////////////////////////////////////////////////////////////////
//public static int Sum(params int[] numbers)
//{
//    int sum = 0;
//    foreach (int num in numbers)
//    {
//        sum += num;
//    }
//    return sum;
//}

//public static void Main(string[] args)
//{
//    int result1 = Sum(1, 2, 3);       // Calling Sum with three arguments
//    int result2 = Sum(4, 5, 6, 7);    // Calling Sum with four arguments

//    Console.WriteLine(result1);      // Output: 6 (1 + 2 + 3)
//    Console.WriteLine(result2);      // Output: 22 (4 + 5 + 6 + 7)
//}
///////////////////////////////////////////////////////////////////////////////////////////////
/// Threads in c#
/// //////////////////////////////////////////////////////////////////////////////////////////
//using System;
//using System.Threading;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Create and start a new thread
//        Thread thread = new Thread(CountNumbers);
//        thread.Start();

//        // Do some work in the main thread
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine("Main thread: " + i);
//            Thread.Sleep(1000); // Pause for 1 second
//        }

//        // Wait for the other thread to complete
//        thread.Join();

//        Console.WriteLine("Main thread finished.");
//    }

//    static void CountNumbers()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine("Secondary thread: " + i);
//            Thread.Sleep(2000); // Pause for 2 seconds
//        }

//        Console.WriteLine("Secondary thread finished.");
//    }
//}

//Example 2
//namespace _14_Threads
//{
//    public class Program
//    {
//        public static void func1()
//        {
//            for (int i = 1; i < 50; i++)
//            {
//                Console.WriteLine("Func1 calls" + i);
//            }
//        }
//        //
//        public static void func2()
//        {
//            for (int i = 1; i < 50; i++)
//            {
//                Console.WriteLine("Func12 calls" + i);
//                if (i == 25)
//                {
//                    Console.WriteLine("thread is on sleep");
//                    Thread.Sleep(8000);
//                }
//            }
//        }
//        //
//        public static void func3()
//        {
//            for (int i = 1; i < 50; i++)
//            {
//                Console.WriteLine("Func3 calls" + i);
//            }
//        }
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Multi threading in c#");
//            /*
//            Thread t = Thread.CurrentThread;
//            t.Name = "Main Thread";

//            Console.WriteLine("Current executing Thread is {0}",t.Name);
//            */
//            Thread t1 = new Thread(func1);
//            Thread t2 = new Thread(func2);
//            Thread t3 = new Thread(func3);
//            t1.Start();
//            t2.Start();
//            t3.Start();
//            //Program.func1();
//            //Program.func2(); 
//            //Program.func3();

//        }
//    }
/////////////////////////////////////////////////////////////////////////////////////////////////
/// String builders 
/// /////////////////////////////////////////////////////////////////////////////////////////////
//namespace _14String_and_StringBuilders
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("String and String Builders");
/*
// Normal string 
string s = "Ali";
Stopwatch sw = new Stopwatch();
sw.Start();
for (int i = 0; i < 100000; i++)
{
    s=s+i;
}
sw.Stop();
*/
// strings are the value based and strings are immutable
// string builder
/*
StringBuilder sb = new StringBuilder("Hello");
Stopwatch sw1 = new Stopwatch();
sw1.Start();
for (int i=0; i<100000; i++)
{
    sb.Append(i);
}
sw1.Stop();
Console.WriteLine("Time taken by string{0}",sw.ElapsedMilliseconds);
Console.WriteLine("Time taken by stringBuilder{0}", sw1.ElapsedMilliseconds);
*/
//            StringBuilder sb = new StringBuilder("Hello");
//            sb.Append("Ali");
//            sb.AppendLine("Hassan");
//            sb.Append("Akram");
//            sb.AppendFormat("{0:C}", 23);
//            sb.AppendFormat("{0:N}", 23);
//            sb.AppendFormat("{0:X}", 23);
//            Console.WriteLine(sb);
//            sb.Insert(4, "MR");
//            sb.Remove(4, 5);
//            sb.Replace("Hello", "Hy");
//            Console.WriteLine(sb);

//        }
//    }
//}
///////////////////////////////////////////////////////////////////////////////////////////////////
/// Extension methods 
/// //////////////////////////////////////////////////////////////////////////////////////////////

//In C#, extension methods allow you to add new
//methods to existing types without modifying their original source code. 
// namespace _15_Extensions_Methods
// {          // Extensions methods in c#
//            // add some methods in the class structs interfaces but in the without 
//            //      // modify deriving  recompiling class an others 

//     class Program
//     {
//         public void Func1()
//         {
//             Console.WriteLine("this is the functions 1");
//         }
//         public void Func2()
//         {
//             Console.WriteLine("this is the functions 2");
//         }
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Extensions Methods");
//         }
//         /// /// // /////////////////////////////////////////////////////////////////////
//     }
// }
/////////////// other class 
///
// namespace _15_Extensions_Methods
// {

//     static class My_staticClass
//     {
//         public static void Func3(this Program p, int i)
//         {
//             Console.WriteLine("This is function  3");

//         }
//         public static bool IsGreaterthen(this int i, int value)
//         {
//             return i > value;

//         }

//         public static void Func2(this Program p)
//         {
//             Console.WriteLine("This is second function");

//         }
//     }
// }
/////////////////  Test extension methods 

////////////////////////////////////////////////////////////////////////////////////////
/// Structures in c#
/// ///////////////////////////////////////////////////////////////////////////////////
// namespace _16_Structures
// {
//     struct Program
//     { 
//         int a;
//         public Program(int i)
//         {
//             this.a = i;
//             Console.WriteLine("Structure in structs" + a);
//         }

//         public void func1()
//         {
//             Console.WriteLine("This is function one");

//         }
//         static void Main(string[] args)
//         {
//             Console.WriteLine("structures in c#");
//             Program p = new Program(12);
//             // also make the object with out new keyword
//             Program p2;
//             p2.a = 12;

//             p.func1();
//             p2.func1();

//         }
//     }

//     interface myinterface
//     {
//         void f();
//     }
//     struct mystrct : myinterface
//     {
//         public void f()
//         {
//             Console.WriteLine("This is the interface" +
//                 " methods implemented in struct");
//         }
//     }
// }
/////////////////////////////////////////////////////////////////////////////////////////////////
/// Guide
/// /////////////////////////////////////////////////////////////////////////////////////////////
//namespace _19_Guide
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Globally unique identifier");
//            Guid g = Guid.NewGuid();
//            //Console.WriteLine(g.ToString().
//            //    Replace("-", string.Empty));
//            // Console.WriteLine(g.ToString("N"));
//            Console.WriteLine(g.ToString("N").Substring(0, 15));
//            Console.WriteLine(g);

//        }
//    }
//}