using Directorys;
Directoryes directoryes = new Directoryes();
void Menu()
{
    Console.WriteLine();
    Console.WriteLine("Menu");
    Console.WriteLine();
    Console.WriteLine("1. Создать директорию");
    Console.WriteLine("2. Удалить директорию");
    Console.WriteLine("3. Проверить наличие файлов в директории");
    Console.WriteLine("4. Удалить какой-либо файл в директории");
    Console.WriteLine("5. Создать текстовый файл");
    Console.WriteLine("6. Прочитать информацию из какого-либо файла");
    Console.WriteLine("7. Записать информацию в файл");
}
void GetMenu()
{
    string select = Console.ReadLine();
    bool parse = int.TryParse(select, out int selected);
    if (parse)
    {
        switch (selected)
        {
            case 1:
                directoryes.CreateDirectory();
                break;
            case 2:
                directoryes.DeleteDirectory();
                break;
            case 3:
                directoryes.CheckFilesInDirectory();
                break;
            case 4:
                directoryes.DeleteFilesInDirectory();
                break;
            case 5:
                directoryes.CreateFile();
                break;
            case 6:
                directoryes.ReadFile();
                break;
            case 7:
                directoryes.WriteInFile();
                break;
        }
    }
}
while (true)
{
    Menu();
    GetMenu();
}