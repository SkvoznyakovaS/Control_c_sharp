string[] array = {"1234", "1567", "-2", "comp uter science", "дом"};
//создали массив
Console.WriteLine(string.Join(" ", array));
//вывели на печать массив
string[] new_array = Array.FindAll(array, a=> a.Length <=3);
//создали новый массив
Console.WriteLine(string.Join(" ", new_array));
//вывели на печать новый массив