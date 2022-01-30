var names = new string[] { "ABOBA", ":D", ">:X", "computer", "Ru", "ASDH" }; 
// находим элементы, у которых длина строки равна 3
string[] array = Array.FindAll(names, name => name.Length <= 3);
foreach (var name in array) 
Console.WriteLine(name);


