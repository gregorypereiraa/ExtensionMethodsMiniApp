using Spectre.Console;

public static class ConsoleHelper
{
    public static int RequestInt(this string message)
    {
        return message.RequestInt(false);
    }

    public static int RequestInt(this string message, int min, int max)
    {
        return message.RequestInt(true, min, max);
    }

    private static int RequestInt(this string message, bool testRangeAge, int min = 0, int max = 0)
    {
        var output = 0;
        if (testRangeAge)
            do
            {
                output = AnsiConsole.Ask<int>(message);
            } while ((output <= min) | (output > max));
        else
            output = AnsiConsole.Ask<int>(message);

        return output;
    }
}