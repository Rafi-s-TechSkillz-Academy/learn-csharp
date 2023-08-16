using HeaderFooter;
Header _header = new();
Footer _footer = new();
_header.DisplayHeader ('=', "A1 TypeCasting Demo");


int age = 181;
WriteLine($"Type: {age.GetType()} :: Size: {sizeof(int)}  Value:: {age}");

// implicit type casting
decimal salary = age + 5;
WriteLine($"Type: {salary.GetType()} :: Size: {sizeof(decimal)}  Value:: {salary}");

// implicit type casting. Undesired result
age = int.MaxValue;
WriteLine($"Type: {age.GetType()} :: Size: {sizeof(int)}  Value:: {age}");
salary = age + 5;
WriteLine($"Type: {salary.GetType()} :: Size: {sizeof(decimal)}  Value:: {salary}");

// explicit type casting
double newSalary = (double)salary;
WriteLine($"Type: {newSalary.GetType()} :: Size: {sizeof(double)}  Value:: {newSalary}");

_footer.DisplayFooter('-');