﻿using UnityEngine;
using UnityEngine.UI;


namespace NewHelicopter
{
    public class UIViewController : MonoBehaviour
    {
        public GameObject PlayerUI;

        [Header("FlightView")]
        public Text UpDragView;
        public Text HeigthUpView;
        public Text HeigthView;
        public Text EngineForceView;

        public static UIViewController runtime;

        void Awake()
        {
            runtime = this;
        }

        public void SetPlayer(Transform player)
        {
            PlayerUI.SetActive(true);
        }

      
        public void DeletePlayer(Transform player)
        {
        }

        void Start()
        {
            ShowInfoPanel(false);
        }


        private void ShowInfoPanel(bool isShow)
        {
            EngineForceView.gameObject.SetActive(!isShow);
            /*  RestartButton.SetActive(!isShow);
                 InfoButton.SetActive(!isShow);
                    InfoPanel.SetActive(isShow);*/
        }

        public void ShowInfo()
        {
            ShowInfoPanel(true);
        }

        public void HideInfo()
        {
            ShowInfoPanel(false);
        }

        public void RestartGame()
        {
        }
    }
}