using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM5 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "남양주시")
        {
            new Skill_Namyangju().UseSkill();
        }
        else if (city.CityName == "전주시")
        {
            new Skill_Jeonju().UseSkill();
        }

    }
    virtual public void UseSkill() { }
}

public class Skill_Namyangju : Skill_PM5
{

    public override void UseSkill()
    {

    }
}

public class Skill_Jeonju : Skill_PM5
{

    public override void UseSkill()
    {

    }
}

