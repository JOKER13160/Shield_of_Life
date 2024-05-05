using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ModuleManagerSample : MonoBehaviour
{
    public List<ModuleSample> moduleList = new();
    public Transform moduleSetTran;
    public ModuleSample modulePrefab;
    public int moduleGenerateCount;

    // Start is called before the first frame update
    void Start()
    {
        GenerateModule(moduleGenerateCount);
    }
    public void GenerateModule(int genereteCount)
    {
        for (int i = 0; i < genereteCount; i++)
        {
            ModuleSample module = Instantiate(modulePrefab, moduleSetTran, false);
            module.SetUp();//SO‚©‚çŽæ“¾—\’è
            moduleList.Add(module);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            moduleList.ForEach(module => {module.gameObject.SetActive(true); });
            //foreach (var module in moduleList)
            //{
            //    module.gameObject.SetActive(true);
            //}
            List<ModuleSample> tempList = moduleList.Where(module => module.modRarityType == MODRarityType.common).ToList();
            moduleList.ForEach(module =>
            {
                if (tempList.Any(tempModule => module == tempModule)){
                    module.gameObject.SetActive(true);
                }
                else
                {
                    module.gameObject.SetActive(false);
                }
            });
        }
    }
}
