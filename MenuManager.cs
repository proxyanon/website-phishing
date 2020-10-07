using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class MenuManager : MonoBehaviour
    {
        [Header("Scenes")]
        [SerializeField] private int gameSceneIndex;

        [Header("Canvas")] 
        [SerializeField] private GameObject[] canvasMenu;

        private int _iActualCanvas;

        public void OnClickStartButton()
        {
            SceneManager.LoadScene(gameSceneIndex);
        }

        public void OnClickChangeMenuScreen(int index)
        {
            canvasMenu[index].SetActive(true);
            canvasMenu[_iActualCanvas].SetActive(false);

            _iActualCanvas = index;
        }

        public void OnClickQuitButton()
        {
            Application.Quit();
        }
    }
}
