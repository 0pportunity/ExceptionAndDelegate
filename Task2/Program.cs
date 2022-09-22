using Task2;

NumberReader numberReader = new NumberReader();
Surnames surnames = new Surnames();
surnames.Input5Surnames();
numberReader.NumberEnteredEvent += surnames.Sort;


while (surnames.SurnamesListing != null)
{
    try
    {
        numberReader.ReadNumber();
    }
    catch (InputException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FormatException)
    {
        Console.WriteLine("Введено не число!");
    }
}


