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
        //�܂��̓��A���e�B�����߂�
        int totalRate = rarityRate.Sum();//���A�x�̏o�₷�����v�l
        Debug.Log("totalRate" + totalRate);
        int RandomValue = Random.Range(0, totalRate);
        Debug.Log("RandomValue" + RandomValue);

        MODRarityType resultRarityType=MODRarityType.common;
        for(int i = 0; i < rarityRate.Count; i++)//rarityRate.Count:���A���e�B��ނ̐�������
        {
            if (rarityRate[i] > RandomValue)
            {
                resultRarityType = (MODRarityType)i;
                Debug.Log("rarity : " + (MODRarityType)i);
                break;
            }
            RandomValue -= rarityRate[i];
        }

        //���A���e�B�̒���mod���K�`��
        RarityData useRarityData = rarityDataList[(int)resultRarityType];
        //rewarddata.rate�̒�������Sum����
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
