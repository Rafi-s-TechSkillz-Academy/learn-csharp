using HeaderFooter;
Header _header = new();
Footer _footer = new();
_header.DisplayHeader ('=', "A3 bool Variables Demo");

ShowBoolDemo();
_footer.DisplayFooter('-');


static void ShowBoolDemo(){
    ForegroundColor = ConsoleColor.Green;

    WriteLine($"Bool: {sizeof(bool)} byte(s) of memory. ");

    bool IsManager = false;

    WriteLine(IsManager ? "Manager" : "Employee");

    ResetColor();
}