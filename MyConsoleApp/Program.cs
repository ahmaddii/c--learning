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
