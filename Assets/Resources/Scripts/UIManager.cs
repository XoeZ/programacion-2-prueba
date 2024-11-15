using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Management
{
    public class UIManager : PanelsManager
    {
        public static UIManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
            }

            Instance = this;
        }
    }
}