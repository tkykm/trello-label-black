using System;
using TrelloNet;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    string KEY = System.Environment.GetEnvironmentVariable("TRELLO_KEY", EnvironmentVariableTarget.Process);
    string TOKEN = System.Environment.GetEnvironmentVariable("TRELLO_TOKEN", EnvironmentVariableTarget.Process);
    string ID_BOARD = System.Environment.GetEnvironmentVariable("TRELLO_ID_BOARD", EnvironmentVariableTarget.Process);
    string ID_LIST = System.Environment.GetEnvironmentVariable("TRELLO_ID_LIST", EnvironmentVariableTarget.Process);

    Trello trello = new Trello(KEY);
    trello.Authorize(TOKEN);
    IListId list = trello.Lists.WithId(ID_LIST);
    foreach (Card card in trello.Cards.ForList(list))
    {
        int hasBlack = 0;
        foreach (Card.Label label in card.Labels)
        {
            if (label.Color == Color.Black)
            {
                hasBlack = 1;
                continue;
            }
            else
                trello.Cards.RemoveLabel(card, label.Color);
        }
        if (hasBlack != 1)
            trello.Cards.AddLabel(card, Color.Black);
        hasBlack = 0;
    }
}