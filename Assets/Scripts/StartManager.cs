using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TNRD;

public class StartManager : MonoBehaviour
{
    [SerializeField]
    private MoveStageScene moveStageScene;
    [SerializeField]
    private ChangeStageDataDropDown[] changeStageDataDropDowns;
    [SerializeField]
    public List<SerializableInterface<ISetup>> setupList = new List<SerializableInterface<ISetup>>();

    // Start is called before the first frame update
    void Start()
    {
        //for(int i=0; i<changeStageDataDropDowns.Length; i++)
        //{
        //    changeStageDataDropDowns[i].StageSetup();

        //}
        //moveStageScene.SetupLoadScene();
        for(int i=0; i<setupList.Count; i++)
        {
            setupList[i].Value.Setup();
        }
    }

    
}
