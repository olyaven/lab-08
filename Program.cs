int lessonNumber = 5;
int totalLessons = 1;

while (lessonNumber >= totalLessons) {
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}

Console.WriteLine("Пары закончились");


//---


Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");

int count1 = 0;
int grade1 = int.Parse(Console.ReadLine());

while (grade1 != -1) {
    Console.WriteLine($"Оценка принята: {grade1}");
    count1++;
    grade1 = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Количество оценок: {count1}");
Console.WriteLine("Ввод завершён");


//---


int sum2 = 0;
int count2 = 0;
int maxGrade = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");

int grade2 = int.Parse(Console.ReadLine());

while (grade2 != -1) {
    sum2 += grade2;
    count2++;

    if (count2 == 1 || grade2 > maxGrade) {
        maxGrade = grade2;
    }

    grade2 = int.Parse(Console.ReadLine());
}

if (count2 > 0) {
    Console.WriteLine($"Средний балл: {(double)sum2 / count2}");
    Console.WriteLine($"Наибольшая оценка: {maxGrade}");
} else {
    Console.WriteLine("Оценок не было введено");
}


//---


string correctPassword = "qwerty123";
int failedAttempts = 0;

while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        Console.WriteLine($"Неудачных попыток: {failedAttempts}");
        break;
    }

    failedAttempts++;
    Console.WriteLine("Неверный пароль, попробуйте снова");
}


//---

string answer;

do {
    Console.Write("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.Write("Добавить ещё одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");

Console.WriteLine("Дневник сохранён");

//TASK A

int N = 7;

for (int i = 1; i <= 10; i++) {
    Console.WriteLine($"{N} * {i} = {N * i}");
}

//TASK B

int count3 = 0;

Console.WriteLine("Вводите имена учеников. Для завершения введите «конец»:");

string name = Console.ReadLine();

while (name != "конец") {
    count3++;
    name = Console.ReadLine();
}

Console.WriteLine($"Количество имён: {count3}");

//VAR 2

int sum3 = 0;

Console.WriteLine("Вводите целые числа. Для завершения введите 0:");

int number = int.Parse(Console.ReadLine());

while (number != 0) {
    if (number > 0) {
        sum3 += number;
    }

    number = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Сумма положительных чисел: {sum3}");

//VAR 7

double sum4 = 0;

for (int day = 1; day <= 7; day++) {
    Console.Write($"Введите температуру за день {day}: ");
    double temperature = double.Parse(Console.ReadLine());

    sum4 += temperature;
}

double average = sum4 / 7;

Console.WriteLine($"Средняя температура за неделю: {average}");