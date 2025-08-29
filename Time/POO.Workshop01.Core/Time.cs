namespace POO.Workshop01.Core;

// Definición de atributos de la clase Time
public class Time
{
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;

    // Constructor de la clase Time
    public Time()
    {
        Hour = 00;
        Millisecond = 000;
        Minute = 00;
        Second = 00;
    }

    public Time (int Hour)
    {
        Hour = _hour;   
    }

    public Time (int Hour, int Millisecond)
    {
        Hour = _hour;
        Millisecond = _millisecond;
    }

    public Time(int Hour, int Millisecond, int Minute)
    {
        Hour = _hour;
        Millisecond = _millisecond;
        Minute = _minute;
    }

    public Time(int Hour, int Millisecond, int Minute, int Second)
    {
        Hour = _hour;
        Millisecond = _millisecond;
        Minute = _minute;
        Second = _second;
    }
    // 3. Metodos // return -> que me devuelva o que me sobreescriba por medio de ToString
    public override string ToString()
    {
        return $"{_hour}/{_minute}/{_second}/{_millisecond}";
    }
}
