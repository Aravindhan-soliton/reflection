using System.Reflection;

System.Console.WriteLine("Enter the property name who's value is to be changed: ");
string? inputPropertyName = Console.ReadLine(); 

System.Console.WriteLine("Enter the value: ");
string? inputPropertyValue = Console.ReadLine();

Sample sampleObject = new Sample();

Type classType = typeof(Sample);
PropertyInfo propertyInfo = classType.GetProperty(inputPropertyName);
PropertyInfo[] properties = classType.GetProperties();

if (propertyInfo != null){
     propertyInfo.SetValue(sampleObject, inputPropertyValue, null);
}
else{
    Console.WriteLine($"Property '{inputPropertyName}' does not exist in MyClass.");
}


foreach(PropertyInfo property in properties){
    System.Console.WriteLine($"value of {property.Name} : {property.GetValue(sampleObject)}");
}

