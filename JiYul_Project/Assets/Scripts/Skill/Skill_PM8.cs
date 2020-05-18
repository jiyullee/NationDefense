using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM8 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "창원시")
        {
            new Skill_Changwon().UseSkill();
        }

    }
    virtual public void UseSkill() { }
}

public class Skill_Changwon : Skill_PM8
{

    public override void UseSkill()
    {

    }
}

