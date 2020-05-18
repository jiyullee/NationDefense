using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Skill : MonoBehaviour
{
    private City city; 

    public int skill_Time { get; set; }
    private Skill[] skills;
    private void Awake()
    {
        city = GetComponent<City>();
        string name_City = city.CityName;
        if (name_City == "수원시")
            skill_Time = 23;
        else if (name_City == "고양시")
            skill_Time = 22;
        else if (name_City == "용인시")
            skill_Time = 21;
        else if (name_City == "창원시")
            skill_Time = 20;
        else if (name_City == "성남시" || name_City == "청주시")
            skill_Time = 19;
        else if (name_City == "부천시" || name_City == "화성시")
            skill_Time = 18;
        else if (name_City == "남양주시" || name_City == "전주시")
            skill_Time = 17;
        else if (name_City == "천안시" || name_City == "안산시")
            skill_Time = 16;
        else if (name_City == "안양시" || name_City == "김해시" || name_City == "평택시")
            skill_Time = 15;
        else if (name_City == "포항시" || name_City == "시흥시" || name_City == "파주시")
            skill_Time = 14;
        else if (name_City == "의정부시" || name_City == "김포시" || name_City == "구미시")
            skill_Time = 13;
        else if (name_City == "광주시" || name_City == "양산시" || name_City == "원주시")
            skill_Time = 12;
        else if (name_City == "진주시" || name_City == "광명시" || name_City == "아산시")
            skill_Time = 11;
        else if (name_City == "익산시" || name_City == "춘천시" || name_City == "경산시")
            skill_Time = 10;
        else if (name_City == "군포시" || name_City == "군산시" || name_City == "하남시")
            skill_Time = 9;
        else if (name_City == "여수시" || name_City == "순천시" || name_City == "경주시")
            skill_Time = 8;
        else if (name_City == "거제시" || name_City == "목포시" || name_City == "오산시")
            skill_Time = 7;
        else if (name_City == "이천시" || name_City == "강릉시" || name_City == "양주시")
            skill_Time = 6;
        else if (name_City == "충주시" || name_City == "안성시" || name_City == "구리시" || name_City == "서산시" || name_City == "당진시")
            skill_Time = 5;
        else if (name_City == "안동시" || name_City == "포천시" || name_City == "의왕시" || name_City == "광양시" || name_City == "김천시")
            skill_Time = 4;
        else if (name_City == "제천시" || name_City == "통영시" || name_City == "논산시" || name_City == "사천시" || name_City == "여주시" || name_City == "공주시" || name_City == "정읍시")
            skill_Time = 3;
        else if (name_City == "영주시" || name_City == "나주시" || name_City == "밀양시" || name_City == "보령시" || name_City == "상주시" || name_City == "영천시" || name_City == "동두천시" || name_City == "동해시")
            skill_Time = 2;
        else if (name_City == "김제시" || name_City == "남원시" || name_City == "속초시" || name_City == "문경시" || name_City == "삼척시" || name_City == "과천시" || name_City == "태백시" || name_City == "계룡시")
            skill_Time = 1;

        skills = new Skill[]
        {
            null, new Skill_AM1(), new Skill_AM2(), new Skill_AM3(), new Skill_AM4(), new Skill_AM5(),
            new Skill_AM6(), new Skill_AM7(), new Skill_AM8(), new Skill_AM9(), new Skill_AM10(), new Skill_AM11(),
            new Skill_PM12(), new Skill_PM1(), new Skill_PM2(), new Skill_PM3(), new Skill_PM4(), new Skill_PM5(),
            new Skill_PM6(), new Skill_PM7(), new Skill_PM8(), new Skill_PM9(), new Skill_PM10(), new Skill_PM11()
        };
    }
    private void Start()
    {
        

        if(skill_Time != 0)
            StartCoroutine(CheckSkill());
    }

    IEnumerator CheckSkill()
    {
        while (true)
        {
            if(gameObject.layer == 10)
            {
                if(LevelManager.Instance.CurrentHour == skill_Time)
                {
                    skills[skill_Time].ChooseSkill(city);
                    yield return new WaitForSeconds(1f);
                }
            }
            yield return null;
        }
    }
}
