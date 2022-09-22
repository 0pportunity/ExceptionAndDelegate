using Task1;

UsersException usersException = new UsersException("Время выполнения операции стремится к бесконечности");
ArgumentNullException argumentNullException = new ArgumentNullException("Аргумент, передаваемый в метод — null.");
DivideByZeroException divideByZeroException = new DivideByZeroException("Знаменатель в операции деления или целого числа Decimal равен нулю.");
NotImplementedException notImplementedException = new NotImplementedException("Метод или операция не реализованы.");
PlatformNotSupportedException platformNotSupportedException = new PlatformNotSupportedException("Операция не поддерживается на текущей платформе.");


Exception[] exceptions = { usersException, argumentNullException, divideByZeroException, notImplementedException, platformNotSupportedException };

foreach (Exception exception in exceptions)
{
    try
    {
        throw exception;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Thread.Sleep(1000);
        Console.WriteLine("Блок finally сработал");
        Console.WriteLine();
    }
}

Console.WriteLine("Все исключения собраны");
Console.ReadKey();

