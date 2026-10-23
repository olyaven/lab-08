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


int sum = 0;
int count = 0;
int maxGrade = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");

int grade = int.Parse(Console.ReadLine());

while (grade != -1) {
    sum += grade;
    count++;

    if (count == 1 || grade > maxGrade) {
        maxGrade = grade;
    }

    grade = int.Parse(Console.ReadLine());
}

if (count > 0) {
    Console.WriteLine($"Средний балл: {(double)sum / count}");
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