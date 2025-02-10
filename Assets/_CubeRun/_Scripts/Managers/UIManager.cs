using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Title("UI Panels Fields.")]
    [SerializeField] private List<UIPanel> UIPanels;

    public void TogglePanel(PanelType panelType)
    {
        DisableAllPanels();

        UIPanels.ForEach(uip =>
        {
            if (panelType == uip.PanelType)
            {
                uip.gameObject.SetActive(true);
            }
        });
    }

    private void DisableAllPanels()
    {
        UIPanels.ForEach(uip =>
        {
            uip.gameObject.SetActive(false);
        });
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        LevelManager.Instance.GameStart();
    }
}
