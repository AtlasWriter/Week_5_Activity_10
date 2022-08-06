// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CST117_IC08_console {
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the set

            Random r = new Random();
            for (int i = 0; i < 10; i++) {
 
                A.addElement(r.Next(4)); 
                B.addElement(r.Next(12));
            }
            //  display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));
            // display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
    }
class Set
{
    private List<int> elements; 
    public Set() { 
        elements = new List<int>();
    }
 
    public bool addElement(int val)
    {
        if (containsElement(val)) 
            return false;
        else
        {
            elements.Add(val);
            return true;
        }
    }
    private bool containsElement(int val) { 
        for (int i = 0; i < elements.Count; i++) { 
            if (val == elements[i]) 
                return true;
 //           else return false;
 //           This would continue to repeat the number if returned false.
        }
        return false;
    }

    
    public override string ToString() { 
        string str = "";
        foreach (int i in elements) 
        { str += i + " "; 
        }

        return str;
    }
    public void clearSet() { 
        elements.Clear(); 
    }
 
    public Set union(Set rhs) {
        //Created a new set. If this didnt happened it would change set A when Set b would populate
        Set set = new Set();

        for (int i = 0; i < this.elements.Count; i++)
        {
            set.addElement(this.elements[i]);
        }
           
        for (int i = 0; i < rhs.elements.Count; i++) {

            set.addElement(rhs.elements[i]);


        }
      
 // Added the sort parameter        
        set.elements.Sort();


        return set;
    }
    }




