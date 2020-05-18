using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM11 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "수원시")
        {
            new Skill_Suwon().UseSkill();
        }

    }
    virtual public void UseSkill() { }
}

public class Skill_Suwon : Skill_PM11
{

    public override void UseSkill()
    {

    }
}