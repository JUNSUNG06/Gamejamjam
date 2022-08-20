using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

[System.Serializable]
public class Turtle
{
    public enum Garde { A, B, C, D }
    public static List<string> descriptionList = new List<string>
    {"바다거북중에서 가장 작은 종중 하나이다,바다거북중에서는 가장수가 많은 편에 속한다, 잡식성으로 게,새우,해초,해조 등을 먹으면서 살아간다",
    "거북목 바다거북과에 속하는 바다거북의 일종,흔히 '대모' 또는 '대모 거북'이라고 불린다,다른 바다거북보다 육식성이 강하다",
    "붉은바다거북에 속하는 유일한 바다거북,등딱지의 색은 적갈색이며, 살은 갈황색이다,알을 낳을 때를 제외하고는 거의 뭍으로 올라오는 경우가 없다",
    "장수거북과에 속하는 바다거북이,현존하는 모든바다 거북중에 가장 큰 종이다,주로 해파릴를 먹으면서 살아간다.",
    "바다거북과에 속하는 대형거북이,대서양과 태평양 부근에서 거주한다.가장 유명한 바다거북이 기도하다",
    "마트에서 살수있는 평범한 신발,고급브랜드는 아닌것 같다",
    "평범한 쓰레기 병, 안쪽에는 살짝 알코올 냄새가 난다",
    "책이다....말그대로 책이다....",
    "청어과의 물고기로 플랑크톤을 주식으로 하며 태평양 서부에 주로 분포하고있다.거대한 무리를 형성하며 대규모로 이동하는 특징이 있다",
    "등푸른 생성중에 하나이다.세께적으로 널리 분포하고 있으며 어릴때는 플랑크톤을 먹지만 성어가 되서는 멸치 또는 작은 물고기를 주 먹이로 삼는다"};

    public Garde grade;
    public string turtleName; 
    public int health;
    public string description; 
    public int sellPrice; 
    public Image turtleImgae = null;
    public int catchTime;

    public OliveImage oliveimgae;
     

    public Turtle(Garde _grade, string _turtleName, int _health, string _description, int _sellPrice, int _catchTime)
    {
        grade = _grade;
        turtleName = _turtleName;
        health = _health;
        description = _description;
        sellPrice = _sellPrice;
        catchTime = _catchTime;
    }
}
