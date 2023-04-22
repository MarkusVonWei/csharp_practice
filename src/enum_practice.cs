public enum Device {
    MAC,
    WINDOWS,
    ANDROID,
    IPHONE
}

[Flags]
public enum Days {
    None = 0b_0000_0000,
    Monday = 0b_0000_0001,
    Tuesday = 0b_0000_0010,
}
