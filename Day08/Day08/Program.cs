using Day08CL;

namespace Day08
{
    /*                    DERIVING CLASSESS          
                                                               
                                ╔═════════╗     ╔══════════╗ 
                 public  class  ║SomeClass║  :  ║OtherClass║ 
                                ╚═════════╝     ╚══════════╝
                                     │                │         
                                     └──┐             └──┐             
                                   ┌────▼────┐      ┌────▼────┐      
                                   │ Derived │      │  Base   │    
                                   │  Class  │      │  Class  │     
                                   └─────────┘      └─────────┘     

    
                CONSTRUCTORS: the derived constructor must call a base constructor
                public SomeClass(.....) : base(....)


     */
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                CHALLENGE 1:

                    In the Day08CL project, add a new class, Pistol, that derives from Weapon.
                    Pistol should have properties for Rounds and MagCapacity.
                    Add a constructor that calls the base constructor
             
            */
            //Weapon knife = new Weapon(5,10);





            /*  
                ╔═══════════╗ 
                ║ UPCASTING ║ - converting a derived type variable to a base type variable
                ╚═══════════╝ 
                
                This is ALWAYS safe.

                DerivedType A = new DerivedType();
                BaseType B = A;
            



                CHALLENGE 2:
                    Create a List of Weapon. Create several Pistols and add them to the list of weapons.
            */

            int num = 5;//4 bytes
            long bigNum = num;//8 bytes. Implicit casting.
            num = (int)bigNum;//explicit casting

            Person bruce = new Person();
            Employee alfred = new Employee(250000, "Alfred", 85);

            //UPCASTING: from a DERIVED type to a BASE type
            //Employee to Person
            //ALWAYS SAFE!
            Person butler = alfred;//upcasting

            List<Weapon> weapons = new List<Weapon>();
            Pistol reuger = new Pistol(100, 50, 5, 2);
            Bat lucille = new Bat(Material.Wood, 4, 15);
            weapons.Add(reuger);//upcasting
            weapons.Add(lucille);//upcasting









            /*  
                ╔═════════════╗ 
                ║ DOWNCASTING ║ - converting a base type variable to a derived type variable
                ╚═════════════╝ 
                
                This is NOT SAFE!!!!!

            
                BaseType B = new DerivedType(); //upcasting
                DerivedType A = B; !! Build ERROR !!
            

                3 ways to downcast safely...
                1) explicit cast inside of a try-catch
                    try {  DerivedType A = B;  }
                    catch(Exception) { }

                2) use the 'as' keyword
                    NOTE: null will be assigned to A if B cannot be cast to DerivedType
                    DerivedType A = B as DerivedType;
                    if(A != null) { can use A }

                3) use 'is' in pattern matching
                    if(B is DerivedType A) { can use A }



                CHALLENGE 3:
                    Loop over the list of weapons.
                    Call ShowMe on each weapon.
                    Downcast to a Pistol and print the rounds and mag capacity of each pistol
            */

            //DOWNCASTING: from a BASE type to a DERIVED type
            //from Person (butler) to Employee (e1)
            //NOT SAFE!!!!
            //bruce = new Employee(10000000, "Bruce", 35);

            //#1 explicit cast in a try-catch
            try
            {
                Employee e1 = (Employee)bruce;
            }
            catch (Exception)
            {
            }

            //#2 'as' keyword
            //  if it CANNOT be cast as the type, it will assign NULL
            Employee? e2 = bruce as Employee;
            if(e2 != null)
                Console.WriteLine($"Salary: {e2.Salary}");

            //#3 'is' keyword w/ pattern matching
            if(bruce is Employee e3)
                Console.WriteLine($"Salary: {e3.Salary}");

            for (int i = 0; i < weapons.Count; i++)
            {
                weapons[i].ShowMe();
                //if (weapons[i] is Pistol bang)
                //    Console.WriteLine($"It's a Pistol! with {bang.Rounds} and {bang.MagCapacity} capacity.");
                //else if (weapons[i] is Bat bat)
                //    Console.WriteLine($"It's a {bat.BatMaterial} bat.");
            }






            /*  
                ╔═════════════╗ 
                ║ OVERRIDING  ║ - changing the behavior of a base method
                ╚═════════════╝ 
                
                2 things are required to override a base method:
                1) add 'virtual' to the base method
                2) add a method to the derived class that has the same signature as the base. put 'override' to the derived method


                FULLY OVERRIDING:
                    not calling the base method from the derived method

                EXTENDING:
                    calling the base method from the derived method




                CHALLENGE 4:
                    Override Weapon's ShowMe method in the Pistol method.
                    In Pistol's version, call the base version and print out the rounds and magCapacity
            */

            alfred.Eat("crumpets and tea");
            Person p1 = alfred;//upcasting
            p1.Eat("bagels and cream");
        }
    }
}