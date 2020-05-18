using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM6 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "이천시")
        {
            new Skill_Yichun().UseSkill();
        }
        else if (city.CityName == "강릉시")
        {
            new Skill_Gangneung().UseSkill();
        }
        else if (city.CityName == "양주시")
        {
            new Skill_YangJu().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Yichun : Skill_AM6
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gangneung : Skill_AM6
{

    public override void UseSkill()
    {

    }
}

public class Skill_YangJu : Skill_AM6
{

    public override void UseSkill()
    {

    }
}

