# Practice_15.6

## Task
Есть список учеников школы с разбивкой по классам:

    var classes = new []
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.

***Описание проекта***  

В данном проекте было написано два метода для решения поставленной задачи:
 - `GetAllStudetsSQLSyntax` - метод реализован при помощи SQL-подобного синтаксиса
 - `GetAllStudentsMethodExtension` - метод реализован при помощи методов расширения