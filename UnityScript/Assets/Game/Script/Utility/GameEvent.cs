
public static class GameEvent
{
    public static OnGameStart OnGameStart;
    public static OnGameLose OnGameLose;
    public static OnGameWin OnGameWin;
    public static OnLevelComplete OnLevelComplete;
    public static OnLoadHome OnLoadHome;
    public static OnReturnHome OnReturnHome;
    public static OnColoring OnColoring;
    public static OnRestartGame OnRestartGame;
    public static DecreaseHealth DecreaseHealth;
    public static OnStartDialogue OnStartDialogue;
    public static OnCompleteLetter OnCompleteLetter;
    public static OnDestroyBlock OnDestroyBlock;
    public static OnMinigameStart OnMinigameStart;
}
public delegate void DecreaseHealth();

public delegate void OnGameStart(int gameNum);

public delegate void OnGameLose();

public delegate void OnGameWin();

public delegate void OnLevelComplete();

public delegate void OnLoadHome();

public delegate void OnReturnHome();

public delegate void OnRestartGame();

public delegate void OnColoring(string colorName);

public delegate void OnStartDialogue(string id);

public delegate void OnCompleteLetter();

public delegate void OnDestroyBlock(string id);

public delegate void OnMinigameStart();