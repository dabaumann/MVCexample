

enum TransactionTypes{
    
    Deposit,
    Withdraw
}

public class Transactions{

    public int AccountID;
    public TransactionTypes TransactionType;
    public int Amount;
    public DateTime Timestamp;

    constructor(AccountID, TransactionType, Amount, Timestamp){
        
        this.AccountID = AccountID;
        this.TransactionType = TransactionType;
        this.Amount = Amount;
        this.Timestamp = Timestamp;

    }

}