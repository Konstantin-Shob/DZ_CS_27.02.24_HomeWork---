using static System.Console;
using System.Collections;
using System.Collections.Generic;

String[] englishWords = { "access mechanism", "addressbuffer", "appliance", "assignment", "bandwidth", "cloud storage",
    "compile", "compress", "credentials", "database", "debug", "drawback", "eject", "encrypt", "folder", "layout",
    "maintenance", "namespace", "negotiate", "password", "plug in", "prohibit", "replace", "uninstall", "upload" };

String[] russianWords = { "механизм доступа", "буфер адреса", "устройство", "присвоение", "пропускная способность", "облачное хранилище данных",
    "компилировать", "сжимать", "учётные данные", "база данных", "отлаживать", "недостаток", "извлекать устройство", "зашифровывать", "папка", "макет",
    "поддержка", "пространство имен", "вести переговоры", "пароль", "подключать", "запрещать", "заменить", "деинсталлировать", "загрузить" };

SortedList englishDict = new SortedList();
SortedList russianDict = new SortedList();

for (int i = 0; i < englishWords.Length; i++)
{
    englishDict.Add(i + 1, englishWords[i]);
    russianDict.Add(i + 1, russianWords[i]);
}
int choise = 1;
while (choise != 0)
{
    WriteLine("\t\t--- Меню ---");
    WriteLine("1 - англо - русский словаь");
    WriteLine("2 - русско - английский словаь");
    WriteLine("0 - Завершение работы");
    Write("Сделайте выбор: ");
    choise = Convert.ToInt32(ReadLine());
    
    switch (choise)
    {
        case 1:
            int enWorldchoise = 1;
            while (enWorldchoise != 0)
            {
                foreach (object item in englishDict.Keys)
                {
                    WriteLine();
                    WriteLine($"{item} - {englishDict[item]}");
                }        
                WriteLine();
                WriteLine($"Для выхода в меню введите 0 ");
                Write($"Введите номер слова для перевода: ");
                enWorldchoise = Convert.ToInt32(ReadLine());
                WriteLine($"\n{englishDict[enWorldchoise]} - {russianDict[enWorldchoise]}");
                Write($"Для продолжения нажмите любую клавишу ");
                ReadLine();

            }
            break;
        case 2:
            int ruWorldchoise = 1;
            while (ruWorldchoise != 0)
            {
                foreach (object item in russianDict.Keys)
                {
                    WriteLine();
                    WriteLine($"{item} - {russianDict[item]}");
                }

                WriteLine();
                WriteLine($"Для выхода в меню введите 0 ");
                Write($"Введите номер слова для перевода: ");
                ruWorldchoise = Convert.ToInt32(ReadLine());
                WriteLine($"\n{russianDict[ruWorldchoise]} - {englishDict[ruWorldchoise]}");
                Write($"Для продолжения нажмите любую клавишу ");
                ReadLine();

            }
            break;
    }

}
/*
access mechanism	механизм доступа
addressbuffer	буфер адреса; адресный буфер
appliance	устройство
assignment	задание, присвоение
bandwidth	пропускная способность
cloud storage	облачное хранилище данных
compile	компилировать
compress	сжимать
credentials	учетные данные
database	база данных
debug	отлаживать
drawback	недостаток
eject	извлекать устройство
encrypt	зашифровывать
folder	папка
layout	макет, разметка
maintenance	поддержка
namespace	пространство имен
negotiate	вести переговоры
outsource	осуществлять аутсорсинг
password	пароль
plug in	подключать
prohibit	запрещать, препятствовать
replace	заменить
uninstall	деинсталлировать, удалять
upload	загрузить
validation	проверка
variable	переменная
vendor	поставщик
virtual control program interface)	виртуальный программный управляющий интерфейс
virtual methods table	таблица адресов виртуальных методов

*/