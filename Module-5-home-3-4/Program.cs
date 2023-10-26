using System;

class Program
{
    static void Main()
    {
        try
        {
            Method1();
        }
        catch (Exception ex)
        {
            // Перехватываем исключение, поднятое из вызываемого метода
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        finally
        {
            // Финальный блок, который всегда будет выполнен
            Console.WriteLine("Завершение программы.");
        }
    }

    static void Method1()
    {
        try
        {
            // Вызываем метод, который генерирует исключение
            Method2();
        }
        catch (Exception ex)
        {
            // Перехватываем исключение и поднимаем его в вызывающий метод
            throw new Exception($"Ошибка в Method1: {ex.Message}");
        }
    }

    static void Method2()
    {
        // Генерируем исключение в этом методе
        throw new Exception("Ошибка в Method2: пример исключения.");
    }
}
