using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    class Dog : Animal
    {
        public void TestB()
        {
            Protected();  //상속된 자식에서는 protected접근 가능
            Public();
        }

        public string Color { get; set; }
        public override void Eat() { Console.WriteLine("요란하게 맛있게 먹습니다."); }
        public sealed override void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
    }
}
