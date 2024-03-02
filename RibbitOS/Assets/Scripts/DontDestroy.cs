using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    //awake is called when the script is initialised
    //even if it isn't enabled/active
    void Awake() {

        DontDestroyOnLoad(this.gameObject);
    }
}
