using HeaderFooter;

Header _header =new();
Footer _footer =new();

_header.DisplayHeader('=',"A1 Strings Demo",100,ConsoleColor.Red);
string userName = "John";

string userAddress = @"
Flat No: 102, 1st Floor
Sai Residency
Kondapur
Hyderabad 500084
";
string  emptystring =string.Empty;
string emptystring2 = "";
string whitespacestring =" ";
string nullstring = null;
string uninitializedstring;


WriteLine($"Welcome {userName} !");
WriteLine($"Your address is: {userAddress}");
WriteLine($"Your office address is: {officeAddress}");
WriteLine($"Empty string: {emptyString}");
WriteLine($"Empty String 2: {emptyString2}");
WriteLine($"White Space String: {whitespacestring}");
WriteLine($"Null string: {nullstring}");

_footer.DisplayFooter('-',100,ConsoleColor.Red);