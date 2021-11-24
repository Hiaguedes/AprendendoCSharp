// See https://aka.ms/new-console-template for more information
DateTime umaDataAi = new(2021, 11,10);
DateTime dataAtual = DateTime.Now;

TimeSpan diferencaData = dataAtual - umaDataAi;

Console.WriteLine("Vencimento em " + Humanizer.TimeSpanHumanizeExtensions.Humanize(diferencaData));