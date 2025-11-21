using StateWzorce.Context;
class Program
{
    static void Main()
    {
        ATMContext atm = new ATMContext(500);
        atm.InsertCard();
        atm.InsertPin(1234);
        atm.WithdrawCash(200);
        Console.WriteLine();
        atm.InsertCard();
        atm.InsertPin(1234);
        atm.WithdrawCash(300);
        Console.WriteLine();
        atm.InsertCard();
    }
}
