using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.UI
{
    /// <summary>
    /// A simple controller for switching between UI panels.
    /// </summary>
    public class MainUIController : MonoBehaviour
    {
        public GameObject[] panels;

        public void SetActivePanel(int index)
        {
            GameObject current = gameObject;
            GameObject next = gameObject;
            for (var i = 0; i < panels.Length; i++)
            {
                
                
                var active = i == index;
                var g = panels[i];

                if (i == index) next = g;
                if (g.activeSelf) current = g;

                if (g.activeSelf != active) g.SetActive(active);
            }

            if (current != next)
                TelemetryLogger.LogMenuChange(current.name, next.name, default);
        }

        void OnEnable()
        {
            SetActivePanel(0);
        }
    }
}