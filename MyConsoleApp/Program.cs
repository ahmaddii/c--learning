Console.WriteLine("Hello, World!");
Console.WriteLine("Malik Ahmad Rasheed");
Console.WriteLine("The current time is " + DateTime.Now);

Console.WriteLine("This is the first line");
Console.WriteLine("This is the 2nd line");

Console.WriteLine('B'); // char literal
//Console.WriteLine('The code is bug');

Console.WriteLine(1+4); // int literal

// Floating Literals

//float         ~6-9 digits
//double        ~15-17 digits
//decimal        28-29 digits

Console.WriteLine(0.262343252F); //F or f means suffix literal jo ke compiler ko bta rha ha ke mein Float type use karoon

// now for double literal compiler is default for double literal if you would not write the suffix literal it will be double

Console.WriteLine(0.456);

// now for decimal literal we use m Or M

Console.WriteLine(0.12412m); // m kya use the decimal literal 

Console.WriteLine(true);
Console.WriteLine(false); // boolean literals

// variables declartion


string name;

name = "Ahmad";

Console.WriteLine(name);

name = "Ali";



// reassigning a variable

Console.WriteLine(name);

char isPassed = 'H';

Console.WriteLine(isPassed);

var message = "Hello world";

// in c# var is differnt from other lanaguaes in thie lanauage when you declare a var it remains to that type you cant convert it


int total;

bool isPakistani;


string firsName = "Bob";

int messages = 3;

double temp = 34.4;

Console.Write("Hello " + firsName);
Console.Write(" You have " + messages + " messages in your inbox ");
Console.Write("The temp is "+ temp + " Celcius");


// String Formating using Escape Sequences

Console.WriteLine("Hey\nWorld");

Console.WriteLine("Hey\tAhmad");

Console.WriteLine("c:\\home\\path\\bin");

Console.WriteLine("Hey there \"ali\"");

// 2nd type to print output is Console.Write which prints everrything in one line

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.Write(@"c:\invoics");

// verbatim string literal

Console.WriteLine(@"     c:\path\bin(this is where your code goes)");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

Console.WriteLine(@"c:\invoices\app.exe - j");

// unicode escape characters 

// Kon'nichiwa World

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// String Interpolation using string literal and variable

string namE = "Ahmad";
int agE = 20;

string messagE = $"Hello {namE} and my age is {agE}";

Console.WriteLine(messagE);

string projectName = "Baba.js";

Console.WriteLine($@"c:\Home\outputs\{projectName}");

Console.WriteLine();


string projecTname = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English Output: ");
Console.WriteLine();


Console.WriteLine($@" c:\Excercise\{projecTname}\data.txt");
Console.WriteLine();


Console.WriteLine($"{russianMessage}"); 
Console.WriteLine();


Console.WriteLine($@" c:\Exsercise\{projecTname}\ru-RU\data.txt");

int firstNumber = 12;
int secondNumber = 4;

Console.WriteLine(firstNumber + secondNumber);

string firstName = "Ahmad";

int widgetSold = 7;

Console.WriteLine(firsName + (widgetSold + 7) +  " has been Sold");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal divideQuotient = 7.0m/5;

Console.WriteLine($"Decimal Quotioent: {divideQuotient}");

int first = 7;

int Seond = 5;

decimal  Quotient = (decimal)first / (decimal)Seond;

Console.WriteLine(Quotient);

Console.WriteLine($"Modulo of 200 / 5 : {200 % 5}");

// Order of opearstions in c# is based on PEMDAS

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;

Console.WriteLine(value1);// 23
Console.WriteLine(value2); // 35


// Compund Assignment Operaters in C#

int value = 5;

value = value +5;

value += 5;

value++;

value = value - 1;

value -= 5;

value--;

Console.WriteLine(value);

int value3 = 1;

value3++;

Console.WriteLine(value3);
Console.WriteLine($"Second {value3++}");
Console.WriteLine("3rd :" + value3);
Console.WriteLine("Fourth: " + (++value3));

// Challenge

int fahrenheit = 94;

decimal temperature = (fahrenheit - 32) * 5m/9m;

Console.WriteLine($"The Temperature is ${temperature} in Celcius");


Console.Write("Windows " + 1 + 1);
Console.WriteLine();


// Student grade Calculation 

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;


int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahriahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// Just print the output on console


Console.WriteLine("---Student Total Sum score for Assignment---");

Console.WriteLine("Sophia : " + sophiaSum);
Console.WriteLine("Nicolas : " + nicolasSum);
Console.WriteLine("Zahria : " + zahriahSum);
Console.WriteLine("Jeong : " + jeongSum);

Console.WriteLine("--Student Average Score--\n");

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;

decimal nicolasScore = (decimal) nicolasSum / currentAssignments;

decimal zahraScore = (decimal) zahriahSum / currentAssignments;

decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\tGrade\n");

Console.WriteLine($"Id  Name      Score      Grade\n");
Console.WriteLine("#1: Sophia :  \t" + sophiaScore + "\t A");
Console.WriteLine("#2: Nicolas:  \t" + nicolasScore + "\t B");
Console.WriteLine("#3  Zahra  :  \t" + zahraScore + "\t B");
Console.WriteLine("#4: Jeong  :  \t"+  jeongScore + "\t A");