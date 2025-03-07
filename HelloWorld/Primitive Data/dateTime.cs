using System.Globalization;
using System.Text.Json;

namespace HelloWorld.Primitive_Data;

class dateTime
{
    static void date()
    {
        DateOnly dia = new DateOnly(2024, 12, 05);

        string diaEmtexto = dia.ToShortDateString();
        string diaEmTexto1 = dia.ToLongDateString();

        string diaEmPortu = dia.ToString("m", new CultureInfo("pt-BR"));
        string diaEmJapo = dia.ToString("dd/MMM/yyyy", new CultureInfo("ja-JP"));

    }

    static void dateHour()
    {
        DateTime day1 = new DateTime(2024, 12, 05, 16, 30, 27);
        DateTime today = DateTime.Now; // DateTime.Today (data de hoje, porém o horário sempre será de meia noite)

        DateTime day2 = DateTime.UtcNow; // tempo universal coordenado

        DateTime newDate = today.AddDays(2);
    }
}
