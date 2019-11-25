using System;

public enum TransactionTypes{
    Deposit,
    Withdraw
}

public class Transactions{

    public int AccountID;
    public TransactionTypes TransactionType;
    public int Amount;
    public DateTime Timestamp;

    Transactions(int AccountID, TransactionTypes TransactionType, int Amount, DateTime Timestamp){
        
        this.AccountID = AccountID;
        this.TransactionType = TransactionType;
        this.Amount = Amount;
        this.Timestamp = Timestamp;

    }

}