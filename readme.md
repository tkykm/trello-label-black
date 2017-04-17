# trello-label-black

trelloのとあるボードのとあるリストのカードのラベルをブラックにするFunction。

[Trello.NET](https://github.com/dillenmeister/Trello.NET)が古くて使えなかったので、[MyTrelloNet](https://www.nuget.org/packages/MyTrelloNet/)というオレオレnugetパッケージに修正して使ってます。オレオレとはいえ誰でも使えます。

ボードのIDや、リストのID, Token、keyは環境変数で設定する必要があります。

コードでは以下のように取得してます。
```
    string KEY = System.Environment.GetEnvironmentVariable("TRELLO_KEY", EnvironmentVariableTarget.Process);
    string TOKEN = System.Environment.GetEnvironmentVariable("TRELLO_TOKEN", EnvironmentVariableTarget.Process);
    string ID_BOARD = System.Environment.GetEnvironmentVariable("TRELLO_ID_BOARD", EnvironmentVariableTarget.Process);
    string ID_LIST = System.Environment.GetEnvironmentVariable("TRELLO_ID_LIST", EnvironmentVariableTarget.Process);
```

* visual studioなどでローカル開発をするときは、appsettings.jsonに環境変数を設定。
* パブリックのAzure Functionでやる場合は、アプリのほうの環境変数に設定。
