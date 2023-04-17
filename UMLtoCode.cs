public class UMLtoCode {
    
        public abstract class Person{
            public int id;
            public String Name;
            protected String Phone;
            public String Email;
            public Address Address;
        }
        
        public struct Address{
            public String Street;
            public String City;
            public String State;
            public int PostalCode;
            public String country;
            public boolean Validate(){
                return true;
            }
        }
        
        public class Customer : Person{
            public Date Registration;
            private int CreditScore;
        }
        
        public class Employee : Person{
            public Enum Department;
            private float Salary;
        }
        
        public class Account : Customer{
            public String IBAN;
            protected float Amount;
            
            public boolean Transaction(String IBAN){
                return true;
            }
        }
        
        public struct Transaction{
            public String From;
            public String To;
            public float Amount;
            public Date Request;
        }
        
        public class Investing : Account{
            public float Interest;
            
            public void ApplyInterest(){
            }
        }
        
        public class Savings extends Account{
            private float ProtectedAmount;
            
            public void LiberateSavings(){
                
            }
        }
        
    
}
