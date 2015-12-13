<<<<<<< 04cf293f1ee380e5a1156c891b758d9b9ae2809f
﻿using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;
=======
using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
>>>>>>> growth and shrink scripts


[RequireComponent(typeof(GUITexture))]
public class ForcedReset : MonoBehaviour {

    void Update () {
        
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
<<<<<<< 04cf293f1ee380e5a1156c891b758d9b9ae2809f
        {
            
            //... reload the scene
            Application.LoadLevelAsync (Application.loadedLevelName);
        }
    }

}
=======
        {
            //... reload the scene
            Application.LoadLevelAsync(Application.loadedLevelName);
        }
    }
}
>>>>>>> growth and shrink scripts
