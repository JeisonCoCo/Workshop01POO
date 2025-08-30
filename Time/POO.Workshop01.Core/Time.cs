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
    public int Hour
    {
        get => _hour;
        set
        { 
            _hour = ValidateHour(value); 
        }
    }
    public int Millisecond
    {
        get => _millisecond;
        set
        {
            _millisecond = ValidateMillisecond(value);
        }
    }
    public int Minute
    {
        get => _minute;
        set
        {
            _minute = ValidateMinute(value);
        }
    }
    public int Second
    {
        get => _second;
        set
        {
            _second = ValidateSecond(value);
        }
    }
    public override string ToString()
    {
        return $"{_hour : 00}/{_minute: 00}/{_second: 00}/{_millisecond: 00}";
    }

    // Creacion de To String
    public int ToHour()
    {
        return _hour * 3600000 + _minute * 60000 + _second * 1000 + _millisecond; 
    }
    public int ToMillisecond()
    {
        return _hour * 3600000 + _minute * 60000 + _second * 1000 + _millisecond;
    }
    public int ToMinute()
    {
        return _hour * 3600000 + _minute * 60000 + _second * 1000 + _millisecond;
    }
    public int ToSecond()
    {
        return _hour * 3600000 + _minute * 60000 + _second * 1000 + _millisecond;
    }

    // Los metodos privados van despues de los metodos public o publicos
    private bool IsOtherday(Time t4)
    {
        // Un día son 86,400,000 milisegundos
        return (this.ToMillisecond() + t4.ToMillisecond()) >= 86400000;
    }
    private int ValidateHour(int hour)
    {
        if (hour < 0)
        {
            throw new Exception("Hour cannot be less than 0");
        }
        return hour;
    }
    private int ValidateMillisecond(int millisecond)
    {
        if (millisecond < 0 && millisecond > 999)
        {
            throw new Exception("Hour cannot be less than 0");
        }
        return millisecond;
    }

    private int ValidateMinute(int minute)
    {
        if (minute < 0 && minute > 59)
        {
            throw new Exception("Hour cannot be less than 0");
        }
        return minute;
    }

    private int ValidateSecond(int second)
    {
        if (second < 0 && second > 59)
        {
            throw new Exception("Hour cannot be less than 0");
        }

    private int ValidateMillisecond(int millisecond)
    {
        if (millisecond < 0 || millisecond > 999)
            throw new Exception($"Millisecond {millisecond} must be between 0 and 999");
        return millisecond;
    }
}
