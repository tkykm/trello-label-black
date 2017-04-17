# trello-label-black

trelloのとあるボードのとあるリストのカードのラベルをブラックにするFunction。
ボードのIDや、リストのID, Token、keyは環境変数で設定する必要がある。
コードでは以下のように取得している。
```
    string KEY = System.Environment.GetEnvironmentVariable("TRELLO_KEY", EnvironmentVariableTarget.Process);
    string TOKEN = System.Environment.GetEnvironmentVariable("TRELLO_TOKEN", EnvironmentVariableTarget.Process);
    string ID_BOARD = System.Environment.GetEnvironmentVariable("TRELLO_ID_BOARD", EnvironmentVariableTarget.Process);
    string ID_LIST = System.Environment.GetEnvironmentVariable("TRELLO_ID_LIST", EnvironmentVariableTarget.Process);
```

visual studioなどでローカル開発をするときは、appsettings.jsonに環境変数を設定。
パブリックのAzure Functionでやる場合は、アプリのほうの環境変数に設定。
