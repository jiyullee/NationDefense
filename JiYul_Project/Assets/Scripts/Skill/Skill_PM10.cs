using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM10 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "고양시")
        {
            new Skill_Goyang().UseSkill();
        }

    }
    virtual public void UseSkill() { }
}

public class Skill_Goyang : Skill_PM10
{

    public override void UseSkill()
    {

    }
}