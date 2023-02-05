using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActionDoor : InteractAction
{
    SceneSwitcher sceneSwitcher;
    [SerializeField] private string nextScene;
    protected override void Action()
    {
        sceneSwitcher.ChangeScene(nextScene);
    }
    // Start is called before the first frame update
    private void Awake() {
        var master = GameObject.Find("Master");
        sceneSwitcher = master.GetComponent<SceneSwitcher>();
    }

}
