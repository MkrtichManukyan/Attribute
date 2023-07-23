using Attribute;
using System.Reflection;

var myClass = new MyClass();

MyClass.Method();

Type type = typeof(MyClass);

object[] attributes = null;

MyAttribute attribute;

attributes = type.GetCustomAttributes(false);

foreach (var att in attributes)
{
    attribute = att as MyAttribute;
    Console.WriteLine(attribute.Number);
    Console.WriteLine(attribute.Date);
}

MethodInfo method = type.GetMethod("Method");
object instance = Activator.CreateInstance(type);
method.Invoke(instance, new object[] { });