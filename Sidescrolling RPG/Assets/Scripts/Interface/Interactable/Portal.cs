using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : Interactable {
    [Header("Portal Attributes")]
    public string sceneToActivate;

    public override void OnInteraction()
    {
        SceneManager.LoadScene(sceneToActivate);

    }

}
