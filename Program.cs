using System;
using CSharpStudy.Struct;
using CSharpStudy.Class;
using CSharpStudy.Enum;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Product1 product = new Product1();
            Product1 otherProduct = new Product1();
            product.num = 1;
            product.name = "Xampú";
            product.cat = Category.Higiêne;

            otherProduct.num = 2;
            otherProduct.name = "Cerveja";
            otherProduct.cat = Category.Bebida;

            Class1 class1 = new Class1();
            class1.printLine($"{product.num} - {product.name} - {product.cat}");
            class1.printLine($"{otherProduct.num} - {otherProduct.name} - {otherProduct.cat}");
        }
    }
}
