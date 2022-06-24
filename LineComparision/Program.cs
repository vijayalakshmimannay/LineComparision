// See https://aka.ms/new-console-template for more information
LineComparision.Line linecomparison = new LineComparision.Line();
double length1 = linecomparison.getLength(4, 6, 8, 6);
double length2 = linecomparison.getLength(3, 7, 9, 11);
Console.WriteLine("length of line 1 " + length1);
Console.WriteLine("length of line 2 " + length2);