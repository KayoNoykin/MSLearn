const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

//quantity
const string openSpan = "<span>";
const string closeSpan = "</span>";
int quantityStart = input.IndexOf(openSpan);
int quantityEnd = input.IndexOf(closeSpan);
quantityStart += openSpan.Length;
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);

//output
const string openDiv = "<div>";
const string closeDiv = "</div>";
const string trade = "&trade";
const string reg = "&reg";
output = input;
output = output.Replace(openDiv, "").Replace(closeDiv, "").Replace(trade, reg);

Console.WriteLine(quantity);
Console.WriteLine(output);