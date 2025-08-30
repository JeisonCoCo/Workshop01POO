namespace POO.Workshop01.Core;

// Definición de atributos de la clase Time
public class Time
{
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;

    // 1) Constructor sin parámetros
    public Time()
    {
        Hour = 0;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
    }

    // 2) Constructor con horas
    public Time(int hour)
    {
        Hour = hour;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
    }

    // 3) Constructor con horas y minutos
    public Time(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
        Second = 0;
        Millisecond = 0;
    }

    // 4) Constructor con horas, minutos y segundos
    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = 0;
    }

    // 5) Constructor con horas, minutos, segundos y milisegundos
    public Time(int hour, int minute, int second, int millisecond)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
    }

    // 3. Metodos // return -> que me devuelva o que me sobreescriba por medio de ToString
    public Time Add(Time other)
    {
        int totalMilli = _millisecond + other._millisecond;
        int carrySeconds = totalMilli / 1000;
        int newMillisecond = totalMilli % 1000;

        int totalSec = _second + other._second + carrySeconds;
        int carryMinutes = totalSec / 60;
        int newSecond = totalSec % 60;

        int totalMin = _minute + other._minute + carryMinutes;
        int carryHours = totalMin / 60;
        int newMinute = totalMin % 60;

        int totalHour = _hour + other._hour + carryHours;
        int newHour = totalHour % 24;

        return new Time(newHour, newMinute, newSecond, newMillisecond);
    }

    public int Hour
    {
        get => _hour;
        set => _hour = ValidateHour(value);
    }

    public int Minute
    {
        get => _minute;
        set => _minute = ValidateMinute(value);
    }

    public int Second
    {
        get => _second;
        set => _second = ValidateSecond(value);
    }

    public int Millisecond
    {
        get => _millisecond;
        set => _millisecond = ValidateMillisecond(value);
    }
    public override string ToString()
    {
        int hour12 = _hour % 12;
        if (hour12 == 0) hour12 = 12;

        string amPm = _hour < 12 ? "AM" : "PM"; // Operador ternario para determinar AM o PM

        return $"{hour12:00}:{_minute:00}:{_second:00}.{_millisecond:000} {amPm}";
    }

    // Métodos públicos
    public int ToMilliseconds()
    {
        return _hour * 3600000 + _minute * 60000 + _second * 1000 + _millisecond;
    }

    public int ToSeconds()
    {
        return _hour * 3600 + _minute * 60 + _second;
    }

    public int ToMinutes()
    {
        return _hour * 60 + _minute;
    }

    public bool IsOtherday(Time other)
    {
        return this.ToMilliseconds() + other.ToMilliseconds() >= 86400000;
    }

    // Los metodos privados van despues de los metodos public o publicos
    // Validaciones privadas
    private int ValidateHour(int hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new Exception($"The hour: {hour} is not valid");
        }
        return hour;
    }
    private int ValidateMinute(int minute)
    {
        if (minute < 0 || minute > 59)
        {
            throw new Exception($"The minute {minute} is not valid");
        }
        return minute;
    }

    private int ValidateSecond(int second)
    {
        if (second < 0 || second > 59)
        {
            throw new Exception($"The second {second} is not valid");
        }
        return second;
    }

    private int ValidateMillisecond(int millisecond)
    {
        if (millisecond < 0 || millisecond > 999)
        {
            throw new Exception($"The millisecond {millisecond} is not valid");
        }
        return millisecond;
    }
}
