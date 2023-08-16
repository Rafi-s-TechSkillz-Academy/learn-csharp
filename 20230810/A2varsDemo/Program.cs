using HeaderFooter;
Header _header = new();
Footer _footer = new();
_header.DisplayHeader ('=', "A2 Vars Demo");

// See https://aka.ms/new-console-template for more information

// To display the Compiler version and Language version uncomment the below line
// #error version

char grade = 'A';
int age = 18;
string name = "Ram";
double gpa = 3.8;
bool isMale = true;
decimal fees = int.MaxValue + .50m;
long population = 10000000000L;

WriteLine($"Type: {grade.GetType()} :: Size: {sizeof(char)}  Value:: {grade}");
WriteLine($"Type: {age.GetType()} :: Size: {sizeof(int)}  Value:: {age}");
WriteLine($"Type: {name.GetType()} :: Size: N/A  Value:: {name}");
WriteLine($"Type: {gpa.GetType()} :: Size: {sizeof(double)}  Value:: {gpa}");
WriteLine($"Type: {isMale.GetType()} :: Size: {sizeof(bool)}  Value:: {isMale}");
WriteLine($"Type: {fees.GetType()} :: Size: {sizeof(decimal)}  Value:: {fees}");
WriteLine($"Type: {population.GetType()} :: Size: {sizeof(long)}  Value:: {population}");

// Explicit type casting

int newAge = (int)fees;
WriteLine($"Type: {newAge.GetType()} :: Size: {sizeof(int)}  Value:: {newAge}");
// newAge = int.MaxValue + .50m; //Will give runtime Exception (OverflowException)

int.TryParse("18", out int newAge2);
WriteLine($"Type: {newAge2.GetType()} :: Size: {sizeof(int)}  Value:: {newAge2}");

decimal.TryParse("18.5", out decimal newAge3);
WriteLine($"Type: {newAge3.GetType()} :: Size: {sizeof(decimal)}  Value:: {newAge3}");

var newGpa = 3.8;
WriteLine($"Type: {newGpa.GetType()} :: Size: {sizeof(double)}  Value:: {newGpa}");

var newGpa1 = 3.8D;
WriteLine($"Type: {newGpa1.GetType()} :: Size: {sizeof(double)}  Value:: {newGpa1}");

var newGpa2 = 3.8F;
WriteLine($"Type: {newGpa2.GetType()} :: Size: {sizeof(float)}  Value:: {newGpa2}");

var newGpa3 = 3.8M;
WriteLine($"Type: {newGpa3.GetType()} :: Size: {sizeof(decimal)}  Value:: {newGpa3}");

var isManager = true;
WriteLine($"Type: {isManager.GetType()} :: Size: {sizeof(bool)}  Value:: {isManager}");



_footer.DisplayFooter('-');