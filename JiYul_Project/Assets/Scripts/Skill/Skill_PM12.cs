using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM12 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "광주시")
        {
            new Skill_Gwangju().UseSkill();
        }
        else if (city.CityName == "양산시")
        {
            new Skill_Yangsan().UseSkill();
        }
        else if (city.CityName == "원주시")
        {
            new Skill_Wonju().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Gwangju : Skill_PM12
{

    public override void UseSkill()
    {

    }
}

public class Skill_Yangsan : Skill_PM12
{

    public override void UseSkill()
    {

    }
}

public class Skill_Wonju : Skill_PM12
{

    public override void UseSkill()
    {

    }
}

