public class Once {
    public void test() {
        var device = Device.MAC;
        Console.WriteLine(device);

        // var d2 = Device.Parse("Android");
        var d2 = Enum.Parse(typeof(Device), "ANDROID");
        Console.WriteLine($"d2={d2} d2int={(int)d2}");
 
    }
}

