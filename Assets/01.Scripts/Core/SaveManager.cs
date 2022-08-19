using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public enum Grade{
    A,
    B,
    C,
    D
}

[System.Serializable]
public class Infomation
{
    public Grade grade;
    public string name;
    public int helth;
    public string des;

    public Infomation()
    {

    }

    public Infomation(Grade _grade, string _name, int _health, string _des)
    {
        grade = _grade;
        name = _name;
        helth = _health;
        des = _des;
    }
}

[System.Serializable]
public class InfoManager//네이밍을 위한 재포장
{
    public Infomation[] infomations;//진짜 데이터

    public InfoManager()
    {
        infomations = new Infomation[10];
        /*for(int i = 0; i < infomations.Length; i++)
        {
            infomations[i] = new Infomation();
        }*/
    }
}

public class SaveManager : MonoBehaviour
{
    public InfoManager info;
    public static SaveManager Instance = null;
    private string key = "SaveKey";
    void Awake()
    {
        info = new InfoManager();
        Debug.Log(JsonUtility.ToJson(info));
        info=Load();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Save();
        }
    }
    public void Save()
    {
        string str = JsonUtility.ToJson(info);
        Debug.Log(str);
        PlayerPrefs.SetString(key, str);
    }
    public InfoManager Load(){    
        InfoManager def = new InfoManager();
        def.infomations[0] = new Infomation(Grade.A,"올리브 들리 바다 거북이",1000,"바다거북중에서 가장 작은 종중 하나이다,바다거북중에서는 가장수가 많은 편에 속한다, 잡식성으로 게,새우,해초,해조 등을 먹으면서 살아간다");
        def.infomations[1] = new Infomation(Grade.A,"매부리 바다 거북이",900,"거북목 바다거북과에 속하는 바다거북의 일종,흔히 '대모' 또는 '대모 거북'이라고 불린다,다른 바다거북보다 육식성이 강하다");
        def.infomations[2] = new Infomation(Grade.B,"붉은 바다 거북이",800,"붉은바다거북에 속하는 유일한 바다거북,등딱지의 색은 적갈색이며, 살은 갈황색이다,알을 낳을 때를 제외하고는 거의 뭍으로 올라오는 경우가 없다");
        def.infomations[3] = new Infomation(Grade.B,"장수 거북이",700,"장수거북과에 속하는 바다거북이,현존하는 모든바다 거북중에 가장 큰 종이다,주로 해파릴를 먹으면서 살아간다.");
        def.infomations[4] = new Infomation(Grade.B,"푸른 바다 거북이",600,"바다거북중에서 가장 작은 종중 하나이다,바다거북중에서는 가장수가 많은 편에 속한다, 잡식성으로 게,새우,해초,해조 등을 먹으면서 살아간다");
        def.infomations[5] = new Infomation(Grade.D,"신발 쓰레기",500,"마트에서 살수있는 평범한 신발,고급브랜드는 아닌것 같다");
        def.infomations[6] = new Infomation(Grade.D,"병",400,"평범한 쓰레기 병, 안쪽에는 살짝 알코올 냄새가 난다");
        def.infomations[7] = new Infomation(Grade.D,"책",300,"책이다....말그대로 책이다....");
        def.infomations[8] = new Infomation(Grade.C,"정어리",200,"청어과의 물고기로 플랑크톤을 주식으로 하며 태평양 서부에 주로 분포하고있다.거대한 무리를 형성하며 대규모로 이동하는 특징이 있다");
        def.infomations[9] = new Infomation(Grade.C,"고등어",100,"등푸른 생성중에 하나이다.세께적으로 널리 분포하고 있으며 어릴때는 플랑크톤을 먹지만 성어가 되서는 멸치 또는 작은 물고기를 주 먹이로 삼는다");
        
        string j =  PlayerPrefs.GetString(key, null);

        if(j.Length <1)return def;

        def = JsonUtility.FromJson<InfoManager>(j);
        return def;
    }
}

