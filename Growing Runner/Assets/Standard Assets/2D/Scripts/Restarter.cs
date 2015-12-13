<<<<<<< 04cf293f1ee380e5a1156c891b758d9b9ae2809f
﻿using UnityEngine;
=======
using System;
using UnityEngine;
>>>>>>> growth and shrink scripts

namespace UnitySampleAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
<<<<<<< 04cf293f1ee380e5a1156c891b758d9b9ae2809f
                Application.LoadLevel(Application.loadedLevelName);
=======
            {
                Application.LoadLevel(Application.loadedLevelName);
            }
>>>>>>> growth and shrink scripts
        }
    }
}