using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] TextAsset textData;
    Dictionary<int, string> textDic;

private void Start() {
    SetTextData();
}
public void SetTextData(){
        textDic = new Dictionary<int, string>();
        string[] lines = textData.ToString().Split('\n');
        for(int i = 0; i<lines.Length; ++i){
            int idx=0;
            string[] words = lines[i].Split(',');
            int.TryParse(words[0], out idx);
            textDic.Add(idx, words[0]);
            for(int j=0; j < words.Length; j++){
            }
        }
    }
}
