using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MODRewardManager : MonoBehaviour
{
    public static MODRewardManager Instance;

    public List<RarityData> rarityDataList = new();
    public List<int> rarityRate = new();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public RewardData GetLotteryForRewards()
    {
        //まずはレアリティを決める
        int totalRate = rarityRate.Sum();//レア度の出やすさ合計値
        Debug.Log("totalRate" + totalRate);
        int RandomValue = Random.Range(0, totalRate);
        Debug.Log("RandomValue" + RandomValue);

        MODRarityType resultRarityType=MODRarityType.common;
        for(int i = 0; i < rarityRate.Count; i++)//rarityRate.Count:レアリティ種類の数だけ回す
        {
            if (rarityRate[i] > RandomValue)
            {
                resultRarityType = (MODRarityType)i;
                Debug.Log("rarity : " + (MODRarityType)i);
                break;
            }
            RandomValue -= rarityRate[i];
        }

        //レアリティの中でmodをガチャ
        RarityData useRarityData = rarityDataList[(int)resultRarityType];
        //rewarddata.rateの中だけでSumする
        int totalRewardRate = useRarityData.RewardDataSO.rewardDataList.Sum(rewarddata => rewarddata.rate);
        Debug.Log(totalRewardRate);
        int RandomRateValue = Random.Range(0, totalRewardRate);

        for(int i=0; i < useRarityData.RewardDataSO.rewardDataList.Count; i++)
        {
            if (useRarityData.RewardDataSO.rewardDataList[i].rate > RandomRateValue)
            {
                Debug.Log(useRarityData.RewardDataSO.rewardDataList[i]);
                return useRarityData.RewardDataSO.rewardDataList[i];
            }
            RandomRateValue -= useRarityData.RewardDataSO.rewardDataList[i].rate;
        }
        return null;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            RewardData RewardData = GetLotteryForRewards();
            Debug.Log(RewardData.rate);
        }
    }
}
