

namespace Lab3
{
    
    //1.9 Створити клас ATriangle (angled triangle, прямокутний трикутник)
    class ATriangle
    {
        private int a, b;
        private readonly int c;

        public ATriangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public ATriangle(int a_, int b_, int c_)
        {
            a = a_;
            b = b_;
            c = c_;
        }

        public void Print()
        {
            Console.WriteLine($"A: {a}, B: {b}, color: {c}");
            Console.WriteLine($"P: {P()}");
            Console.WriteLine($"S: {S()}");
        }

        public  double P()
        {
            double c = Math.Sqrt(a * a + b * b);
            return a + b + c;
        }

        public double S()
        {
            return 0.5 * a * b;
        }

        public bool isRivnobedr()
        {
            return a == b;
        }
        
        public void setA(int newA)
        {
            a = newA;
        }

        public int getA()
        {
            return a;
        }

        public void setB(int newB)
        {
            b = newB;
        }

        public int getB()
        {
            return b;
        }

        public int getColor()
        {
            return c;
        }
        
    }
    
    //2.9. Іграшка, продукт, товар, молочний продукт.
    class Tovar
    {
        protected string name;
        protected double price;
        public Tovar()
        {
            name = "none";
            price = 0;
        }
        
        protected Tovar(string n, double p)
        {
            name = n;
            price = p;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {name}, price: {price}");
        }
    }

    class Toy : Tovar
    {
        private int minAge;

        public Toy()
        {
            minAge = 3;
            name = "Toy";
            price = 40;
        }

        public Toy(int age, string n, double p)
        {
            minAge = age;
            name = n;
            price = p;
        } 
        
        public void Show()
        {
            Console.WriteLine($"Name: {name}, price: {price}, minAge: {minAge}");
        }
    }

    class Product : Tovar
    {
        private int creationYear;
        
        public Product()
        {
            creationYear = 2022;
            name = "Product";
            price = 12;
        }

        public Product(int year, string n, double p)
        {
            creationYear = year;
            name = n;
            price = p;
        }
        
        public void Show()
        {
            Console.WriteLine($"Name: {name}, price: {price}, creationYear: {creationYear}");
        }
    }

    class MolochniyProduct : Tovar
    {
        public string country;
        public MolochniyProduct()
        {
            country = "Ukraine";
            name = "MolochniyProduct";
            price = 25;
        }

        public MolochniyProduct(string cntry, string n, double p)
        {
            country = cntry;
            name = n;
            price = p;
        } 
        
        public void Show()
        {
            Console.WriteLine($"Name: {name}, price: {price}, country: {country}");
        }
    }
    
    static class Program
    {
        static void Main()
        {
            ATriangle a = new ATriangle();
            ATriangle b = new ATriangle(2, 3, 3);
            Console.WriteLine("A:");
            a.Print();
            Console.WriteLine("B:");
            b.Print();
            //-----------------
            Tovar tovar = new Tovar();
            tovar.Show();
            Console.WriteLine();
            
            Toy toy = new Toy();
            toy.Show();
            Console.WriteLine();

            Product product = new Product();
            product.Show();
            Console.WriteLine();

            MolochniyProduct molochniyProduct = new MolochniyProduct();
            molochniyProduct.Show();
            Console.WriteLine();
        }
    }
}