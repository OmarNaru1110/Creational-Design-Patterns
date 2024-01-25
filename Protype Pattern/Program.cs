namespace Protype_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ShallowCopy
            /*            var obj = new CostlyOperationClass { 
                            Id = 1,Name="obj",Address = new Address{
                                Street="alakma",City="hehia",Country="egypt" } };

                        var obj2=obj.ShallowCopy();
                        obj2.Id = 2;
                        obj2.Name = "obj2";
                        obj2.Address.Street = "blabla";
                        //obj.operation.street will change too cuz it's copied as reference type
                        Console.WriteLine(obj.ToString());
                        Console.WriteLine(obj2.ToString());
                        //restore old obj
                        obj.Address.Street = "alakma";
                        //make obj2.operation reference new address in memory
                        obj2.Address = new Address { Street = "Subeih", City = "hehia", Country = "egypt" };
                        Console.WriteLine(obj.ToString());
                        Console.WriteLine(obj2.ToString());*/
            #endregion

            #region DeepCopy
            /*            var obj = new CostlyOperationClass {Id=1,Name="obj",Address= 
                            new Address { 
                                Street="alakma", City="hehia", Country="egypt"
                            } 
                        };
                        var obj2=obj.DeepCopy();
                        Console.WriteLine(obj.ToString());
                        Console.WriteLine(obj2.ToString());*/
            #endregion

            Console.ReadKey();
        }
    }
}
