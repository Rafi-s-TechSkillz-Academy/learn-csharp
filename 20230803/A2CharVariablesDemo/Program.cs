using HeaderFooter;
Header _header = new();
Footer _footer = new();
_header.DisplayHeader ('=', "A2 Char Variables Demo");

ForegroundColor = ConsoleColor.Green;

WriteLine($"Char: {sizeof(char)} byte(s) of memory. Its Min and Max Values are {(int)char.MinValue} and {(int)char.MaxValue}");


char choice;
choice = 'Y';
WriteLine ($"Char: {choice} {(int)choice}");
choice = 'y';
WriteLine ($"Char: {choice} {(int)choice}");


for(int i = 97 , j=65; i < 123; i++)
{
        Write($"{(char)i} == {i} :: {(char)j} == {j++} || ");
} 

char chA= 'A';
char ch1 = '1';
string str = "test string";
WriteLine(chA. CompareTo('B')); //   Output: "-1" (meaning 'A' is 1 less than 'B')
WriteLine(chA.Equals('A')); //Output: "True"
WriteLine(Char.GetNumericValue(ch1)); //Output: "1"
WriteLine(Char.IsControl ('\t')); //Output: "True"
WriteLine(Char.IsDigit(ch1)); //Output: "True"
WriteLine(Char.IsLetter(',')); //Output: "False"
WriteLine(Char.IsLower ('u')); //Output: "True"
WriteLine(Char.IsNumber (ch1)); //Output: "True"
WriteLine(Char.IsPunctuation('.')); //Output: "True"
WriteLine(Char.IsSeparator (str, 4)); //Output: "True"
WriteLine(Char.IsSymbol('+')); //-- Output: "True"
WriteLine(Char.IsWhiteSpace(str,4)); //Output: "True"
WriteLine(Char.Parse("s")); //Output: "s"
WriteLine(Char.ToLower ('M')); //Output: "m"
WriteLine('x'.ToString()); //Output:"x"
// for (int i = 0; i < 2000; i++)
// {
// Write($"Char: {(char)i} {i} || ");
// }
ResetColor();
_footer.DisplayFooter('-');