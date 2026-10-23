int lessonNumber = 1;
int totalLessons = 5;

while (lessonNumber <= totalLessons) {
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber++;
}

Console.WriteLine("Пары закончились");

//---

Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1) {
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ввод завершён");

//---

int sum = 0;
int count = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1) {
    sum += grade;
    count++;
    grade = int.Parse(Console.ReadLine());
}

if (count > 0) {
    Console.WriteLine($"Средний балл: {(double)sum / count}");
} else {
    Console.WriteLine("Оценок не было введено");
}

//---

string correctPassword = "qwerty123";

while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        break;
    }

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