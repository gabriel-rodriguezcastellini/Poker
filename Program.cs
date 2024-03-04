using Poker;

List<Decision> decisions = [];
Array decisionValues = Enum.GetValues(typeof(Decision));
Random random = new();

do
{
    Decision decision = (Decision)decisionValues.GetValue(random.Next(decisionValues.Length))!;

    if (decision == Decision.Fold && decisions.Count == 0)
    {
        continue;
    }

    decisions.Add(decision);
} while (!decisions.Contains(Decision.Fold));

Console.WriteLine(string.Join(Environment.NewLine, decisions.Select((decision, index) => $"{index + 1}. {decision}")));