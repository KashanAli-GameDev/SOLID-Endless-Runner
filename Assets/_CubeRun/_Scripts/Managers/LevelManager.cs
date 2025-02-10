using Sirenix.OdinInspector;
using UnityEngine;

public class LevelManager : SingletonPersistent<LevelManager>
{
    #region Properties and Fields

    [Title("UI Panels Fields.")]
    [SerializeField] private UIManager UIManager;

    #endregion

    public void GameStart()
    {
        Time.timeScale = 1;
        UIManager.TogglePanel(PanelType.HUD);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        UIManager.TogglePanel(PanelType.GameOver);
    }
}
