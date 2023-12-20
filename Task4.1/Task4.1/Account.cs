using System;
namespace Task4._1
{
	public class Account
	{
		private decimal balance;
		private string name;

		public Account()
		{
			Name = null;
			balance = 0;
		} public Account(string name, decimal balance) {

			this.Name = name;
			this.balance = balance;


		}

		public bool Deposit(decimal amountAdd) {

			if (amountAdd > 0) {

                balance += amountAdd;
				return true;

            }
			return false;

		}
		public bool Withdraw(decimal amountSubtract) {


            if (amountSubtract > 0 && amountSubtract <= balance)
            {

                balance -= amountSubtract;
                return true;

            }
            return false;

        }
		public string Name { get; }

		public void Print() {

			Console.WriteLine($"name is {Name}  and your balance is {balance}");
			

        }

    }
}

